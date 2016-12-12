using System.Collections.Generic;
using Windows.ApplicationModel.Resources;
using Windows.ApplicationModel.Resources.Core;
using Windows.Globalization;

namespace Localization_UWP
{
    /// <summary>
    /// Provides an easy-to-use interface for localizing a UWP app.
    /// </summary>
    public static class LocalizedResources
    {
        private static ResourceLoader _resourceLoader = new ResourceLoader();
        private static string _language = "en-US";

        /// <summary>
        /// A list of the supported application languages.
        /// </summary>
        public static IReadOnlyList<string> SupportedLanguages
        {
            get
            {
                return ApplicationLanguages.ManifestLanguages;
            }
        }

        /// <summary>
        /// Sets the language of the app.
        /// </summary>
        public static string Language
        {
            get
            {
                return _language;
            }
            set
            {
                _language = value;

                ApplicationLanguages.PrimaryLanguageOverride = _language;

                ResourceContext.GetForViewIndependentUse().Reset();
                ResourceContext.GetForCurrentView().Reset();
            }
        }

        /// <summary>
        /// Returns the localized value of the specified key.
        /// </summary>
        /// <param name="key">The resource identifier.</param>
        /// <returns>The appropriate string value of the localized resources.</returns>
        public static string GetString(string key)
        {
            return _resourceLoader.GetString(key);
        }
    }
}
