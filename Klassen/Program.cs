using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             9* 
             8* 
             7* 
             6* 
             5*     3
             4* 
             3* 1
             2*        2
             1* 
             * *****************************************
             * 12345678901234567890
             */

            int P1x = 2;
            int P1y;
            P1y = 3;

            int[] P1 = new int[] { 2, 3 };
            
            Koordinate myKoordinate;
            myKoordinate = new Koordinate(2,3);

            //myKoordinate.x = 2;
            //myKoordinate.y = 3;
            myKoordinate.farbe = "grün";
            myKoordinate.name = "Start";

            Koordinate Punkt2;
            Punkt2 = new Koordinate(9,2);

            Punkt2.farbe = "grün";
            Punkt2.name = "Ende";

            Console.WriteLine($"Punkt1 x: {myKoordinate.x}\ty: {myKoordinate.y}");
            Console.WriteLine($"Punkt2 x: {Punkt2.x}\ty: {Punkt2.y}");

            Koordinate Punkt3 = new Koordinate(6,5);
            Console.WriteLine($"Punkt3 x: {Punkt3.x}\ty: {Punkt3.y}");


            Console.ReadLine();
        }
    }
}
