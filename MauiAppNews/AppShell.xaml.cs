using MauiAppNews.Views;

namespace MauiAppNews
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("article", typeof(ArticlePage));

            this.HomeTab.Icon = ImageSource.FromResource("MauiAppNews.Resources.Images.home.png", this.GetType().Assembly);
            this.SectionsTab.Icon = ImageSource.FromResource("MauiAppNews.Resources.Images.categories.png", this.GetType().Assembly);
            this.BookmarksTab.Icon = ImageSource.FromResource("MauiAppNews.Resources.Images.bookmarks.png", this.GetType().Assembly);
            this.ProfileTab.Icon = ImageSource.FromResource("MauiAppNews.Resources.Images.profile.png", this.GetType().Assembly);
        }
    }
}
