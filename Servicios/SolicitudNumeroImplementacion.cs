using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioBucle2.Servicios
{
    /// <summary>
    /// asignacion de la implementacion a la interfaz 
    /// 30102023 - ipl
    /// </summary>
    internal class SolicitudNumeroImplementacion : SolicitudNumeroInterfaz
    {
        public int numeroInt()
        {
         int numeroInt;

            Console.WriteLine("Introduzca un numero int");
            numeroInt=Convert.ToInt32(Console.ReadLine());
            return numeroInt;
        }
    
        public double numeroDouble()
        {
            double numeroDouble;

            Console.WriteLine("Introduzca un numero double");
            numeroDouble=Convert.ToDouble(Console.ReadLine()); 
            return numeroDouble;
        }
    }
}

