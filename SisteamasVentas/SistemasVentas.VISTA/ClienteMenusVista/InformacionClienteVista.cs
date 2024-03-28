using SistemasVentas.BSS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.ClienteMenusVista
{
    public partial class InformacionClienteVista : Form
    {
        public InformacionClienteVista()
        {
            InitializeComponent();
        }
        ClienteBSS bss = new ClienteBSS();
       

        private void InformacionClienteVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarClienteBss();
        }
    }
}
