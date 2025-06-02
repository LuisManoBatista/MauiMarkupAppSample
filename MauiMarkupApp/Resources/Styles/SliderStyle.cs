namespace MauiMarkupApp.Resources.Styles;

public static class SliderStyle
{
    public static Style Create() => new(typeof(Slider))
    {
        Setters =
        {
            ApplicationStylesDictionary.AppThemeBinding(Slider.MinimumTrackColorProperty, ApplicationColorsDictionary.Primary, ApplicationColorsDictionary.White),
            ApplicationStylesDictionary.AppThemeBinding(Slider.MaximumTrackColorProperty, ApplicationColorsDictionary.Gray200, ApplicationColorsDictionary.Gray600),
            ApplicationStylesDictionary.AppThemeBinding(Slider.ThumbColorProperty, ApplicationColorsDictionary.Primary, ApplicationColorsDictionary.White),
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
                                    ApplicationStylesDictionary.AppThemeBinding(Slider.MinimumTrackColorProperty, ApplicationColorsDictionary.Gray300, ApplicationColorsDictionary.Gray600),
                                    ApplicationStylesDictionary.AppThemeBinding(Slider.MaximumTrackColorProperty, ApplicationColorsDictionary.Gray300, ApplicationColorsDictionary.Gray600),
                                    ApplicationStylesDictionary.AppThemeBinding(Slider.ThumbColorProperty, ApplicationColorsDictionary.Gray300, ApplicationColorsDictionary.Gray600)
                                }
                            }
                        }
                    }
                }
            }
        }
    };
}