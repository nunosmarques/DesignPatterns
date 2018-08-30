using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Implementation
    {
        public Implementation()
        {

            Console.WriteLine(implement(new IVA(3)));
            Console.WriteLine(implement(new IRC(3)));
            Console.WriteLine(implement(new IRS(3)));

            Console.ReadKey();
        }

        private double implement(Imposto imposto)
        {
            return imposto.calcular();
        }
    }
}
