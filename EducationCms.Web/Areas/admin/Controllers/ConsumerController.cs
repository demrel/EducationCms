using AutoMapper;
using EducationCms.Data.Model.Pages;
using EducationCms.Service.Interface;
using EducationCms.Web.Areas.admin.Models.Consumers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducationCms.Web.Areas.admin.Controllers
{
    public class ConsumerController : BaseContentController<ConsumerModel>
    {
        private readonly IConsumer _consumerService;
        public ConsumerController(IMapper mapper, IConsumer consumerService) : base(mapper)
        {
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
        public override async Task<IActionResult> Create(ConsumerModel model)
        {
            var data = _mapper.Map<Consumer>(model);
            await _consumerService.Create(data);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public override IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public override async Task<IActionResult> Update(ConsumerModel model)
        {
            var data = _mapper.Map<Consumer>(model);
            await _consumerService.Update(data);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public override async Task<IActionResult> Update(int id)
        {
            var consumer=await  _consumerService.GetById(id);
            ConsumerModel model = _mapper.Map<ConsumerModel>(consumer);
            return View(model);

        }

        public override async Task<IActionResult> Delete(int id)
        {
             await _consumerService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
