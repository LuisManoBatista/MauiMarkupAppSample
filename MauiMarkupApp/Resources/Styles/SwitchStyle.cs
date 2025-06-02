namespace MauiMarkupApp.Resources.Styles;

public static class SwitchStyle
{
    public static Style Create() => new(typeof(Switch))
    {
        Setters =
        {
            ApplicationStylesDictionary.AppThemeBinding(Switch.OnColorProperty, ApplicationColorsDictionary.Primary, ApplicationColorsDictionary.White),
            ApplicationStylesDictionary.SimpleSetter(Switch.ThumbColorProperty, ApplicationColorsDictionary.White),
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
                                    ApplicationStylesDictionary.AppThemeBinding(Switch.OnColorProperty, ApplicationColorsDictionary.Gray300, ApplicationColorsDictionary.Gray600),
                                    ApplicationStylesDictionary.AppThemeBinding(Switch.ThumbColorProperty, ApplicationColorsDictionary.Gray300, ApplicationColorsDictionary.Gray600)
                                }
                            },
                            new VisualState
                            {
                                Name = "On",
                                Setters =
                                {
                                    ApplicationStylesDictionary.AppThemeBinding(Switch.OnColorProperty, ApplicationColorsDictionary.Secondary, ApplicationColorsDictionary.Gray200),
                                    ApplicationStylesDictionary.AppThemeBinding(Switch.ThumbColorProperty, ApplicationColorsDictionary.Primary, ApplicationColorsDictionary.White)
                                }
                            },
                            new VisualState
                            {
                                Name = "Off",
                                Setters = { ApplicationStylesDictionary.AppThemeBinding(Switch.ThumbColorProperty, ApplicationColorsDictionary.Gray400, ApplicationColorsDictionary.Gray500) }
                            }
                        }
                    }
                }
            }
        }
    };
}