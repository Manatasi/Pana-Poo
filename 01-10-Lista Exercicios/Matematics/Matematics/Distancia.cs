using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematics
{
    class Distancia
    {
        // A= (4, -8, -9) e B = (2, -3, -5)
        double xa, ya, za; // Ponto A.
        double xb, yb, zb; // Ponto B.
        public Distancia(double xa, double ya, double za, double xb, double yb, double zb)
        {
            this.xa = xa;
            this.ya = ya;
            this.za = za;

            this.xb = xb;
            this.yb = yb;
            this.zb = zb;
        }

        public Distancia(double xa, double ya, double xb, double yb)
        {
            this.xa = xa;
            this.ya = ya;

            this.xb = xb;
            this.yb = yb;
        }

        public double calculaDistanciaTridimencional()
        {
            return Math.Sqrt(Math.Pow((xb - xa), 2) + Math.Pow((yb - ya), 2) + Math.Pow((zb - za), 2));
        }

        public double calculaDistanciaBidimencional()
        {
            return Math.Sqrt(Math.Pow((xb - xa), 2) + Math.Pow((yb - ya), 2));
        }
    }
}
