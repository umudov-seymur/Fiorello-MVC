namespace Fiorello_MVC.Helpers
{
    public static class Helpers
    {
        public static string CategorySlug(string name, int id)
        {
            return $"{name.ToLower()}_{id}";
        }
    }
}
