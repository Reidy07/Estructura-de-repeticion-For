using System;

namespace EjerciciosFor
{
    public class EstructurasFor
    {
        public void Ejercicio1()
        {
            int n;
            int count = 0;

            try
            {
                Console.WriteLine("Ingrese la cantidad de números enteros a analizar:");
                n = int.Parse(Console.ReadLine());

                for (int i = 0; i < n; i++)
                {
                    int num;
                    Console.WriteLine($"Ingrese el número {i + 1}:");
                    num = int.Parse(Console.ReadLine());

                    if (num >= 1000)
                    {
                        count++;
                    }
                }

                Console.WriteLine($"La cantidad de números mayores o iguales a 1000 es: {count}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Ingrese un número válido.");
            }
        }

        public void ejercicio2()
        {
            int n;
            int count = 0;

            try
            {
                Console.WriteLine("Ingrese la cantidad de triángulos:");
                n = int.Parse(Console.ReadLine());

                for (int i = 0; i < n; i++)
                {
                    double baseTriangulo, alturaTriangulo;
                    Console.WriteLine($"Ingrese la base del triángulo {i + 1}:");
                    baseTriangulo = double.Parse(Console.ReadLine());

                    Console.WriteLine($"Ingrese la altura del triángulo {i + 1}:");
                    alturaTriangulo = double.Parse(Console.ReadLine());

                    double superficie = (baseTriangulo * alturaTriangulo) / 2;

                    Console.WriteLine($"Triángulo {i + 1}:");
                    Console.WriteLine($"Base: {baseTriangulo}");
                    Console.WriteLine($"Altura: {alturaTriangulo}");
                    Console.WriteLine($"Superficie: {superficie}");

                    if (superficie > 12)
                    {
                        count++;
                    }
                }

                Console.WriteLine($"La cantidad de triángulos cuya superficie es mayor a 12 es: {count}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Ingrese un número decimal válido.");
            }
        }

        public void Ejercicio3()
        {
            try
            {
                int multiplicador = 5;
                int limiteSuperior = 50;

                Console.WriteLine($"Tabla de multiplicar del {multiplicador}:");

                for (int i = 1; i <= limiteSuperior / multiplicador; i++)
                {
                    int resultado = multiplicador * i;
                    Console.WriteLine($"{multiplicador} x {i} = {resultado}");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Ha ocurrido un error.");
            }
        }
    }
}
