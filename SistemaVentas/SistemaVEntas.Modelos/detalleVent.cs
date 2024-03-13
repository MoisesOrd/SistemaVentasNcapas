using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVEntas.Modelos
{
    internal class detalleVent
    {
        public int IdDetalleVenta{ get; set; }
        public int IdVenta { get; set; }
        public int IdProducto { get; set; }
        public int cantidad { get; set; }
        public Decimal precioVenta { get; set; }
        public Decimal subTotal { get; set; }
        public string Estado { get; set; }
    }
}
