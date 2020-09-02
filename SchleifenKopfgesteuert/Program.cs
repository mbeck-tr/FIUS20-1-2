using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchleifenKopfgesteuert
{
    class Program
    {
        static void Main(string[] args)
        {
            //kopfgesteuerte Schleife
            //Bedingungsprüfung zu Beginn
            int zahl = 4;
            
            while (zahl < 10) // Bedingung muss true sein
            {
                Console.WriteLine("Schleifenanweisung: {0}", zahl);
                zahl++;
                if (zahl == 8)
                {
                    Console.WriteLine("Sonderfall");
                    continue; // springt direkt zur Bedingungsprüfung der Schleife
                }
                Console.WriteLine("Zahl inkrementiert!");
            }
            Console.WriteLine("Schleife beendet");
            Console.ReadLine();
        }
    }
}
