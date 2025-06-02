namespace MauiMarkupApp.Resources.Styles;

public static class SearchHandlerStyle
{
    public static Style Create() => new(typeof(SearchHandler))
    {
        Setters =
        {
            ApplicationStylesDictionary.AppThemeBinding(SearchHandler.TextColorProperty, ApplicationColorsDictionary.Gray900, ApplicationColorsDictionary.White),
            ApplicationStylesDictionary.SimpleSetter(SearchHandler.PlaceholderColorProperty, ApplicationColorsDictionary.Gray500),
            ApplicationStylesDictionary.SimpleSetter(VisualElement.BackgroundColorProperty, ApplicationColorsDictionary.Transparent),
            ApplicationStylesDictionary.SimpleSetter(SearchHandler.FontFamilyProperty, "OpenSansRegular"),
            ApplicationStylesDictionary.SimpleSetter(SearchHandler.FontSizeProperty, 14),
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
                                    ApplicationStylesDictionary.AppThemeBinding(SearchHandler.TextColorProperty, ApplicationColorsDictionary.Gray300, ApplicationColorsDictionary.Gray600),
                                    ApplicationStylesDictionary.AppThemeBinding(SearchHandler.PlaceholderColorProperty, ApplicationColorsDictionary.Gray300, ApplicationColorsDictionary.Gray600)
                                }
                            }
                        }
                    }
                }
            }
        }
    };
}