using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_23_August
{
    public class Erdkröte
    {

        public static void Eins()
        {
            Console.Clear();
            Tier t1 = new Tier(1, "Erdkröte", "Bufo Bufo", "Nahezu überall in der Nähe von Gewässern zu finden", "Zu finden im Aquarium, vom Infoterminal aus nach links gehen", "Die Erdkröte ist mit einer Größe von bis zu elf Zentimetern eine unserer größten Amphibienarten. Die Oberseite ist bräunlich gefärbt und mit einer Vielzahl von Warzen ausgestattet.");
            Console.WriteLine("\nLateinischer Name:");t1.AusgabeLateinName();
            Console.WriteLine("\nVorkommen:");t1.AusgabeVorkommen();
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
                        t1.AusgabeMerkmale();
                        Console.WriteLine("\nEnter drücken um zurück ins Artprofil zu kommen");
                        Console.ReadLine();
                        Eins();
                        break;
                    }
                case "2":
                    {
                        Console.Clear();
                        t1.AusgabeWegbeschreibung();
                        Console.WriteLine("\nEnter drücken um zurück ins Artprofil zu kommen");
                        Console.ReadLine();
                        Eins();
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
                        Eins();
                        break;
                    }
            }
        }
    }
}
