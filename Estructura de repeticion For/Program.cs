using System;

namespace EjerciciosFor
{
    class Program
    {
        static void Main(string[] args)
        {

            EstructurasFor estructuras = new EstructurasFor();

            // Llamar al método los ejercicios
            // Cambia el nombre de ejercicio1 para llamar los otros, ejemplo, Ejercico2 y ejercicio3
            estructuras.Ejercicio1();


            Console.WriteLine("Presione cualquier tecla para cerrar la aplicación...");
            Console.ReadKey();
        }
    }
}
