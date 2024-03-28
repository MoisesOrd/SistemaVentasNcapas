﻿using SistemasVentas.BSS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.VentasVistasCajero
{
    public partial class VentasCajeroVistas : Form
    {
        public VentasCajeroVistas()
        {
            InitializeComponent();
        }

        VentaBSS bss = new VentaBSS();
        private void VentasCajeroVistas_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarVentaBss();
        }
    }
}
    