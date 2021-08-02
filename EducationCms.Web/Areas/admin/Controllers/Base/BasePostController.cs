using AutoMapper;
using EducationCms.Data.Model.Posts;
using EducationCms.Service.Interface;
using EducationCms.Service.Interface.PostInterface;
using EducationCms.Web.Areas.admin.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducationCms.Web.Areas.admin.Controllers.Base
{
    public abstract class BasePostController<T,M>:BaseAdminController where T: BasePost 
    {
        protected readonly IMapper _mapper;
        protected readonly IImageFile _imageService;
        protected readonly IWebHostEnvironment _env;
        protected readonly IBasePost<T> _postService;
        public BasePostController(IMapper mapper, IImageFile imageService, IWebHostEnvironment env, IBasePost<T> postService)
        {
            _mapper = mapper;
            _imageService = imageService;
            _env = env;
            _postService = postService;
        }

        public virtual async Task<IActionResult> Index()
        {
            var data = await _postService.GetAll();
            BasePostIndexVM model = new ()
            {
              Posts =  _mapper.Map<List<BasePostListModel>>(data)
             };
            return View("Areas/admin/Views/BasePostList/Index.cshtml", model);
        }



        public abstract Task<IActionResult> Create(M model);
        public abstract Task<IActionResult> Update(M model);
        public abstract Task<IActionResult> Update(int id);
     



        public async Task<IActionResult> Delete(int id)
        {
            await _postService.Delete(id);

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> ActivateDeactivate(int id)
        {
            await _postService.ActivateDeactivate(id);

            return RedirectToAction("Index");
        }
    }
}
