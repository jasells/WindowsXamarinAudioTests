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

            //MediaElement will silently fail if not added to the visual tree. 
            myGrid.Children.Add(m);

            //"https://1drv.ms/u/s!AkJlaLtUNZiig80Hiocg0xFEBQGtQg");//
            m.Source = new Uri("http://www.westhuntsville.org/Audio/Uploaded/TestFile.mp3");

            m.Play();
        }
    }
}
