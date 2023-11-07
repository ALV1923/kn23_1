using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_23_August
{
    internal class Tier
    {
        internal int Zahl;
        internal string Name;
        internal string Lateinischer_Name;
        internal string Vorkommen;
        internal string Wegbeschreibung;
        internal string Merkmale;

        public Tier(int zahl, string name, string lateinischer_Name, string vorkommen, string wegbeschreibung, string merkmale)
        {
            Zahl = zahl;
            Name = name;
            Lateinischer_Name = lateinischer_Name;
            Vorkommen = vorkommen;
            Wegbeschreibung = wegbeschreibung;
            Merkmale = merkmale;
        }
        public void AusgabeZahlName()
        {
            Console.WriteLine($"{Zahl} {Name}");
        }

        public void AusgabeName()
        {
            Console.WriteLine($"\n{Name}");
        }
        public void AusgabeLateinName()
        {
            Console.WriteLine($"\n{Lateinischer_Name}");
        }
        public void AusgabeVorkommen()
        {
            Console.WriteLine($"\n{Vorkommen}");
        }
        public void AusgabeWegbeschreibung()
        {
            Console.WriteLine($"\n{Wegbeschreibung}");
        }
        public void AusgabeMerkmale()
        {
            Console.WriteLine($"\n{Merkmale}");
        }
    }

}
