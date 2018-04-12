using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Project_18
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
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

        private void New_Click (object sender, RoutedEventArgs e)
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
