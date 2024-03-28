using SistemasVentas.DAL;
using SistemasVentas.VISTA.Menu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.InicioVistas
{
    public partial class IniciodesesionVista : Form
    {
        public IniciodesesionVista()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string usuario = textBox1.Text;
            string contraseña = textBox2.Text;

            if (conexion.VerificarCredenciales(usuario, contraseña))
            {
                MessageBox.Show("Inicio de sesion exitoso");
                MenuCogerenteVista formulario = new MenuCogerenteVista();
                formulario.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }
    }
}
