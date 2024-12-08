using Carpinteria.Logica;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Carpinteria.Presentación
{
    public partial class PantallaPresupuesto : Form
    {
        private List<Presupuesto> listaPresupuestos;
        private List<Cliente> listaClientes;
        private List<DetallePresupuesto> listaDetallePresupuestos;
        private GestorPresupuestos gestorPresupuestos;

        public PantallaPresupuesto()
        {
            InitializeComponent();
            // leer clientes y presupuestos
            GestorPresupuestos gestorPresupuestos = new GestorPresupuestos();
            listaClientes = gestorPresupuestos.cargarClientes();
            listaPresupuestos = gestorPresupuestos.cargarPresupuestos();
            nombreCliente_ComboBox.DataSource = listaClientes;
            nombreCliente_ComboBox.DisplayMember = "nombre";
            nombrePresupuesto_ComboBox.Enabled = false;
            nuevo_presupuesto_Check.Enabled = false;
            panel_nuevoPresupuesto.Visible = false;
            btn_imprimir.Enabled = false;
        }

        internal void cargarDetallePresupuestos()
        {
            Presupuesto presupuestoSeleccionado = (Presupuesto)nombrePresupuesto_ComboBox.SelectedItem;
            Cliente clienteSeleccionado = (Cliente)nombreCliente_ComboBox.SelectedItem;

            if (presupuestoSeleccionado != null && clienteSeleccionado != null)
            {
                dgv_detallesPresupuesto.Rows.Clear();
                dgv_detallesPresupuesto.Refresh();
                // listaDetallePresupuestos.Clear();
                gestorPresupuestos = new GestorPresupuestos();
                listaDetallePresupuestos = gestorPresupuestos.getDetalles(presupuestoSeleccionado, clienteSeleccionado);

                foreach (DetallePresupuesto detalle in listaDetallePresupuestos)
                {
                    dgv_detallesPresupuesto.Rows.Add(
                        detalle.cantidad,
                        detalle.descripcion,
                        detalle.precioUnitario,
                        detalle.id
                        );
                }
            }
        }

        internal void cargarDetallePresupuestos(Presupuesto presupuestoNuevo)
        {
            Cliente clienteSeleccionado = (Cliente)nombreCliente_ComboBox.SelectedItem;

            if (presupuestoNuevo != null && clienteSeleccionado != null)
            {
                dgv_detallesPresupuesto.Rows.Clear();
                dgv_detallesPresupuesto.Refresh();
                // listaDetallePresupuestos.Clear();
                gestorPresupuestos = new GestorPresupuestos();
                listaDetallePresupuestos = gestorPresupuestos.getDetalles(presupuestoNuevo, clienteSeleccionado);

                foreach (DetallePresupuesto detalle in listaDetallePresupuestos)
                {
                    dgv_detallesPresupuesto.Rows.Add(
                        detalle.cantidad,
                        detalle.descripcion,
                        detalle.precioUnitario,
                        detalle.id
                        );
                }
            }
        }

        private void agregarDetalle(int cantidad, string descripcion, int precioUnitario)
        {
            Presupuesto presupuestoSeleccionado = (Presupuesto)nombrePresupuesto_ComboBox.SelectedItem;
            Cliente clienteSeleccionado = (Cliente)nombreCliente_ComboBox.SelectedItem;

            DetallePresupuesto detalle = new DetallePresupuesto();
            detalle.cliente = clienteSeleccionado;
            detalle.presupuesto = presupuestoSeleccionado;
            detalle.precioUnitario = precioUnitario;
            detalle.cantidad = cantidad;
            detalle.descripcion = descripcion;

            gestorPresupuestos.addDetalles(detalle);
            txt_cantidad.Clear();
            txt_descripcion.Clear();
            txt_precioUnitario.Clear();
            cargarDetallePresupuestos();
        }

        private void agregarPresupuesto()
        {
            Cliente clienteSeleccionado = (Cliente)nombreCliente_ComboBox.SelectedItem;

            Presupuesto presupuestoSeleccionado = new Presupuesto(txt_nombre_nuevoPresupuesto.Text, clienteSeleccionado);

            GestorPresupuestos gestorPresupuestos = new GestorPresupuestos();
            if (gestorPresupuestos is null)
            {
                MessageBox.Show("no hay gestor");
            }
            gestorPresupuestos.addPresupuesto(presupuestoSeleccionado);
            cargarDetallePresupuestos(presupuestoSeleccionado);

            txt_cantidad.Clear();
            txt_descripcion.Clear();
            txt_precioUnitario.Clear();
            cargarDetallePresupuestos();
        }

        private DataGridViewRow registroSeleccionado()
        {
            if (dgv_detallesPresupuesto.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                return dgv_detallesPresupuesto.SelectedRows[0];
            }
            return null;
        }
        private void modificarDetalle(int id, int precioUnitario, int cantidad, string descripcion)
        {
            Presupuesto presupuestoSeleccionado = (Presupuesto)nombrePresupuesto_ComboBox.SelectedItem;
            Cliente clienteSeleccionado = (Cliente)nombreCliente_ComboBox.SelectedItem;
            

            gestorPresupuestos.setDetalles(cantidad, descripcion, precioUnitario, id);
            txt_cantidad.Clear();
            txt_descripcion.Clear();
            txt_precioUnitario.Clear();
            cargarDetallePresupuestos();
        }
        private void nombrePresupuesto_Selected(object sender, EventArgs e)
        {
            cargarDetallePresupuestos();
            btn_imprimir.Enabled = true;
        }

        private void nombreCliente_Selected(object sender, EventArgs e)
        {
            Cliente clienteSeleccionado = (Cliente)nombreCliente_ComboBox.SelectedItem;
            
            nombrePresupuesto_ComboBox.Enabled = true;
            nuevo_presupuesto_Check.Enabled = true;

            List<Presupuesto> presupuestosFiltrados = listaPresupuestos
                .Where(p => p.cliente.id == clienteSeleccionado.id)
                .ToList(); 

            nombrePresupuesto_ComboBox.DataSource = null;
            nombrePresupuesto_ComboBox.DataSource = presupuestosFiltrados;
            nombrePresupuesto_ComboBox.DisplayMember = "nombre";
            nombrePresupuesto_ComboBox.SelectedIndex = -1;
            
        }



        private void btn_agregar_Click(object sender, EventArgs e)
        {
            try
            {
                agregarDetalle(int.Parse(txt_cantidad.Text), txt_descripcion.Text, int.Parse(txt_precioUnitario.Text));
                btn_agregar.Text = "Agregar";
            }
            catch
            {
                MessageBox.Show("Campos erroneos");
                txt_cantidad.Clear();
                txt_descripcion.Clear();
                txt_precioUnitario.Clear();
            }
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            DataGridViewRow registroSeleccionado = this.registroSeleccionado();
            if (registroSeleccionado != null)
            {
                try
                {
                    modificarDetalle(Convert.ToInt32(registroSeleccionado.Cells["id"].Value), int.Parse(txt_precioUnitario.Text), int.Parse(txt_cantidad.Text), txt_descripcion.Text);
                    cargarDetallePresupuestos();
                }
                catch
                {
                    MessageBox.Show("Precio y Cantidad deben ser valores numéricos.");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un producto para modificar.");
            }
        }

        private void filaSeleccionada_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow registroSeleccionado = dgv_detallesPresupuesto.Rows[e.RowIndex];
                txt_cantidad.Text = registroSeleccionado.Cells["cantidad"].Value.ToString();
                txt_descripcion.Text = registroSeleccionado.Cells["descripcion"].Value.ToString();
                txt_precioUnitario.Text = registroSeleccionado.Cells["precio_unitario"].Value.ToString();
                btn_agregar.Text = "Duplicar";
            }
        }

        private void filaSeleccionada_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv_detallesPresupuesto.ClearSelection();
            txt_cantidad.Clear();
            txt_descripcion.Clear();
            txt_precioUnitario.Clear();
            cargarDetallePresupuestos();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            DataGridViewRow registroSeleccionado = this.registroSeleccionado();
            if (registroSeleccionado != null)
            {
                gestorPresupuestos.deleteDetalle(Convert.ToInt32(registroSeleccionado.Cells["id"].Value));
                cargarDetallePresupuestos();
            }
            else
            {
                MessageBox.Show("Seleccione un detalle para eliminar.");
            }
        }

        private void nuevoPresupuesto_CheckedChanged(object sender, EventArgs e)
        {
            // habilitar el panel_nuevoPresupuesto
            if (nuevo_presupuesto_Check.Checked)
            {
                nombrePresupuesto_ComboBox.Enabled = false;
                panel_nuevoPresupuesto.Visible = true;
                btn_agregarP.Enabled = false;
            }
            else
            {
                nombrePresupuesto_ComboBox.Enabled = true;
                panel_nuevoPresupuesto.Visible = false;
            }


        }

        private void btn_agregarP_Click(object sender, EventArgs e)
        {
            agregarPresupuesto();
            panel_nuevoPresupuesto.Visible = false;
            nuevo_presupuesto_Check.Checked = false; 
            this.Hide();
        }

        private void txt_nombrep_TextChanged(object sender, EventArgs e)
        {
            if (txt_nombre_nuevoPresupuesto.Text == "")
            {
                btn_agregarP.Enabled = false;
            }
            else
            {
                btn_agregarP.Enabled = true;
            }
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            // Tomamos el cliente y presupuesto seleccionado
            Cliente clienteSeleccionado = (Cliente)nombreCliente_ComboBox.SelectedItem;
            Presupuesto presupuestoSeleccionado = (Presupuesto)nombrePresupuesto_ComboBox.SelectedItem;

            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("{0}.pdf", clienteSeleccionado.nombre + " - " + presupuestoSeleccionado.nombre);

            gestorPresupuestos = new GestorPresupuestos();
            listaDetallePresupuestos = gestorPresupuestos.getDetalles(presupuestoSeleccionado, clienteSeleccionado);

            if (listaDetallePresupuestos.Count > 0 )
            {
                string HTML = Properties.Resources.Plantilla.ToString();
                HTML = HTML.Replace("@nombreCliente", clienteSeleccionado.nombre);
                HTML = HTML.Replace("@fechaActual", DateTime.Now.ToString("dd/MM/yyyy"));
                HTML = HTML.Replace("@nombrePresupuesto", presupuestoSeleccionado.nombre);

                string rutaCompleta = Path.GetFullPath("../../Resources/PADI.png");
                HTML = HTML.Replace("@rutaLogo", rutaCompleta);

                string tabla = string.Empty;
                float total = 0;

                foreach (DetallePresupuesto detalle in listaDetallePresupuestos)
                {
                    tabla += "<tr>";
                    tabla += "<td>" + detalle.cantidad.ToString() + "</td>";
                    tabla += "<td>" + detalle.descripcion.ToString() + "</td>";
                    tabla += "<td>" + detalle.precioUnitario.ToString() + "</td>";
                    tabla += "<td>" + (detalle.cantidad * detalle.precioUnitario).ToString() + "</td>";
                    tabla += "</tr>";
                    total += detalle.cantidad * detalle.precioUnitario;

                }
                HTML = HTML.Replace("@tabla", tabla);
                HTML = HTML.Replace("@total", total.ToString());

                if (savefile.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                    {
                        Document document = new Document(PageSize.A4, 25, 25, 25, 25);
                        PdfWriter writer = PdfWriter.GetInstance(document, stream);

                        document.Open();

                        document.Add(new Phrase(""));

                        using (StringReader sr = new StringReader(HTML))
                        {
                            XMLWorkerHelper.GetInstance().ParseXHtml(writer, document, sr);
                        }

                        document.Close();
                        stream.Close();
                    }
                }
                MessageBox.Show("El archivo PDF se creó con éxito.");
                this.Close();
            }
            else
            {
                MessageBox.Show("No hay detalles. Seleccione otro Presupuesto");
            }
        }
    }
}
