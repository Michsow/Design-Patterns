using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    internal class DvdPlayer
    {
        private Amplifier _amplifier;
        public DvdPlayer(Amplifier amplifier)
        {
            _amplifier = amplifier;
        }

        public void On()
        {

        }
        public void Off()
        {

        }
        public void Eject()
        {

        }
        public void Pause()
        {

        }
        public void Play(string movie)
        {

        }
        public void SetSurroundAudio()
        {

        }
        public void SetTWoChannelAudio()
        {

        }
        public void Stop()
        {

        }
    }
}
