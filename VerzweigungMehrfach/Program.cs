using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerzweigungMehrfach
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mehrfachauswahl
            bool stammkunde = true;
            bool neukunde = false;

            if (neukunde)
            {
                /* Im Falle eines Neukunden*/
                Console.WriteLine("Neukunde");
            }
            else if (stammkunde)
            {
                /* Im Falle eines Stammkunden*/
                Console.WriteLine("Stammkunde");
            }
            else
            {
                /* In allen anderen Fällen*/
                Console.WriteLine("Kein Neu- oder Stammkunde");
            }

            Console.ReadLine();
        }
    }
}
