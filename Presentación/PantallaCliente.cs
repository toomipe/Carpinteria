using Carpinteria.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carpinteria.Presentación
{
    public partial class PantallaCliente : Form
    {
        private List<Cliente> listaClientes;
        private GestorClientes gestorClientes = new GestorClientes();
        public PantallaCliente()
        {
            InitializeComponent();
            listaClientes = gestorClientes.getClientes();
            dgv_clientes.Columns["telefonoCliente"].DefaultCellStyle.Format = "0";
            cargarClientes();
        }

        public void agregarCliente(string nombre, string telefono)
        {
            Cliente cliente = new Cliente();
            cliente.nombre = nombre;
            cliente.telefono = telefono;

            gestorClientes.addCliente(cliente);
            txt_nombreCliente.Clear();
            txt_telefonoCliente.Clear();
            cargarClientes();
        }

        public void cargarClientes()
        {
            dgv_clientes.Rows.Clear();
            dgv_clientes.Refresh();
            gestorClientes = new GestorClientes();
            listaClientes = gestorClientes.getClientes();
            foreach (Cliente cliente in listaClientes)
            {
                dgv_clientes.Rows.Add(
                    cliente.id,
                    cliente.nombre,
                    cliente.telefono
                    );
            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            try
            {
                agregarCliente(txt_nombreCliente.Text, txt_telefonoCliente.Text);
                btn_agregar.Text = "Agregar";
            }
            catch
            {
                MessageBox.Show("Campos erroneos");
                txt_nombreCliente.Clear();
                txt_telefonoCliente.Clear();
            }
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            DataGridViewRow registroSeleccionado = this.registroSeleccionado();
            if (registroSeleccionado != null)
            {
                try
                {
                    // MessageBox.Show(Convert.ToInt32(registroSeleccionado.Cells["id"].Value).ToString() + txt_nombreCliente.Text + int.Parse(txt_telefonoCliente.Text));
                    modificarCliente(Convert.ToInt32(registroSeleccionado.Cells["idCliente"].Value), txt_nombreCliente.Text, txt_telefonoCliente.Text);
                    cargarClientes();
                }
                catch
                {
                    MessageBox.Show("Error de Modificación");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un producto para modificar.");
            }
        }

        private void modificarCliente(int id, string nombre, string telefono)
        {
            gestorClientes.setClientes(id, nombre, telefono);
            txt_nombreCliente.Clear();
            txt_telefonoCliente.Clear();
            cargarClientes();
        }

        private void filaSeleccionada_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow registroSeleccionado = dgv_clientes.Rows[e.RowIndex];
                txt_nombreCliente.Text = registroSeleccionado.Cells["nombreCliente"].Value.ToString();
                txt_telefonoCliente.Text = registroSeleccionado.Cells["telefonoCliente"].Value.ToString();
                btn_agregar.Text = "Duplicar";
            }
        }

        private void filaSeleccionada_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv_clientes.ClearSelection();
            txt_nombreCliente.Clear();
            txt_telefonoCliente.Clear();
            cargarClientes();
        }

        private DataGridViewRow registroSeleccionado()
        {
            if (dgv_clientes.SelectedRows.Count > 0)
            {
                return dgv_clientes.SelectedRows[0];
            }
            return null;
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            DataGridViewRow registroSeleccionado = this.registroSeleccionado();
            if (registroSeleccionado != null)
            {
                gestorClientes.deleteCliente(Convert.ToInt32(registroSeleccionado.Cells["idCliente"].Value));
                cargarClientes();
            }
            else
            {
                MessageBox.Show("Seleccione un cliente para eliminar.");
            }
        }
    }
}
