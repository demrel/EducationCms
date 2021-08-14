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
    public class ConsultingController : BasePostController<Consulting,PostAddVM>
    {
        private readonly IConsulting _consultingService;
        public ConsultingController(IMapper mapper, IImageFile imageService, IWebHostEnvironment env, IConsulting maintenceService 
            ,IBasePost<Consulting> basePost) : base(mapper, imageService, env, basePost)
        {
            _consultingService = maintenceService;
        }

        [HttpPost]
        public override async Task<IActionResult> Create(PostAddVM model)
        {
            var data = _mapper.Map<Consulting>(model.Add);
            data.BannerImage = await _imageService.Add(model.Image, _env.WebRootPath + "/images/posts/");
            await _consultingService.Create(data);
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
            var data = _mapper.Map<Consulting>(model.Add);
            data.BannerImage = await _imageService.Edit(model.Image, _env.WebRootPath + "/images/posts/", model.Add.Image.Id);

            await _consultingService.Update(data);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public override async Task<IActionResult> Update(int id)
        {
            var blog = await _consultingService.GetById(id);
            PostAddVM model = new()
            {
               
                Add = _mapper.Map<PostModel>(blog)
            };
            ViewBag.Title = "Update Service";
            return View("Areas/admin/Views/WithContent/Update.cshtml", model);
        }
    }
}
