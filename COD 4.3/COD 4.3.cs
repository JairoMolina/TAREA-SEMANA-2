using System;

namespace TAREA_SEMANA_2.TEMA_1
{
    class Program
    {
        static void Main()
        {
            try
            {
                double X1, X2, Y1, Y2, Resul;

                Console.WriteLine("---- DISTANCIA ENTRE DOS PUNTOS ----");
                Console.WriteLine("Ingresa la cordenada X del primer punto: ");
                X1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Ingresa la cordenada Y del primer punto");
                Y1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Ingresa la cordenada X del segundo punto");
                X2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Ingresa la cordenada Y del segundo punto");
                Y2 = Convert.ToDouble(Console.ReadLine());

                Resul = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));

                Console.WriteLine("La distancia entre los dos puntos es de: " + Resul);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hubo un error, ingresa los datos correctamente.");
                Console.WriteLine("Error :" + ex.Message);
            }
        }
    }
}