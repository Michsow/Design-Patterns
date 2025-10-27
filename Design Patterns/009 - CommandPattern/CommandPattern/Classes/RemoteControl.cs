using CommandPattern.Classes.Commands;
using CommandPattern.Interfaces;
using System.Text;
using System.Collections.Generic;

namespace CommandPattern.Classes
{
    internal class RemoteControl
    {
        Command[] onCommands = new Command[7];
        Command[] offCommands = new Command[7];
        Stack<Command> commandHistory = new Stack<Command>(); // store history of commands
        //stack is array that can only add or remove from the top (when i will be asked about it i will 100% forget how it works)
        public RemoteControl()
        {
            Command noCommand = new NoCommand();
            for (int i = 0; i < onCommands.Length; i++)
            {
                onCommands[i] = noCommand;
                offCommands[i] = noCommand;
            }
        }

        public void SetCommand(int slot, Command onCommand, Command offCommand)
        {
            onCommands[slot] = onCommand;
            offCommands[slot] = offCommand;
        }

        public void OnButtonWasPushed(int slot)
        {
            onCommands[slot].Execute();
            commandHistory.Push(onCommands[slot]); // add command to history
            // Push sends an item to the top of the stack
        }

        public void OffButtonWasPushed(int slot)
        {
            offCommands[slot].Execute();
            commandHistory.Push(offCommands[slot]); // add command to history
        }

        public void UndoButtonWasPushed()
        {
            if (commandHistory.Count > 0)
            {
                Command lastCommand = commandHistory.Pop(); // get last command
                lastCommand.Undo();
            }
            else
            {
                Console.WriteLine("No previous commands");
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\n----- Remote Control -----\n");
            for (int i = 0; i < onCommands.Length; i++)
            {
                sb.Append($"[slot {i}] {onCommands[i].GetType().Name,-35} {offCommands[i].GetType().Name}\n");
            }
            return sb.ToString();
        }
    }
}
