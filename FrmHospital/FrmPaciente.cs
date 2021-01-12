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
    public partial class FrmPaciente : Form
    {
        //nCitaMedica gcita = new nCitaMedica();
        nPaciente gpaciente = new nPaciente();
        EPaciente paciente = null;
        DataTable directorio = new DataTable();
        //ECitaMedica cita = null;
        public FrmPaciente()
        {
            InitializeComponent();
            MostrarCodigoCita();
            MostrarPacientes();
            directorio.Columns.Add("NOMBRE");
            directorio.Columns.Add("APELLIDO");
            directorio.Columns.Add("DNI");
            directorio.Columns.Add("TELEFONO");
            directorio.Columns.Add("SEXO");
            directorio.Columns.Add("EDAD");
            directorio.Columns.Add("PADECIMIENTO");
            directorio.Columns.Add("CODIGO CITA");
        }
        private void MostrarCodigoCita()
        {
            //cbxCodigoCita.items = gcita.ListaCitas();
        }
        private void MostrarPacientes()
        {
            dgPacientes.DataSource = directorio;
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (tbxApellidos.Text != "" && tbxDni.Text != "" && tbxEdad.Text != "" && tbxNombres.Text != "" && tbxTelefono.Text != "" && cbxPadecimiento.SelectedIndex != -1 && cbxSexo.SelectedIndex != -1 && txtCodigoCita.Text != "")
            {
                directorio.Rows.Add(new object[] { tbxNombres.Text, tbxApellidos.Text, tbxDni.Text, tbxTelefono.Text, cbxSexo.Text, Convert.ToInt32(tbxEdad.Text), cbxPadecimiento.Text, Convert.ToInt32(txtCodigoCita.Text) });
                MostrarPacientes();
                tbxApellidos.Clear();
                tbxDni.Clear();
                tbxEdad.Clear();
                tbxNombres.Clear();
                tbxTelefono.Clear();
                txtCodigoCita.Clear();
                cbxPadecimiento.SelectedIndex = -1;
                cbxSexo.SelectedIndex = -1;
            }
            else
                MessageBox.Show("Por favor debe completar todos los datos");
            tbxNombres.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            dgPacientes.Rows.Remove(dgPacientes.CurrentRow);
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (paciente != null)
            {
                if (tbxApellidos.Text != "" && tbxDni.Text != "" && tbxEdad.Text != "" && tbxNombres.Text != "" && tbxTelefono.Text != "" && cbxPadecimiento.SelectedIndex != -1 && cbxSexo.SelectedIndex != -1 && txtCodigoCita.Text != "")
                {
                    MessageBox.Show(gpaciente.ModificarPacientedatos(tbxNombres.Text, tbxApellidos.Text, tbxDni.Text, tbxTelefono.Text, cbxSexo.Text, Convert.ToInt32(tbxEdad.Text), cbxPadecimiento.Text, Convert.ToInt32(txtCodigoCita.Text)));
                    tbxApellidos.Clear();
                    tbxDni.Clear();
                    tbxEdad.Clear();
                    tbxNombres.Clear();
                    tbxTelefono.Clear();
                    txtCodigoCita.Clear();
                    cbxPadecimiento.SelectedIndex = -1;
                    cbxSexo.SelectedIndex = -1;
                }
                else
                    MessageBox.Show("Por favor debe completar todos los datos");
            }
            else
                MessageBox.Show("Por favor debe seleccionar un paciente de la lista");
            tbxNombres.Focus();
        }

        private void dgPacientes_SelectionChanged(object sender, EventArgs e)
        {
            //paciente = dgPacientes.SelectedCells as EPaciente;

            if (paciente != null)
            {
                tbxNombres.Text = paciente.Nombre;
                tbxApellidos.Text = paciente.Apellido;
                tbxDni.Text = paciente.DNI;
                tbxTelefono.Text = paciente.Telefono;
                cbxPadecimiento.Text = paciente.Padecimiento;
                cbxSexo.Text = paciente.Sexo;
            }
        }
    }
}
