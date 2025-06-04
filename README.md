# Maui Markup App

MauiMarkupApp is a cross-platform .NET MAUI application that demonstrates the use of CommunityToolkit.Maui.Markup for building UIs in C# using fluent markup extensions. The project targets Android, iOS, Mac Catalyst, and Windows platforms.

## Features
- **.NET MAUI**: Utilizes the latest .NET 9 MAUI framework for multi-platform support.
- **CommunityToolkit.Maui.Markup**: Enables concise, maintainable, and type-safe UI construction in C# using fluent extension methods.
- **Fluent Styles**: All styles are defined using CommunityToolkit.Maui.Markup fluent extension methods for consistency and maintainability.
- **Visual States**: Uses `AddVisualStateGroupList` extension for clear and reusable visual state management in styles.
- **MVVM Pattern**: Implements the Model-View-ViewModel pattern for separation of concerns.
- **Custom Styles**: Centralized styling for controls (e.g., labels, buttons, frames) using static style classes.
- **Accessibility**: Semantic properties are set for improved accessibility.

## Project Structure
- `Views/`: Contains UI pages, such as `MainPage`, built with markup extensions.
- `ViewModels/`: Contains view models for MVVM binding.
- `Resources/Styles/`: Contains reusable style definitions for various controls, all using fluent markup and visual state extensions.
- `Platforms/`: Platform-specific entry points and configuration.
- `MauiProgram.cs`: App startup and dependency injection configuration.

## MainPage Example
- Displays an image, styled labels, and a button.
- Button click updates a counter and announces the new value for accessibility.
- Styles and colors are applied using centralized dictionaries and fluent markup extensions.

## Dependencies
- [CommunityToolkit.Maui](https://learn.microsoft.com/en-us/dotnet/communitytoolkit/maui/overview)
- [CommunityToolkit.Maui.Markup](https://github.com/CommunityToolkit/Maui.Markup)
- [CommunityToolkit.Mvvm](https://learn.microsoft.com/en-us/dotnet/communitytoolkit/mvvm/overview)
- [Microsoft.Maui.Controls](https://learn.microsoft.com/en-us/dotnet/maui/what-is-maui)

## Getting Started
1. **Clone the repository**
2. **Open in Visual Studio 2022+** with .NET 9 and MAUI workloads installed.
3. **Restore NuGet packages**
4. **Build and run** on your preferred platform (Android, iOS, Mac Catalyst, or Windows).

## Notes
- The project uses C# 13 and targets .NET 9.
- Some style classes (e.g., `FrameStyle`) are marked as obsolete and may be removed in future releases.
- All styles use fluent markup and visual state extensions for maintainability.

---
This project is a template for building modern, maintainable, and accessible .NET MAUI applications using C# markup and fluent style extensions.