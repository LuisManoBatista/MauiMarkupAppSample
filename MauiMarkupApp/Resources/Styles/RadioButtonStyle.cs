namespace MauiMarkupApp.Resources.Styles;

public static class RadioButtonStyle
{
    public static Style Create() => new(typeof(RadioButton))
    {
        Setters =
        {
            ApplicationStylesDictionary.SimpleSetter(VisualElement.BackgroundColorProperty, ApplicationColorsDictionary.Transparent),
            ApplicationStylesDictionary.AppThemeBinding(RadioButton.TextColorProperty, ApplicationColorsDictionary.Black, ApplicationColorsDictionary.White),
            ApplicationStylesDictionary.SimpleSetter(RadioButton.FontFamilyProperty, "OpenSansRegular"),
            ApplicationStylesDictionary.SimpleSetter(RadioButton.FontSizeProperty, 14),
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
                                Setters = { ApplicationStylesDictionary.AppThemeBinding(RadioButton.TextColorProperty, ApplicationColorsDictionary.Gray300, ApplicationColorsDictionary.Gray600) }
                            }
                        }
                    }
                }
            }
        }
    };
}