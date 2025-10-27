using CommandPattern.Interfaces;
using System.Collections.Generic;

namespace CommandPattern.Classes.Commands
{
    internal class StereoCycleCommands : Command
    {
        Stereo stereo;
        string prevMode;
        int prevVolume;
        bool prevPowerState; // true = on, false = off
        Stack<(string mode, int volume, bool power)> history = new Stack<(string, int, bool)>();

        public StereoCycleCommands(Stereo stereo)
        {
            this.stereo = stereo;
        }

        public void Execute()
        {
            // store previous state before changing
            history.Push((prevMode, prevVolume, prevPowerState));

            if (prevMode == null)
            {
                stereo.On();
                stereo.SetCD();
                stereo.SetVolume(5);
                prevMode = "CD";
                prevVolume = 5;
                prevPowerState = true;
            }
            else if (prevMode == "CD")
            {
                stereo.SetDVD();
                prevMode = "DVD";
            }
            else if (prevMode == "DVD")
            {
                stereo.SetRadio();
                prevMode = "Radio";
            }
            else if (prevMode == "Radio")
            {
                stereo.Off();
                prevMode = null;
                prevPowerState = false;
            }
        }

        public void Undo()
        {
            if (history.Count > 0)
            {
                var (mode, volume, power) = history.Pop();

                if (!power)
                {
                    stereo.Off();
                    prevMode = null;
                    prevPowerState = false;
                    return;
                }

                // only call On() if stereo was previously off
                if (!prevPowerState)
                {
                    stereo.On();
                }

                switch (mode)
                {
                    case "CD": stereo.SetCD(); break;
                    case "DVD": stereo.SetDVD(); break;
                    case "Radio": stereo.SetRadio(); break;
                }

                prevMode = mode;
                prevVolume = volume;
                prevPowerState = power;
            }
        }
    }
}
