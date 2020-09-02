using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerzweigungenFallauswahl
{
    class Program
    {
        static void Main(string[] args)
        {
            //Schulnote
            Console.WriteLine("Note eingeben (1-6):");
            string note = Console.ReadLine();

            switch (note)
            {
                case "1":
                    Console.WriteLine("Fall 1:");
                    Console.WriteLine("sehr gut");
                    break;
                case "2":
                    Console.WriteLine("2 eingegeben");
                    Console.WriteLine("gut");
                    break;
                case "3":
                    Console.WriteLine("super gemacht: drei eingegeben :-)");
                    Console.WriteLine("befriedigend");
                    break;
                case "4":
                    Console.WriteLine("ausreichend");
                    break;
                case "5":
                    Console.WriteLine("mangelhaft");
                    break;
                case "6":
                    Console.WriteLine("ungenügend");
                    break;
                case "7": /* kein break; bewirkt die Weiterführung im nächsten Fall*/
                case "8":
                case "9":
                    Console.WriteLine("keine Schulnote");
                    break;
                default: /* für alle nichtzutreffenden Fälle*/
                    Console.WriteLine("Falsche Eingabe");
                    break;
            }
            Console.ReadLine();
        }
    }
}
