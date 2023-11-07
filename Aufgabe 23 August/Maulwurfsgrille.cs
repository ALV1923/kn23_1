using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_23_August
{
    internal class Maulwurfsgrille
    {
        public static void Vier()
        {
            Console.Clear();
            Tier t4 = new Tier(4, "Gemeine Maulwurfsgrille", "Gryllotalpa Gryllotalpa", "Leben auf lockeren, feuchten, sandigen bis lehmigen Böden mit niedrigem Grasbewuchs.", "Zu finden im Terrarium, vom Infoterminal aus nach rechts gehen", "Der Körperbau ist an die überwiegend unterirdische Lebensweise angepasst. Die Färbung ist überwiegend dunkel graubraun, wobei die Beine und die Unterseite etwas heller gefärbt sind");

            Console.WriteLine("\nLateinischer Name:"); t4.AusgabeLateinName();
            Console.WriteLine("\nVorkommen:"); t4.AusgabeVorkommen();
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
                        t4.AusgabeMerkmale();
                        Console.WriteLine("\nEnter drücken um zurück ins Artprofil zu kommen");
                        Console.ReadLine();
                        Vier();
                        break;
                    }
                case "2":
                    {
                        Console.Clear();
                        t4.AusgabeWegbeschreibung();
                        Console.WriteLine("\nEnter drücken um zurück ins Artprofil zu kommen");
                        Console.ReadLine();
                        Vier();
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
                        Vier();
                        break;
                    }
            }
        }
    }
}
