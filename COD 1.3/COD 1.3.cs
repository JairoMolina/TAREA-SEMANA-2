using System;

namespace TAREA_SEMANA_2.TEMA_1
{
    class Program
    {
        static void Main()
        {
            try
            {
                float NumFlo;
                int NumEnt;

                Console.WriteLine("---- CONVERSION DE FLOTANTE A ENTERO ----");
                Console.WriteLine("Ingrese un número de tipo float: ");
                NumFlo = Convert.ToSingle(Console.ReadLine());

                NumEnt = (int)NumFlo;

                Console.WriteLine("El numero decimal " + NumFlo + " como numero flotante ahora es: " + NumEnt);
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