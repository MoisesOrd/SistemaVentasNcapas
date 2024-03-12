using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVEntas.Modelos
{
    internal class detalleIng
    {
        public int idetalleIng { get; set; }
        public string idingreso { get; set; }
        public string idProducto { get; set; }
        public string fechaVenc { get; set; }
        public string cantidad { get; set; }
        public string precioCosto { get; set; }
        public string precioVenta { get; set; }
        public int subTotal { get; set; }
        public string Estado { get; set; }
    }
}
