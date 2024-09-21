using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudiantes
{
    public class Estudiante
    {
        public string Nombre { get; set; }
        private int Edad { get; set; }
        public double Promedio { get; set; }

        public Estudiante(string nombre, int edad, double promedio)
        {
            Nombre = nombre;
            Edad = edad;
            Promedio = promedio;
        }

        public bool EsMayorDeEdad()
        {
            return Edad >= 18;
        }

        public void MostrarInfo()
        {
            Console.WriteLine($"Nombre: {Nombre}, Promedio: {Promedio}");
        }

        public int ObtenerEdad()
        {
            return Edad;
        }
    }
}
