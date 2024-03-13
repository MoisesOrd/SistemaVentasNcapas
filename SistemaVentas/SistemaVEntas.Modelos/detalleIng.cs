using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVEntas.Modelos
{
    internal class detalleIng
    {
        public int IdDetalleIng { get; set; }
        public string IdIngreso { get; set; }
        public string IdProducto { get; set; }
        public DateTime FechaVenc { get; set; }
        public string Cantidad { get; set; }
        public Decimal PrecioCosto { get; set; }
        public Decimal PrecioVenta { get; set; }
        public Decimal SubTotal { get; set; }
        public string Estado { get; set; }
    }
}
