using CommunityToolkit.Maui.Markup;
using MauiMarkupApp.Resources.Styles;

namespace MauiMarkupApp;

public partial class MainPage : ContentPage
{
    private int count = 0;
    
    public MainPage()
    {

        Content = new ScrollView 
        { 
            Content = new VerticalStackLayout
            {
                Padding = new Thickness(30, 0),
                Spacing = 25,
                Children =
                {
                    new Image()
                        .Source("dotnet_bot.png")
                        .Aspect(Aspect.AspectFit)
                        .Height(185)
                        .SemanticDescription("dot net bot in a hovercraft number nine"),
                    
                    new Label()
                        .Text( "Hello, World!")
                        .Style(HeadlineStyle.Create())
                        .SemanticHeadingLevel(SemanticHeadingLevel.Level1),

                    new Label()
                        .Text("Welcome to \n.NET Multi-platform App UI")
                        .Style(SubHeadlineStyle.Create())
                        .SemanticHeadingLevel(SemanticHeadingLevel.Level2)
                        .SemanticDescription("Welcome to dot net Multi platform App U I"),

                    new Button()
                        .Text("Click me")
                        .FillHorizontal()
                        .SemanticHint("Counts the number of times you click")
                        .Invoke( btn => btn.Clicked += (sender, e) => OnCounterClicked(sender, e))
                }
            }
        };
    }

    private void OnCounterClicked(object? sender, EventArgs e)
    {
        if( sender is not Button button)
            return;

        count++;
        button.Text = $"Clicked {count} time{(count == 1? string.Empty:"s")}";
        SemanticScreenReader.Announce(button.Text);
    }
}
