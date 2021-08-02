using AutoMapper;
using EducationCms.Data.Model.Pages;
using EducationCms.Service.Interface;
using EducationCms.Web.Areas.admin.Models.Faqs;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducationCms.Web.Areas.admin.Controllers
{
    public class FaqController : BaseAdminController
    {
        private readonly IQA _faqService;
        private readonly IMapper _mapper;
        public FaqController(IMapper mapper, IQA faqService) 
        {
            _faqService = faqService;
            _mapper = mapper;
        }

        public  async Task<IActionResult> Index()
        {
            var faqs = await   _faqService.GetAll();
           FaqIndexVM  model = new()
            {
                Faqs = _mapper.Map<List<FaqModel>>(faqs),
            };
            return View(model);
        }

        public  async Task<IActionResult> Create(FaqIndexVM model)
        { 
            var data = _mapper.Map<QuestionAnswer>(model.Add);
            await _faqService.Create(data);
            return RedirectToAction("Index");
        }

       
    

        public  async Task<IActionResult> Update(FaqIndexVM model)
        {
            var data = _mapper.Map<QuestionAnswer>(model.Add);
            await _faqService.Update(data);
            return RedirectToAction("Index");
        }

      

        public  async Task<IActionResult> Delete(int id)
        {
             await _faqService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
