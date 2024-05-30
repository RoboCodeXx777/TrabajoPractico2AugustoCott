using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico2AugustoCott.Models
{
    public class Bloque
    {
        private int largo;
        private int ancho;
        private int alto;

        public Bloque(int largo, int ancho, int alto)
        {
            this.largo = largo;
            this.ancho = ancho;
            this.alto = alto;
        }

        public int ObtenerLargo()
        {
            return largo;
        }

        public int ObtenerAncho()
        {
            return ancho;
        }

        public int ObtenerAlto()
        {
            return alto;
        }

        public int ObtenerVolumen()
        {
            return largo * ancho * alto;
        }

        public int ObtenerAreaSuperficie()
        {
            return 2 * (largo * ancho + largo * alto + ancho * alto);
        }
    }
}
