using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Utilities.File.Extentions
{
    public static class Extensions
    {
        public static async Task<string> UploadFile(this IFormFile file, string rootPath, string destinationPath)
        {
            var fileName = $"{Guid.NewGuid()}_{file.FileName}";;
            var filePath = Path.Combine(rootPath, destinationPath, fileName);

            await using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(fileStream);
            }

            return fileName;
        }
    }
}