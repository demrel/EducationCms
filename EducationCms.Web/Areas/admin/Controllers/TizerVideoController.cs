using AutoMapper;
using EducationCms.Data.Model.Pages;
using EducationCms.Service.Interface;
using EducationCms.Web.Areas.admin.Models.TizerVideoPlaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducationCms.Web.Areas.admin.Controllers
{
    public class TizerVideoController : BaseAdminController
    {
        private readonly IMapper _mapper;
        private readonly IImageFile _imageService;
        private readonly IWebHostEnvironment _env;
        private readonly ITizerVideo _tizerVideoService;


        public TizerVideoController(IMapper mapper, IImageFile imageService, IWebHostEnvironment env, ITizerVideo tizerVideoService)
        {
            _mapper = mapper;
            _imageService = imageService;
            _env = env;
            _tizerVideoService = tizerVideoService;
        }



        public async Task<IActionResult> Create(TizerVIdeoAddVM model)
        {
            var data = _mapper.Map<TizerVideoPlace>(model);
            data.ImageRect = await _imageService.Add(model.ImageRect, _env.WebRootPath + "/images/tizer/");
            data.ImageSquare= await _imageService.Add(model.ImageSquare, _env.WebRootPath + "/images/tizer/");
            await _tizerVideoService.Create(data);
            return RedirectToAction("Update");
        }

        public  IActionResult Create()
        {
              return View();
        }

        public async Task<IActionResult> Update(TizerVIdeoAddVM model)
        {
            var data = _mapper.Map<TizerVideoPlace>(model);
            data.ImageRect = await _imageService.Edit(model.ImageRect, _env.WebRootPath + "/images/tizer/", model.Add.ImageRect.Id);
            data.ImageSquare = await _imageService.Edit(model.ImageSquare, _env.WebRootPath + "/images/tizer/", model.Add.ImageSquare.Id);
            await _tizerVideoService.Update(data);
            return RedirectToAction("Update");
        }

        public async Task<IActionResult> Update()
        {
            var id = 1;
            var data = await _tizerVideoService.GetById(id);
            TizerVIdeoAddVM model = new()
            {
                Add = _mapper.Map<TizerVideoPlaceModel>(data)
            };
            return View(model);
        }
    }
}
