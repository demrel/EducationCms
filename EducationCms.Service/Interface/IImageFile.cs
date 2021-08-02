using EducationCms.Data.Model;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace EducationCms.Service.Interface
{
    public interface IImageFile
    {
        Task<AppImage> Add(IFormFile formFile, string path);
        Task<List<AppImage>> AddAll(List<IFormFile> formFiles, string path);
        void Delete(int id);
        Task<AppImage> Edit(IFormFile formFile, string path, int id);
        AppImage GetById(int id);
        void SaveChanges();
        void DeleteRange(List<AppImage> images);
    }
}
