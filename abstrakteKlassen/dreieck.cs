using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstrakteKlassen
{
    class Dreieck : GeometrischesObjekt
    {
        public Punkt P1;
        public Punkt P2;
        public Punkt P3;

        public override void Verschieben(double deltaX, double deltaY)
        {
            Console.WriteLine("Verschiebe (Dreieck)");
        }
    }
}
