using MauiMarkupApp.Resources.Styles;

namespace MauiMarkupApp;

public partial class App : Application
{
    private readonly IServiceProvider _serviceProvider;
    public App(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider; 
        Resources = new ResourceDictionary
        {
            MergedDictionaries =
            {
                new ApplicationColorsDictionary(),
                new ApplicationStylesDictionary()
            }
        };
    }

    protected override Window CreateWindow(IActivationState? activationState)
    {
        return new Window(_serviceProvider.GetRequiredService<AppShell>());
    }
}