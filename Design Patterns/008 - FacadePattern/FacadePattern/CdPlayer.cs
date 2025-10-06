using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    internal class CdPlayer
    {
        private Amplifier _amplifier;
        public CdPlayer(Amplifier amplifier)
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
        public void Play()
        {

        }
        public void Stop()
        {

        }
    }
}
