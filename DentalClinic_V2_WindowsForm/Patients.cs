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
    public partial class Patients : Form
    {
        Functions Connection;
        public Patients()
        {
            InitializeComponent();
            Connection = new Functions();
            ShowPatients();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowPatients()
        {
            string Query = "SELECT * FROM PatientTbl";
            DGVPatientList.DataSource = Connection.GetData(Query);
        }
        private void Clear()
        {
            txtName.Text = "";
            txtLastname.Text = "";
            txtCedula.Text = "";
            txtAddress.Text = "";
            txtAllergy.Text = "";
            DOBDate.Text = "";
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text == "" || txtLastname.Text == "")
                {
                    MessageBox.Show("Ingrese los datos necesarios");
                }
                else
                {
                    string patientName = txtName.Text;
                    string patientLastname = txtLastname.Text;
                    string patientDOB = DOBDate.Value.ToShortDateString();
                    string patientCedula = txtCedula.Text;
                    string patientAddress = txtAddress.Text;
                    string patientAllergy = txtAllergy.Text;

                    string Query = "INSERT INTO PatientTbl  VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')";
                    Query = string.Format(Query, patientName, patientLastname, patientDOB, patientCedula, patientAddress, patientAllergy);
                    Connection.SetData(Query);
                    ShowPatients();
                    Clear();
                    MessageBox.Show("Paciente agregado");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
