using MauiAppNews.Services;
using MauiAppNews.ViewModels;

namespace MauiAppNews.Views;

public partial class HomePage : ContentPage
{
    public HomePage(INewsService news)
    {
        InitializeComponent();
        this.BindingContext = new HomeViewModel(news);
    }
}