using AutoMapper;
using EducationCms.Data.Model.Posts;
using EducationCms.Service.Interface;
using EducationCms.Service.Interface.PostInterface;
using EducationCms.Web.Areas.admin.Controllers.Base;
using EducationCms.Web.Areas.admin.Models.Materials;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducationCms.Web.Areas.admin.Controllers.Posts
{
    public class SummaryController : BasePostController<Summary, FileShareAddVM>
    {
        private readonly IFileShare _fileShareService;
        public SummaryController(IMapper mapper, IImageFile imageService, IWebHostEnvironment env, IFileShare fileShareService,IBasePost<Summary> basePost) 
            : base(mapper, imageService, env,basePost)
        {
            _fileShareService = fileShareService;
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Title = "Add Pdf";
            return View("Areas/admin/Views/WithoutContent/Create.cshtml");
        }

        [HttpPost]
        public override async Task<IActionResult> Create(FileShareAddVM model)
        {
            var data = _mapper.Map<Summary>(model.Add);
            data.BannerImage = await _imageService.Add(model.Image, _env.WebRootPath + "/images/posts/");
            await _fileShareService.Create(data);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public override async Task<IActionResult> Update(FileShareAddVM model)
        {
            var data = _mapper.Map<Summary>(model.Add);
            data.BannerImage = await _imageService.Edit(model.Image, _env.WebRootPath + "/images/posts/", model.Add.Image.Id);
            await _fileShareService.Update(data);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public override async Task<IActionResult> Update(int id)
        {
            var blog = await _fileShareService.GetById(id);
            FileShareAddVM model = new()
            {

                Add = _mapper.Map<FileShareModel>(blog)
            };
            ViewBag.Title = "Update  Pdf";
            return View("Areas/admin/Views/WithoutContent/Update.cshtml", model);
        }
    }
}
