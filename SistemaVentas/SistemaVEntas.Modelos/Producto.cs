using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVEntas.Modelos
{
    internal class Producto
    {
        public int IdProducto { get; set; }
        public string IdTipoProducto { get; set; }
        public string Nombre { get; set; }
        public string CodigoBarra { get; set; }
        public string IdMarca { get; set; }
        public string Unidad { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set;}
    }
}
