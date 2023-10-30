using ejercicioBucle2.Servicios;

namespace ejercicioBucle2
{
    class Program
    {

        /// <summary>
        /// Clase por la que se va amandar el programa
        /// 30102023 - ipl
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            SolicitudNumeroInterfaz sn = new SolicitudNumeroImplementacion();
            int numeroInt = sn.numeroInt();

            double numeroDouble = sn.numeroDouble();

           
            OperacionesInterfaz op = new OperacionesImplementacion();

           op.calculo(numeroDouble, numeroInt);

        }
    }

}
