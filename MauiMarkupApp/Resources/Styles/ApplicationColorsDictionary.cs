namespace MauiMarkupApp.Resources.Styles;

public partial class ApplicationColorsDictionary : ResourceDictionary
{
    public ApplicationColorsDictionary()
    {
        InitializeComponent();
    }
    
    private void InitializeComponent()
    {

        Add(nameof(Primary), Primary);
        Add(nameof(PrimaryDark), PrimaryDark);
        Add(nameof(PrimaryDarkText), PrimaryDarkText);
        Add(nameof(Secondary), Secondary);
        Add(nameof(SecondaryDarkText), SecondaryDarkText);
        Add(nameof(Tertiary), Tertiary);
        Add(nameof(White), White);
        Add(nameof(Black), Black);
        Add(nameof(Magenta), Magenta);
        Add(nameof(MidnightBlue), MidnightBlue);
        Add(nameof(OffBlack), OffBlack);
        Add(nameof(Gray100), Gray100);
        Add(nameof(Gray200), Gray200);
        Add(nameof(Gray300), Gray300);
        Add(nameof(Gray400), Gray400);
        Add(nameof(Gray500), Gray500);
        Add(nameof(Gray600), Gray600);
        Add(nameof(Gray900), Gray900);
        Add(nameof(Gray950), Gray950);

        Add(nameof(PrimaryBrush), PrimaryBrush);
        Add(nameof(SecondaryBrush), SecondaryBrush);
        Add(nameof(TertiaryBrush), TertiaryBrush);
        Add(nameof(WhiteBrush), WhiteBrush);
        Add(nameof(BlackBrush), BlackBrush);
        Add(nameof(Gray100Brush), Gray100Brush);
        Add(nameof(Gray200Brush), Gray200Brush);
        Add(nameof(Gray300Brush), Gray300Brush);
        Add(nameof(Gray400Brush), Gray400Brush);
        Add(nameof(Gray500Brush), Gray500Brush);
        Add(nameof(Gray600Brush), Gray600Brush);
        Add(nameof(Gray900Brush), Gray900Brush);
        Add(nameof(Gray950Brush), Gray950Brush);
    }
}