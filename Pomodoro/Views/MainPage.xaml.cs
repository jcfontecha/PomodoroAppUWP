using Windows.Foundation;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml.Controls;

namespace Pomodoro.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void TogglePaneButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            SplitView.IsPaneOpen = !SplitView.IsPaneOpen;
        }

        private void TimerButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            ContentFrame.Navigate(typeof(TimerPage));
            SplitView.IsPaneOpen = false;
        }

        private void LogButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            ContentFrame.Navigate(typeof(LogPage));
            SplitView.IsPaneOpen = false;
        }

        private void SettingsButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            ContentFrame.Navigate(typeof(SettingsPage));
            SplitView.IsPaneOpen = false;
        }
    }
}
