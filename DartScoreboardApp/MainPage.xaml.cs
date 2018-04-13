using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;


namespace DartScoreboardApp
{
  
    public sealed partial class MainPage : Page
    {
        public Library lib = new Library();


        public MainPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            SetBackGroundTitleBar();
        }

        private void SetBackGroundTitleBar()
        {
            var appView = Windows.UI.ViewManagement.ApplicationView.GetForCurrentView();
            var titleBar = appView.TitleBar;
            titleBar.BackgroundColor = Colors.DarkSlateGray;
            titleBar.ForegroundColor = Colors.White;
            titleBar.ButtonBackgroundColor = Colors.DarkSlateGray;
            titleBar.ButtonForegroundColor = Colors.White;
        }

        private void btnShowPane_Click(object sender, RoutedEventArgs e)
        {
            // MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;

            if (MySplitView.IsPaneOpen == false)
            {
                MySplitView.IsPaneOpen = true;
                btnShowPane.Content = "\uE00F";
            }

            else
            {
                MySplitView.IsPaneOpen = false;
                btnShowPane.Content = "\uE00F";
            }

        }

        private void New_Click(object sender, RoutedEventArgs e)
        {
            lib.New(StartDate, StartTime, Subject, Location, Details, Duration, AllDay);
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            lib.Add(sender, StartDate, StartTime, Subject, Location, Details, Duration, AllDay);
        }

        private void Calendar_Click(object sender, RoutedEventArgs e)
        {
            lib.Calendar(StartDate, StartTime);
        }

        public void btnScorePane_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(ScorePage));
        }


    }
}
