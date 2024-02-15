using System;

namespace TAREA_SEMANA_2.TEMA_1
{
    class Program
    {
        static void Main()
        {
            try
            {
                string Texto;
                int Resul;

                Console.WriteLine("---- CONTADOR DE LETRAS ----");
                Console.WriteLine("Ingresa cualquier texto: ");
                Texto = Console.ReadLine();

                Resul = Texto.Length;

                Console.WriteLine("El texto ");
                Console.WriteLine(Texto);
                Console.WriteLine("Contiene " + Resul + " letras");
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hubo un error, ingresa los datos correctamente.");
                Console.WriteLine("Error :" + ex.Message);
            }
        }
    }
}