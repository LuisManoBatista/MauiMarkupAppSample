namespace MauiMarkupApp.Resources.Styles;

public static class CheckBoxStyle
{
    public static Style Create() => new(typeof(CheckBox))
    {
        Setters =
        {
            ApplicationStylesDictionary.AppThemeSetter(CheckBox.ColorProperty, ApplicationColorsDictionary.Primary, ApplicationColorsDictionary.White),
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
                                Setters = { ApplicationStylesDictionary.AppThemeSetter(CheckBox.ColorProperty, ApplicationColorsDictionary.Gray300, ApplicationColorsDictionary.Gray600) }
                            }
                        }
                    }
                }
            }
        }
    };
}