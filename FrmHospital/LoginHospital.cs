using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmHospital
{
    public partial class LoginHospital : Form
    {
        public LoginHospital()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (tbxUsuario.Text != "" && tbxContraseña.Text != "")
            {
                if (tbxUsuario.Text == "Administrador" && tbxContraseña.Text == "admin")
                {
                    Form1 frm = new Form1();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("EL USUARIO O LA CONTRASEÑA SON INCORRECTOS", "AVISO: ");
                    this.tbxContraseña.Focus();
                }
            }
            else
            {
                if (tbxUsuario.Text != "" && tbxContraseña.Text != "")
                {
                    if (tbxUsuario.Text == "Trabajador" && tbxContraseña.Text == "hola123")
                    {
                        Form1 frm = new Form1();
                        frm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("EL USUARIO O LA CONTRASEÑA SON INCORRECTOS", "AVISO: ");
                        this.tbxContraseña.Focus();
                    }
                }
                else
                    MessageBox.Show("INGRESE USUARIO Y CONTRASEÑA CORRECTA", "AVISO: ");

            }
        }

        private void p(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
