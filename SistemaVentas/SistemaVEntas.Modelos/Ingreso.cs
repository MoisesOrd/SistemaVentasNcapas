using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVEntas.Modelos
{
    internal class Ingreso
    {
        public int IdIngreso { get; set; }
        public string IdProveedor { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string Total { get; set; }
        public string Estado { get; set; }
    }
}
