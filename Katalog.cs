using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modelarz
{
    public partial class Katalog : Form
    {
        public Katalog()
        {
            InitializeComponent();
            Katalog_Load();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Katalog_Load()
        {

            string connectionString = "User Id=msbd4;Password=haslo2024;Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=155.158.112.45)(PORT=1521)))(CONNECT_DATA=(SID=oltpstud)))";

            using (OracleConnection con = new OracleConnection(connectionString))
            {
                con.Open();
                Console.WriteLine("Connected to Oracle Database");

                string sqlQuery = "SELECT imie, nazwisko FROM pacjenci";

                using (OracleCommand command = new OracleCommand(sqlQuery, con))
                {

                    using (OracleDataAdapter adapter = new OracleDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                    }

                }
                con.Close();
            }

        
        }

 
    }
}
