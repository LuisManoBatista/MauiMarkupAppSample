namespace MauiMarkupApp.Resources.Styles;

public static class SearchHandlerStyle
{
    public static Style Create() => new(typeof(SearchHandler))
    {
        Setters =
        {
            ApplicationStylesDictionary.AppThemeSetter(SearchHandler.TextColorProperty, ApplicationColorsDictionary.Gray900, ApplicationColorsDictionary.White),
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
                                    ApplicationStylesDictionary.AppThemeSetter(SearchHandler.TextColorProperty, ApplicationColorsDictionary.Gray300, ApplicationColorsDictionary.Gray600),
                                    ApplicationStylesDictionary.AppThemeSetter(SearchHandler.PlaceholderColorProperty, ApplicationColorsDictionary.Gray300, ApplicationColorsDictionary.Gray600)
                                }
                            }
                        }
                    }
                }
            }
        }
    };
}