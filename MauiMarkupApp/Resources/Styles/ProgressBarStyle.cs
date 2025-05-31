namespace MauiMarkupApp.Resources.Styles;

public static class ProgressBarStyle
{
    public static Style Create() => new(typeof(ProgressBar))
    {
        Setters =
        {
            ApplicationStylesDictionary.AppThemeSetter(ProgressBar.ProgressColorProperty, ApplicationColorsDictionary.Primary, ApplicationColorsDictionary.White),
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
                                Setters = { ApplicationStylesDictionary.AppThemeSetter(ProgressBar.ProgressColorProperty, ApplicationColorsDictionary.Gray300, ApplicationColorsDictionary.Gray600) }
                            }
                        }
                    }
                }
            }
        }
    };
}