using MauiAppNews.Models;
using MauiAppNews.Services;

namespace MauiAppNews.ViewModels
{
    public class SectionsViewModel
    {
        public SectionsViewModel(INewsService news)
        {
            Sections = news.GetCategories();
        }

        public ICollection<Category> Sections { get; set; }
    }
}
