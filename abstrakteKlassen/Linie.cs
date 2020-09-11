using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstrakteKlassen
{
    class Linie : GeometrischesObjekt
    {
        public Punkt Anfang = new Punkt(0,0);
        public Punkt Ende = new Punkt(0,0);

        public override void Verschieben(double x, double y)
        {
            Console.WriteLine("Verschiebe (Linie)");
            Anfang.X += x;
            Anfang.Y += y;

            Ende.X += x;
            Ende.Y += y;
            Console.WriteLine($"Ax: {Anfang.X}");
            Console.WriteLine($"Ay: {Anfang.Y}");
            Console.WriteLine($"Ex: {Ende.X}");
            Console.WriteLine($"Ey: {Ende.Y}");
        }


        public Linie() { }
        public Linie(Punkt a, Punkt e)
        {
            Anfang = a;
            Ende = e;
        }
    }
}
