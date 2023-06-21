using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuGProjektCYOA
{
    internal class Ausweichen
    {
        public static void Zwei()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("       ___---___                    \r\n      .--         --.      \r\n    ./   ()      .-. \\.\r\n   /   o    .   (   )  \\\r\n  / .            '-'    \\         \r\n | ()    .  O         .  |      \r\n|                         |      \r\n|    o           ()       |\r\n|       .--.          O   |            \r\n | .   |    |            |\r\n  \\    `.__.'    o   .  /    \r\n   \\                   /                   \r\n    `\\  o    ()      /'          \r\n      `--___   ___--'\r\n            ---");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Auf den Weg gerätst du in einen Asteroidenschauer, du hielst es für eine gute Möglichkeit deinen Laser zu Testen und nutzt die kleineren Asteroiden als Zielübung");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("          .--------------.\r\n                 .---'  o        .    `---.\r\n              .-'    .    O  .         .   `-.\r\n           .-'     @@@@@@       .             `-.\r\n         .'@@   @@@@@@@@@@@       @@@@@@@   .    `.\r\n       .'@@@  @@@@@@@@@@@@@@     @@@@@@@@@         `.\r\n      /@@@  o @@@@@@@@@@@@@@     @@@@@@@@@     O     \\\r\n     /        @@@@@@@@@@@@@@  @   @@@@@@@@@ @@     .  \\\r\n    /@  o      @@@@@@@@@@@   .  @@  @@@@@@@@@@@     @@ \\\r\n   /@@@      .   @@@@@@ o       @  @@@@@@@@@@@@@ o @@@@ \\\r\n  /@@@@@                  @ .      @@@@@@@@@@@@@@  @@@@@ \\\r\n  |@@@@@    O    `.-./  .        .  @@@@@@@@@@@@@   @@@  |\r\n / @@@@@        --`-'       o        @@@@@@@@@@@ @@@    . \\            +\r\n |@ @@@@ .  @  @    `    @            @@      . @@@@@@    |   0         \r\n |   @@                         o    @@   .     @@@@@@    |                \r\n-\r\n |  .     @   @ @       o              @@   o   @@@@@@.   |               \r\n \\     @    @       @       .-.       @@@@       @@@      /\r\n  |  @    @  @              `-'     . @@@@     .    .    |\r\n  \\ .  o       @  @@@@  .              @@  .           . /\r\n   \\      @@@    @@@@@@       .                   o     /\r\n    \\    @@@@@   @@\\@@    /        O          .        /\r\n     \\ o  @@@       \\ \\  /  __        .   .     .--.  /\r\n      \\      .     . \\.-.---                   `--'  /\r\n       `.             `-'      .                   .'\r\n         `.    o     / | `           O     .     .'\r\n           `-.      /  |        o             .-'\r\n              `-.          .         .     .-'\r\n                 `---.        .       .---'\r\n                      `--------------'");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Jetzt kommt dir aber ein Asteroid entgegen der sehr viel größer ist, was willst du machen?\n's' zum Schießen\n'a' zum Ausweichen\n'i' für eine kurze Info");
            string auswahl;
            Console.ForegroundColor = ConsoleColor.Green;
            auswahl = Console.ReadLine().ToLower();

            switch (auswahl)
            {
                case "s":
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("                             ____\r\n                     __,-~~/~    `---.\r\n                   _/_,---(      ,    )\r\n               __ /        <    /   )  \\___\r\n- ------===;;;'====------------------===;;;===----- -  -\r\n                  \\/  ~\"~\"~\"~\"~\"~\\~\"~)~\"/\r\n                  (_ (   \\  (     >    \\)\r\n                   \\_( _ <         >_>'\r\n                      ~ `-i' ::>|--\"");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("Der Asteroid erzittert unter den vielen Schüssen aber durch ihre schiere Masse steckt es die Treffer weg.");
                        Console.WriteLine("Bevor du noch rechtzeitig Ausweichen kannst trifft dich der riesige Flugkörper und dein kleines Abenteuer endet mit einem Feuerball");
                        Spiel.GameOver();
                        break;
                    }
                case "a":
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("Du weichst den riesigen Felsen gekonnt aus und machst dich weiter auf den Weg");
                        AusweichenZwei.Rakete();
                        break;
                    }
                case "i":
                    {
                        AsteroidInfo.AInfo();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Du überlegst fieberhaft wie du mit der Situation am besten umgehen sollst.");
                        Zwei();
                        break;

                    }                   
            }
        }
    }
}
