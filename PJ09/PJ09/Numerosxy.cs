using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJ09
{
    internal class Numerosxy
    {
        //atributos
        private double x;
        private double y;
        private double valores;




        //metodos 
        public void setXnumero(double p)
        {
            x = p;
        }

        public void setYnumero(double p)
        {
            y = p;
        }


        public double getXnumero()
        {
            return x;
        }

        public double getYnumero()
        {
            return y;
        }

        public double getValores()
        {
            return valores;
        }

        public string calcularValores()
        {
            if (x > y)
            {
                return "Primeiro número é o maior";
            }
            else
                if (y > x)
                {
                   return "Segundo número é o maior";
                }

            else
                {
                return "os dois numeros são iguais";

                }
           

        }
    }
}

