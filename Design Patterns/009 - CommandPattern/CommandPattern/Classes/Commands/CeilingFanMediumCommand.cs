using CommandPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Classes.Commands
{
    internal class CeilingFanMediumCommand : Command
    {
        CeilingFan ceilingFan;
        int prevSpeed;
        public CeilingFanMediumCommand(CeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }

        public void Execute()
        {
            prevSpeed = ceilingFan.GetSpeed();
            ceilingFan.Medium();
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
        }
    }
}
