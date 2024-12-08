namespace Carpinteria.Presentación
{
    partial class PantallaPresupuesto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaPresupuesto));
            this.label1 = new System.Windows.Forms.Label();
            this.nombrePresupuesto_ComboBox = new System.Windows.Forms.ComboBox();
            this.nombreCliente_ComboBox = new System.Windows.Forms.ComboBox();
            this.dgv_detallesPresupuesto = new System.Windows.Forms.DataGridView();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nuevo_presupuesto_Check = new System.Windows.Forms.CheckBox();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.btn_descripcion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_precioUnitario = new System.Windows.Forms.TextBox();
            this.panel_nuevoPresupuesto = new System.Windows.Forms.Panel();
            this.btn_agregarP = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_nombre_nuevoPresupuesto = new System.Windows.Forms.TextBox();
            this.btn_imprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detallesPresupuesto)).BeginInit();
            this.panel_nuevoPresupuesto.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(98, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscador:";
            // 
            // nombrePresupuesto_ComboBox
            // 
            this.nombrePresupuesto_ComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombrePresupuesto_ComboBox.FormattingEnabled = true;
            this.nombrePresupuesto_ComboBox.Location = new System.Drawing.Point(951, 69);
            this.nombrePresupuesto_ComboBox.Name = "nombrePresupuesto_ComboBox";
            this.nombrePresupuesto_ComboBox.Size = new System.Drawing.Size(516, 45);
            this.nombrePresupuesto_ComboBox.TabIndex = 3;
            this.nombrePresupuesto_ComboBox.SelectedIndexChanged += new System.EventHandler(this.nombrePresupuesto_Selected);
            // 
            // nombreCliente_ComboBox
            // 
            this.nombreCliente_ComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreCliente_ComboBox.FormattingEnabled = true;
            this.nombreCliente_ComboBox.Location = new System.Drawing.Point(371, 69);
            this.nombreCliente_ComboBox.Name = "nombreCliente_ComboBox";
            this.nombreCliente_ComboBox.Size = new System.Drawing.Size(516, 45);
            this.nombreCliente_ComboBox.TabIndex = 4;
            this.nombreCliente_ComboBox.SelectedIndexChanged += new System.EventHandler(this.nombreCliente_Selected);
            // 
            // dgv_detallesPresupuesto
            // 
            this.dgv_detallesPresupuesto.AllowDrop = true;
            this.dgv_detallesPresupuesto.AllowUserToAddRows = false;
            this.dgv_detallesPresupuesto.AllowUserToDeleteRows = false;
            this.dgv_detallesPresupuesto.AllowUserToResizeColumns = false;
            this.dgv_detallesPresupuesto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_detallesPresupuesto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cantidad,
            this.descripcion,
            this.precio_unitario,
            this.id});
            this.dgv_detallesPresupuesto.Location = new System.Drawing.Point(200, 403);
            this.dgv_detallesPresupuesto.Name = "dgv_detallesPresupuesto";
            this.dgv_detallesPresupuesto.RowHeadersVisible = false;
            this.dgv_detallesPresupuesto.RowHeadersWidth = 62;
            this.dgv_detallesPresupuesto.RowTemplate.Height = 28;
            this.dgv_detallesPresupuesto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_detallesPresupuesto.Size = new System.Drawing.Size(803, 403);
            this.dgv_detallesPresupuesto.TabIndex = 5;
            this.dgv_detallesPresupuesto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.filaSeleccionada_CellClick);
            this.dgv_detallesPresupuesto.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.filaSeleccionada_DoubleClick);
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.MinimumWidth = 8;
            this.cantidad.Name = "cantidad";
            this.cantidad.Width = 150;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.MinimumWidth = 8;
            this.descripcion.Name = "descripcion";
            this.descripcion.Width = 150;
            // 
            // precio_unitario
            // 
            this.precio_unitario.HeaderText = "Precio Unitario";
            this.precio_unitario.MinimumWidth = 8;
            this.precio_unitario.Name = "precio_unitario";
            this.precio_unitario.Width = 150;
            // 
            // id
            // 
            this.id.HeaderText = "Column1";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.Visible = false;
            this.id.Width = 150;
            // 
            // nuevo_presupuesto_Check
            // 
            this.nuevo_presupuesto_Check.AutoSize = true;
            this.nuevo_presupuesto_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuevo_presupuesto_Check.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nuevo_presupuesto_Check.Location = new System.Drawing.Point(951, 30);
            this.nuevo_presupuesto_Check.Name = "nuevo_presupuesto_Check";
            this.nuevo_presupuesto_Check.Size = new System.Drawing.Size(251, 33);
            this.nuevo_presupuesto_Check.TabIndex = 6;
            this.nuevo_presupuesto_Check.Text = "Nuevo Presupuesto";
            this.nuevo_presupuesto_Check.UseVisualStyleBackColor = true;
            this.nuevo_presupuesto_Check.CheckedChanged += new System.EventHandler(this.nuevoPresupuesto_CheckedChanged);
            // 
            // btn_modificar
            // 
            this.btn_modificar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_modificar.Location = new System.Drawing.Point(1206, 524);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(207, 103);
            this.btn_modificar.TabIndex = 23;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = false;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_eliminar.Location = new System.Drawing.Point(1206, 673);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(207, 103);
            this.btn_eliminar.TabIndex = 22;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_agregar.Location = new System.Drawing.Point(1206, 369);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(207, 103);
            this.btn_agregar.TabIndex = 21;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = false;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descripcion.Location = new System.Drawing.Point(403, 335);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(356, 35);
            this.txt_descripcion.TabIndex = 29;
            // 
            // btn_descripcion
            // 
            this.btn_descripcion.AutoSize = true;
            this.btn_descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_descripcion.Location = new System.Drawing.Point(398, 300);
            this.btn_descripcion.Name = "btn_descripcion";
            this.btn_descripcion.Size = new System.Drawing.Size(147, 29);
            this.btn_descripcion.TabIndex = 28;
            this.btn_descripcion.Text = "Descripción:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(213, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 29);
            this.label3.TabIndex = 27;
            this.label3.Text = "Cantidad:";
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidad.Location = new System.Drawing.Point(218, 335);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(138, 35);
            this.txt_cantidad.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(796, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 29);
            this.label2.TabIndex = 25;
            this.label2.Text = "Precio:";
            // 
            // txt_precioUnitario
            // 
            this.txt_precioUnitario.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_precioUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precioUnitario.Location = new System.Drawing.Point(801, 335);
            this.txt_precioUnitario.Name = "txt_precioUnitario";
            this.txt_precioUnitario.Size = new System.Drawing.Size(136, 35);
            this.txt_precioUnitario.TabIndex = 24;
            // 
            // panel_nuevoPresupuesto
            // 
            this.panel_nuevoPresupuesto.Controls.Add(this.btn_agregarP);
            this.panel_nuevoPresupuesto.Controls.Add(this.label4);
            this.panel_nuevoPresupuesto.Controls.Add(this.txt_nombre_nuevoPresupuesto);
            this.panel_nuevoPresupuesto.Location = new System.Drawing.Point(840, 150);
            this.panel_nuevoPresupuesto.Name = "panel_nuevoPresupuesto";
            this.panel_nuevoPresupuesto.Size = new System.Drawing.Size(700, 129);
            this.panel_nuevoPresupuesto.TabIndex = 30;
            // 
            // btn_agregarP
            // 
            this.btn_agregarP.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_agregarP.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregarP.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_agregarP.Location = new System.Drawing.Point(578, 47);
            this.btn_agregarP.Name = "btn_agregarP";
            this.btn_agregarP.Size = new System.Drawing.Size(49, 44);
            this.btn_agregarP.TabIndex = 7;
            this.btn_agregarP.Text = "+";
            this.btn_agregarP.UseVisualStyleBackColor = false;
            this.btn_agregarP.Click += new System.EventHandler(this.btn_agregarP_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(114, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(354, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nombre del nuevo Presupuesto";
            // 
            // txt_nombre_nuevoPresupuesto
            // 
            this.txt_nombre_nuevoPresupuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre_nuevoPresupuesto.Location = new System.Drawing.Point(111, 48);
            this.txt_nombre_nuevoPresupuesto.Name = "txt_nombre_nuevoPresupuesto";
            this.txt_nombre_nuevoPresupuesto.Size = new System.Drawing.Size(441, 44);
            this.txt_nombre_nuevoPresupuesto.TabIndex = 0;
            this.txt_nombre_nuevoPresupuesto.TextChanged += new System.EventHandler(this.txt_nombrep_TextChanged);
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_imprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_imprimir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_imprimir.Location = new System.Drawing.Point(187, 176);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(207, 103);
            this.btn_imprimir.TabIndex = 31;
            this.btn_imprimir.Text = "Imprimir";
            this.btn_imprimir.UseVisualStyleBackColor = false;
            this.btn_imprimir.Click += new System.EventHandler(this.btn_imprimir_Click);
            // 
            // PantallaPresupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1708, 982);
            this.Controls.Add(this.btn_imprimir);
            this.Controls.Add(this.panel_nuevoPresupuesto);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.btn_descripcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_precioUnitario);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.nuevo_presupuesto_Check);
            this.Controls.Add(this.dgv_detallesPresupuesto);
            this.Controls.Add(this.nombreCliente_ComboBox);
            this.Controls.Add(this.nombrePresupuesto_ComboBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PantallaPresupuesto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pantalla de Presupuestos - PADI";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detallesPresupuesto)).EndInit();
            this.panel_nuevoPresupuesto.ResumeLayout(false);
            this.panel_nuevoPresupuesto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox nombrePresupuesto_ComboBox;
        private System.Windows.Forms.ComboBox nombreCliente_ComboBox;
        private System.Windows.Forms.DataGridView dgv_detallesPresupuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.CheckBox nuevo_presupuesto_Check;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Label btn_descripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_precioUnitario;
        private System.Windows.Forms.Panel panel_nuevoPresupuesto;
        private System.Windows.Forms.TextBox txt_nombre_nuevoPresupuesto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_agregarP;
        private System.Windows.Forms.Button btn_imprimir;
    }
}