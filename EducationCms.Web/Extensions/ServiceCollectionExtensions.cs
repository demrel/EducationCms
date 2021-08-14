using EducationCms.Service.Interface;
using EducationCms.Service.Interface.PostInterface;
using EducationCms.Service.Services;
using EducationCms.Service.Services.Posts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducationCms.Web.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
   
         
            services.AddScoped<IBanner, BannerService>();
            services.AddScoped<IPage, PageService>();
            services.AddScoped<IConsumer, ConsumerService>();
            services.AddScoped<IQA, QAService>();
            services.AddScoped<ICategory, CategoryService>();
            services.AddScoped<IImageFile, ImageFileService>();
            services.AddScoped<ITizerVideo, TizerVideoService>();
            services.AddScoped<ISiteSetting, SiteSettingService>();
            services.AddScoped<IMissionVission, MissionVissionSecrive>();

            services.AddScoped<IBlog, BlogService>();
            services.AddScoped<IConsulting, ConsultingService>();
            services.AddScoped<IMaintence, MaintanceService>();
            services.AddScoped<ISeminar, SeminarService>();
            services.AddScoped<IFileShare, FileShareService>();
            services.AddScoped<IVideo, VideoService>();
            services.AddScoped(typeof(IBasePost<>), typeof(BasePostService<>));

            return services;
        }
    }
}
