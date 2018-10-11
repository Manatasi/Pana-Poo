using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematics
{
    class Ponto
    {
        float x;
        float y;
        float z;

        public Ponto(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        override
        public string ToString()
        {
            return "ponto";
        }
    }
}
