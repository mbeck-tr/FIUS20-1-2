using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstrakteKlassen
{
    class Program
    {
        static void Main(string[] args)
        {
            Linie l1 = new Linie();
            l1.Anfang.X = 10;
            l1.Anfang.Y = 10;
            l1.Ende.X = 20;
            l1.Ende.Y = 20;
            l1.Verschieben(1,2);
            l1.Verschieben(4, -1);
            l1.Verschieben(-2, 4);

            Punkt ap = new Punkt(2, 5);
            Punkt ep = new Punkt(6, 3);

            Linie l2 = new Linie(ap, ep);

            Linie l3 = new Linie(new Punkt(2, 34), new Punkt(2, 4));

            Dreieck d1 = new Dreieck();
            d1.Verschieben(2,5);

            //GeometrischesObjekt g = new GeometrischesObjekt();

            int[] heizung;

            var anzahl = 15;

            heizung = new int[anzahl];

            heizung[0] = 3;
            heizung[1] = 2; //...
            heizung[2] = 1;
            heizung[3] = 4;
            heizung[4] = 5;

            foreach (int item in heizung)
            {
                Console.WriteLine(item);
            }





            Console.ReadLine();
        }
    }
}
