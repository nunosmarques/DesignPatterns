using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class IVA : Imposto
    {
        private double valor;

        public IVA(double valor)
        {
            this.valor = valor;
        }

        double Imposto.calcular()
        {
            return this.valor * 0.10;
        }
    }
}
