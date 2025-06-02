namespace MauiMarkupApp.Resources.Styles;

public static class BoxViewStyle
{
    public static Style Create() => new(typeof(BoxView))
    {
        Setters = { ApplicationStylesDictionary.AppThemeBinding(VisualElement.BackgroundColorProperty, ApplicationColorsDictionary.Gray950, ApplicationColorsDictionary.Gray200) }
    };
}