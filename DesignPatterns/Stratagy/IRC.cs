using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class IRC : Imposto
    {
        private double valor;

        public IRC(double valor)
        {
            this.valor = valor;
        }

        public double calcular()
        {
            return this.valor * 0.20;
        }
    }
}
