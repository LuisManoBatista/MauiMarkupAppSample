namespace MauiMarkupApp.Resources.Styles;

public static class ImageButtonStyle
{
    public static Style Create() => new(typeof(ImageButton))
    {
        Setters =
        {
            ApplicationStylesDictionary.SimpleSetter(VisualElement.OpacityProperty, 1),
            ApplicationStylesDictionary.SimpleSetter(ImageButton.BorderColorProperty, ApplicationColorsDictionary.Transparent),
            ApplicationStylesDictionary.SimpleSetter(ImageButton.BorderWidthProperty, 0),
            ApplicationStylesDictionary.SimpleSetter(ImageButton.CornerRadiusProperty, 0),
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
                                    ApplicationStylesDictionary.SimpleSetter(VisualElement.OpacityProperty, 0.5)
                                }
                            },
                            new VisualState { Name = "PointerOver" }
                        }
                    }
                }
            }
        }
    };
}