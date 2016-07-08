using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinAudioTest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            DependencyService.Get<IAudioPlayer>()
                .PlayStream(new Uri("http://www.westhuntsville.org/Audio/Uploaded/TestFile.mp3"));
        }
    }
}
