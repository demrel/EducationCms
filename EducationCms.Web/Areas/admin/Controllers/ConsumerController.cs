using AutoMapper;
using EducationCms.Data.Model.Pages;
using EducationCms.Data.Model.Posts;
using EducationCms.Service.Interface;
using EducationCms.Service.Interface.PostInterface;
using EducationCms.Web.Areas.admin.Models.Consumers;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducationCms.Web.Areas.admin.Controllers
{
    public class ConsumerController : BaseContentController<ConsumerAddVM>
    {
        private readonly IConsumer _consumerService;
        private readonly ISeminar _seminarService;

        public ConsumerController(IMapper mapper, IImageFile imageService, IWebHostEnvironment env, ISeminar seminarService, IConsumer consumerService) : base(mapper, imageService, env)
        {
            _seminarService = seminarService;
            _consumerService = consumerService;
        }

        public override async Task<IActionResult> Index()
        {
            var consumers = await   _consumerService.GetAll();
            ConsumerIndexVM model = new()
            {
                Consumers = _mapper.Map<List<ConsumerModel>>(consumers),
            };
            return View(model);
        }

        [HttpPost]
        public override async Task<IActionResult> Create(ConsumerAddVM model)
        {
            var data = _mapper.Map<Consumer>(model.Add);
            data.Image = await _imageService.Add(model.Image, _env.WebRootPath + "/images/consumer/");

            await _consumerService.Create(data);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public  async Task<IActionResult> Create()
        {
            var seminars =await _seminarService.GetAll();
            ConsumerAddVM model= new ()
            {
                Seminars = new SelectList(seminars, nameof(Seminar.Id), nameof(Seminar.Title))
            };
            return View(model);
        }


        [HttpPost]
        public override async Task<IActionResult> Update(ConsumerAddVM model)
        {
            var data = _mapper.Map<Consumer>(model.Add);
          
          
                data.Image = await _imageService.Edit(model.Image, _env.WebRootPath + "/images/consumer/", model.Add.Image.Id);

            data.ImageId = data.Image?.Id;


            await _consumerService.Update(data);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public override async Task<IActionResult> Update(int id)
        {
            var consumer=await  _consumerService.GetById(id);
            var seminars = await _seminarService.GetAll();
         
            ConsumerAddVM model = new() { 
                Add = _mapper.Map<ConsumerModel>(consumer),
                Seminars = new SelectList(seminars, nameof(Seminar.Id), nameof(Seminar.Title),consumer.SeminarId)
            };
            return View(model);

        }

        [HttpGet]
        public async Task<IActionResult> MakeStared(int id)
        {
            await _consumerService.Stared(id);

            return RedirectToAction("Index");
        }

        public override async Task<IActionResult> Delete(int id)
        {
             await _consumerService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
