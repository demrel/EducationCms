using AutoMapper;
using EducationCms.Data.Model.Posts;
using EducationCms.Service.Interface;
using EducationCms.Service.Interface.PostInterface;
using EducationCms.Web.Areas.admin.Controllers.Base;
using EducationCms.Web.Areas.admin.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducationCms.Web.Areas.admin.Controllers.Posts
{
    public class ServiceController : BasePostController<English,PostAddVM>
    {
        private readonly IMaintence _maintenceService;
        public ServiceController(IMapper mapper, IImageFile imageService, IWebHostEnvironment env, IMaintence maintenceService 
            ,IBasePost<English> basePost) : base(mapper, imageService, env, basePost)
        {
            _maintenceService = maintenceService;
        }

        [HttpPost]
        public override async Task<IActionResult> Create(PostAddVM model)
        {
            var data = _mapper.Map<English>(model.Add);
            data.BannerImage = await _imageService.Add(model.Image, _env.WebRootPath + "/images/posts/");
            await _maintenceService.Create(data);
            ViewBag.Title = "Add Service";
            return RedirectToAction("Index");
        }

        [HttpGet]
        public  IActionResult Create()
        {
            return View("Areas/admin/Views/WithContent/Create.cshtml");
        }

        [HttpPost]
        public override async Task<IActionResult> Update(PostAddVM model)
        {
            var data = _mapper.Map<English>(model.Add);
            data.BannerImage = await _imageService.Edit(model.Image, _env.WebRootPath + "/images/posts/", model.Add.Image.Id);

            await _maintenceService.Update(data);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public override async Task<IActionResult> Update(int id)
        {
            var blog = await _maintenceService.GetById(id);
            PostAddVM model = new()
            {
               
                Add = _mapper.Map<PostModel>(blog)
            };
            ViewBag.Title = "Update Service";
            return View("Areas/admin/Views/WithContent/Update.cshtml", model);
        }
    }
}
