namespace ControlesElectronicos
{
	partial class MundoCelular
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MundoCelular));
			this.lblTitulo = new System.Windows.Forms.Label();
			this.lblMarcaCelulares = new System.Windows.Forms.Label();
			this.cmbCelulares = new System.Windows.Forms.ComboBox();
			this.lblDispositivo = new System.Windows.Forms.Label();
			this.lbHuawei = new System.Windows.Forms.ListBox();
			this.lbiPhone = new System.Windows.Forms.ListBox();
			this.lbSamsung = new System.Windows.Forms.ListBox();
			this.lblDatos = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtCedula = new System.Windows.Forms.TextBox();
			this.picNormal = new System.Windows.Forms.PictureBox();
			this.picPro = new System.Windows.Forms.PictureBox();
			this.chkComprar = new System.Windows.Forms.CheckBox();
			this.chkComprar1 = new System.Windows.Forms.CheckBox();
			this.btnComprar = new System.Windows.Forms.Button();
			this.lstProductos = new System.Windows.Forms.ListView();
			this.Productos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.button1 = new System.Windows.Forms.Button();
			this.mtxtNombre = new System.Windows.Forms.MaskedTextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnPedido = new System.Windows.Forms.Button();
			this.pnlDatos = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.picNormal)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picPro)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.pnlDatos.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblTitulo
			// 
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
			this.lblTitulo.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.lblTitulo.Location = new System.Drawing.Point(316, 37);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(349, 38);
			this.lblTitulo.TabIndex = 1;
			this.lblTitulo.Text = "MUNDO CELULAR";
			// 
			// lblMarcaCelulares
			// 
			this.lblMarcaCelulares.AutoSize = true;
			this.lblMarcaCelulares.BackColor = System.Drawing.Color.Transparent;
			this.lblMarcaCelulares.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMarcaCelulares.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblMarcaCelulares.Location = new System.Drawing.Point(167, 117);
			this.lblMarcaCelulares.Name = "lblMarcaCelulares";
			this.lblMarcaCelulares.Size = new System.Drawing.Size(60, 23);
			this.lblMarcaCelulares.TabIndex = 4;
			this.lblMarcaCelulares.Text = "Marca : ";
			// 
			// cmbCelulares
			// 
			this.cmbCelulares.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbCelulares.FormattingEnabled = true;
			this.cmbCelulares.Items.AddRange(new object[] {
            "Huawei",
            "iPhone",
            "Samsung"});
			this.cmbCelulares.Location = new System.Drawing.Point(233, 121);
			this.cmbCelulares.Name = "cmbCelulares";
			this.cmbCelulares.Size = new System.Drawing.Size(121, 21);
			this.cmbCelulares.TabIndex = 1;
			this.cmbCelulares.SelectedIndexChanged += new System.EventHandler(this.cmbCelulares_SelectedIndexChanged);
			// 
			// lblDispositivo
			// 
			this.lblDispositivo.AutoSize = true;
			this.lblDispositivo.BackColor = System.Drawing.Color.Transparent;
			this.lblDispositivo.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDispositivo.ForeColor = System.Drawing.Color.Black;
			this.lblDispositivo.Location = new System.Drawing.Point(167, 170);
			this.lblDispositivo.Name = "lblDispositivo";
			this.lblDispositivo.Size = new System.Drawing.Size(90, 23);
			this.lblDispositivo.TabIndex = 2;
			this.lblDispositivo.Text = "Dispositivo : ";
			// 
			// lbHuawei
			// 
			this.lbHuawei.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbHuawei.FormattingEnabled = true;
			this.lbHuawei.ItemHeight = 16;
			this.lbHuawei.Items.AddRange(new object[] {
            "HUAWEI Mate 20",
            "HUAWEI Mate 10",
            "HUAWEI Y9"});
			this.lbHuawei.Location = new System.Drawing.Point(252, 159);
			this.lbHuawei.Name = "lbHuawei";
			this.lbHuawei.Size = new System.Drawing.Size(126, 36);
			this.lbHuawei.TabIndex = 2;
			this.lbHuawei.Visible = false;
			this.lbHuawei.SelectedIndexChanged += new System.EventHandler(this.lbHuawei_SelectedIndexChanged);
			// 
			// lbiPhone
			// 
			this.lbiPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbiPhone.FormattingEnabled = true;
			this.lbiPhone.ItemHeight = 16;
			this.lbiPhone.Items.AddRange(new object[] {
            "iPhone 11",
            "iPhone X",
            "iPhone 8"});
			this.lbiPhone.Location = new System.Drawing.Point(252, 159);
			this.lbiPhone.Name = "lbiPhone";
			this.lbiPhone.Size = new System.Drawing.Size(126, 36);
			this.lbiPhone.TabIndex = 2;
			this.lbiPhone.Visible = false;
			this.lbiPhone.SelectedIndexChanged += new System.EventHandler(this.lbiPhone_SelectedIndexChanged);
			// 
			// lbSamsung
			// 
			this.lbSamsung.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbSamsung.FormattingEnabled = true;
			this.lbSamsung.ItemHeight = 16;
			this.lbSamsung.Items.AddRange(new object[] {
            "Samsung Galaxy S20",
            "Samsung Galaxy A50",
            "Samsung Galaxy S10"});
			this.lbSamsung.Location = new System.Drawing.Point(252, 157);
			this.lbSamsung.Name = "lbSamsung";
			this.lbSamsung.Size = new System.Drawing.Size(170, 36);
			this.lbSamsung.TabIndex = 2;
			this.lbSamsung.Visible = false;
			this.lbSamsung.SelectedIndexChanged += new System.EventHandler(this.lbSamsung_SelectedIndexChanged);
			// 
			// lblDatos
			// 
			this.lblDatos.AutoSize = true;
			this.lblDatos.BackColor = System.Drawing.Color.Transparent;
			this.lblDatos.Font = new System.Drawing.Font("Sitka Banner", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDatos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lblDatos.Location = new System.Drawing.Point(73, 8);
			this.lblDatos.Name = "lblDatos";
			this.lblDatos.Size = new System.Drawing.Size(111, 21);
			this.lblDatos.TabIndex = 8;
			this.lblDatos.Text = "Datos Comprador";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Sitka Banner", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label1.Location = new System.Drawing.Point(37, 74);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 21);
			this.label1.TabIndex = 9;
			this.label1.Text = "Cédula :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Sitka Banner", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label2.Location = new System.Drawing.Point(37, 42);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 21);
			this.label2.TabIndex = 10;
			this.label2.Text = "Nombre : ";
			// 
			// txtCedula
			// 
			this.txtCedula.Location = new System.Drawing.Point(110, 77);
			this.txtCedula.Name = "txtCedula";
			this.txtCedula.Size = new System.Drawing.Size(100, 20);
			this.txtCedula.TabIndex = 4;
			// 
			// picNormal
			// 
			this.picNormal.BackColor = System.Drawing.Color.Transparent;
			this.picNormal.Image = ((System.Drawing.Image)(resources.GetObject("picNormal.Image")));
			this.picNormal.InitialImage = null;
			this.picNormal.Location = new System.Drawing.Point(23, 250);
			this.picNormal.Name = "picNormal";
			this.picNormal.Size = new System.Drawing.Size(237, 256);
			this.picNormal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picNormal.TabIndex = 13;
			this.picNormal.TabStop = false;
			// 
			// picPro
			// 
			this.picPro.BackColor = System.Drawing.Color.Transparent;
			this.picPro.Image = ((System.Drawing.Image)(resources.GetObject("picPro.Image")));
			this.picPro.InitialImage = null;
			this.picPro.Location = new System.Drawing.Point(308, 250);
			this.picPro.Name = "picPro";
			this.picPro.Size = new System.Drawing.Size(235, 256);
			this.picPro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picPro.TabIndex = 14;
			this.picPro.TabStop = false;
			// 
			// chkComprar
			// 
			this.chkComprar.AutoSize = true;
			this.chkComprar.Location = new System.Drawing.Point(101, 532);
			this.chkComprar.Name = "chkComprar";
			this.chkComprar.Size = new System.Drawing.Size(65, 17);
			this.chkComprar.TabIndex = 5;
			this.chkComprar.Text = "Comprar";
			this.chkComprar.UseVisualStyleBackColor = true;
			// 
			// chkComprar1
			// 
			this.chkComprar1.AutoSize = true;
			this.chkComprar1.Location = new System.Drawing.Point(373, 532);
			this.chkComprar1.Name = "chkComprar1";
			this.chkComprar1.Size = new System.Drawing.Size(65, 17);
			this.chkComprar1.TabIndex = 6;
			this.chkComprar1.Text = "Comprar";
			this.chkComprar1.UseVisualStyleBackColor = true;
			// 
			// btnComprar
			// 
			this.btnComprar.Location = new System.Drawing.Point(233, 539);
			this.btnComprar.Name = "btnComprar";
			this.btnComprar.Size = new System.Drawing.Size(75, 42);
			this.btnComprar.TabIndex = 7;
			this.btnComprar.Text = "Llevar al carrito";
			this.btnComprar.UseVisualStyleBackColor = true;
			this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
			// 
			// lstProductos
			// 
			this.lstProductos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Productos});
			this.lstProductos.HideSelection = false;
			this.lstProductos.Location = new System.Drawing.Point(602, 236);
			this.lstProductos.Name = "lstProductos";
			this.lstProductos.Size = new System.Drawing.Size(201, 270);
			this.lstProductos.TabIndex = 18;
			this.lstProductos.UseCompatibleStateImageBehavior = false;
			this.lstProductos.View = System.Windows.Forms.View.Details;
			// 
			// Productos
			// 
			this.Productos.Text = "Productos Comprados";
			this.Productos.Width = 99;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(729, 539);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(74, 23);
			this.button1.TabIndex = 19;
			this.button1.Text = "Quitar ";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.btnQuitar_Click);
			// 
			// mtxtNombre
			// 
			this.mtxtNombre.Location = new System.Drawing.Point(110, 42);
			this.mtxtNombre.Mask = "LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL";
			this.mtxtNombre.Name = "mtxtNombre";
			this.mtxtNombre.PromptChar = ' ';
			this.mtxtNombre.Size = new System.Drawing.Size(100, 20);
			this.mtxtNombre.TabIndex = 3;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(221, 11);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(89, 73);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 20;
			this.pictureBox1.TabStop = false;
			// 
			// btnPedido
			// 
			this.btnPedido.Location = new System.Drawing.Point(582, 532);
			this.btnPedido.Name = "btnPedido";
			this.btnPedido.Size = new System.Drawing.Size(74, 36);
			this.btnPedido.TabIndex = 21;
			this.btnPedido.Text = "Realizar pedido";
			this.btnPedido.UseVisualStyleBackColor = true;
			this.btnPedido.Click += new System.EventHandler(this.btnPedido_Click);
			// 
			// pnlDatos
			// 
			this.pnlDatos.Controls.Add(this.lblDatos);
			this.pnlDatos.Controls.Add(this.label1);
			this.pnlDatos.Controls.Add(this.label2);
			this.pnlDatos.Controls.Add(this.txtCedula);
			this.pnlDatos.Controls.Add(this.mtxtNombre);
			this.pnlDatos.Location = new System.Drawing.Point(576, 93);
			this.pnlDatos.Name = "pnlDatos";
			this.pnlDatos.Size = new System.Drawing.Size(247, 121);
			this.pnlDatos.TabIndex = 22;
			this.pnlDatos.Visible = false;
			// 
			// MundoCelular
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(848, 596);
			this.Controls.Add(this.pnlDatos);
			this.Controls.Add(this.btnPedido);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.lstProductos);
			this.Controls.Add(this.btnComprar);
			this.Controls.Add(this.chkComprar1);
			this.Controls.Add(this.chkComprar);
			this.Controls.Add(this.picPro);
			this.Controls.Add(this.picNormal);
			this.Controls.Add(this.lbSamsung);
			this.Controls.Add(this.lbiPhone);
			this.Controls.Add(this.cmbCelulares);
			this.Controls.Add(this.lblMarcaCelulares);
			this.Controls.Add(this.lbHuawei);
			this.Controls.Add(this.lblDispositivo);
			this.Controls.Add(this.lblTitulo);
			this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.MaximizeBox = false;
			this.Name = "MundoCelular";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Mundo Celular";
			((System.ComponentModel.ISupportInitialize)(this.picNormal)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picPro)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.pnlDatos.ResumeLayout(false);
			this.pnlDatos.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.Label lblMarcaCelulares;
		private System.Windows.Forms.ComboBox cmbCelulares;
		private System.Windows.Forms.Label lblDispositivo;
		private System.Windows.Forms.ListBox lbHuawei;
		private System.Windows.Forms.ListBox lbiPhone;
		private System.Windows.Forms.ListBox lbSamsung;
		private System.Windows.Forms.Label lblDatos;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtCedula;
		private System.Windows.Forms.PictureBox picNormal;
		private System.Windows.Forms.PictureBox picPro;
		private System.Windows.Forms.CheckBox chkComprar;
		private System.Windows.Forms.CheckBox chkComprar1;
		private System.Windows.Forms.Button btnComprar;
		private System.Windows.Forms.ListView lstProductos;
		private System.Windows.Forms.ColumnHeader Productos;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.MaskedTextBox mtxtNombre;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btnPedido;
		private System.Windows.Forms.Panel pnlDatos;
	}
}

