namespace MauiMarkupApp.Resources.Styles;

public static class PageStyle
{
    public static Style Create() => new(typeof(Page))
    {
        Setters =
        {
            ApplicationStylesDictionary.SimpleSetter(Page.PaddingProperty, 0),
            ApplicationStylesDictionary.AppThemeSetter(VisualElement.BackgroundColorProperty, ApplicationColorsDictionary.White, ApplicationColorsDictionary.OffBlack)
        },
        ApplyToDerivedTypes = true
    };
}