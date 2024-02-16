// using System;

namespace TAREA_SEMANA_2.TEMA_1
{
    class Program
    {
        static void Main()
        {
            try
            {
                string Texto, Resul;

                Console.WriteLine("---- TEXTO A MAYUSCULAS ----");
                Console.WriteLine("Ingresa cualquier texto: ");
                Texto = Console.ReadLine();

                Console.WriteLine("El texto con cambios quedaría: ");
                Console.WriteLine(Texto.ToUpper());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hubo un error, ingresa los datos correctamente.");
                Console.WriteLine("Error :" + ex.Message);
            }
        }
    }
}