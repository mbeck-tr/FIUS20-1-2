using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstrakteKlassen
{
    class Kreis : GeometrischesObjekt
    {
        public Punkt Mittelpunkt;
        public double Radius;

        public override void Verschieben(double deltaX, double deltaY)
        {
            Console.WriteLine("Verschieben (Kreis)");
        }
    }
}
