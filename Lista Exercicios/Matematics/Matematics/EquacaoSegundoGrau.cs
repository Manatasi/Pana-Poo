using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematics
{
    class EquacaoSegundoGrau
    {
        double a, b, c;

        public EquacaoSegundoGrau(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        private double calcularDelta()
        {
            return (Math.Pow(b, 2)) - (4 * a * c);
        }

        public double calcularX1()
        {
            return (-b + Math.Sqrt(calcularDelta())) / (2*a);
        }

        public double calcualrX2()
        {
            return (-b - Math.Sqrt(calcularDelta())) / (2*a);
        }

        override
        public string ToString()
        {
            string result;
            result = String.Format("Delta = {0}.\nX1 = {0}.\nX2 = {1}.", calcularDelta(), calcularX1(), calcualrX2());
            return result;
        }
    }
}
