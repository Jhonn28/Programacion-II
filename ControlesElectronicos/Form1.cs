using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlesElectronicos
{
    public partial class Form1 : Form
    {
        List<Compra> Compras = new List<Compra>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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

        private void lbDispositivo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbHuawei.SelectedItem.Equals("HUAWEI Mate 20"))
            {
                Image miImagen = Image.FromFile("mate20.png");
                Image mio = Image.FromFile("mate20pro.png");
                //IMAGENES
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
          
            try
            {
                if (Control())
                {
                    MessageBox.Show("Producto en el carrito+");
                    //Muestra en la lista el objeto ingresado
                    ListViewItem item =  new ListViewItem();

                    if (cmbCelulares.SelectedItem.Equals("Huawei"))
                    {
                        item = lstProductos.Items.Add(lbHuawei.Text);
                        
                    }
                    if (cmbCelulares.SelectedItem.Equals("iPhone"))
                    {
                        item = lstProductos.Items.Add(lbiPhone.Text);
                    }
                    if (cmbCelulares.SelectedItem.Equals("Samsung"))
                    {
                        item = lstProductos.Items.Add(lbSamsung.Text);
                    }
          
                }
                else
                {
                    MessageBox.Show("Selecciones producto :)");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
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

  
        public void limpiar()
        {
            mtxtNombre.Clear();
            txtCedula.Clear();
            chkComprar.Checked = false;
            chkComprar1.Checked = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            foreach(ListViewItem item in lstProductos.SelectedItems)
            {
                item.Remove();
            }
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            if(mtxtNombre.Text != "" && txtCedula.Text != "")
            {
                Compra cliente = new Compra();

                cliente.Nombre = mtxtNombre.Text;
                cliente.Cedula = txtCedula.Text;
                Compras.Add(cliente);
                MessageBox.Show("compra realizada");
                limpiar();
                PedidoRealizado pedidoRealizado = new PedidoRealizado();
                pedidoRealizado.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Ingrese Datos del Comprador");
            }
		}
    }
}
