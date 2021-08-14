using AutoMapper;
using EducationCms.Data.Model.Pages;
using EducationCms.Service.Interface;
using EducationCms.Web.Areas.admin.Models.MissionVisions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducationCms.Web.Areas.admin.Controllers
{
    public class MissionVissionController :BaseAdminController
    {
        private readonly IMapper _mapper;
        private readonly IImageFile _imageService;
        private readonly IWebHostEnvironment _env;
        private readonly IMissionVission _missionVissionService;

        public MissionVissionController(IMapper mapper, IImageFile imageService, IWebHostEnvironment env, IMissionVission missionVissionService)
        {
            _mapper = mapper;
            _imageService = imageService;
            _env = env;
            _missionVissionService = missionVissionService;
        }

        public  async Task<IActionResult> Create(MissionVissionAddVM model)
        {
            var data = _mapper.Map<MissionVision>(model);
            data.Image = await _imageService.Add(model.Image, _env.WebRootPath + "/images/mv/");

            await _missionVissionService.Create(data);
            return RedirectToAction("Index");
        }

        public  IActionResult Create()
        {
            return View();
        }

    

        public  async Task<IActionResult> Index()
        {
            var data = await _missionVissionService.GetAll();
            MissionVissionIndexVM model = new ()
            {
                Datas = _mapper.Map<List<MissionVissionModel>>(data)
            };
            return View(model);
        }

        public async Task<IActionResult> Update(MissionVissionAddVM model)
        {
            var data = _mapper.Map<MissionVision>(model.Add);
            data.Image = await _imageService.Edit(model.Image, _env.WebRootPath + "/images/mv/", model.Add.Image.Id);
            await _missionVissionService.Update(data);


            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Update(int id)
        {
            var data = await _missionVissionService.GetById(id);
            MissionVissionAddVM model = new()
            {
                Add = _mapper.Map<MissionVissionModel>(data)
            };
            return View(model);
        }
    }
}
