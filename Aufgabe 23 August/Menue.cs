using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Aufgabe_23_August
{
    internal class Menue
    {
        public static void Start()
        {
            Tier t1 = new Tier(1, "Erdkröte", "Bufo Bufo", "nahezu überall in der Nähe von Gewässern zu finden", "Zu finden im Aquarium, vom Infoterminal aus nach links gehen", "Die Erdkröte ist mit einer Größe von bis zu elf Zentimetern eine unserer größten Amphibienarten. Die Oberseite ist bräunlich gefärbt und mit einer Vielzahl von Warzen ausgestattet.");
            Tier t2 = new Tier(2, "Karausche", "Carassius Carassius", "Sehr anpassungsfähig, daher in fast jeden bestehenden Gewässer zu finden", "Zu finden im Aquarium, vom Infoterminal aus nach links gehen", "Die Karausche gleicht einem Karpfen, jedoch mit noch steilerer Rückenlinie und sie besitzt keine Bartfäden. Die Körperfarbe ist zumeist messinggelb, aber auch grau und grünlich. Insgesamt sind diese Fische sehr langsamwüchsig.");
            Tier t3 = new Tier(3, "Ringelnatter", "Natrix Natrix", "Fundorte sind Bäche, Flüsse, Grabensysteme, Teiche und Seen, Feuchtwiesen, Moore, Sümpfe und deren jeweilige Umgebung", "Zu finden im Terrarium, vom Infoterminal aus nach rechts gehen", "Der Körper der Ringelnatter weist oberseits meist eine hell- bis dunkelgraue Grundfarbe auf, dazu kommen dunklere Flecken auf dem Rücken und an der Seite. Weitere Artkennzeichen sind die runde Pupille, deutlich erkennbare Mittelrippen auf den gekielten Schuppen und die großen Schilder auf dem Kopf.");
            Tier t4 = new Tier(4, "Gemeine Maulwurfsgrille", "Gryllotalpa Gryllotalpa", "Leben auf lockeren, feuchten, sandigen bis lehmigen Böden mit niedrigem Grasbewuchs.", "Zu finden im Terrarium, vom Infoterminal aus nach rechts gehen", "Der Körperbau ist an die überwiegend unterirdische Lebensweise angepasst. Die Färbung ist überwiegend dunkel graubraun, wobei die Beine und die Unterseite etwas heller gefärbt sind");
            Tier t5 = new Tier(5, "Europäischer Flusskrebs", "Astacus Astacus", "bevorzugt sommerwarme, nährstoffreiche Gewässer der Niederung, er ist aber auch in Fließgewässern höherer Lagen zu finden.", "Zu finden im Aquarium, vom Infoterminal aus nach links gehen", "Es hat einen länglichen Körperbau und kann je nach Art eine Länge von bis zu 30 cm erreichen.Der Körper ist von einem harten Panzer bedeckt, der in der Regel braun oder rot gefärbt ist.");
            Console.Clear();
            Console.WriteLine("Willkommen im Infoterminal von AquaTerrarium Nürnberg!");
            Console.WriteLine("\nFolgende Tiere stehen zur Auswahl:");
            t1.AusgabeZahlName();
            t2.AusgabeZahlName();
            t3.AusgabeZahlName();
            t4.AusgabeZahlName();
            t5.AusgabeZahlName();
            Console.WriteLine("\n Für mehr Infos zu den Tieren drücken sie auf die entsprechende Taste");
            string auswahl;
            auswahl = Console.ReadLine().ToLower();

            switch (auswahl)
            {
                case "1":
                    {
                        Erdkröte.Eins();
                        break;
                    }
                case "2":
                    {
                        Karausche.Zwei();
                        break;
                    }
                case "3":
                    {
                        Ringelnatter.Drei();
                        break;
                    }
                case "4":
                    {
                        Maulwurfsgrille.Vier();
                        break;
                    }
                case "5":
                    {
                        Edelkrebs.Fünf();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Zur Erinnerung: Drücke auf die Taste '1', '2', '3', '4' oder '5'");
                        Console.WriteLine("Drücke Enter um zurück ins Menü zu kommen");
                        Console.ReadLine();
                        Start();
                        break;
                    }

            }
        }
    }
}
