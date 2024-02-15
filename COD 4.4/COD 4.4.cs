using System;

namespace TAREA_SEMANA_2.TEMA_1
{
    class Program
    {
        static void Main()
        {
            try
            {
                decimal Faren, Celc;

                Console.WriteLine("---- GRADOS FARENHEIT A GRADOS CELCIUS ----");
                Console.WriteLine("Ingresa los grados Farenheit: ");
                Faren = Convert.ToDecimal(Console.ReadLine());

                Celc = (Faren - 32) * 5.0m / 9.0m;

                Console.WriteLine( Faren + "° Farenheit equivalen a: " + Celc + "° Celcius");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hubo un error, ingresa los datos correctamente.");
                Console.WriteLine("Error :" + ex.Message);
            }
        }
    }
}