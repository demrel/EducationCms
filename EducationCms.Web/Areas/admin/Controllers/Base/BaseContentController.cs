using AutoMapper;
using EducationCms.Service.Interface;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducationCms.Web.Areas.admin.Controllers
{
    public abstract class BaseContentController<T> : BaseAdminController
    {
        protected readonly IMapper _mapper;
        protected readonly IImageFile _imageService;
        protected readonly IWebHostEnvironment _env;
        public BaseContentController(IMapper mapper, IImageFile imageService, IWebHostEnvironment env)
        {
            _mapper = mapper;
            _imageService = imageService;
            _env = env;
        }

        public BaseContentController(IMapper mapper)
        {
            _mapper = mapper;
        }

        public abstract Task<IActionResult> Index();
        public abstract Task<IActionResult> Create(T model);
        //public abstract IActionResult Create();
        public abstract Task<IActionResult> Update(T model);
        public abstract Task<IActionResult> Update(int id);
        public abstract Task<IActionResult> Delete(int id);
    }
}
