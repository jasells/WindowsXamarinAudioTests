using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace XamarinAudioTest.UWP
{
    public sealed partial class PlayerView : UserControl
    {
        public PlayerView()
        {
            this.InitializeComponent();

            var m = App.Player;

            myGrid.Children.Add(m);

            m.Source = new Uri("http://www.westhuntsville.org/Audio/Uploaded/TestFile.mp3");//new Uri("http://feedproxy.google.com/~r/WestHuntsville/feeds/current/~5/BXrnhyRj-c4/04032016-Sunday-AM.mp3"); //// new Uri("http://15133.live.streamtheworld.com:3690/WGOWAM_SC");

            m.Play();
        }
    }
}
