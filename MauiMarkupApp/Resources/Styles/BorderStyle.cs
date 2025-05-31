namespace MauiMarkupApp.Resources.Styles;

public static class BorderStyle
{
    public static Style Create() => new(typeof(Border))
    {
        Setters =
        {
            ApplicationStylesDictionary.AppThemeSetter(Border.StrokeProperty, ApplicationColorsDictionary.Gray200, ApplicationColorsDictionary.Gray500),
            ApplicationStylesDictionary.SimpleSetter(Border.StrokeShapeProperty, new Microsoft.Maui.Controls.Shapes.Rectangle()),
            ApplicationStylesDictionary.SimpleSetter(Border.StrokeThicknessProperty, 1)
        }
    };
}