using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carpinteria.Logica
{
    internal class Presupuesto
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public DateTime fecha { get; set; }

        // public List<DetallePresupuesto> detallesPresupuestos { get; set; }

        public Cliente cliente { get; set; }  

        // public float calcularTotal()
        public Presupuesto(string nombre, Cliente Cliente)
        {
            this.nombre = nombre;
            this.cliente = Cliente; 
        }

        public Presupuesto()
        {
        }
    }
}
