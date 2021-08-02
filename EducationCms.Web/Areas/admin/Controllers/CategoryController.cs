using AutoMapper;
using EducationCms.Data.Model.Posts;
using EducationCms.Service.Interface;
using EducationCms.Web.Areas.admin.Models.Category;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducationCms.Web.Areas.admin.Controllers
{
    public class CategoryController : BaseAdminController
    {
        private readonly ICategory _categoryService;
        private readonly IMapper _mapper;
        public CategoryController(ICategory categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var categories =await _categoryService.GetAll();
            CategoryIndexVM model = new()
            {
                Categories = _mapper.Map<List<CategoryModel>>(categories)
            };
            return View(model);
        }

        public async Task<IActionResult> Create(CategoryIndexVM model)
        {
            var data = _mapper.Map<Category>(model.Add);
            await _categoryService.Create(data);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Update(CategoryIndexVM model)
        {
            var data = _mapper.Map<Category>(model.Add);
            await _categoryService.Update(data);
            return RedirectToAction("Index");
        }

        public  async Task<IActionResult> Delete(int id)
        {
            await _categoryService.Delete(id);
            return RedirectToAction("Index");
        }

    }
}
