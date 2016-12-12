using System;
using System.Linq;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace Localization_UWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            CbxLanguages.ItemsSource = LocalizedResources.SupportedLanguages;
            CbxLanguages.SelectedIndex = Array.IndexOf(LocalizedResources.SupportedLanguages.ToArray(), LocalizedResources.Language);
        }

        private void CbxLanguages_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CbxLanguages.SelectedItem != null)
            {
                var language = CbxLanguages.SelectedItem as string;

                LocalizedResources.Language = language;

                Frame.Navigate(Frame.CurrentSourcePageType);
                Frame.BackStack.Clear();
            }
        }
    }
}
