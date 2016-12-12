# Explicit Localization in UWP
Learn how to localize your Universal Windows app by selecting the language programmatically.

![Localization UWP by LightBuzz](http://lightbuzz.com/wp-content/uploads/2016/12/localization-uwp.gif)

## Features

### Get the languages supported by the current app
    var supportedLanguages = LocalizedResources.SupportedLanguages;

### Set the language
    LocalizedResources.Language = "en-US";

### Localize content in C#
    TblTitle.Text = LocalizedResources.GetString("Title/Text");

### Localize content in XAML
    <TextBlock x:Uid="Title" x:Name="TblTitle" Text="Title" />

## Contributors
* [Vangos Pterneas](http://pterneas.com)
* [George Karakatsiotis](http://lightbuzz.com)

## License
Licensed under the [MIT License](https://github.com/LightBuzz/Localization-UWP/blob/master/LICENSE).
