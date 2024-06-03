using OfficeOpenXml;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modelarz
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            openHome();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            closeForms();

            openHome();

        }

        private void buttonKatalog_Click(object sender, EventArgs e)
        {
            closeForms();

            openKatalog();

        }

        private void buttonEdycja_Click(object sender, EventArgs e)
        {
            closeForms();

            openEdycja();

        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            Main();

        }
        

        void closeForms()
        {
            List<Form> formsToClose = new List<Form>();
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is Home || frm is Katalog || frm is Edycja)
                {
                    formsToClose.Add(frm);
                }
            }

            foreach (Form frm in formsToClose)
            {
                frm.Close();
            }
        }

        void openHome()
        {
            Home frm = new Home()
            {
                TopLevel = false,
                Dock = DockStyle.Fill
            };
            frm.FormBorderStyle = FormBorderStyle.None;
            this.panelMain.Controls.Add(frm);
            frm.Show();
        }

        void openKatalog()
        {
            Katalog frm = new Katalog()
            {
                TopLevel = false,
                Dock = DockStyle.Fill
            };
            frm.FormBorderStyle = FormBorderStyle.None;
            this.panelMain.Controls.Add(frm);
            frm.Show();
        }

        void openEdycja()
        {
            Edycja frm = new Edycja()
            {
                TopLevel = false,
                Dock = DockStyle.Fill
            };
            frm.FormBorderStyle = FormBorderStyle.None;
            this.panelMain.Controls.Add(frm);
            frm.Show();
        }

        public void Main()
        {
            // Your connection string
            string connectionString = "User Id=msbd4;Password=haslo2024;Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=155.158.112.45)(PORT=1521)))(CONNECT_DATA=(SID=oltpstud)))";

            // Your SQL query
            string sqlQuery = "select p.pacjent_id, p.imie, p.nazwisko, p.pesel, p.data_urodzenia, m.nr_modelu, m.data_wykonania from pacjenci p join modeleortodontyczne m on p.pacjent_id = m.pacjent_id";

            // Get data from database
            
            DataTable dataTable = GetDataFromDatabase(connectionString, sqlQuery);
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
            saveFileDialog.Title = "Save as Excel File";
            saveFileDialog.FileName = "plik.xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Export to Excel
                ExportToExcel(dataTable, saveFileDialog.FileName);

                // Inform the user
                MessageBox.Show("Dane wyeksportowane pomyslnie!");
            }

            // Define the file path for the Excel file
            string filePath = "D:\\plik.xlsx";

            // Export to Excel
            ExportToExcel(dataTable, filePath);

           
        }

        public DataTable GetDataFromDatabase(string connectionString, string query)
        {
            DataTable dataTable = new DataTable();

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    using (OracleDataAdapter adapter = new OracleDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            return dataTable;
        }

        public void ExportToExcel(DataTable dataTable, string filePath)
        {
            OfficeOpenXml.ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Sheet1");

                // Load the data table into the worksheet, starting at cell A1
                worksheet.Cells["A1"].LoadFromDataTable(dataTable, true);

                // Save the package to the specified file
                package.SaveAs(new FileInfo(filePath));
            }
        }
    }
}