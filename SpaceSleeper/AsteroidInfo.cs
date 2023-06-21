using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuGProjektCYOA
{
    internal class AsteroidInfo
    {
        public static void AInfo()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\nDu scannst den riesigen Asteroiden der auf dich zufliegt");
            Thread.Sleep(500);
            Console.WriteLine("\nDer Asteroid besteht aus:\n70% Regolith\n25% Eis\n5% Metall");
            Console.WriteLine("\nFür dich von Interesse sind nur zwei Fakten\n1. Mit deiner Bewaffnung wirst du den Felsen nicht kleinschießen können\n2. Es währe sehr leicht den Asteroiden auszuweichen");
            Console.WriteLine("\nDrücke 'Enter' um das Infomenü zu schließen.");
            Console.ReadLine();
            Console.Clear();
            Ausweichen.Zwei();
        }
    }
}
