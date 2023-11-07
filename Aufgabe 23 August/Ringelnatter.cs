using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_23_August
{
    internal class Ringelnatter
    {
        public static void Drei()
        {
            Console.Clear();
            Tier t3 = new Tier(3, "Ringelnatter", "Natrix Natrix", "Fundorte sind Bäche, Flüsse, Grabensysteme, Teiche und Seen, Feuchtwiesen, Moore, Sümpfe und deren jeweilige Umgebung", "Zu finden im Terrarium, vom Infoterminal aus nach rechts gehen", "Der Körper der Ringelnatter weist oberseits meist eine hell- bis dunkelgraue Grundfarbe auf, dazu kommen dunklere Flecken auf dem Rücken und an der Seite. Weitere Artkennzeichen sind die runde Pupille, deutlich erkennbare Mittelrippen auf den gekielten Schuppen und die großen Schilder auf dem Kopf.");

            Console.WriteLine("\nLateinischer Name:"); t3.AusgabeLateinName();
            Console.WriteLine("\nVorkommen:"); t3.AusgabeVorkommen();
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
                        t3.AusgabeMerkmale();
                        Console.WriteLine("\nEnter drücken um zurück ins Artprofil zu kommen");
                        Console.ReadLine();
                        Drei();
                        break;
                    }
                case "2":
                    {
                        Console.Clear();
                        t3.AusgabeWegbeschreibung();
                        Console.WriteLine("\nEnter drücken um zurück ins Artprofil zu kommen");
                        Console.ReadLine();
                        Drei();
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
                        Drei();
                        break;
                    }
            }
        }
    }
}
