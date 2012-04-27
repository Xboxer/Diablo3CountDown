using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Threading;
using Microsoft.Phone.Controls;

namespace Diablo3_Countdown

    
{
    public partial class MainPage : PhoneApplicationPage
    {
        private DispatcherTimer timer;
        // Konstruktor
        public MainPage()
        {
            InitializeComponent();
        }

        private void Countdown_Loaded(object sender, RoutedEventArgs e)
        {
            timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(1)
            };

            timer.Tick += OnTick;

            timer.Start();
        }
        private void OnTick(object sender, EventArgs e)
        {
            var launch = new DateTime(2012, 05, 15);
            var timeLeft = launch - DateTime.Now;
            if (DateTime.Now >= launch)
            {
                textBlock1.Text = "";
                textBlock2.Text = "";
                textBlock3.Text = "";
                textBlock4.Text = "";
                textblockRelease.Text = "";
                Countdown.Height = 70;
                Countdown.FontSize = 34;
                Countdown.Text = "Diablo 3 is released";
            }
            else
            {
                Countdown.Text = string.Format("{0:D2}:{1:D2}:{2:D2}:{3:D2}", timeLeft.Days, timeLeft.Hours, timeLeft.Minutes, timeLeft.Seconds);
            }
        }
    }
}