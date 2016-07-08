using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinAudioTest
{
    public interface IAudioPlayer
    {
        void PlayStream(Uri link);
    }
}
