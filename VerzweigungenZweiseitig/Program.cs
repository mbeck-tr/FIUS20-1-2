using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerzweigungenZweiseitig
{
    class Program
    {
        static void Main(string[] args)
        {
            //zweiseitige Auswahl
            bool stammkunde = true;
            
            if (stammkunde) /*Bedingung*/
                 /*im Falle von Bedingung ist wahr*/
            {
                Console.WriteLine("ist Stammkunde");
                Console.WriteLine("Rabatt gewähren!!!");
            }
            else /*im Falle von Bedingung ist falsch*/
                Console.WriteLine("ist kein Stammkunde");

            Console.WriteLine("Gesamtbetrag: XY Euro");
            Console.ReadLine();
        }
    }
}
