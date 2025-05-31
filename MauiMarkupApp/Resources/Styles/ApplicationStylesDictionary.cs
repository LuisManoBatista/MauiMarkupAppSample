using CommunityToolkit.Maui;

namespace MauiMarkupApp.Resources.Styles;

public partial class ApplicationStylesDictionary : ResourceDictionary
{
    public ApplicationStylesDictionary()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        Add(ActivityIndicatorStyle.Create());
        Add(IndicatorViewStyle.Create());
        Add(BorderStyle.Create());
        Add(BoxViewStyle.Create());
        Add(ButtonStyle.Create());
        Add(CheckBoxStyle.Create());
        Add(DatePickerStyle.Create());
        Add(EditorStyle.Create());
        Add(EntryStyle.Create());
#pragma warning disable CS0618 // Type or member is obsolete
        Add(FrameStyle.Create());
#pragma warning restore CS0618 // Type or member is obsolete
        Add(ImageButtonStyle.Create());
        Add(LabelStyle.Create());
        Add(SpanStyle.Create());
        Add(HeadlineStyle.StyleName, HeadlineStyle.Create());
        Add(SubHeadlineStyle.StyleName, SubHeadlineStyle.Create());
        Add(ListViewStyle.Create());
        Add(PickerStyle.Create());
        Add(ProgressBarStyle.Create());
        Add(RadioButtonStyle.Create());
        Add(RefreshViewStyle.Create());
        Add(SearchBarStyle.Create());
        Add(SearchHandlerStyle.Create());
        Add(ShadowStyle.Create());
        Add(SliderStyle.Create());
        Add(SwipeItemStyle.Create());
        Add(SwitchStyle.Create());
        Add(TimePickerStyle.Create());
        Add(PageStyle.Create());
        Add(ShellStyle.Create());
        Add(NavigationPageStyle.Create());
        Add(TabbedPageStyle.Create());
    }

    public static Setter AppThemeSetter(BindableProperty property, Color lightColor, Color darkColor) =>
        new(){ Property = property, Value = AppThemeColorBindingBase(lightColor, darkColor) };

    private static BindingBase AppThemeColorBindingBase(Color lightColor, Color darkColor) =>
        new AppThemeColor { Light = lightColor, Dark = darkColor }.GetBinding();

    public static Setter SimpleSetter(BindableProperty property, object value) =>
        new() { Property = property, Value = value };
}
