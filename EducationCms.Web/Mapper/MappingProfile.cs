using AutoMapper;
using EducationCms.Data.Model;
using EducationCms.Data.Model.Pages;
using EducationCms.Data.Model.Posts;
using EducationCms.Web.Areas.admin.Models;
using EducationCms.Web.Areas.admin.Models.AppImages;
using EducationCms.Web.Areas.admin.Models.Banners;
using EducationCms.Web.Areas.admin.Models.Blog;
using EducationCms.Web.Areas.admin.Models.Category;
using EducationCms.Web.Areas.admin.Models.Consumers;
using EducationCms.Web.Areas.admin.Models.Faqs;
using EducationCms.Web.Areas.admin.Models.Materials;
using EducationCms.Web.Areas.admin.Models.MissionVisions;
using EducationCms.Web.Areas.admin.Models.Pages;
using EducationCms.Web.Areas.admin.Models.SIteSettings;
using EducationCms.Web.Areas.admin.Models.TizerVideoPlaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducationCms.Web.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<AppImage, AppImageModel>().ReverseMap();
            Banner();
            Category();
            Faq();
            Pages();
            Consumer();
            Blog();
            BasePost();
            SiteSetting();
            MissionVission();
            TizerVideoPlace();
        }

        private void TizerVideoPlace()
        {
            CreateMap<TizerVideoPlace, TizerVideoPlaceModel>()
               .ForMember(c => c.ImageSquare, m => m.MapFrom(c => c.ImageSquare))
               .ForMember(c => c.ImageRect, m => m.MapFrom(c => c.ImageRect))
               .ReverseMap();
        }

        private void BasePost()
        {
            CreateMap<BasePost, BasePostListModel>()
               .ForMember(c => c.Image, m => m.MapFrom(c => c.BannerImage));

            CreateMap<Video, BasePostModel>()
               .ForMember(c => c.Image, m => m.MapFrom(c => c.BannerImage)).ReverseMap();

            CreateMap<Video, FileShareModel>()
              .ForMember(c => c.Image, m => m.MapFrom(c => c.BannerImage)).ReverseMap();
        }
        private void Blog()
        {
            CreateMap<Blog, BlogModel>()
                .ForMember(c => c.Image, m => m.MapFrom(c => c.BannerImage)).ReverseMap();

            CreateMap<Blog, BlogListModel>()
             .ForMember(c => c.CaegoryName, m => m.MapFrom(c => c.Cateogry.Name))
             .ForMember(c => c.Image, m => m.MapFrom(c => c.BannerImage.Name));
        }

        private  void Banner()
        {
            CreateMap<Banner,BannerModel>()
                .ForMember(c => c.Image, m => m.MapFrom(c => c.Image)).ReverseMap();
        }

        private void Category()
        {
            CreateMap<Category, CategoryModel>().ReverseMap();
        }

        private void Faq()
        {
            CreateMap<QuestionAnswer, FaqModel>().ReverseMap();
        }

        private void Pages()
        {
            CreateMap<Page, PageModel>().ReverseMap();
            CreateMap<Page, PageListModel>();
        }
        private void Consumer()
        {
            CreateMap<Consumer, ConsumerModel>()
                .ForMember(c => c.Image, m => m.MapFrom(c => c.Image))
                .ReverseMap();
           
        }

        private void SiteSetting()
        {
            CreateMap<SiteSettings, SiteSettingsModel>().ReverseMap();
        }
        private void MissionVission()
        {
            CreateMap<MissionVision, MissionVissionModel>()
                  .ForMember(c => c.Image, m => m.MapFrom(c => c.Image))
                  .ReverseMap();
        }
    }
}
