namespace ControlesElectronicos
{
    partial class PedidoRealizado
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
			this.lblDatos = new System.Windows.Forms.Label();
			this.lblCliente = new System.Windows.Forms.Label();
			this.lblCedula = new System.Windows.Forms.Label();
			this.lblPProductos = new System.Windows.Forms.Label();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnEnviar = new System.Windows.Forms.Button();
			this.dgvMostrar = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).BeginInit();
			this.SuspendLayout();
			// 
			// lblDatos
			// 
			this.lblDatos.AutoSize = true;
			this.lblDatos.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDatos.Location = new System.Drawing.Point(17, 11);
			this.lblDatos.Name = "lblDatos";
			this.lblDatos.Size = new System.Drawing.Size(181, 28);
			this.lblDatos.TabIndex = 0;
			this.lblDatos.Text = "Datos del Comprador:";
			// 
			// lblCliente
			// 
			this.lblCliente.AutoSize = true;
			this.lblCliente.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCliente.Location = new System.Drawing.Point(19, 49);
			this.lblCliente.Name = "lblCliente";
			this.lblCliente.Size = new System.Drawing.Size(0, 23);
			this.lblCliente.TabIndex = 1;
			// 
			// lblCedula
			// 
			this.lblCedula.AutoSize = true;
			this.lblCedula.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCedula.Location = new System.Drawing.Point(18, 89);
			this.lblCedula.Name = "lblCedula";
			this.lblCedula.Size = new System.Drawing.Size(0, 23);
			this.lblCedula.TabIndex = 2;
			// 
			// lblPProductos
			// 
			this.lblPProductos.AutoSize = true;
			this.lblPProductos.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPProductos.Location = new System.Drawing.Point(17, 119);
			this.lblPProductos.Name = "lblPProductos";
			this.lblPProductos.Size = new System.Drawing.Size(158, 28);
			this.lblPProductos.TabIndex = 4;
			this.lblPProductos.Text = "Productos a pedir: ";
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(23, 358);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(75, 23);
			this.btnCancelar.TabIndex = 6;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// btnEnviar
			// 
			this.btnEnviar.Location = new System.Drawing.Point(198, 363);
			this.btnEnviar.Name = "btnEnviar";
			this.btnEnviar.Size = new System.Drawing.Size(75, 23);
			this.btnEnviar.TabIndex = 8;
			this.btnEnviar.Text = "Enviar";
			this.btnEnviar.UseVisualStyleBackColor = true;
			this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
			// 
			// dgvMostrar
			// 
			this.dgvMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvMostrar.Location = new System.Drawing.Point(66, 156);
			this.dgvMostrar.Name = "dgvMostrar";
			this.dgvMostrar.Size = new System.Drawing.Size(178, 196);
			this.dgvMostrar.TabIndex = 9;
			// 
			// PedidoRealizado
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(294, 401);
			this.Controls.Add(this.dgvMostrar);
			this.Controls.Add(this.btnEnviar);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.lblPProductos);
			this.Controls.Add(this.lblCedula);
			this.Controls.Add(this.lblCliente);
			this.Controls.Add(this.lblDatos);
			this.MaximizeBox = false;
			this.Name = "PedidoRealizado";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "PedidoRealizado";
			this.Load += new System.EventHandler(this.PedidoRealizado_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDatos;
        public System.Windows.Forms.Label lblCliente;
        public System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Label lblPProductos;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEnviar;
        public System.Windows.Forms.DataGridView dgvMostrar;
    }
}