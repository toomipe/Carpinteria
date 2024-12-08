namespace Carpinteria
{
    partial class PantallaPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaPrincipal));
            this.btn_presupuestos = new System.Windows.Forms.Button();
            this.btn_clientes = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_presupuestos
            // 
            this.btn_presupuestos.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_presupuestos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_presupuestos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_presupuestos.Location = new System.Drawing.Point(1224, 252);
            this.btn_presupuestos.Name = "btn_presupuestos";
            this.btn_presupuestos.Size = new System.Drawing.Size(308, 121);
            this.btn_presupuestos.TabIndex = 0;
            this.btn_presupuestos.Text = "Presupuestos";
            this.btn_presupuestos.UseVisualStyleBackColor = false;
            this.btn_presupuestos.Click += new System.EventHandler(this.btn_presupuestos_Click);
            // 
            // btn_clientes
            // 
            this.btn_clientes.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clientes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_clientes.Location = new System.Drawing.Point(1224, 523);
            this.btn_clientes.Name = "btn_clientes";
            this.btn_clientes.Size = new System.Drawing.Size(308, 121);
            this.btn_clientes.TabIndex = 1;
            this.btn_clientes.Text = "Clientes";
            this.btn_clientes.UseVisualStyleBackColor = false;
            this.btn_clientes.Click += new System.EventHandler(this.btn_clientes_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Carpinteria.Properties.Resources.PADI;
            this.pictureBox1.Location = new System.Drawing.Point(44, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1089, 851);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // PantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1708, 975);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_clientes);
            this.Controls.Add(this.btn_presupuestos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PantallaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pantalla Principal - PADI";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_presupuestos;
        private System.Windows.Forms.Button btn_clientes;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

