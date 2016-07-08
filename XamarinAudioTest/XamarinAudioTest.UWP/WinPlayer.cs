using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: Xamarin.Forms.Dependency(typeof(XamarinAudioTest.UWP.WinPlayer))]


namespace XamarinAudioTest.UWP
{
    public class WinPlayer : IAudioPlayer
    {
        public void PlayStream(Uri link)
        {
            App.Player.Source = link;
            App.Player.Play();
        }
    }
}