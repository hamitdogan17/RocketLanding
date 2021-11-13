using RocketLanding.Services;
using RocketLanding.Services.Contracts;
using System;

namespace RocketLanding
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ILandingControlService landing = new LandingControlService();
            ConsoleKeyInfo cki;
            Console.WriteLine("Press the Escape (Esc) key to quit: \n");
            do
            {
                cki = Console.ReadKey();
                Console.WriteLine("\nPress the Enter Continue:");
                string val;
                Console.Write("Enter X: ");
                val = Console.ReadLine();
                int x = Convert.ToInt32(val);
                Console.Write("Enter Y: ");
                val = Console.ReadLine();
                int y = Convert.ToInt32(val);

                var res = landing.LandingPlatformControl(landingPlatform, x, y);

                Console.WriteLine(res + " ( {0}, {1} )" , x, y);
                cki = Console.ReadKey();
            } while (cki.Key != ConsoleKey.Escape);

        }
        public static int[,] landingPlatform = new int[100, 100];
    }

}
