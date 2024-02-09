using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoMontecarlo
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.Write("How many attempts do you want? ");
            double attempts = double.Parse(Console.ReadLine());
            double increase = 1.0 / attempts;
            double contInside = 0;
            for (double i = 0; i < 1; i += increase)
            {
                Point p = new Point();
                contInside += p.IsInside();
            }
            double pi = contInside / attempts * 4;
            Console.WriteLine(Pi estimated with {0}: {1}", attempts, pi);
            Console.ReadKey();
        }
    }
}
