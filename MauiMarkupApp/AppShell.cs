using MauiMarkupApp.Views;

namespace MauiMarkupApp;

public partial class AppShell : Shell
{
    public AppShell(IServiceProvider serviceProvider)
    {
    
        Title = "Maui Markup Sample";
        var mainPage = new ShellContent
        {
            Title = "Home",
            ContentTemplate = new DataTemplate(serviceProvider.GetRequiredService<MainPage>),
            Route = "MainPage"
        };

        Items.Add(mainPage);
    }
} 
