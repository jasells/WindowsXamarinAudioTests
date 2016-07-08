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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Win8U
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            mediaElement.Source = new Uri("http://www.westhuntsville.org/Audio/Uploaded/TestFile.mp3");//new Uri("http://feedproxy.google.com/~r/WestHuntsville/feeds/current/~5/BXrnhyRj-c4/04032016-Sunday-AM.mp3"); //// new Uri("http://15133.live.streamtheworld.com:3690/WGOWAM_SC");

            mediaElement.Play();
        }
    }
}
