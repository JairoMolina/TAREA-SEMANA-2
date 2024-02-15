using System;

namespace TAREA_SEMANA_2.TEMA_1
{
    class Program
    {
        static void Main()
        {
            try
            {
                int Num1, Num2, Resul;

                Console.WriteLine("---- RESIDUO DE DIVISION DE DOS NUMEROS ENTEROS ----");
                Console.WriteLine("Ingresa el primer número entero: ");
                Num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingresa el segundo número entero: ");
                Num2 = Convert.ToInt32(Console.ReadLine());

                Resul = Num1 % Num2;
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