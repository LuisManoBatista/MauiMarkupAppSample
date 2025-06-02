namespace MauiMarkupApp.Resources.Styles;

public static class EntryStyle
{
    public static Style Create() => new(typeof(Entry))
    {
        Setters =
        {
            ApplicationStylesDictionary.AppThemeBinding(Entry.TextColorProperty, ApplicationColorsDictionary.Black, ApplicationColorsDictionary.White),
            ApplicationStylesDictionary.SimpleSetter(VisualElement.BackgroundColorProperty, ApplicationColorsDictionary.Transparent),
            ApplicationStylesDictionary.SimpleSetter(Entry.FontFamilyProperty, "OpenSansRegular"),
            ApplicationStylesDictionary.SimpleSetter(Entry.FontSizeProperty, 14),
            ApplicationStylesDictionary.AppThemeBinding(Entry.PlaceholderColorProperty, ApplicationColorsDictionary.Gray200, ApplicationColorsDictionary.Gray500),
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
                                    ApplicationStylesDictionary.AppThemeBinding(Entry.TextColorProperty, ApplicationColorsDictionary.Gray300, ApplicationColorsDictionary.Gray600)
                                }
                            }
                        }
                    }
                }
            }
        }
    };
}