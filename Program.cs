using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudiantes
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Console.Write("¿Cuántos estudiantes deseas registrar? ");
            int cantidadEstudiantes = int.Parse(Console.ReadLine());

            List<Estudiante> listaEstudiantes = new List<Estudiante>();

            for (int i = 0; i < cantidadEstudiantes; i++)
            {
                Console.WriteLine($"\nRegistro del estudiante #{i + 1}:");

                Console.Write("Nombre: ");
                string nombre = Console.ReadLine();

                Console.Write("Edad: ");
                int edad = int.Parse(Console.ReadLine());

                Console.Write("Promedio: ");
                double promedio = double.Parse(Console.ReadLine());

                Estudiante estudiante = new Estudiante(nombre, edad, promedio);
                listaEstudiantes.Add(estudiante);
            }

            int index = 0;
            Console.WriteLine("\nEstudiantes con promedio mayor o igual a 70:");
            while (index < listaEstudiantes.Count)
            {
                Estudiante estudianteActual = listaEstudiantes[index];
                if (estudianteActual.Promedio >= 70)
                {
                    estudianteActual.MostrarInfo();

                    if (estudianteActual.EsMayorDeEdad())
                    {
                        Console.WriteLine("El estudiante es mayor de edad.");
                    }
                    else
                    {
                        Console.WriteLine("El estudiante es menor de edad.");
                    }
                }
                index++;
            }
        }
    }
}
