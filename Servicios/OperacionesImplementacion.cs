using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioBucle2.Servicios
{
    internal class OperacionesImplementacion : OperacionesInterfaz
    {
        public void calculo(double numeroDouble, int numeroInt)
        {
            double aux = 1;
            for (int i =0;i< numeroInt; i++) 
            {
                aux = aux * numeroDouble;

            }
            Console.WriteLine(aux);

        }
    }
}
