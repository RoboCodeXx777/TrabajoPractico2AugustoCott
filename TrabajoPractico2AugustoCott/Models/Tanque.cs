using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico2AugustoCott.Models
{
    public class Tanque
    {
        public string Nombre { get; set; }
        public string Pais {  get; set; }
        public int Año {  get; set; }
        public int Peso { get; set; }
        public List<string> Aliados { get; set; }

        public Tanque(string nombre, string pais, int año, int peso, List<string> aliados)
        {
            Nombre = nombre;
            Pais = pais;
            Año = año;
            Peso = peso;
            Aliados = aliados;
        }

        public void Batalla(Tanque otroTanque)
        {
            Console.WriteLine("Detalles del Tanque 1:");
            Console.WriteLine(this.ToString());
            Console.WriteLine("Detalles del Tanque 2:");
            Console.WriteLine(otroTanque.ToString());

            // Estos serian los criterios que determinan al ganador.
            int puntuacionEsteTanque = 0;
            int puntuacionOtroTanque = 0;

            // Aqui comparan los años de fabricacion, el mejor es el mas reciente.
            if (this.Año > otroTanque.Año) puntuacionEsteTanque++;
            else if (this.Año < otroTanque.Año) puntuacionOtroTanque++;

            // Lo mismo que el año pero esta vez es con el mas pesado es mejor.
            if (this.Peso > otroTanque.Peso) puntuacionEsteTanque++;
            else if (this.Peso < otroTanque.Peso) puntuacionOtroTanque++;

            Console.WriteLine("Resultado de la Batalla: ");
            if(puntuacionEsteTanque > puntuacionOtroTanque)
            {
                Console.WriteLine($"{this.Nombre} del pais {this.Pais} gana la batalla.");
            }
            else if (puntuacionEsteTanque < puntuacionOtroTanque)
            {
                Console.WriteLine($"{otroTanque.Nombre} del pais {otroTanque.Pais} gana la batalla.");
            }
            else
            {
                Console.WriteLine("La batalla termina en empate.");
            }
        }

        public override string ToString()
        {
            return $"Nombre: {Nombre}, País: {Pais}, Año: {Año}, Peso: {Peso} toneladas, Aliados: {string.Join(", ", Aliados)}";
        }
    }
}
