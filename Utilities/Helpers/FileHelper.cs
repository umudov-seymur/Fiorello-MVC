using System.IO;

namespace Utilities.Helpers
{
    public static class FileHelper
    {
        public static void RemoveFile(string rootPath, string file)
        {
            var filePath = Path.Combine(rootPath, file);

            if (System.IO.File.Exists(filePath))
            {
                System.IO.File.Delete(filePath);
            }
        }
    }
}