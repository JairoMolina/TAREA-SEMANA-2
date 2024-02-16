using System;

namespace TAREA_SEMANA_2.TEMA_1
{
    class Program
    {
        static void Main()
        {
            try
            {
                char Caracter;
                int NumEnt;

                Console.WriteLine("---- CONVERSION DE CARACTER A ENTERO ----");
                Console.WriteLine("Ingrese un caracter: ");
                Caracter = Convert.ToChar(Console.ReadLine());

                NumEnt = (int)Caracter;

                Console.WriteLine("El caracter " + Caracter + " tiene un valor de " + NumEnt + " en el codigo ASCII");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hubo un error, ingresa los datos correctamente.");
                Console.WriteLine("Error :" + ex.Message);
            }
        }
    }
}