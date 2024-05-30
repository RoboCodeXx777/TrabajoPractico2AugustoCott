using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico2AugustoCott.Models
{
    public class Barco
    {
        public int Cargamento { get; set; }
        public int Tripulacion {  get; set; }

        public Barco(int cargamento, int tripulacion)
        {
            Cargamento = cargamento;
            Tripulacion = tripulacion;
        }

        public string ValeLaPenaSaquear()
        {
            int pesoNeto = Cargamento - Tripulacion;
            if(pesoNeto > 20)
            {
                return "Si, vale la pena saquear. ";
            }
            else
            {
                return "No, no vale la pena saquear. ";
            }
        }

        public override string ToString()
        {
            return $"Cargamento: {Cargamento}, Tripulacion: {Tripulacion}";
        }
    }
}
