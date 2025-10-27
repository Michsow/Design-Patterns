using CommandPattern.Classes;
using CommandPattern.Interfaces;
using System.Collections.Generic;

namespace CommandPattern.Classes.Commands
{
    internal class StereoCycleCommands : Command
    {

        Stereo stereo;
        string prevMode;
        int prevVolume;
        Stack<(string, int)> history = new Stack<(string, int)>();
        public StereoCycleCommands(Stereo stereo)
        {
            this.stereo = stereo;
        }
        public void Execute()
        {
            history.Push((prevMode, prevVolume));
            if (prevMode == null)
            {
                stereo.On();
                stereo.SetCD();
                stereo.SetVolume(5);
                prevMode = "CD";
                prevVolume = 5;
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
            }
        }
        public void Undo()
        {
            if (history.Count > 0)
            {
                var (mode, volume) = history.Pop();
                if (mode == null)
                {
                    stereo.Off();
                }
                else
                {
                    stereo.On();
                    switch (mode)
                    {
                        case "CD":
                            stereo.SetCD();
                            break;
                        case "DVD":
                            stereo.SetDVD();
                            break;
                        case "Radio":
                            stereo.SetRadio();
                            break;
                    }
                    stereo.SetVolume(volume);
                }
                prevMode = mode;
                prevVolume = volume;
            }
        }
    }
}