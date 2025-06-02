namespace MauiMarkupApp.Resources.Styles;

public static class SwipeItemStyle
{
    public static Style Create() => new(typeof(SwipeItem))
    {
        Setters = { ApplicationStylesDictionary.AppThemeBinding(VisualElement.BackgroundColorProperty, ApplicationColorsDictionary.White, ApplicationColorsDictionary.Black) }
    };
}