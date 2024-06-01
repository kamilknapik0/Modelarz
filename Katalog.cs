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
            CustomDataGrid();
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

                string sqlQuery = "select p.imie, p.nazwisko, p.pesel, m.nr_modelu, m.data_wykonania from pacjenci p join modeleortodontyczne m on p.pacjent_id = m.pacjent_id";

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
        private void CustomDataGrid()
        {
            dataGridView1.Columns[0].HeaderText = "Imię";
            dataGridView1.Columns[1].HeaderText = "Nazwisko";
            dataGridView1.Columns[2].HeaderText = "PESEL";
            dataGridView1.Columns[3].HeaderText = "Nr modelu";
            dataGridView1.Columns[4].HeaderText = "Data wykonania";

            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.HeaderCell.Style.Font = new Font("Microsoft Sans Serif", 9F);
            }

            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.LightGray;

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private bool changeBtn = false;

        private void button1_Click(object sender, EventArgs e)
        {
            if(changeBtn)
            {
                button1.FlatAppearance.MouseOverBackColor = Color.LightGray;
                button1.BackColor = Color.FromArgb(247, 247, 247);
                changeBtn = false;
                dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            }
            else
            {
                button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(247, 247, 247);
                button1.BackColor = Color.LightGray;
                changeBtn = true;
                dataGridView1.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
            }
        }
    }
}
