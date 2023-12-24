using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoMontecarlo
{
    internal class Point
    {
        Random random = new Random();
        public Point()
        {
            GenerateCoordinates();
        }
        public double X;
        public double Y;
        private void GenerateCoordinates()
        {
            X = random.Next(0, 1001);
            Y = random.Next(0, 1001);
        }
        public double IsInside()
        {
            if(Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2)) < 1000)
            {
                return 1;
            }
            return 0;
        }
    } 
}
