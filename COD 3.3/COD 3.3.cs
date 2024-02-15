using System;
using System.Text;

namespace TAREA_SEMANA_2.TEMA_1
{
    class Program
    {
        static void Main()
        {
            try
            {
                string Texto;

                Console.WriteLine("---- TEXTO A MAYUSCULAS ----");
                Console.WriteLine("Ingresa cualquier texto: ");
                Texto = Console.ReadLine();

                StringBuilder Resul = new StringBuilder();
                for (int i = Texto.Length - 1; i >= 0; i--)
                {
                    Resul.Append(Texto[i]);
                }

                // Imprimir el texto al revés
                Console.WriteLine("El texto al revés es:");
                Console.WriteLine(Resul.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hubo un error, ingresa los datos correctamente.");
                Console.WriteLine("Error :" + ex.Message);
            }
        }
    }
}