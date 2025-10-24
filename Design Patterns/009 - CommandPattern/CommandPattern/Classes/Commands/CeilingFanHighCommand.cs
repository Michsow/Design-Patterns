using CommandPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Classes.Commands
{
    internal class CeilingFanHighCommand : Command
    {
        CeilingFan ceilingFan;
        int prevSpeed;
        public CeilingFanHighCommand(CeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }

        public void Execute()
        {
            prevSpeed = ceilingFan.GetSpeed();
            if (prevSpeed == ceilingFan.HIGH)
            {
                ceilingFan.Low();
            }
            else if (prevSpeed == ceilingFan.MEDIUM)
            {
                ceilingFan.High();
            }
            else if (prevSpeed == ceilingFan.LOW)
            {
                ceilingFan.Medium();
            }
        }
        

        public void Undo()
        {
            if (prevSpeed == ceilingFan.HIGH)
            {
                ceilingFan.High();
            }
            else if (prevSpeed == ceilingFan.MEDIUM)
            {
                ceilingFan.Medium();
            }
            else if (prevSpeed == ceilingFan.LOW)
            {
                ceilingFan.Low();
            }
            else if (prevSpeed == ceilingFan.OFF)
            {
                ceilingFan.Off();
            }
        }
    }
}
