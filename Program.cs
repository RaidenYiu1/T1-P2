using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1_d
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Elaborar un algoritmo que que pida las notas de n alumnos y muestre cuántos de ellos obtuvieron menos
            //de 12 y que muestre el mayor y el menor puntaje
            //obtenido

            Console.WriteLine("Ingrese la cantidad de alumnos");
            int nota = int.Parse(Console.ReadLine());

            int contadorMenor12 = 0;
            double mayor = double.MinValue;
            double menor = double.MaxValue;

            for (int i = 1; i <= nota; i++)
            {
                Console.Write($"Ingrese la nota del alumno :");
                double n = double.Parse(Console.ReadLine());

                if (nota < 12) contadorMenor12++;
                contadorMenor12++;

                if (nota > mayor)
                    mayor = nota;


                if (nota < menor)
                    menor = nota;
            }
            {
                Console.WriteLine($"\nCantidad de alumnos con nota menor a 12:{menor}");
                Console.WriteLine($"\nCantidad de alumnos con nota mayor a 12:{mayor}");
                Console.WriteLine($"Mayor nota: {mayor}");
                Console.WriteLine($"Menor nota: {menor}");
                Console.ReadKey();
            }
        }
    }
}
