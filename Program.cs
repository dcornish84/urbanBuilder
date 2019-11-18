using System;
using System.Collections.Generic;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            // City MeowMeowTropolis = new City();
            Building Leeloo = new Building("123 Sandpit Ave")
            {
                Width = 6000,
                Height = 10_000,
                Stories = 12,
                Depth = 200
            };

            Building Ludo = new Building("125 Sandpit Ave")
            {
                Width = 7000,
                Height = 11_000,
                Stories = 13,
                Depth = 400
            };

            Building Elmer = new Building("127 Sandpit Ave")
            {
                Width = 8000,
                Height = 12_000,
                Stories = 14,
                Depth = 500
            };

            Building Soleil = new Building("129 Sandpit Ave")
            {
                Width = 9000,
                Height = 13_000,
                Stories = 15,
                Depth = 600
            };

            Leeloo.Purchase("Heidi");
            Ludo.Purchase("Seth");
            Elmer.Purchase("Fortunato");
            Soleil.Purchase("Phil");

            Console.WriteLine(Leeloo.Description);
            Console.WriteLine(Ludo.Description);
            Console.WriteLine(Elmer.Description);
            Console.WriteLine(Soleil.Description);

        }
    }
}