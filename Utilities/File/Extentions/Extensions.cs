using System.IO;
using Microsoft.AspNetCore.Http;

namespace Utilities.File.Extentions
{
    public static class Extensions
    {
        public static async void UploadFile(this IFormFile file, string rootPath, string destinationPath,
            string fileName)
        {
            var filePath = Path.Combine(rootPath, destinationPath, fileName);

            await using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(fileStream);
            }
        }
    }
}