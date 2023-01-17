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
    public partial class Deseases : Form
    {
        Functions connection;
        public Deseases()
        {
            InitializeComponent();
            connection = new Functions();
            ShowDesease();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowDesease()
        {
            string Query = "SELECT * FROM DeseaseTbl";
            DGVDeseaseList.DataSource = connection.GetData(Query);
        }
        private void Clear()
        {
            txtName.Text = "";
            txtDescription.Text = "";
        }
    }
}
