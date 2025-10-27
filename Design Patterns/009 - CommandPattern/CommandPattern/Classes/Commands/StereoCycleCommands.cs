using CommandPattern.Classes;
using CommandPattern.Interfaces;
using System.Collections.Generic;

namespace CommandPattern.Classes.Commands
{
    internal class StereoCycleCommand : Command
    {
        private Stereo stereo;
        private Stack<string> modeHistory = new Stack<string>();

        public StereoCycleCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }

        public void Execute()
        {
            // Save current mode for undo
            modeHistory.Push(GetCurrentMode());

            switch (GetCurrentMode())
            {
                case "CD":
                    stereo.SetDVD();
                    break;
                case "DVD":
                    stereo.SetRadio();
                    break;
                case "Radio":
                    stereo.Off();
                    break;
                case "Off":
                default:
                    stereo.On();
                    stereo.SetCD();
                    break;
            }
        }

        public void Undo()
        {
            if (modeHistory.Count > 0)
            {
                string lastMode = modeHistory.Pop();
                switch (lastMode)
                {
                    case "CD":
                        stereo.On();
                        stereo.SetCD();
                        break;
                    case "DVD":
                        stereo.On();
                        stereo.SetDVD();
                        break;
                    case "Radio":
                        stereo.On();
                        stereo.SetRadio();
                        break;
                    case "Off":
                        stereo.Off();
                        break;
                }
            }
        }

        private string GetCurrentMode()
        {
            // Peek the last mode in the history if available
            if (modeHistory.Count > 0)
                return modeHistory.Peek();

            // Default to "Off" if no history
            return "Off";
        }
    }
}
