using Carpinteria.Presentación;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Carpinteria.Persistencia;

namespace Carpinteria
{
    public partial class PantallaPrincipal : Form
    {
        private GestorBaseDeDatos gestorBaseDeDatos; 
        public PantallaPrincipal()
        {
            InitializeComponent();
            cargarBDD();
        }

        private void btn_presupuestos_Click(object sender, EventArgs e)
        {
            PantallaPresupuesto pantallaPresupuesto = new PantallaPresupuesto();
            pantallaPresupuesto.Show();
        }

        private void btn_clientes_Click(object sender, EventArgs e)
        {
            PantallaCliente pantallaCliente= new PantallaCliente();
            pantallaCliente.Show();
        }

        private void cargarBDD()
        {
            GestorBaseDeDatos gestorBaseDeDatos = new GestorBaseDeDatos();
            gestorBaseDeDatos.cargarBaseDeDatos();
        }
    }
}
