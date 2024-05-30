using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico2AugustoCott.Models
{
    internal class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Genero { get; set; }

        public Persona(string nombre, int edad, string genero)
        {
            Nombre = nombre;
            Edad = edad;
            Genero = genero;
        }

        public void Hablar()
        {
            Console.WriteLine($"Me llamo {Nombre}, me considero {Genero} y tengo {Edad} años.");
        }
    }
}
