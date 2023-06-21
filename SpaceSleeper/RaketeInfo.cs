using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuGProjektCYOA
{
    internal class RaketeInfo
    {
        public static void RInfo()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\nSchnell scannst du die Rakete, die auf Abfangkurs steht.");
            Thread.Sleep(500);
            Console.WriteLine("\nEs handelt sich um eine Lenkrakete mit einen Infrarotsensor, das heißt die zielt auf dein Triebwerk");
            Console.WriteLine("\nDas so ein Ding auf dich zufliegt kann nur folgendes bedeuten:\n1. Irgendjemand hat dich bereits auf den Schirm\n2. Dieser jemand möchte das du von der Bildfläche verschwindest\n3. Der Rakete auszuweichen wäre ein hoffnungsloses Unterfangen da sie viel wendiger als dein Schiff ist, es besser du schießt das Ding ab.");
            Console.WriteLine("\nDrücke 'Enter' um das Infomenü zu schließen.");
            Console.ReadLine();
            Console.Clear();
            AusweichenZwei.Rakete();
        }
    }
}
