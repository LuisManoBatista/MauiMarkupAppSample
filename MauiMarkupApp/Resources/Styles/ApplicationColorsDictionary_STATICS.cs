
namespace MauiMarkupApp.Resources.Styles;

public partial class ApplicationColorsDictionary
{
    public static Color Primary => Color.FromArgb("#512BD4");
    public static Color PrimaryDark => Color.FromArgb("#AC99EA");
    public static Color PrimaryDarkText => Color.FromArgb("#242424");
    public static Color Secondary => Color.FromArgb("#DFD8F7");
    public static Color SecondaryDarkText => Color.FromArgb("#9880E5");
    public static Color Tertiary => Color.FromArgb("#2B0B98");

    public static Color White => Color.FromArgb("#FFFFFFFF");
    public static Color Black => Color.FromArgb("#FF000000");
    public static Color Magenta => Color.FromArgb("#D600AA");
    public static Color MidnightBlue => Color.FromArgb("#190649");
    public static Color OffBlack => Color.FromArgb("#1F1F1F");

    public static Color Gray100 => Color.FromArgb("#E1E1E1");
    public static Color Gray200 => Color.FromArgb("#C8C8C8");
    public static Color Gray300 => Color.FromArgb("#ACACAC");
    public static Color Gray400 => Color.FromArgb("#919191");
    public static Color Gray500 => Color.FromArgb("#6E6E6E");
    public static Color Gray600 => Color.FromArgb("#404040");
    public static Color Gray900 => Color.FromArgb("#212121");
    public static Color Gray950 => Color.FromArgb("#141414");
    public static Color Transparent => Color.FromArgb("#00000000");

    public static SolidColorBrush PrimaryBrush => new(Primary);
    public static SolidColorBrush SecondaryBrush => new(Secondary);
    public static SolidColorBrush TertiaryBrush => new(Tertiary);
    public static SolidColorBrush WhiteBrush => new(White);
    public static SolidColorBrush BlackBrush => new(Black);
    public static SolidColorBrush Gray100Brush => new(Gray100);
    public static SolidColorBrush Gray200Brush => new(Gray200);
    public static SolidColorBrush Gray300Brush => new(Gray300);
    public static SolidColorBrush Gray400Brush => new(Gray400);
    public static SolidColorBrush Gray500Brush => new(Gray500);
    public static SolidColorBrush Gray600Brush => new(Gray600);
    public static SolidColorBrush Gray900Brush => new(Gray900);
    public static SolidColorBrush Gray950Brush => new(Gray950);

}
