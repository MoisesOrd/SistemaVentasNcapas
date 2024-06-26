﻿using SistemasVentas.VISTA.InterfazGerenteVista;
using SistemasVentas.VISTA.InterfazInicioSesionVista;
using SistemasVentas.VISTA.ProductoVistas;
using SistemasVentas.VISTA.ProveedorVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.InterfazSupervisorVista
{
    public partial class InterfazSupervisorMenu : Form
    {
        public InterfazSupervisorMenu()
        {
            InitializeComponent();
        }
        private void AbrirFormHija(Object FormHija)
        {
            if (this.panel3.Controls.Count > 0)
                this.panel3.Controls.RemoveAt(0);
            Form fh = FormHija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(fh);
            this.panel3.Tag = fh;
            fh.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new ProductoInterfazSupervisor());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new ProveedorInterfazSupervisor());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Esta seguro que desea cerrar la sesion?", "CERRAR SESION", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                InterfazinicioSesionMenu abrir = new InterfazinicioSesionMenu();
                abrir.Show();
                this.Hide();
            }
        }



    }
}
