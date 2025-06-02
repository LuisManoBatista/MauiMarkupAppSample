using CommunityToolkit.Maui;

namespace MauiMarkupApp.Resources.Styles.Extensions;

public static class VisualStateGroupListExtensions
{
    public static VisualStateGroupList AddItem(this VisualStateGroupList list, string groupName, Action<VisualStateGroup> configure)
    {
        var group = new VisualStateGroup { Name = groupName };
        configure?.Invoke(group);
        list.Add(group);
        return list;
    }

    // Add VisualState by name
    public static VisualStateGroup Add(this VisualStateGroup group, string name)
    {
        var state = new VisualState { Name = name };
        group.States.Add(state);
        return group;
    }

    // Add VisualState by name with configuration
    public static VisualStateGroup Add(this VisualStateGroup group, string name, Action<VisualState> configure)
    {
        var state = new VisualState { Name = name };
        configure?.Invoke(state);
        group.States.Add(state);
        return group;
    }
    public static VisualState Add(this VisualState state, BindableProperty property, object value)
    {
        return state.AddSetter(
            new Setter() 
            { 
                Property = property, 
                Value = value 
            });
    }

    public static VisualState AddAppThemeBinding(this VisualState state, BindableProperty property, Color lightColor, Color darkColor)
    {
        return state.AddSetter(
            new Setter() 
            { 
                Property = property, 
                Value = new AppThemeColor 
                { 
                    Light = lightColor, 
                    Dark = darkColor 
                }.GetBinding() 
            });
    }

    private static VisualState AddSetter(this VisualState state, Setter setter)
    {
        state.Setters.Add(setter);
        return state;
    }
}
