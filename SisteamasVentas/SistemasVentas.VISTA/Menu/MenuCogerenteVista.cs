using SistemasVentas.VISTA.VentasVistasCajero;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.Menu
{
    public partial class MenuCogerenteVista : Form
    {
        public MenuCogerenteVista()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Ventas
            VentasCajeroVistas formulario = new VentasCajeroVistas();
            formulario.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Clientes
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Productos
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Proveedores
        }
    }
}
