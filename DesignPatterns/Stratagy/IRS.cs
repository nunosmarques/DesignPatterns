using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class IRS : Imposto
    {
        private double valor;

        public IRS(double valor)
        {
            this.valor = valor;
        }

        double Imposto.calcular()
        {
            return this.valor * 0.30;
        }
    }
}
