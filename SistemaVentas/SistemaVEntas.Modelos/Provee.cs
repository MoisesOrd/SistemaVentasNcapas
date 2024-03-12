using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVEntas.Modelos
{
    internal class Provee
    {
        public int IdProvee { get; set; }
        public string IdProveedor { get; set; }
        public string IdProducto { get; set; }
        public DateTime Fecha { get; set; }
        public string Precio { get; set; }
    }
}
