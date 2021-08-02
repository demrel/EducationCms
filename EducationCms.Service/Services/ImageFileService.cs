using EducationCms.Data.Data;
using EducationCms.Data.Model;
using EducationCms.Service.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace EducationCms.Service.Services
{
    public class ImageFileService : IImageFile
    {

        private readonly AppDBContext _context;
        public ImageFileService(AppDBContext context)
        {
            _context = context;
        }
        public async Task<AppImage> Add(IFormFile formFile, string path)
        {
            AppImage file =await AddImage(formFile, path);
            if (file != null)
            {
                _context.Add(file);
                await  _context.SaveChangesAsync();
                return file;
            }
            return null;
        }



        public async Task<List<AppImage>> AddAll(List<IFormFile> formFiles, string path)
        {
            List<AppImage> files = new ();
            if (formFiles == null) return files;
            
            foreach (var item in formFiles)
            {
                files.Add(await AddImage(item, path));
            }
            _context.Images.AddRange(files);
         //   _context.SaveChanges();
            return files;
        }


        private async static Task<AppImage> AddImage(IFormFile formFile, string path)
        {
            if (formFile != null)
            {
                string fileName = Guid.NewGuid().ToString()  + Path.GetExtension(formFile.FileName);

                var p = Path.Combine(path);
                if (!Directory.Exists(p))
                {
                    Directory.CreateDirectory(p);
                }
                
                using (var fileStream = new FileStream(Path.Combine(p,fileName), FileMode.Create))
                {
                    
                    await formFile.CopyToAsync(fileStream);
                }
                var imagFile = new AppImage { Name = fileName , Url = path };
                return imagFile;
            }
            return null;
        }



        public void Delete(int id)
        {
            var image = GetById(id);

            if (image == null) return;
            Delete(image);
        }

        private void Delete(AppImage img)
        {
            var imagePath = img.Url + img.Name;
            RemoveImage(imagePath);
            _context.Images.Remove(img);
        }

        public void DeleteRange(List<AppImage> images)
        {
            foreach (var item in images)
            {
                Delete(item);
            }
        }

        private static void RemoveImage(string path)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }

        public async Task<AppImage> Edit(IFormFile formFile,string path, int id)
        {
            
           var oldImage=await _context.Images.FirstOrDefaultAsync(i => i.Id == id);
            AppImage file = await AddImage(formFile,path);
            if (file != null)
            {
                if (oldImage!=null)
                {
                    RemoveImage(oldImage.Url + oldImage.Name);
                }
                else
                {
                    oldImage = new AppImage();
                }
              
                oldImage.Name = file.Name;
                oldImage.Url = file.Url;
                _context.Update(oldImage);
                await _context.SaveChangesAsync();
               
               
            }
            return oldImage;
        }

        public AppImage GetById(int id)
        {
            return _context.Images.Find(id);
        }


        public void SaveChanges()
        {
            
            _context.SaveChanges();
        }

   
    }
}

