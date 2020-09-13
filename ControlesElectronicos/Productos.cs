using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlesElectronicos
{
    public class Productos
    {
        public List<Producto> MisProductos { set; get; }
       public Productos()
        {
            MisProductos = new List<Producto>();
        }
        public void Ingresar(Producto producto)
        {
            MisProductos.Add(producto);
        }
    }
}
