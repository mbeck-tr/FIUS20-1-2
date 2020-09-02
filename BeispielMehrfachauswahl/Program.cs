using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeispielMehrfachauswahl
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ganze Note aus dem IHK-Notenschlüssel
            /*
             *       100 - 92   Punkte sehr gut
             * unter 92 - 81    Punkte gut 
             * unter 81 - 67    Punkte befriedigend 
             * unter 67 - 50    Punkte ausreichend 
             * unter 50 - 30    Punkte mangelhaft 
             * unter 30 - 0     Punkte ungenügend
             */
            int punkte;
            
            Console.WriteLine("Eingabe Punkte");
            punkte = Convert.ToInt32(Console.ReadLine());

            if (punkte > 100 || punkte < 0) 
                Console.WriteLine("Falsche Punktzahl");
            else if (punkte > 91) Console.WriteLine("sehr gut");
            else if (punkte > 80) Console.WriteLine("gut");
            else if (punkte > 66) Console.WriteLine("befriedigend");
            else if (punkte > 49) Console.WriteLine("ausreichend");
            else if (punkte > 29) Console.WriteLine("mangelhaft");
            else Console.WriteLine("ungenügend");


            Console.ReadLine();
        }
    }
}
