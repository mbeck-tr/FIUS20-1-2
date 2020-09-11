using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace statischeMember
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mathe myMatheObject = new Mathe();
            Console.WriteLine("zahl1: ");
            string eingabe = Console.ReadLine();
            double a = Convert.ToDouble(eingabe);

            Console.WriteLine("zahl2: ");
            eingabe = Console.ReadLine();
            double b = Convert.ToDouble(eingabe);

            Console.WriteLine("radius: ");
            eingabe = Console.ReadLine();
            double radius = Convert.ToDouble(eingabe);

            double ergebnis = Mathe.Addiere(a, b);
            Console.WriteLine("Ergebnis: " + ergebnis);

            double umfang = 2 * radius * Mathe.PI;
            umfang = Mathe.Umfang(radius);
            Console.WriteLine("Umfang: " + umfang);

            Console.ReadLine();
        }

       
    }


}
