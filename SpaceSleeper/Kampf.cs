using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuGProjektCYOA
{
    internal class Kampf
    {
        public static void Eins()
        {
            int schiffTrefferpunkte = 60;
            int gegnerTrefferpunkte = 35;

            int reparatur = 15;
            int gegnerReparatur = 1;

            int schiffAngriff = 15;
            int gegnerAngriff = 5;

            Random random = new Random();

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Du hast dich trotz der Gefahr entschieden ein Notrufsignal zu senden...");
            Console.WriteLine("Dein Kurzstreckensensor erfasste ein Signal..aber das Signal ist dir unbekannt.");
            Console.WriteLine("Erst als du es visuell erfassen kannst wird dir klar was da auftaucht");
            Console.WriteLine("Eine Bergungsdrohne..eine die dafür gemacht wurde Weltraumschrott mit ihren großen Metallklauen zu greifen und mit ihren Laser den Schrott in kleinere Stücke zu zerkleinern");
            Console.WriteLine("Schnell rückt das Ding näher und du machst dich auf ein Gefecht bereit");
            

            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nWas willst du machen?");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("Deine Hüllenintegrität = ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(schiffTrefferpunkte);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("\nZustand des Gegners = ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(gegnerTrefferpunkte);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("\n\nDrücke 's' zum Schießen\nDrücke 'r' zum Reparieren.");
                Console.ForegroundColor = ConsoleColor.Green;
                string auswahl = Console.ReadLine();
                auswahl.ToLower();
                Console.ForegroundColor = ConsoleColor.Gray;
                if (auswahl == "s")
                {
                    gegnerTrefferpunkte -= schiffAngriff;
                    Console.WriteLine("\nDu feuerst auf das Schiff mit deiner Waffe, Funken zucken an den Stellen wo du getroffen hast.");
                }
                else if (auswahl == "r")
                {
                    int neueSchifftrefferpunkte = schiffTrefferpunkte + reparatur;
                    {
                        if (neueSchifftrefferpunkte >= 60)
                        {
                            schiffTrefferpunkte = 60;
                            Console.WriteLine("Eine Reparatur ist nicht notwendig!");
                        }
                        else
                        {
                            schiffTrefferpunkte = neueSchifftrefferpunkte;
                        }
                    }
                    Console.WriteLine("\nDeine Reparatursysteme geben ihr möglichstes um die Schäden zu reparieren.");
                }
                else
                {
                    Console.WriteLine("Während du falsche Inputs eingibst macht das feindliche Schiff folgendes:");              
                }

                if (gegnerTrefferpunkte > 0)
                {

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nEtwas regt sich im feindlichen Schiff...");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("Deine Hüllenintegrität = ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(schiffTrefferpunkte);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("\nZustand des Gegners = ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(gegnerTrefferpunkte);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    int gegnerAuswahl = random.Next(0, 2);

                    if (gegnerAuswahl == 0)
                    {
                        schiffTrefferpunkte -= gegnerAngriff;
                        Console.WriteLine("\n\nDu gibst dein bestes dem entgegenkommenden Feuer auszuweichen, dennoch streifen dich hier und da die Laserstrahlen.");
                    }
                    else if (gegnerTrefferpunkte == 35)
                    {
                        gegnerTrefferpunkte += gegnerReparatur;
                        Console.WriteLine("\n\nDas gegnerische Schiff hat wohl einen Schlag, es steht einfach rum und macht nichts.");
                    }
                    else
                    {
                        {
                            int neuegegnerTrefferpunkte = gegnerTrefferpunkte + gegnerReparatur;
                            {
                                if (neuegegnerTrefferpunkte >= 35)
                                {
                                    gegnerTrefferpunkte = 35;
                                    Console.WriteLine("\n\nDas gegnerische Schiff hat wohl einen Schlag, es steht einfach rum und macht nichts außer von alleine Funken zu sprühen");
                                }
                                else
                                {
                                    gegnerTrefferpunkte = neuegegnerTrefferpunkte;
                                }
                            }
                            Console.WriteLine("\n\nDie Drohne steht still und versucht den eigenen Schaden zu reparieren");
                        }
                    }
                }
            } while (schiffTrefferpunkte > 0 && gegnerTrefferpunkte > 0);

            if (gegnerTrefferpunkte <= 0)
            {
                Console.WriteLine("\n\nDein letzter Schuss hat die Drohne außer Gefecht gesetzt! Schwer beschädigt torkelt die Drohne davon bevor ihre Lichter komplett erlöschen.");
                Console.WriteLine("Da solche Drohnen immer von einer Art Mutterschiff entsendet wurden hältst du es für Schlau dein Notfallsignal auszuschalten und dich zu verduften.");
                Spiel.Win();
            }
            else if (schiffTrefferpunkte <= 0)
            {
                Console.WriteLine("\nDieser letzte Angriff hat dir den Rest gegeben, nach und nach fallen alle Systeme aus. Diesen Kampf hast du verloren");                
                Spiel.GameOver();
            }
            else
            {
                Console.WriteLine("Derp");
            }
        }

    }
}
