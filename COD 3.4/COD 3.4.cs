using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main()
    {
        try
        {
            string Texto, Palabra;

            Console.WriteLine("---- BUCAR PALABRAS ----");
            Console.WriteLine("Ingrese cualquier texto:");
            Texto = Console.ReadLine();

            Console.WriteLine("Ingrese la palabra que desea buscar:");
            Palabra = Console.ReadLine();

            if (Texto.Contains(Palabra))
            {
                Console.WriteLine("La palabra '" + Palabra + "' si existe en el texto.");
            }
            else
            {
                Console.WriteLine("La palabra '" + Palabra + "' no existe en el texto.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Hubo un error, ingresa los datos correctamente.");
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
