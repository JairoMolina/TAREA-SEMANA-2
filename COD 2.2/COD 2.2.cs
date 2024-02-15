using System;

namespace TAREA_SEMANA_2.TEMA_1
{
    class Program
    {
        static void Main()
        {
            try
            {
                decimal Num1, Num2, Resul;

                Console.WriteLine("---- RESTA DE DOS NUMEROS DECIMALES ----");
                Console.WriteLine("Ingresa el primer número con decimales: ");
                Num1 = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Ingresa el segundo número con decimales: ");
                Num2 = Convert.ToDecimal(Console.ReadLine());

                Resul = Num1 - Num2;
                Console.WriteLine("El resultado de la suma de ambos números es: " + Resul);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hubo un error, ingresa los datos correctamente.");
                Console.WriteLine("Error :" + ex.Message);
            }
        }
    }
}