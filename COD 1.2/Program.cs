using System;

namespace TAREA_SEMANA_2.TEMA_1
{
    class Program
    {
        static void Main()
        {
            try
            {
                decimal NumDec;
                float NumFlo;

                Console.WriteLine("---- CONVERSION DE DECIMAL A FLOTANTE ----");
                Console.WriteLine("Ingrese un número con decimales: ");
                NumDec = Convert.ToDecimal(Console.ReadLine());

                NumFlo = (float)NumDec;

                Console.WriteLine("El numero decimal " + NumDec + " como numero flotante ahora es: " + NumFlo);
                Console.WriteLine("Aunque realmente no se nota el cambio xD");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hubo un error, ingresa los datos correctamente.");
                Console.WriteLine("Error :" + ex.Message);
            }
        }
    }
}