﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVEntas.Modelos
{
    internal class usuarioRol
    {
        public int IdUsuarioRol { get; set; }
        public string IdUsuario { get; set; }
        public string IdRol { get; set; }
        public DateTime FechaAsigna { get; set; }
        public string Estado { get; set; }
    }
}
