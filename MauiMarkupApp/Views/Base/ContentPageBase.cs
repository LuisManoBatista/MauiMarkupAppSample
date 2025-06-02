using MauiMarkupApp.ViewModels.Base;

namespace MauiMarkupApp.Views.Base;

public abstract class ContentPageBase<TViewModel>(TViewModel viewModel) : ContentPageBase(viewModel) where TViewModel : ViewModelBase
{
    public new TViewModel BindingContext => (TViewModel)base.BindingContext;
}

public abstract class ContentPageBase : ContentPage
{
    protected ContentPageBase(object? viewModel = null)
    {
        BindingContext = viewModel;
        Padding = 12;
    }
}
