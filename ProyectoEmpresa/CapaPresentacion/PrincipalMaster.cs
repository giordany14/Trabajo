using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class PrincipalMaster : Form
    {
        public PrincipalMaster()
        {
            InitializeComponent();
        }

        private void PrincipalMaster_Load(object sender, EventArgs e)
        {
            ActualizarInfo.Hide();
        }

        private void CerrarSesión_Click(object sender, EventArgs e)
        {
            this.Close();
            Login lg = new Login();
            lg.Show();
        }


        private void txtCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
            Login lg = new Login();
            lg.Show();
        }

        private void EditarInfo_Click(object sender, EventArgs e)
        {

            tabControlFunciones.Hide();
            ActualizarInfo.Show();
            panelNavar.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            ActualizarInfo.Hide();
            tabControlFunciones.Show();
            panelNavar.Show();
        }
    }
}
