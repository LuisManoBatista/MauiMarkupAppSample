namespace MauiMarkupApp.Resources.Styles;

public static class DatePickerStyle
{
    public static Style Create() => new(typeof(DatePicker))
    {
        Setters =
        {
            ApplicationStylesDictionary.AppThemeSetter(DatePicker.TextColorProperty, ApplicationColorsDictionary.Gray900, ApplicationColorsDictionary.White),
            ApplicationStylesDictionary.SimpleSetter(VisualElement.BackgroundColorProperty, ApplicationColorsDictionary.Transparent),
            ApplicationStylesDictionary.SimpleSetter(DatePicker.FontFamilyProperty, "OpenSansRegular"),
            ApplicationStylesDictionary.SimpleSetter(DatePicker.FontSizeProperty, 14),
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
                                    ApplicationStylesDictionary.AppThemeSetter(DatePicker.TextColorProperty, ApplicationColorsDictionary.Gray200, ApplicationColorsDictionary.Gray500)
                                }
                            }
                        }
                    }
                }
            }
        }
    };
}