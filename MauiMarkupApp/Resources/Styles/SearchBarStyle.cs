namespace MauiMarkupApp.Resources.Styles;

public static class SearchBarStyle
{
    public static Style Create() => new(typeof(SearchBar))
    {
        Setters =
        {
            ApplicationStylesDictionary.AppThemeBinding(SearchBar.TextColorProperty, ApplicationColorsDictionary.Gray900, ApplicationColorsDictionary.White),
            ApplicationStylesDictionary.SimpleSetter(SearchBar.PlaceholderColorProperty, ApplicationColorsDictionary.Gray500),
            ApplicationStylesDictionary.SimpleSetter(SearchBar.CancelButtonColorProperty, ApplicationColorsDictionary.Gray500),
            ApplicationStylesDictionary.SimpleSetter(VisualElement.BackgroundColorProperty, ApplicationColorsDictionary.Transparent),
            ApplicationStylesDictionary.SimpleSetter(SearchBar.FontFamilyProperty, "OpenSansRegular"),
            ApplicationStylesDictionary.SimpleSetter(SearchBar.FontSizeProperty, 14),
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
                                    ApplicationStylesDictionary.AppThemeBinding(SearchBar.TextColorProperty, ApplicationColorsDictionary.Gray300, ApplicationColorsDictionary.Gray600),
                                    ApplicationStylesDictionary.AppThemeBinding(SearchBar.PlaceholderColorProperty, ApplicationColorsDictionary.Gray300, ApplicationColorsDictionary.Gray600)
                                }
                            }
                        }
                    }
                }
            }
        }
    };
}