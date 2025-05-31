namespace MauiMarkupApp.Resources.Styles;

public static class SliderStyle
{
    public static Style Create() => new(typeof(Slider))
    {
        Setters =
        {
            ApplicationStylesDictionary.AppThemeSetter(Slider.MinimumTrackColorProperty, ApplicationColorsDictionary.Primary, ApplicationColorsDictionary.White),
            ApplicationStylesDictionary.AppThemeSetter(Slider.MaximumTrackColorProperty, ApplicationColorsDictionary.Gray200, ApplicationColorsDictionary.Gray600),
            ApplicationStylesDictionary.AppThemeSetter(Slider.ThumbColorProperty, ApplicationColorsDictionary.Primary, ApplicationColorsDictionary.White),
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
                                    ApplicationStylesDictionary.AppThemeSetter(Slider.MinimumTrackColorProperty, ApplicationColorsDictionary.Gray300, ApplicationColorsDictionary.Gray600),
                                    ApplicationStylesDictionary.AppThemeSetter(Slider.MaximumTrackColorProperty, ApplicationColorsDictionary.Gray300, ApplicationColorsDictionary.Gray600),
                                    ApplicationStylesDictionary.AppThemeSetter(Slider.ThumbColorProperty, ApplicationColorsDictionary.Gray300, ApplicationColorsDictionary.Gray600)
                                }
                            }
                        }
                    }
                }
            }
        }
    };
}