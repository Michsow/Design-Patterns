using CommandPattern.Classes;
using CommandPattern.Interfaces;


namespace CommandPattern.Classes.Commands
{
    internal class CeilingFanCycleCommand : Command
    {
        CeilingFan ceilingFan;
        int prevSpeed;
        Stack<int> speedHistory = new Stack<int>();

        public CeilingFanCycleCommand(CeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }

        public void Execute()
        {
            speedHistory.Push(ceilingFan.GetSpeed());
            prevSpeed = ceilingFan.GetSpeed();
            switch (ceilingFan.GetSpeed())
            {
                case var _ when ceilingFan.GetSpeed() == ceilingFan.OFF:
                    ceilingFan.Low();
                    break;
                case var _ when ceilingFan.GetSpeed() == ceilingFan.LOW:
                    ceilingFan.Medium();
                    break;
                case var _ when ceilingFan.GetSpeed() == ceilingFan.MEDIUM:
                    ceilingFan.High();
                    break;
                case var _ when ceilingFan.GetSpeed() == ceilingFan.HIGH:
                    ceilingFan.Off();
                    break;
            }

        }

        public void Undo()
        {
            if (speedHistory.Count > 0)
            {
                int lastSpeed = speedHistory.Pop();
                switch (lastSpeed)
                {
                    case var _ when lastSpeed == ceilingFan.OFF: ceilingFan.Off(); break;
                    case var _ when lastSpeed == ceilingFan.LOW: ceilingFan.Low(); break;
                    case var _ when lastSpeed == ceilingFan.MEDIUM: ceilingFan.Medium(); break;
                    case var _ when lastSpeed == ceilingFan.HIGH: ceilingFan.High(); break;
                }
            }
        }
    }
}