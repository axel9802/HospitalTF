using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocio;

namespace FrmHospital
{
    public partial class FrmDoctor : Form
    {
        nDoctor nd = new nDoctor();
        DataTable directorio = new DataTable();
        public FrmDoctor()
        {
            InitializeComponent();
            MostrarDoctores();
            directorio.Columns.Add("NOMBRE");
            directorio.Columns.Add("APELLIDO");
            directorio.Columns.Add("DNI");
            directorio.Columns.Add("EDAD");
            directorio.Columns.Add("TELEFONO");
            directorio.Columns.Add("SEXO");
            directorio.Columns.Add("CODIGO");
            directorio.Columns.Add("ESPECIALIDAD");
            directorio.Columns.Add("TURNO");
            directorio.Columns.Add("ID ESPECIALIDAD");
        }

        private void MostrarDoctores()
        {
            dgDoctores.DataSource = directorio;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtApellido.Text != "" && txtDni.Text != "" && txtEdad.Text != "" && txtNombre.Text != "" && txtTelefono.Text != "" && cbbSexo.SelectedIndex != -1 && txtCodigo.Text != "" && txtEspecialidad.Text != "" && cbbTurno.Text != "" && txtID.Text != "")
            {
                directorio.Rows.Add(new object[] { txtNombre.Text, txtApellido.Text, txtDni.Text, txtEdad.Text, txtTelefono.Text , cbbSexo.Text, txtCodigo.Text ,txtEspecialidad.Text , cbbTurno.Text , txtID.Text });
                MostrarDoctores();
                txtApellido.Clear();
                txtDni.Clear();
                txtEdad.Clear();
                txtNombre.Clear();
                txtTelefono.Clear();
                txtCodigo.Clear();
                cbbSexo.SelectedIndex = -1;
            }
            else
                MessageBox.Show("Por favor debe completar todos los datos");
            txtNombre.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
