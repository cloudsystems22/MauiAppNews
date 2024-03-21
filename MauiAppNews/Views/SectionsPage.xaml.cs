using MauiAppNews.Services;
using MauiAppNews.ViewModels;

namespace MauiAppNews.Views;

public partial class SectionsPage : ContentPage
{
	public SectionsPage(INewsService news)
	{
		InitializeComponent();
        this.BindingContext = new SectionsViewModel(news);
    }
}