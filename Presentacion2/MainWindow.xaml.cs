using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Entidades;
using Negocio;

namespace Presentacion2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //nCitaMedica gcita = new nCitaMedica();
        nPaciente gpaciente = new nPaciente();
        EPaciente pacienteseleccionado = null;
        int codpaciente;
        public MainWindow()
        {
            InitializeComponent();
            MostrarPacientes();
        }
        private void MostrarPacientes()
        {
            dgPacientes.ItemsSource = gpaciente.ListarPacientes();
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (tbxApellidos.Text != "" && tbxDni.Text != "" && tbxEdad.Text != "" && tbxNombres.Text != "" && tbxTelefono.Text != "" && cbxPadecimiento.SelectedIndex != -1 && cbxSexo.SelectedIndex != -1)
            {
                MessageBox.Show(gpaciente.InsertarPacientedatos(tbxNombres.Text, tbxApellidos.Text, tbxDni.Text, tbxTelefono.Text, cbxSexo.Text, Convert.ToInt32(tbxEdad.Text), cbxPadecimiento.Text, cita.Codigo));
                //MostrarPacientes();
                tbxApellidos.Clear();
                tbxDni.Clear();
                tbxEdad.Clear();
                tbxNombres.Clear();
                tbxTelefono.Clear();
                cbxCodigoCita.SelectedIndex = -1;
                cbxPadecimiento.SelectedIndex = -1;
                cbxSexo.SelectedIndex = -1;
            }
            else
                MessageBox.Show("Por favor debe completar todos los datos");
            tbxNombres.Focus();
        }
    }
}
