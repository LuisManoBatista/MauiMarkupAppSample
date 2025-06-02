namespace MauiMarkupApp.Resources.Styles;

[Obsolete("FrameStyle is deprecated and will be removed in a future release. Use alternative styling methods.")]
public static class FrameStyle
{
    public static Style Create() => new(typeof(Frame))
    {
        Setters =
        {
            ApplicationStylesDictionary.SimpleSetter(Frame.HasShadowProperty, false),
            ApplicationStylesDictionary.AppThemeBinding(Frame.BorderColorProperty, ApplicationColorsDictionary.Gray200, ApplicationColorsDictionary.Gray950),
            ApplicationStylesDictionary.SimpleSetter(Frame.CornerRadiusProperty, 8),
            ApplicationStylesDictionary.AppThemeBinding(VisualElement.BackgroundColorProperty, ApplicationColorsDictionary.White, ApplicationColorsDictionary.Black)
        }
    };
}