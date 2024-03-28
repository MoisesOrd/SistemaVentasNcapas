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

namespace SistemasVentas.VISTA.Menu_Proveedor
{
    public partial class MenuProveedorVista : Form
    {
        public MenuProveedorVista()
        {
            InitializeComponent();
        }
        ProveedorBSS bss = new ProveedorBSS();
        private void MenuProveedorVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarProveedorBss();
        }
    }
}
