namespace MauiMarkupApp.Resources.Styles;

public static class EditorStyle
{
    public static Style Create() => new(typeof(Editor))
    {
        Setters =
        {
            ApplicationStylesDictionary.AppThemeSetter(Editor.TextColorProperty, ApplicationColorsDictionary.Black, ApplicationColorsDictionary.White),
            ApplicationStylesDictionary.SimpleSetter(VisualElement.BackgroundColorProperty, ApplicationColorsDictionary.Transparent),
            ApplicationStylesDictionary.SimpleSetter(Editor.FontFamilyProperty, "OpenSansRegular"),
            ApplicationStylesDictionary.SimpleSetter(Editor.FontSizeProperty, 14),
            ApplicationStylesDictionary.AppThemeSetter(Editor.PlaceholderColorProperty, ApplicationColorsDictionary.Gray200, ApplicationColorsDictionary.Gray500),
            ApplicationStylesDictionary.SimpleSetter(VisualElement.MinimumHeightRequestProperty, 44),
            ApplicationStylesDictionary.SimpleSetter(VisualElement.MinimumWidthRequestProperty, 44),
            new Setter
            {
                Property = VisualStateManager.VisualStateGroupsProperty,
                Value = new VisualStateGroupList
                {
                    new VisualStateGroup
                    {
                        Name = "CommonStates",
                        States =
                        {
                            new VisualState { Name = "Normal" },
                            new VisualState
                            {
                                Name = "Disabled",
                                Setters =
                                {
                                    ApplicationStylesDictionary.AppThemeSetter(Editor.TextColorProperty, ApplicationColorsDictionary.Gray300, ApplicationColorsDictionary.Gray600)
                                }
                            }
                        }
                    }
                }
            }
        }
    };
}