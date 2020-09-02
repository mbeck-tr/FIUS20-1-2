using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchleifenFussgesteuert
{
    class Program
    {
        static void Main(string[] args)
        {
            //fussgesteuerte Schleifen
            // Bedingungsprüfung nach den Schleifenanweisungen
            int zahl;
            string währung = "Euro";
            do
            {
                zahl = Convert.ToInt32(Console.ReadLine());
                if (zahl == 0) continue;

                //Verkettung, concat
                Console.WriteLine("zahl: " + zahl + währung);
                
                //Platzhalter, klassisch
                Console.WriteLine("zahl: {0}{1}", zahl, währung);
                
                //Platzhalter, direkte Angabe der Variablen
                Console.WriteLine($"zahl: {zahl}{währung}");

            } while (zahl < 10);

            Console.WriteLine("Schleife beendet");
            Console.ReadLine();
        }
    }
}
