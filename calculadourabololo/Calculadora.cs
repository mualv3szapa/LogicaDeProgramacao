using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace calculadourabololo
{
    public class Calculadora
    {
        public float n1;
        public float n2;
        public float somar()
        {
            return this.n1 + this.n2;
        }

        public float subtrair()
        {
            return this.n1 - this.n2;
        }
        public float multiplicar()
        {
            return this.n1 * this.n2;
        }
        public float dividir()
        {
            return this.n1 / this.n2;
        }
    }
}