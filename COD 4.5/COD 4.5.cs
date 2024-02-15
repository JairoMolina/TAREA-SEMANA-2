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

                Console.WriteLine("---- GRADOS CELCIUS A FARENHEIT ----");
                Console.WriteLine("Ingresa los grados Celcius: ");
                Celc = Convert.ToDecimal(Console.ReadLine());

                Faren = (9.0m / 5.0m * Celc) + 32;

                Console.WriteLine(Celc + "° Celcius equivalen a: " + Faren + "° Farenheit");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hubo un error, ingresa los datos correctamente.");
                Console.WriteLine("Error :" + ex.Message);
            }
        }
    }
}