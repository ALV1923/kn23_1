using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuGProjektCYOA
{
    internal class AusweichenZwei
    {
        public static void Rakete()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(" /_/      __\r\n            \\ \\_____\r\n         ###[==_____>\r\n            /_/\r\n\r\n");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\nDoch plötzlich fliegt dir eine Rakete entgegen! Was willst du machen?\n's' zum Schießen\n'a' zum Ausweichen\n'i' für eine kurze Info");
            string auswahl2;
            Console.ForegroundColor = ConsoleColor.Green;
            auswahl2 = Console.ReadLine().ToLower();

            switch (auswahl2)
            {
                case "s":
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("Du feuerst auf die Rakete, die in tausende harmlose Splitter explodiert");
                        Console.WriteLine("Da du nicht weist wer diese Rakte abgefeuert hat und du nicht möchtest das noch mehr auf dich zufliegen, hast du dich entschieden einen Umweg zu nehmen um so viel Abstand wie möglich zwischen dir und den Asteroidenfeld zu haben.");
                        Console.WriteLine("\nDu bist der Gefahr entkommen.");
                        Spiel.Win();
                        break;
                    }
                case "a":
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("                             ____\r\n                     __,-~~/~    `---.\r\n                   _/_,---(      ,    )\r\n               __ /        <    /   )  \\___\r\n- ------===;;;'====------------------===;;;===----- -  -\r\n                  \\/  ~\"~\"~\"~\"~\"~\\~\"~)~\"/\r\n                  (_ (   \\  (     >    \\)\r\n                   \\_( _ <         >_>'\r\n                      ~ `-i' ::>|--\"");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("Du dachtest du könntest der Rakete mit einen Flugmanöver entkommen, leider war die Lenkrakete viel wendiger als du und erwischte dich.");
                        Console.WriteLine("Mit einen Feuerball endete damit dein kleines Abenteuer..");
                        Spiel.GameOver();
                        break;
                    }           
                case "i":
                    {
                        RaketeInfo.RInfo();
                        break;
                    }                                        
                default:
                    {
                        Console.WriteLine("Du überlegst fieberhaft wie du mit der Situation am besten umgehen sollst.");
                        Rakete();
                        break;
                    }
            }
        }
    }
}
