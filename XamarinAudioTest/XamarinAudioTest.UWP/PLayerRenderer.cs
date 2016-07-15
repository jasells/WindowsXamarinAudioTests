using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.Platform.UWP;

[assembly: ExportRenderer(typeof(XamarinAudioTest.XPlayView), typeof(XamarinAudioTest.UWP.PlayerRenderer))]

namespace XamarinAudioTest.UWP
{
    public class PlayerRenderer: ViewRenderer<XamarinAudioTest.XPlayView, PlayerView>
    {
        protected override void OnElementChanged(ElementChangedEventArgs<XPlayView> e)
        {
            base.OnElementChanged(e);

            if(e.OldElement == null)//first run, no previous native view(element)
            {
                this.SetNativeControl(new PlayerView());
            }
        }
    }
}