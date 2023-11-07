using System;
using System.Reflection;

namespace Aufgabe_22_August
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool checkPreis;
            bool checkMenge;
            decimal melonenPreis;
            int melonenMenge;

            DateTime dt = DateTime.Now;


            Console.WriteLine("Willkommen beim Verkaufsprogramm");
            Console.WriteLine();

            do

            {
                Console.WriteLine("Bitte geben Sie den Preis pro Melone ein");
                checkPreis = decimal.TryParse(Console.ReadLine(), out melonenPreis);

                if (checkPreis == false)
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("Falsche Eingabe, bitte eine gültige Zahl eingeben");
                }

            }
            while (checkPreis == false);


            do
            {
                Console.WriteLine("Geben Sie nun die Anzahl ein:");
                checkMenge = int.TryParse(Console.ReadLine(), out melonenMenge);

                if (checkMenge == false)
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("Falsche Eingabe, bitte geben Sie eine gültige Zahl ein");
                }
            } while (checkMenge == false);


            if (melonenMenge >= 10)

            {
                decimal neuPreis = melonenPreis * melonenMenge;
                neuPreis = Math.Round(neuPreis - (neuPreis * 10 / 100), 2);
                Console.WriteLine("Da hat jemand Hunger! Das gibt noch 10 % Rabatt!");
                Console.WriteLine($"Mit Rabatt beträgt der Preis {neuPreis} EUR");
                if (dt.DayOfWeek == DayOfWeek.Tuesday)
                {

                    int[] dienstagRabatt = { 7, 12 };
                    Random rnd = new Random();
                    int index = rnd.Next(dienstagRabatt.Length);
                    decimal dienstagPreis = Math.Round(neuPreis - (neuPreis * dienstagRabatt[index] / 100), 2);
                    decimal bruttoPreisDienstag = Math.Round(dienstagPreis + (dienstagPreis * 7 / 100), 2);

                    Console.WriteLine();
                    Console.WriteLine($"DIENSTAG! Nur am Dienstag noch zusätzlich {dienstagRabatt[index]} % Rabatt!");
                    Console.WriteLine($"Mit Dienstagrabatt beträgt der Preis {dienstagPreis} EUR");

                    Console.WriteLine("Bitte auf Enter drücken um die Quittung zu erstellen");
                    Console.ReadLine();
                    Console.Clear();

                    Console.WriteLine($"Preis pro Melone: {melonenPreis}");
                    Console.WriteLine($"Eingegebene Menge: {melonenMenge}");
                    Console.WriteLine($"Mengenrabatt: 10 %");
                    Console.WriteLine($"Dienstagrabatt:{dienstagRabatt[index]} % ");
                    Console.WriteLine($"Nettopreis: {dienstagPreis} EUR");
                    Console.WriteLine($"Mehrwertsteuer: 7 %");
                    Console.WriteLine($"Bruttopreis: {bruttoPreisDienstag}");
                    Console.WriteLine("Vielen Dank für Ihren Einkauf!");
                }
                else
                {
                    decimal bruttoPreis = Math.Round(neuPreis + (neuPreis * 7 / 100), 2);
                    Console.WriteLine("Bitte auf Enter drücken um die Quittung zu erstellen");
                    Console.ReadLine();
                    Console.Clear();

                    Console.WriteLine($"Preis pro Melone: {melonenPreis}");
                    Console.WriteLine($"Eingegebene Menge: {melonenMenge}");
                    Console.WriteLine($"Mengenrabatt: 10 %");
                    Console.WriteLine($"Nettopreis: {neuPreis} EUR");
                    Console.WriteLine($"Mehrwertsteuer: 7 %");
                    Console.WriteLine($"Bruttopreis: {bruttoPreis}");
                    Console.WriteLine("Vielen Dank für Ihren Einkauf!");
                }
            }
            else if (melonenMenge >= 5)
            {
                decimal neuPreis = melonenPreis * melonenMenge;
                neuPreis = Math.Round(neuPreis - (neuPreis * 5 / 100), 2);
                Console.WriteLine("Ab einen Bestellwert von 5 Melonen gibt es einen 5 % Rabatt!");
                if (dt.DayOfWeek == DayOfWeek.Tuesday)
                {

                    int[] dienstagRabatt = { 7, 12 };
                    Random rnd = new Random();
                    int index = rnd.Next(dienstagRabatt.Length);
                    decimal dienstagPreis = Math.Round(neuPreis - (neuPreis * dienstagRabatt[index] / 100), 2);
                    decimal bruttoPreisDienstag = Math.Round(dienstagPreis + (dienstagPreis * 7 / 100), 2);

                    Console.WriteLine();
                    Console.WriteLine($"DIENSTAG! Nur am Dienstag noch zusätzlich {dienstagRabatt[index]} % Rabatt!");
                    Console.WriteLine($"Mit Dienstagrabatt beträgt der Preis {dienstagPreis} EUR");

                    Console.WriteLine("Bitte auf Enter drücken um die Quittung zu erstellen");
                    Console.ReadLine();
                    Console.Clear();

                    Console.WriteLine($"Preis pro Melone: {melonenPreis}");
                    Console.WriteLine($"Eingegebene Menge: {melonenMenge}");
                    Console.WriteLine($"Mengenrabatt: 5 %");
                    Console.WriteLine($"Dienstagrabatt:{dienstagRabatt[index]} % ");
                    Console.WriteLine($"Nettopreis: {dienstagPreis} EUR");
                    Console.WriteLine($"Mehrwertsteuer: 7 %");
                    Console.WriteLine($"Bruttopreis: {bruttoPreisDienstag}");
                    Console.WriteLine("Vielen Dank für Ihren Einkauf!"); 
                }
                else
                {
                    decimal bruttoPreis = Math.Round(neuPreis + (neuPreis * 7 / 100), 2);
                    Console.WriteLine("Bitte auf Enter drücken um die Quittung zu erstellen");
                    Console.ReadLine();
                    Console.Clear();

                    Console.WriteLine($"Preis pro Melone: {melonenPreis}");
                    Console.WriteLine($"Eingegebene Menge: {melonenMenge}");
                    Console.WriteLine($"Mengenrabatt: 5 %");
                    Console.WriteLine($"Nettopreis: {neuPreis} EUR");
                    Console.WriteLine($"Mehrwertsteuer: 7 %");
                    Console.WriteLine($"Bruttopreis: {bruttoPreis}");
                    Console.WriteLine("Vielen Dank für Ihren Einkauf!");
                }
            }
            else
            {
                decimal neuPreis = melonenPreis * melonenMenge;
                neuPreis = Math.Round(neuPreis, 2);
                Console.WriteLine($"Ihr Preis beträgt: {neuPreis} EUR"); 
                if (dt.DayOfWeek == DayOfWeek.Tuesday)
                {

                    int[] dienstagRabatt = { 7, 12 };
                    Random rnd = new Random();
                    int index = rnd.Next(dienstagRabatt.Length);
                    decimal dienstagPreis = Math.Round(neuPreis - (neuPreis * dienstagRabatt[index] / 100), 2);
                    decimal bruttoPreisDienstag = Math.Round(dienstagPreis + (dienstagPreis * 7 / 100), 2);

                    Console.WriteLine();
                    Console.WriteLine($"DIENSTAG! Nur am Dienstag noch zusätzlich {dienstagRabatt[index]} % Rabatt!");
                    Console.WriteLine($"Mit Dienstagrabatt beträgt der Preis {dienstagPreis} EUR");

                    Console.WriteLine("Bitte auf Enter drücken um die Quittung zu erstellen");
                    Console.ReadLine();
                    Console.Clear();

                    Console.WriteLine($"Preis pro Melone: {melonenPreis}");
                    Console.WriteLine($"Eingegebene Menge: {melonenMenge}");
                    Console.WriteLine($"Dienstagrabatt:{dienstagRabatt[index]} % ");
                    Console.WriteLine($"Nettopreis: {dienstagPreis} EUR");
                    Console.WriteLine($"Mehrwertsteuer: 7 %");
                    Console.WriteLine($"Bruttopreis: {bruttoPreisDienstag}");
                    Console.WriteLine("Vielen Dank für Ihren Einkauf!");
                }
                else
                {
                    decimal bruttoPreis = Math.Round(neuPreis + (neuPreis * 7 / 100), 2);
                    Console.WriteLine("Bitte auf Enter drücken um die Quittung zu erstellen");
                    Console.ReadLine();
                    Console.Clear();

                    Console.WriteLine($"Preis pro Melone: {melonenPreis}");
                    Console.WriteLine($"Eingegebene Menge: {melonenMenge}");
                    Console.WriteLine($"Nettopreis: {neuPreis} EUR");
                    Console.WriteLine($"Mehrwertsteuer: 7 %");
                    Console.WriteLine($"Bruttopreis: {bruttoPreis}");
                    Console.WriteLine("Vielen Dank für Ihren Einkauf!");
                }
            }

            // Notiz Alles in einem Methodenaufruf stecken
        }
    }
}