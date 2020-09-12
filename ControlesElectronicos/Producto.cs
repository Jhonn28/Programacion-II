using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlesElectronicos
{
    public class Producto
    {
        public string Producto { set; get; }

        public Producto()
        {
        }

        public Producto(string nombreP)
        {
            NombreP = nombreP;
        }
    }
}
