using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlesElectronicos
{
    public class Compra
    {
        public string Nombre { set; get; }
        public string Cedula { set; get; }

        public Compra()
        {
        }

        public Compra(string nombre, string cedula, int comprar)
        {
            Nombre = nombre;
            Cedula = cedula;
        }
    }
}
