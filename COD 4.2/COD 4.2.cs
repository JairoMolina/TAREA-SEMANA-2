using System;

namespace TAREA_SEMANA_2.TEMA_1
{
    class Program
    {
        static void Main()
        {
            try
            {
                double Radio, Resul;

                Console.WriteLine("---- VOLUMEN DE UNA ESFERA ----");
                Console.WriteLine("Ingresa el radio del circulo: ");
                Radio = Convert.ToDouble(Console.ReadLine());

                Resul = (4.0 / 3.0) * Math.PI * Math.Pow(Radio, 3);

                Console.WriteLine("El volumen de la esfera es de: " + Resul);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hubo un error, ingresa los datos correctamente.");
                Console.WriteLine("Error :" + ex.Message);
            }
        }
    }
}