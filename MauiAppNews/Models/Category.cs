namespace MauiAppNews.Models
{
    public class Category
    {
        public string Name { get; set; }

        public string MaterialIcon { get; set; }

        public Category(string name, string icon)
        {
            Name = name;
            MaterialIcon = icon;
        }
    }
}
