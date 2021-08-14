using AutoMapper;
using EducationCms.Data.Model;
using EducationCms.Service.Interface;
using EducationCms.Web.Areas.admin.Models.SIteSettings;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducationCms.Web.Areas.admin.Controllers
{
    public class SiteSettingController : BaseAdminController
    {
        private readonly IMapper _mapper;
        private readonly ISiteSetting _siteSettingService;

        public SiteSettingController(IMapper mapper, ISiteSetting siteSettingService)
        {
           _mapper = mapper;
            _siteSettingService = siteSettingService;
        }

        public async Task<IActionResult> Create(SiteSettingsModel model)
        {
            var data = _mapper.Map<SiteSettings>(model);
            await _siteSettingService.Create(data);
            return RedirectToAction("Update");
        }

        public  IActionResult Create()
        {
            return View();
        }

    
        public async  Task<IActionResult> Update(SiteSettingsModel model)
        {
            var data = _mapper.Map<SiteSettings>(model);
         
            await _siteSettingService.Update(data);
            return RedirectToAction("Update");
        }

        public async Task<IActionResult> Update()
        {
            var id = 1;
            var data = await _siteSettingService.GetById(id);
            SiteSettingsModel model = _mapper.Map<SiteSettingsModel>(data);
            
            return View(model);
        }
    }
}
