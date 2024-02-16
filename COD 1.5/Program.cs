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
                Char Caracter;

                Console.WriteLine("---- CONVERSION DE ENTERO A CARACTER ----");
                Console.WriteLine("Ingresa un número de tipo entero: ");
                NumEnt = Convert.ToInt32(Console.ReadLine());

                Caracter = (char)NumEnt;

                Console.WriteLine("El número " + NumEnt + " representa " + Caracter + " en codigo ASCII");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hubo un error, ingresa los datos correctamente.");
                Console.WriteLine("Error :" + ex.Message);
            }
        }
    }
}