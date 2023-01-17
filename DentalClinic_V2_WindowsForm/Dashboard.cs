using DentalClinic_V2_WindowsForm.BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalClinic_V2_WindowsForm
{
    public partial class Dashboard : Form
    {

        public Dashboard()
        {
            InitializeComponent();
        }

        public Patients patient;
        public Deseases deseases;

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AbrirFormulario_Click(object sender, EventArgs e)
        {
            if (patient == null)
            {
                patient = new Patients();
                patient.FormClosed += (o, args) => patient = null;
            }
            patient.TopLevel = false;
            panel2.Controls.Add(patient);
            patient.Show();
            patient.BringToFront();
        }

        private void OpenDeseases_Click(object sender, EventArgs e)
        {
            if (deseases == null)
            {
                deseases = new Deseases();
                deseases.FormClosed += (o, args) => deseases = null;
            }
            deseases.TopLevel = false;
            panel2.Controls.Add(deseases);
            deseases.Show();
            deseases.BringToFront();
        }
    }
}
