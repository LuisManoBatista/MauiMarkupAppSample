namespace MauiMarkupApp.Resources.Styles;

public static class LabelStyle
{
    public static Style Create() => new(typeof(Label))
    {
        Setters =
        {
            ApplicationStylesDictionary.AppThemeSetter(Label.TextColorProperty, ApplicationColorsDictionary.Black, ApplicationColorsDictionary.White),
            ApplicationStylesDictionary.SimpleSetter(VisualElement.BackgroundColorProperty, ApplicationColorsDictionary.Transparent),
            ApplicationStylesDictionary.SimpleSetter(Label.FontFamilyProperty, "OpenSansRegular"),
            ApplicationStylesDictionary.SimpleSetter(Label.FontSizeProperty, 14),
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
                                    ApplicationStylesDictionary.AppThemeSetter(Label.TextColorProperty, ApplicationColorsDictionary.Gray300, ApplicationColorsDictionary.Gray600)
                                }
                            }
                        }
                    }
                }
            }
        }
    };
}