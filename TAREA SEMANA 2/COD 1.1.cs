using System;

namespace TAREA_SEMANA_2.TEMA_1
{
    class Program
    {
        static void Main()
        {
            try
            {
                int NumEnt;
                decimal NumDec;

                Console.WriteLine("---- CONVERSION ENTERO A DECIMAL ----");
                Console.WriteLine("Ingrese un número entero: ");
                NumEnt = Convert.ToInt32(Console.ReadLine());

                NumDec = NumEnt;

                Console.WriteLine("El numero entero " + NumEnt + " en decimal ahora es: " + NumDec);
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