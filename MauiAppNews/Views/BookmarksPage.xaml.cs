using MauiAppNews.Services;
using MauiAppNews.ViewModels;

namespace MauiAppNews.Views;

public partial class BookmarksPage : ContentPage
{
    public BookmarksPage(INewsService news)
    {
        InitializeComponent();
        BindingContext = new BookmarksViewModel(news);
    }
}