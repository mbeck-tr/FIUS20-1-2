using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace statischeMember
{
    static class Mathe
    {
        public static double PI = 3.14;
        public static double Addiere(double zahl1, double zahl2)
        {
            double summe = zahl1 + zahl2;
            return summe;
        }
        public static double Umfang(double r)
        {
            return 2 * PI * r;
        }
    }
}
