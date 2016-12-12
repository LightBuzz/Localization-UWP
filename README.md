# Explicit Localization in UWP
Learn how to localize your Universal Windows app by selecting the language programmatically.

![Localization iOS by LightBuzz](http://lightbuzz.com/wp-content/uploads/2016/12/localization-ios.gif)

## Features

### Get the languages supported by the current app
    var supportedLanguages = LocalizedResources.SupportedLanguages;

### Set the language
    LocalizedResources.Language = "en-US";

### Localize content
    label.Text = LocalizedResources.GetString("label_text")
    picture.Source = LocalizedResources.GetString("image_name");

## Contributors
* [Vangos Pterneas](http://pterneas.com)
* [George Karakatsiotis](http://lightbuzz.com)

## License
Licensed under the [MIT License](https://github.com/LightBuzz/Localization-UWP/blob/master/LICENSE).
