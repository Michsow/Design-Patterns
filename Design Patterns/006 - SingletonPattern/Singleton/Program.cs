namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ChocolateBoiler boiler = ChocolateBoiler.getInstance();
            ChocolateBoiler boiler2 = ChocolateBoiler.getInstance();

            boiler.fill();
            boiler.boil();
            boiler.drain();

            Console.WriteLine(Object.ReferenceEquals(boiler, boiler2));
        }
    }
}