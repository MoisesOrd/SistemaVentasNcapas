using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVEntas.Modelos
{
    internal class Venta
    {
        public int IdVenta { get; set; }
        public string IdCliente { get; set; }
        public string IdVendedor { get; set; }
        public DateTime Fecha { get; set; }
        public string Total { get; set; }
        public string Estado { get; set; }
    }
}
