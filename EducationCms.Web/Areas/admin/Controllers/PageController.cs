using AutoMapper;
using EducationCms.Data.Model.Pages;
using EducationCms.Service.Interface;
using EducationCms.Service.Services;
using EducationCms.Web.Areas.admin.Models.Faqs;
using EducationCms.Web.Areas.admin.Models.Pages;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducationCms.Web.Areas.admin.Controllers
{
    public class PageController : BaseContentController<PageModel>
    {
        private readonly IPage _pageService;

        public PageController(IMapper mapper, IPage pageService) : base(mapper)
        {
            _pageService = pageService;
        }

        public override async Task<IActionResult> Index()
        {
            var pages = await   _pageService.GetAll();
           PageIndexVM  model = new()
            {
                Pages = _mapper.Map<List<PageListModel>>(pages),
            };
            return View(model);
        }

        [HttpPost]
        public override async Task<IActionResult> Create(PageModel model)
        {
            var data = _mapper.Map<Page>(model);
            await _pageService.Create(data);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public  IActionResult Create()
        {
            return View();
        }

    
        [HttpPost]
        public override async Task<IActionResult> Update(PageModel model)
        {
            var data = _mapper.Map<Page>(model);
            await _pageService.Update(data);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public override async Task<IActionResult> Update(int id)
        {
            var faq=await  _pageService.GetById(id);
            PageModel model = _mapper.Map<PageModel>(faq);
            return View(model);

        }

        [HttpGet]
        public  async Task<IActionResult> MakeStared(int id)
        {
             await _pageService.Stared(id);

            return RedirectToAction("Index");
        }

        public override async Task<IActionResult> Delete(int id)
        {
             await _pageService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
