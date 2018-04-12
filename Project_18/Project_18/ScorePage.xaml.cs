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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Project_18
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ScorePage : Page
    {
        public ScorePage()
        {
            this.InitializeComponent();

            setupTextBlockManipulation();
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
            titleBar.ForegroundColor = Colors.GreenYellow;
            titleBar.ButtonBackgroundColor = Colors.DarkSlateGray;
            titleBar.ButtonForegroundColor = Colors.Red;
        }

        public void btnBack_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
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

        int _yStart, _yFinish;

    
        private void setupTextBlockManipulation()
        {
            player1_sets.ManipulationMode = ManipulationModes.TranslateX | ManipulationModes.TranslateY;
            player1_sets.ManipulationStarted += (s, e) => _yStart = (int)e.Position.Y;
            player1_sets.ManipulationCompleted += (s, e) =>
            {
                _yFinish = (int)e.Position.Y;
                if (_yStart < _yFinish)
                {
                    decreaseValue(((TextBlock)s));
                };
            };

            player2_sets.ManipulationMode = ManipulationModes.TranslateX | ManipulationModes.TranslateY;
            player2_sets.ManipulationStarted += (s, e) => _yStart = (int)e.Position.Y;
            player2_sets.ManipulationCompleted += (s, e) =>
            {
                _yFinish = (int)e.Position.Y;
                if (_yStart < _yFinish)
                {
                    decreaseValue(((TextBlock)s));
                };
            };

            player1_legs.ManipulationMode = ManipulationModes.TranslateX | ManipulationModes.TranslateY;
            player1_legs.ManipulationStarted += (s, e) => _yStart = (int)e.Position.Y;
            player1_legs.ManipulationCompleted += (s, e) =>
            {
                _yFinish = (int)e.Position.Y;
                if (_yStart < _yFinish)
                {
                    decreaseValue(((TextBlock)s));
                };
            };

            player2_legs.ManipulationMode = ManipulationModes.TranslateX | ManipulationModes.TranslateY;
            player2_legs.ManipulationStarted += (s, e) => _yStart = (int)e.Position.Y;
            player2_legs.ManipulationCompleted += (s, e) =>
            {
                _yFinish = (int)e.Position.Y;
                if (_yStart < _yFinish)
                {
                    decreaseValue(((TextBlock)s));
                };
            };
        }





        private void textBlock_Tapped(object sender, TappedRoutedEventArgs e)
        {
            increaseValue((TextBlock)sender);
        }


        void increaseValue(TextBlock scoreLbl)
        {
            int newValue = Convert.ToInt32(scoreLbl.Text) + 1;

            scoreLbl.Text = newValue.ToString();

        }


        void decreaseValue(TextBlock scoreLbl)
        {
            if (Convert.ToInt32(scoreLbl.Text) <= 0)
            {
                return;
            }

            int newValue = Convert.ToInt32(scoreLbl.Text) - 1;

            scoreLbl.Text = newValue.ToString();

        }
    }


}

