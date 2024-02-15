using System;

namespace TAREA_SEMANA_2.TEMA_1
{
    class Program
    {
        static void Main()
        {
            try
            {
                float Base, Altura, Resul;

                Console.WriteLine("---- AREA DE UN TRIANGULO ----");
                Console.WriteLine("Ingresa la base del triangulo: ");
                Base = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("Ingresa la altura del triangulo");
                Altura = Convert.ToSingle(Console.ReadLine());

                Resul = (Base * Altura) / 2;

                Console.WriteLine("El area del traingulo es de: " + Resul);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hubo un error, ingresa los datos correctamente.");
                Console.WriteLine("Error :" + ex.Message);
            }
        }
    }
}