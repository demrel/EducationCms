using AutoMapper;
using EducationCms.Service.Filters;
using EducationCms.Service.Interface;
using EducationCms.Service.Interface.PostInterface;
using EducationCms.Web.Areas.admin.Models;
using EducationCms.Web.Areas.admin.Models.Banners;
using EducationCms.Web.Areas.admin.Models.Blog;
using EducationCms.Web.Areas.admin.Models.Faqs;
using EducationCms.Web.Areas.admin.Models.MissionVisions;
using EducationCms.Web.Areas.admin.Models.Pages;
using EducationCms.Web.Areas.admin.Models.SIteSettings;
using EducationCms.Web.Areas.admin.Models.TizerVideoPlaces;
using EducationCms.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducationCms.Web.Controllers
{
    
    public class HomeController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IBanner _bannerService;
        private readonly ITizerVideo _tizerVideoService;
        private readonly IPage _pageService;
        private readonly IMissionVission _mvService;
        private readonly IQA _faqService;
        private readonly IBlog _blogService;
        private readonly ISiteSetting _siteSettingService;
        private readonly IVideo _videoService;
      
        public HomeController(IMapper mapper, IBanner bannerService, IPage pageService, ITizerVideo tizerVideoService, IMissionVission mvService, IQA faqService, IBlog blogService, ISiteSetting siteSettingService, IVideo videoService)
        {
            _mapper = mapper;
            _bannerService = bannerService;
            _pageService = pageService;
            _tizerVideoService = tizerVideoService;
            _mvService = mvService;
            _faqService = faqService;
            _blogService = blogService;
            _siteSettingService = siteSettingService;
            _videoService = videoService;
        }

        public async Task<IActionResult> Index()
        {
            var banner =await _bannerService.GetAll();
            var pagesStared = await _pageService.GetAllStared();
            var tizerVideo = await _tizerVideoService.Get();
            var page = await _pageService.GetByName("home");
            var mission = await _mvService.Get(Data.Enums.MissionVisionType.Mission);
            var faqs = await _faqService.GetAll();
            var blogs = await _blogService.GetLast(6);
            var siteSetting = await _siteSettingService.Get();
            var videos = await _videoService.GetAllActive();
         

            HomeVM model = new();
            model.Banners = _mapper.Map<List<BannerModel>>(banner);
            model.StarredPage = _mapper.Map<List<PageModel>>(pagesStared);
            model.TizerVideo = _mapper.Map<TizerVideoPlaceModel>(tizerVideo);
            model.Page = _mapper.Map<PageModel>(page);
            model.MV = _mapper.Map<MissionVissionModel>(mission);
            model.Faqs = _mapper.Map<List<FaqModel>>(faqs);
            model.Blogs = _mapper.Map<List<BlogModel>>(blogs);
            model.SiteSettings = _mapper.Map<SiteSettingsModel>(siteSetting);
            model.LastVideos = _mapper.Map <List<BasePostModel>>(videos);
            return View(model);
        }
    }
}
