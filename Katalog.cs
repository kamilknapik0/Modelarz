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
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("imie LIKE '%{0}%' OR nazwisko LIKE '%{0}%' OR pesel LIKE '%{0}%' OR nr_modelu LIKE '%{0}%'", textBox1.Text);
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

            dataGridView1.Columns[0].Name = "Imie";
            dataGridView1.Columns[1].Name = "Nazwisko";
            dataGridView1.Columns[2].Name = "PESEL";
            dataGridView1.Columns[3].Name = "NrModelu";
            dataGridView1.Columns[4].Name = "DataWykonania";

            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.HeaderCell.Style.Font = new Font("Microsoft Sans Serif", 9F);
            }

            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(227, 227, 227);

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private bool changeBtn = false;

        private void button1_Click(object sender, EventArgs e)
        {
            if (changeBtn)
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


        //zapisanie danych do bazy danych
        private void button2_Click(object sender, EventArgs e)
        {

            string connectionString = "User Id=msbd4;Password=haslo2024;Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=155.158.112.45)(PORT=1521)))(CONNECT_DATA=(SID=oltpstud)))";


            using (OracleConnection con = new OracleConnection(connectionString))
            {
                con.Open();
                Console.WriteLine("Połączenie otwarte.");

                    string imie = dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells["Imie"].Value.ToString();
                    string nazwisko = dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells["Nazwisko"].Value.ToString();
                    string pesel = dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells["pesel"].Value.ToString();
                    string nrModelu = dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells["NrModelu"].Value.ToString();
                    string dataWykonania = dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells["DataWykonania"].Value.ToString();

                Console.WriteLine($"Imię: {imie}, Nazwisko: {nazwisko}, PESEL: {pesel}, Nr Modelu: {nrModelu}, Data Wykonania: {dataWykonania}");

                    if (string.IsNullOrEmpty(imie) || string.IsNullOrEmpty(nazwisko) || string.IsNullOrEmpty(pesel))
                    {
                        MessageBox.Show("Wszystkie pola muszą być wypełnione.");
                        return;
                    }



                    string insertPacjenciQuery = "insert into pacjenci (imie, nazwisko, pesel) values (:imie, :nazwisko, :pesel) returning pacjent_id into :pacjent_id";
                    string insertModeleQuery = "insert into modeleortodontyczne (pacjent_id, nr_modelu, data_wykonania) values (:pacjent_id, :nr_modelu, :data_wykonania)";

                    OracleTransaction transaction = con.BeginTransaction();
                    Console.WriteLine("Transakcja rozpoczęta.");

                    try
                    {
                        int pacjentId;
                        using (OracleCommand cmdPacjenci = new OracleCommand(insertPacjenciQuery, con))
                        {
                            cmdPacjenci.Parameters.Add("imie", OracleDbType.Varchar2).Value = imie;
                            cmdPacjenci.Parameters.Add("nazwisko", OracleDbType.Varchar2).Value = nazwisko;
                            cmdPacjenci.Parameters.Add("pesel", OracleDbType.Varchar2).Value = pesel;

                            OracleParameter outParameter = new OracleParameter("pacjent_id", OracleDbType.Int32, ParameterDirection.Output);
                            cmdPacjenci.Parameters.Add(outParameter);
                            cmdPacjenci.ExecuteNonQuery();

                            pacjentId = Convert.ToInt32(outParameter.Value.ToString());
                            Console.WriteLine($"Dodano pacjenta o ID: {pacjentId}");
                        }

                        using (OracleCommand cmdModele = new OracleCommand(insertModeleQuery, con))
                        {
                            cmdModele.Parameters.Add("pacjent_id", OracleDbType.Int32).Value = pacjentId;
                            cmdModele.Parameters.Add("nr_modelu", OracleDbType.Varchar2).Value = nrModelu;
                            cmdModele.Parameters.Add("data_wykonania", OracleDbType.Date).Value = Convert.ToDateTime(dataWykonania);

                            cmdModele.ExecuteNonQuery();
                            Console.WriteLine("Dodano model.");
                        }

                        transaction.Commit();
                        Console.WriteLine("Transakcja zatwierdzona.");
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        Console.WriteLine("Transakcja wycofana.");
                        MessageBox.Show("Upewnij się, czy dane są poprawnie wpisane" + ex.Message);
                    }

                    finally
                    {
                        con.Close();
                        Console.WriteLine("Połączenie zamknięte.");
                    }
                


            }
        }
    }
}
