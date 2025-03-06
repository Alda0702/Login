using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class FormLogin : Form
    {

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnOk_Click_2(object sender, EventArgs e)
        {

            string user = txtUser.Text;
            string paswword = txtPsw.Text;

            if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(paswword))
            {
                MessageBox.Show("Ningún campo puede estar vacío");

            }
            if (user == "Alda07" && paswword == "alda07")
            {
                MessageBox.Show("Inicio exitoso");
                Bienvenido acce = new Bienvenido();
                acce.lblUsuario.Text = txtUser.Text;
                acce.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectas");
            }

        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
