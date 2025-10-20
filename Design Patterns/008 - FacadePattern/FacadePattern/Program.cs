namespace FacadePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Amplifier amp = new Amplifier();
            CdPlayer cdPlayer = new CdPlayer(amp);
            DvdPlayer dvdPlayer = new DvdPlayer(amp);
            PopcornPopper popcornPopper = new PopcornPopper();
            Projector projector = new Projector();
            Screen screen = new Screen();
            TheaterLights lights = new TheaterLights();
            Tuner tuner = new Tuner(amp);


            //Create the facade and inject all subsystems
            HomeTheaterFacade homeTheater = new HomeTheaterFacade(
                amp, tuner, dvdPlayer, cdPlayer, projector, lights, screen, popcornPopper);

            //Use the simplified interface
            Console.WriteLine("\nStarting the movie \n");
            homeTheater.WatchMovie("Shrek☺");

            Console.WriteLine("\nEnding the movie \n");
            homeTheater.EndMovie();
        }
    }
}
