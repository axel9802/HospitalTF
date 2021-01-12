using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Entidades;

namespace FrmHospital
{
    public partial class FrmCitaMedica : Form
    {
        DataTable directorio = new DataTable();
        nCitaMedica gCita = new nCitaMedica();
        public FrmCitaMedica()
        {
            InitializeComponent();
            MostrarCitaMedica();
            directorio.Columns.Add("NOMBRE");
            directorio.Columns.Add("APELLIDO");
            directorio.Columns.Add("DNI");
            directorio.Columns.Add("TELEFONO");
        }
        private void MostrarCitaMedica()
        {
            dgCitaMedica.DataSource = directorio;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "" && txtPrecio.Text != "" && txtDescripcion.Text != "" && DateTime.Text != "" )
            {
                directorio.Rows.Add(new object[] { txtCodigo.Text, txtPrecio.Text, txtDescripcion.Text, DateTime.Text });
                MostrarCitaMedica();
                txtCodigo.Clear();
                txtPrecio.Clear();
                txtDescripcion.Clear();
            }
            else
                MessageBox.Show("Por favor debe completar todos los datos");
            txtCodigo.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
