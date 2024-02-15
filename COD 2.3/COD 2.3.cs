using System;

namespace TAREA_SEMANA_2.TEMA_1
{
    class Program
    {
        static void Main()
        {
            try
            {
                float Num1, Num2, Resul;

                Console.WriteLine("---- MULTIPLICACION DE DOS NUMEROS FLOTANTES ----");
                Console.WriteLine("Ingresa el primer número de tipo float: ");
                Num1 = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("Ingresa el segundo número de tipo float: ");
                Num2 = Convert.ToSingle(Console.ReadLine());

                Resul = Num1 * Num2;
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