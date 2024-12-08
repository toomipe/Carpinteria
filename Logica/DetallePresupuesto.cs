using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carpinteria.Logica
{
    internal class DetallePresupuesto
    {
        public int id { get; set; }
        public string descripcion { get; set; }
        public int cantidad { get; set; }
        public float precioUnitario { get; set; }
        public Presupuesto presupuesto { get; set; }
        public Cliente cliente { get; set; }

    }
}
