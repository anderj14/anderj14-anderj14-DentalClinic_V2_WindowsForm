using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinic_V2_WindowsForm.BusinessLogic
{
    class Functions
    {
        // Fields
        private SqlConnection Connection;
        private SqlCommand Command;
        private DataTable dataTable;
        private SqlDataAdapter dataAdapter;
        private string ConStr;


        // Constructor
        public Functions()
        {
            ConStr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Ander\\Documents\\Dental.mdf;Integrated Security=True;Connect Timeout=30";
            Connection = new SqlConnection(ConStr);
            Command = new SqlCommand();
            Command.Connection = Connection;
        }

        // Data
        public DataTable GetData(string Query)
        {
            dataTable = new DataTable();
            dataAdapter = new SqlDataAdapter(Query, Connection);
            dataAdapter.Fill(dataTable);
            return dataTable;
        }

        public int SetData(string Query)
        {
            int Cnt = 0;
            if(Connection.State == ConnectionState.Closed)
            {
                Connection.Open();
            }
            Command.CommandText = Query;
            Cnt = Command.ExecuteNonQuery();
            Connection.Close();
            return Cnt;
        }
    }
}
