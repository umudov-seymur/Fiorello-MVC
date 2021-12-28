using System.IO;

namespace Utilities.File.Helpers
{
    public static class FileHelpers
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