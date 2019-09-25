using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
   
    class Operacion
    {
        //declarar global
         double Res;
        //Metodos con respectiva operacion
        public double Suma(Valores V)
        {
            Res = V.ValorA + V.ValorB;
            return Res;
        }

        public double Resta(Valores V)
        {
            Res = V.ValorA - V.ValorB;
            return Res;
        }

        public double Multiplicar(Valores V)
        {
            Res = V.ValorA * V.ValorB;
            return Res;

        }

        public double Division(Valores V)
        {
            Res = V.ValorA / V.ValorB;
            return Res;
        }
    }
}
