using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVEntas.Modelos
{
    internal class detalleVent
    {
        public int idetalleVent { get; set; }
        public string idVenta { get; set; }
        public string idProducto { get; set; }
        public string cantidad { get; set; }
        public string precioVenta { get; set; }
        public string subTotal { get; set; }
        public string Estado { get; set; }
    }
}
