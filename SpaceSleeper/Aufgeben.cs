using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuGProjektCYOA
{
    internal class Aufgeben
    {
        public static void Drei()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("                 '\r\n            *          .\r\n                   *       '\r\n              *                *\r\n\r\n\r\n\r\n\r\n\r\n   *   '*\r\n           *\r\n                *\r\n                       *\r\n               *\r\n                     *\r\n\r\n         .                      .\r\n         .                      ;\r\n         :                  - --+- -\r\n         !           .          !\r\n         |        .             .\r\n         |_         +\r\n      ,  | `.\r\n--- --+-<#>-+- ---  --  -\r\n      `._|_,'\r\n         T\r\n         |\r\n         !\r\n         :         . : \r\n         .       *\r\n");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Die KI hielt wohl für das Beste gar nichts zu machen.");
            Console.WriteLine("Kaum waren alle vorhandenen Systeme hochgefahren, wurden sie alle heruntergefahren.");
            Console.WriteLine("Nun wartet die KI bis doch noch jemand kommt.");
            Console.WriteLine("So endet dein Abenteuer bevor es überhaupt anfing...");
            Spiel.GameOver();
        }
    }
}
