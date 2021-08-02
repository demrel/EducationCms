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
    public class SeminarController : BasePostController<Seminar, PostAddVM>
    {
        private readonly ISeminar _seminarService;
        public SeminarController(IMapper mapper, IImageFile imageService, IWebHostEnvironment env, ISeminar seminarService, IBasePost<Seminar> basePost) : base(mapper, imageService, env, basePost)
        {
            _seminarService = seminarService;
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Title = "Add Seminar";
            return View("Areas/admin/Views/WithContent/Create.cshtml");
        }

        [HttpPost]
        public override async Task<IActionResult> Create(PostAddVM model)
        {
            var data = _mapper.Map<Seminar>(model.Add);
            data.BannerImage = await _imageService.Add(model.Image, _env.WebRootPath + "/images/posts/");
            await _seminarService.Create(data);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public override async Task<IActionResult> Update(PostAddVM model)
        {
            var data = _mapper.Map<Seminar>(model.Add);
            data.BannerImage = await _imageService.Edit(model.Image, _env.WebRootPath + "/images/posts/", model.Add.Image.Id);
            await _seminarService.Update(data);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public override async Task<IActionResult> Update(int id)
        {
            var blog = await _seminarService.GetById(id);
            PostAddVM model = new()
            {

                Add = _mapper.Map<PostModel>(blog)
            };
            ViewBag.Title = "Update Seminar";
            return View("Areas/admin/Views/WithContent/Update.cshtml", model);
        }
    }
}
