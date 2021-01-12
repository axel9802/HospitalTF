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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void registrarPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPaciente frmpaciente = new FrmPaciente();
            frmpaciente.ShowDialog();
        }

        private void registrarDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDoctor frm = new FrmDoctor();
            frm.ShowDialog();
        }

        private void registrarCitaMedicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCitaMedica frm = new FrmCitaMedica();
            frm.ShowDialog();
        }
    }
}
