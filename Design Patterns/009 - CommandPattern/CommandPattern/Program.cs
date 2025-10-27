using CommandPattern.Classes;
using CommandPattern.Classes.Commands;
using CommandPattern.Interfaces;

namespace CommandPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RemoteControl remoteControl = new RemoteControl();

            /* Define and instantiate the following Vendor classes
             * Kitchen Light : Light
             * Livingroom Light : Light
             * Livingroom ceiling fan : CeilingFan
             * Garage door: Garagedoor
             * Stereo : Stereo
             */
            Light kitchenLight = new Light("Kitchen");
            Light livingRoomLight = new Light("Living Room");
            CeilingFan LivingroomFan = new CeilingFan("Living Roon Fan");
            GarageDoor garageDoor = new GarageDoor(new Light("garagedoor"));
            Stereo stereo = new Stereo();


            // Define and instantiate an Off and On command for each Vendor class
            remoteControl.SetCommand(1, new LightOnCommand(livingRoomLight), new LightOffCommand(livingRoomLight));
            remoteControl.SetCommand(2, new LightOnCommand(kitchenLight), new LightOffCommand(kitchenLight));
            remoteControl.SetCommand(3, new CeilingFanCycleCommand(LivingroomFan), new CeilingFanOffCommand(LivingroomFan));
            remoteControl.SetCommand(4, new GarageDoorUpCommand(garageDoor), new GarageDoorDownCommand(garageDoor));
            remoteControl.SetCommand(5, new StereoCycleCommands(stereo), new StereoOffCommand(stereo));



            /* Set the On and Off commands to the appropriate slot:
             * 
             * 1: Living Room light
             * 2: Kitchen light
             * 3: Livingroom ceiling fan
             * 4: Garage door
             * 5: Stereo
             */


            Console.WriteLine(remoteControl);

            // Test the pressing of Buttons here. Don't forget to test the Undo button
            remoteControl.OnButtonWasPushed(1);
            remoteControl.OffButtonWasPushed(1);

            remoteControl.OnButtonWasPushed(2);
            remoteControl.OffButtonWasPushed(2);

            remoteControl.OnButtonWasPushed(3);
            remoteControl.OffButtonWasPushed(3);

            remoteControl.OnButtonWasPushed(4);
            remoteControl.OffButtonWasPushed(4);

            remoteControl.OnButtonWasPushed(5);
            remoteControl.OffButtonWasPushed(5);

            remoteControl.OnButtonWasPushed(2);
            remoteControl.UndoButtonWasPushed();

            remoteControl.OnButtonWasPushed(3);
            remoteControl.OnButtonWasPushed(3);
            remoteControl.OnButtonWasPushed(3);
            remoteControl.UndoButtonWasPushed();
            remoteControl.UndoButtonWasPushed();
            remoteControl.UndoButtonWasPushed();
            remoteControl.UndoButtonWasPushed();
            remoteControl.UndoButtonWasPushed();
            remoteControl.UndoButtonWasPushed();
            remoteControl.UndoButtonWasPushed();
            remoteControl.UndoButtonWasPushed();
            remoteControl.UndoButtonWasPushed();
            remoteControl.UndoButtonWasPushed();
            remoteControl.UndoButtonWasPushed();
            remoteControl.UndoButtonWasPushed();
            remoteControl.UndoButtonWasPushed();
            remoteControl.UndoButtonWasPushed();
            remoteControl.UndoButtonWasPushed();
            remoteControl.UndoButtonWasPushed();
            remoteControl.UndoButtonWasPushed();
            remoteControl.UndoButtonWasPushed();
            remoteControl.UndoButtonWasPushed();
            remoteControl.UndoButtonWasPushed();
            remoteControl.UndoButtonWasPushed();

            remoteControl.OnButtonWasPushed(5);
            remoteControl.OnButtonWasPushed(5);
        }
    }
}