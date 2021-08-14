using AutoMapper;
using EducationCms.Data.Model.Pages;
using EducationCms.Service.Interface;
using EducationCms.Web.Areas.admin.Models.Banners;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducationCms.Web.Areas.admin.Controllers
{
    public class BannerController : BaseContentController<BannerAddEditVM>
    {
        private readonly IBanner _bannerService;

        public BannerController(IBanner bannerService, IMapper mapper, IImageFile imageService, IWebHostEnvironment env) : base(mapper, imageService, env)
        {
            _bannerService = bannerService;
        }

        public override async Task<IActionResult> Index()
        {
            var banners = await _bannerService.GetAll();
            BannerIndexVM model = new()
            {
                Banners = _mapper.Map<List<BannerModel>>(banners)
            };
            return View(model);
        }

        [HttpPost]
        public override async Task<IActionResult> Create(BannerAddEditVM model)
        {
            var data = _mapper.Map<Banner>(model.Add);
            data.Image = await _imageService.Add(model.Image, _env.WebRootPath + "/images/banner/");
            await _bannerService.Create(data);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public  IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public override async Task<IActionResult> Update(BannerAddEditVM model)
        {
            var data = _mapper.Map<Banner>(model);
            data.Image = await _imageService.Edit(model.Image, _env.WebRootPath + "/images/banner/", model.Add.Image.Id);
            await _bannerService.Update(data);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public override async Task<IActionResult> Update(int id)
        {
            var data = await _bannerService.GetById(id);
            BannerAddEditVM model = new()
            {
                Add = _mapper.Map<BannerModel>(data)
            };

            return View(model);
        }

        public override async Task<IActionResult> Delete(int id)
        {
            await _bannerService.Delete(id);
            return RedirectToAction("Index");
        }

    }
}
