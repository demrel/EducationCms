using AutoMapper;
using EducationCms.Data.Model.Posts;
using EducationCms.Service.Interface;
using EducationCms.Service.Interface.PostInterface;
using EducationCms.Web.Areas.admin.Controllers.Base;
using EducationCms.Web.Areas.admin.Models.Blog;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducationCms.Web.Areas.admin.Controllers.Posts
{
    public class BlogController : BasePostController<Blog, BlogAddVM>
    {
        private readonly IBlog _blogService;
        private readonly ICategory _categoryService;
        public BlogController(IMapper mapper, 
            IImageFile imageService,
            IWebHostEnvironment env, 
            IBlog blogService,
            IBasePost<Blog> basePostService,
            ICategory categoryService) : base(mapper, imageService, env, basePostService)
        {
            _blogService = blogService;
            _categoryService = categoryService;
        }

        public override async Task<IActionResult> Index()
        {
            var blogs=await  _blogService.GetAllForList();
            BlogIndexVM model = new ()
            {
                Blogs=_mapper.Map<List<BlogListModel>>(blogs)
            };
            return View(model);
        }

        [HttpGet]
        public   async Task<IActionResult> Create()
        {
            var categories = await _categoryService.GetAll();
            BlogAddVM model = new ()
            {
                Categories = new SelectList(categories, nameof(Category.Id), nameof(Category.Name))
            };
           
            return View(model);
        }

        [HttpPost]
        public override async Task<IActionResult> Create(BlogAddVM model)
        {
            var data = _mapper.Map<Blog>(model.Add);
            data.BannerImage = await _imageService.Add(model.Image, _env.WebRootPath + "/images/posts/");
            await _blogService.Create(data);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public override async Task<IActionResult> Update(BlogAddVM model)
        {
            var data = _mapper.Map<Blog>(model.Add);
            data.BannerImage = await _imageService.Edit(model.Image, _env.WebRootPath + "/images/posts/", model.Add.Image.Id);
            await _blogService.Update(data);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public override async Task<IActionResult> Update(int id)
        {
            var blog = await _blogService.GetById(id);
            var categories = await _categoryService.GetAll();

            BlogAddVM model = new ()
            {
                Categories = new SelectList(categories, nameof(Category.Id), nameof(Category.Name), blog.CategoryId),
                Add = _mapper.Map<BlogModel>(blog)
            };

            return View(model);
        }
    }
}
