using System;
using Fiorello_MVC.DAL;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorello_MVC.Helpers
{
    public static class Helpers
    {
        public static async Task<string> Setting(AppDbContext context, string key)
        {
            return (await context.Settings
                    .Where(setting => setting.Key == key)
                    .FirstOrDefaultAsync())
                    .Value;
        }

        public static string CategorySlug(string name, int id)
        {
            return $"{name.ToLower()}_{id}";
        }
    }
}