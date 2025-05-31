namespace MauiMarkupApp.Resources.Styles;

public static class TimePickerStyle
{
    public static Style Create() => new(typeof(TimePicker))
    {
        Setters =
        {
            ApplicationStylesDictionary.AppThemeSetter(TimePicker.TextColorProperty, ApplicationColorsDictionary.Gray900, ApplicationColorsDictionary.White),
            ApplicationStylesDictionary.SimpleSetter(VisualElement.BackgroundColorProperty, ApplicationColorsDictionary.Transparent),
            ApplicationStylesDictionary.SimpleSetter(TimePicker.FontFamilyProperty, "OpenSansRegular"),
            ApplicationStylesDictionary.SimpleSetter(TimePicker.FontSizeProperty, 14),
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
                                Setters = { ApplicationStylesDictionary.AppThemeSetter(TimePicker.TextColorProperty, ApplicationColorsDictionary.Gray300, ApplicationColorsDictionary.Gray600) }
                            }
                        }
                    }
                }
            }
        }
    };
}