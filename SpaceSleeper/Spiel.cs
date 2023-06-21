using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuGProjektCYOA
{
    internal class Spiel
    {
        public static void Start()
        {
            Console.Clear();        
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(" __                            __  _                                \r\n/ _\\ _ __    __ _   ___  ___  / _\\| |  ___   ___  _ __    ___  _ __ \r\n\\ \\ | '_ \\  / _` | / __|/ _ \\ \\ \\ | | / _ \\ / _ \\| '_ \\  / _ \\| '__|\r\n_\\ \\| |_) || (_| || (__|  __/ _\\ \\| ||  __/|  __/| |_) ||  __/| |   \r\n\\__/| .__/  \\__,_| \\___|\\___| \\__/|_| \\___| \\___|| .__/  \\___||_|   \r\n    |_|                                          |_|                ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\nWillkommen in Space Sleeper!");            
            Console.WriteLine("\nDrücke 'Enter' um mit den Spiel anzufangen!");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\n\n\nCredits gehen an:\nASCII-Art https://ascii.co.uk/art und https://www.asciiart.eu/\nASCII Schrift https://textkool.com/en\n\nEs ist eventuell notwendig die Konsole auf Vollbild zu stellen.");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Es ist das Jahr 2XXX");
            Console.WriteLine("\nMehrere Lichtjahre von Planet Erde entfernt, wurde eine erbitterte Schlacht im Weltraum ausgetragen.");
            Console.WriteLine("Wer aber teilgenommen hat und wer als Sieger hervor kahm lässt sich nicht erkennen..");
            Console.WriteLine("Die einzigen Zeugen dieser Schlacht waren die beschädigten Raumschiffe, die jetzt als Wracks leblos im All drifteten.");  
            Console.WriteLine("Doch plötzlich explodierte ein nahegelegender Stern und setzte eine Menge Energie frei.");
            Console.WriteLine("Vielleicht wurde der Generator durch den plötzlichen Energieschub reaktiviert, oder vielleicht war es auch nur ein Zufall.");
            Console.WriteLine("Aber in einem dieser Wracks flackern Lichter auf");
            Console.WriteLine("Der Name dieses Schiffs lautet:");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("     .  . '    .\r\n      '   .            . '            .                +\r\n              `                          '    . '\r\n        .                         ,'`.                         .\r\n   .                  ..\"    _.-;'    `.              .\r\n              _.-\"`.##%\"_.--\" ,'        `.           \"#\"     ___,,od000\r\n           ,'\"-_ _.-.--\"\\   ,'            `-_       '%#%',,/////00000HH\r\n         ,'     |_.'     )`/-     __..--\"\"`-_`-._    J L/////00000HHHHM\r\n . +   ,'   _.-\"        / /   _-\"\"           `-._`-_/___\\///0000HHHHMMM\r\n     .'_.-\"\"      '    :_/_.-'                 _,`-/__V__\\0000HHHHHMMMM\r\n . _-\"\"                         .        '   _,////\\  |  /000HHHHHMMMMM\r\n_-\"   .       '  +  .              .        ,//////0\\ | /00HHHHHHHMMMMM\r\n       `                                   ,//////000\\|/00HHHHHHHMMMMMM\r\n.             '       .  ' .   .       '  ,//////00000|00HHHHHHHHMMMMMM\r\n     .             .    .    '           ,//////000000|00HHHHHHHMMMMMMM\r\n                  .  '      .       .   ,///////000000|0HHHHHHHHMMMMMMM\r\n  '             '        .    '         ///////000000000HHHHHHHHMMMMMMM\r\n                    +  .  . '    .     ,///////000000000HHHHHHHMMMMMMMM\r\n     '      .              '   .       ///////000000000HHHHHHHHMMMMMMMM\r\n   '                  . '              ///////000000000HHHHHHHHMMMMMMMM\r\n                           .   '      ,///////000000000HHHHHHHHMMMMMMMM\r\n       +         .        '   .    .  ////////000000000HHHHHHHHMMMMMMhs");

            Console.ForegroundColor = ConsoleColor.Green;
            string schiffName = Console.ReadLine();
            while (schiffName == "")
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Es muss einen Namen haben oder zumindest eine Alphanumerische Identifikationsnummer..Schiffe ohne Namen bringen Unglück.");
                Console.ForegroundColor = ConsoleColor.Green;
                schiffName = Console.ReadLine();
            }
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Clear();
            Console.WriteLine($"Knisternd erweckt die {schiffName} zum Leben.");
            Console.WriteLine("\nNEUSTART");
            Thread.Sleep(500);
            Console.WriteLine("LADE KI");
            Thread.Sleep(500);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("FEHLER in SEKTOR e523");
            Console.WriteLine("DATEI g315 korrupiieeeerrrrrrrrrr...t");
            Thread.Sleep(2000);
            Console.WriteLine("LADEN FEHLGESCHLAGEN");
            Thread.Sleep(500);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("LADE SICHERUNGSKOPIE");
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("LADEN ERFOLGREICH");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\nNach und nach fährt die künstliche Intelligenz, die das Schiff steuert, alle Systeme hoch.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nTRIEBWERKE:");
            Console.ForegroundColor = ConsoleColor.Green;
            Thread.Sleep(500);
            Console.WriteLine("Online");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("REAKTOR:");
            Console.ForegroundColor = ConsoleColor.Green;
            Thread.Sleep(500);
            Console.WriteLine("Online");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("DATENBANK:");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Thread.Sleep(1000);
            Console.WriteLine("Fehlerhaft");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("KURZSTRECKENSENSOR:");
            Console.ForegroundColor = ConsoleColor.Green;
            Thread.Sleep(500);
            Console.WriteLine("Online");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("LANGSTRECKENSENSOR:");
            Console.ForegroundColor = ConsoleColor.Red;
            Thread.Sleep(1000);
            Console.WriteLine("Offline");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("WAFFEN:");
            Console.Write("Laser: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Thread.Sleep(500);
            Console.Write("Online");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\nRaketen: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Thread.Sleep(500);
            Console.Write("Leer");
            Console.ForegroundColor= ConsoleColor.White;
            Console.WriteLine("\nZUSTAND:");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Thread.Sleep(500);
            Console.WriteLine("Reparatur dringend empfohlen!");
            Console.ForegroundColor=ConsoleColor.White;
            Console.WriteLine("'Enter' drücken um fortzufahren");
            Console.ReadLine();
            Entscheidung();
        }
        public static void Entscheidung()
        {
            string auswahl;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Der erste Impuls der KI war es sofort ein Notrufsignal zu Senden, hielt aber inne als es sich den ernst der Lage bewusst wurde");
            Console.WriteLine("Es ist irgendwo im nirgendwo, in einem beschädigten Raumschiff");
            Console.WriteLine("Würde es jetzt ein Notrufsignal senden, läuft es Gefahr unnötige Aufmerksamkeit auf sich zu lenken.");
            Console.WriteLine("Alternativ könnte es versuchen von alleine aus zum nächstbesten Planeten hinzufliegen und dort auf Hilfe hoffen");
            Console.WriteLine("Es würde dann aber in unbekanntes Gebiet und ohne Langstreckensensor fliegen, was natürlich Risiken mit sich bringt.");
            Console.WriteLine("Oder es könnte sich auch einfach selbst ausschalten und so hoffen das irgendjemand von alleine kommt und das Schiff abholt");
            Console.WriteLine("\nDrücke 1 um trotzdem ein Notrufsignal zu senden\nDrücke 2 falls du zum nächsten Planeten fliegen willst\nDrücke 3 zum Ausschalten");
            Console.ForegroundColor = ConsoleColor.Green;
            auswahl = Console.ReadLine().ToLower();
            Console.Clear();

            switch (auswahl)
            {
                case "1":
                    {
                        Kampf.Eins();
                        break;
                    }
                case "2":
                    {
                        Ausweichen.Zwei();
                        break;
                    }
                case "3":
                    {
                        Aufgeben.Drei();
                        break;
                    }
                default:
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("Die KI zögert noch mit einer Antwort...");
                        Console.WriteLine("Zur Erinnerung: Drücke auf die Taste '1', '2' oder '3'");
                        Console.WriteLine("Drücke Enter um es nochmal zu versuchen");
                        Console.ReadLine();
                        Entscheidung();
                        break;
                    }
            }
        }
        public static void GameOver()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("  ________                        ________                     \r\n /  _____/_____    _____   ____   \\_____  \\___  __ ___________ \r\n/   \\  ___\\__  \\  /     \\_/ __ \\   /   |   \\  \\/ // __ \\_  __ \\\r\n\\    \\_\\  \\/ __ \\|  Y Y  \\  ___/  /    |    \\   /\\  ___/|  | \\/\r\n \\______  (____  /__|_|  /\\___  > \\_______  /\\_/  \\___  >__|   \r\n        \\/     \\/      \\/     \\/          \\/          \\/       ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\nVielen Dank für das Testen meines kleinen Projektes!");
            Console.WriteLine("Bitte auf Enter drücken falls du es nochmal testen möchtest");
            Console.ReadLine();
            Start();
        }
        public static void Win()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("_____.___.               __      __.__         ._.\r\n\\__  |   | ____  __ __  /  \\    /  \\__| ____   | |\r\n /   |   |/  _ \\|  |  \\ \\   \\/\\/   /  |/    \\  | |\r\n \\____   (  <_> )  |  /  \\        /|  |   |  \\  \\|\r\n / ______|\\____/|____/    \\__/\\  / |__|___|  /  __\r\n \\/                            \\/          \\/   \\/\r\n");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\nGratulation, du hast gewonnen!");
            Console.WriteLine("Bitte auf Enter drücken falls du es nochmal testen möchtest");
            Console.ReadLine();
            Start();
        }
    }
}
    

