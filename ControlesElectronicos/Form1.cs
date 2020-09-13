using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Freddy Alverca
namespace ControlesElectronicos
{
    public partial class MundoCelular : Form
    {
        Productos productos = new Productos();
        public MundoCelular()
        {
            InitializeComponent();
        }

        private void cmbCelulares_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCelulares.SelectedItem.Equals("Huawei"))
            {
                lbiPhone.Visible = false;
                lbSamsung.Visible = false;
                lbHuawei.Visible = true;
            }
            if (cmbCelulares.SelectedItem.Equals("iPhone"))
            {
                lbiPhone.Visible = true;
                lbSamsung.Visible = false;
                lbHuawei.Visible = false;
            }
            if (cmbCelulares.SelectedItem.Equals("Samsung"))
            {
                lbiPhone.Visible = false;
                lbSamsung.Visible = true;
                lbHuawei.Visible = false;
            }
        }

        private void lbHuawei_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbHuawei.SelectedItem.Equals("HUAWEI Mate 20"))
            {
                Image miImagen = Image.FromFile("mate20.png");
                Image mio = Image.FromFile("mate20pro.png");

                picNormal.Image = miImagen;
                picPro.Image = mio;

                chkComprar.Checked = false;
                chkComprar1.Checked = false;
            }
            if (lbHuawei.SelectedItem.Equals("HUAWEI Mate 10"))
            {
                Image miImagen = Image.FromFile("mate10.png");
                Image mio = Image.FromFile("mate10pro.png");

                picNormal.Image = miImagen;
                picPro.Image = mio;

                chkComprar.Checked = false;
                chkComprar1.Checked = false;
            }
            if (lbHuawei.SelectedItem.Equals("HUAWEI Y9"))
            {
                Image miImagen = Image.FromFile("y9-prime-2019.png");
                Image mio = Image.FromFile("y9-2018.png");

                picNormal.Image = miImagen;
                picPro.Image = mio;

                chkComprar.Checked = false;
                chkComprar1.Checked = false;
            }
        }
        private void lbSamsung_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbSamsung.SelectedItem.Equals("Samsung Galaxy S20"))
            {
                Image miImagen = Image.FromFile("s20.jpg");
                Image mio = Image.FromFile("s20ultra.jpg");

                picNormal.Image = miImagen;
                picPro.Image = mio;

                chkComprar.Checked = false;
                chkComprar1.Checked = false;
            }
            if (lbSamsung.SelectedItem.Equals("Samsung Galaxy A50"))
            {
                Image miImagen = Image.FromFile("a50.jpg");
                Image mio = Image.FromFile("a50s.jpg");

                picNormal.Image = miImagen;
                picPro.Image = mio;

                chkComprar.Checked = false;
                chkComprar1.Checked = false;
            }
            if (lbSamsung.SelectedItem.Equals("Samsung Galaxy S10"))
            {
                Image miImagen = Image.FromFile("s10.jpg");
                Image mio = Image.FromFile("s10plus.jpg");

                picNormal.Image = miImagen;
                picPro.Image = mio;

                chkComprar.Checked = false;
                chkComprar1.Checked = false;
            }
        }

        private void lbiPhone_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbiPhone.SelectedItem.Equals("iPhone 11"))
            {
                Image miImagen = Image.FromFile("11pro.jpg");
                Image mio = Image.FromFile("11promax.jpg");

                picNormal.Image = miImagen;
                picPro.Image = mio;
                chkComprar.Checked = false;
                chkComprar1.Checked = false;
            }
            if (lbiPhone.SelectedItem.Equals("iPhone X"))
            {
                Image miImagen = Image.FromFile("xpro.jpg");
                Image mio = Image.FromFile("xpromax.jpg");

                picNormal.Image = miImagen;
                picPro.Image = mio;
                chkComprar.Checked = false;
                chkComprar1.Checked = false;
            }
            if (lbiPhone.SelectedItem.Equals("iPhone 8"))
            {
                Image miImagen = Image.FromFile("i8.jpg");
                Image mio = Image.FromFile("i8plus.jpg");

                picNormal.Image = miImagen;
                picPro.Image = mio;
                chkComprar.Checked = false;
                chkComprar1.Checked = false;
            }
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {

            try
            {
                if (Control() == true)
                {
                    MessageBox.Show("Producto en el carrito");

                    pnlDatos.Visible = true;

                    Producto producto = new Producto();

                    if (cmbCelulares.SelectedItem.Equals("Huawei"))
                    {
                        lstProductos.Items.Add(lbHuawei.Text);
                        producto.Pedido = lbHuawei.Text;
                    }
                    if (cmbCelulares.SelectedItem.Equals("iPhone"))
                    {
                        lstProductos.Items.Add(lbiPhone.Text);
                        producto.Pedido = lbiPhone.Text;
                    }
                    if (cmbCelulares.SelectedItem.Equals("Samsung"))
                    {
                        lstProductos.Items.Add(lbSamsung.Text);
                        producto.Pedido = lbSamsung.Text;
                    }
                    productos.Ingresar(producto);
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Seleccione un producto :)");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            if (mtxtNombre.Text != "" && txtCedula.Text != "")
            {
                this.Hide();

                PedidoRealizado pedidoRealizado = new PedidoRealizado();

                pedidoRealizado.Show();
                pedidoRealizado.lblCliente.Text = "Cliente: " + mtxtNombre.Text;

                pedidoRealizado.lblCedula.Text = "Cédula: " + txtCedula.Text;

                pedidoRealizado.dgvMostrar.DataSource = null;
                pedidoRealizado.dgvMostrar.DataSource = productos.MisProductos;
            }
            else
            {
                MessageBox.Show("Ingrese Datos del Comprador");
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lstProductos.SelectedItems)
            {
                item.Remove();
            }
        }

        public bool Control()
        {
            bool aux = false;
            if ((chkComprar.Checked != false || chkComprar1.Checked != false) && (lbiPhone.Text != " " || lbHuawei.Text != " " || lbSamsung.Text != " "))
            {
                aux = true;
            }
            return aux;
        }

        public void Limpiar()
        {
            mtxtNombre.Clear();
            txtCedula.Clear();
            chkComprar.Checked = false;
            chkComprar1.Checked = false;
        }
    }
}