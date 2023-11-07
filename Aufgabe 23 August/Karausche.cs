using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_23_August
{
    internal class Karausche
    {
        public static void Zwei()
        {
            Console.Clear();
            Tier t2 = new Tier(2, "Karausche", "Carassius Carassius", "Sehr anpassungsfähig, daher in fast jeden bestehenden Gewässer zu finden", "Zu finden im Aquarium, vom Infoterminal aus nach links gehen", "Die Karausche gleicht einem Karpfen, jedoch mit noch steilerer Rückenlinie und sie besitzt keine Bartfäden. Die Körperfarbe ist zumeist messinggelb, aber auch grau und grünlich. Insgesamt sind diese Fische sehr langsamwüchsig.");

            Console.WriteLine("\nLateinischer Name:"); t2.AusgabeLateinName();
            Console.WriteLine("\nVorkommen:"); t2.AusgabeVorkommen();
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
                        t2.AusgabeMerkmale();
                        Console.WriteLine("\nEnter drücken um zurück ins Artprofil zu kommen");
                        Console.ReadLine();
                        Zwei();
                        break;
                    }
                case "2":
                    {
                        Console.Clear();
                        t2.AusgabeWegbeschreibung();
                        Console.WriteLine("\nEnter drücken um zurück ins Artprofil zu kommen");
                        Console.ReadLine();
                        Zwei();
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
                        Zwei();
                        break;
                    }
            }
        }
    }
}
