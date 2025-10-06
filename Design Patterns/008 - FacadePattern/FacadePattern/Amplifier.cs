using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    internal class Amplifier
    {
        private Tuner _tuner;
        private DvdPlayer _dvdPlayer;
        private CdPlayer _cdPlayer;

        public void On()
        {

        }

        public void Off()
        {

        }
        public void SetCd(CdPlayer cdPlayer)
        {
            this._cdPlayer = cdPlayer;
        }
        public void SetDvd(DvdPlayer dvdPlayer)
        {
            this._dvdPlayer = dvdPlayer;
        }
        public void SetStereoSound()
        {

        }
        public void SetSurroundSound()
        {

        }
        public void SetTuner(Tuner tuner)
        {
            this._tuner = tuner;
        }
        public void SetVolume(int volume)
        {

        }

    }
}
