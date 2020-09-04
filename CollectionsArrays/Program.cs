using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deklaration einer Variable vom Typ Integer-Array
            //Ein Array ist ein Container, der eine angegebene Anzahl
            //von Werten speichern kann
            int[] Liste;
            
            //Initialisierung mit 6 Integerspeicherplätze
            Liste = new int[3];

            //Zugriff auf die Elemente, erfolgt über einen Index
            //Wertzuweisung
            Liste[0] = 100; //Index 0 bedeutet erstes Element des Arrays
            Liste[1] = 150;
            //Die Größe eines Arrays kann über die Property "Length"
            //abgerufen werden
            Console.WriteLine("Anzahl Elemente: " + Liste.Length);

            //letztes Element eines Arrays
            Liste[Liste.Length - 1] = 200;
            for (int index = 0;index < Liste.Length; index++)
            {
                Console.WriteLine($"Element {index}: {Liste[index]}");
            }

            foreach (int zahl in Liste)
            {
                Console.WriteLine(zahl);
            }

            for (int index = 0; index < Liste.Length; index++)
            {
                int zahl = Liste[index];
                Console.WriteLine(zahl);
            }

            Console.ReadLine();
        }
    }
}
