using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_23_August
{
    internal class Edelkrebs
    {
        public static void Fünf()
        {
            Console.Clear();
            Tier t5 = new Tier(5, "Europäischer Flusskrebs", "Astacus Astacus", "bevorzugt sommerwarme, nährstoffreiche Gewässer der Niederung, er ist aber auch in Fließgewässern höherer Lagen zu finden.", "Zu finden im Aquarium, vom Infoterminal aus nach links gehen", "Es hat einen länglichen Körperbau und kann je nach Art eine Länge von bis zu 30 cm erreichen.Der Körper ist von einem harten Panzer bedeckt, der in der Regel braun oder rot gefärbt ist.");
            Console.WriteLine("\nLateinischer Name:"); t5.AusgabeLateinName();
            Console.WriteLine("\nVorkommen:"); t5.AusgabeVorkommen();
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("\n\nDrücken Sie eine der folgenden Tasten:");

            Console.WriteLine("\n1. Kurze Beschreibung des Tieres");
            Console.WriteLine("\n2. Wegbeschreibung");
            Console.WriteLine("\n3. Zurück ins Hauptmenü");

            string auswahl;
            auswahl = Console.ReadLine().ToLower();

            switch (auswahl)
            {
                case "1":
                    {
                        Console.Clear();
                        t5.AusgabeMerkmale();
                        Console.WriteLine("\nEnter drücken um zurück ins Artprofil zu kommen");
                        Console.ReadLine();
                        Fünf();
                        break;
                    }
                case "2":
                    {
                        Console.Clear();
                        t5.AusgabeWegbeschreibung();
                        Console.WriteLine("\nEnter drücken um zurück ins Artprofil zu kommen");
                        Console.ReadLine();
                        Fünf();
                        break;
                    }
                case "3":
                    {
                        Menue.Start();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Zur Erinnerung: Drücke auf die Taste '1', '2', '3'");
                        Console.WriteLine("\nDrücke Enter um zurück ins Menü zu kommen");
                        Console.ReadLine();
                        Fünf();
                        break;
                    }
            }
        }
    }
}
