namespace MauiMarkupApp.Resources.Styles;

public static class ButtonStyle
{
    public static Style Create() => new(typeof(Button))
    {
        Setters =
        {
            ApplicationStylesDictionary.AppThemeSetter(Button.TextColorProperty, ApplicationColorsDictionary.White, ApplicationColorsDictionary.PrimaryDarkText),
            ApplicationStylesDictionary.AppThemeSetter(VisualElement.BackgroundColorProperty, ApplicationColorsDictionary.Primary, ApplicationColorsDictionary.PrimaryDark),
            ApplicationStylesDictionary.SimpleSetter(Button.FontFamilyProperty, "OpenSansRegular"),
            ApplicationStylesDictionary.SimpleSetter(Button.FontSizeProperty, 14),
            ApplicationStylesDictionary.SimpleSetter(Button.BorderWidthProperty, 0),
            ApplicationStylesDictionary.SimpleSetter(Button.CornerRadiusProperty, 8),
            ApplicationStylesDictionary.SimpleSetter(Button.PaddingProperty, new Thickness(14, 10)),
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
                                    ApplicationStylesDictionary.AppThemeSetter(Button.TextColorProperty, ApplicationColorsDictionary.Gray950, ApplicationColorsDictionary.Gray200),
                                    ApplicationStylesDictionary.AppThemeSetter(VisualElement.BackgroundColorProperty, ApplicationColorsDictionary.Gray200, ApplicationColorsDictionary.Gray600)
                                }
                            },
                            new VisualState { Name = "PointerOver" }
                        }
                    }
                }
            }
        }
    };
}