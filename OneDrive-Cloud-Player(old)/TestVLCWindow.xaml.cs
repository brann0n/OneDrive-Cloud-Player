﻿using OneDrive_Cloud_Player.VLC;
using MahApps.Metro.Controls;
using System.Windows;

namespace OneDrive_Cloud_Player
{
    /// <summary>
    /// Interaction logic for TestVLCWindow.xaml
    /// </summary>
    public partial class TestVLCWindow : MetroWindow
    {
        public TestVLCWindow()
        {
            InitializeComponent();
        }

        //For testing purposes only.
        private void OpenVideoWindow_Click(object sender, RoutedEventArgs e)
        {
            VideoPlayerWindow win2 = new VideoPlayerWindow("b!MFdcYTQb50KRsCG7n7NTZLiOhD1-AB1Kj2aUdVa53fBBD1J-dnclTaEaS6tBko9-", "01V3DWMJRTSJ5JRUTZURFKAGZJ6C5BAOYD");
            win2.Show();
        }
    }
}