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
using OfficeOpenXml;
using System.IO;

namespace Modelarz
{
    public partial class Export : Form
    {
        public Export()
        {
            InitializeComponent();
        }


       

        public void Main()
        {
            // Your connection string
            string connectionString = "User Id=msbd4;Password=haslo2024;Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=155.158.112.45)(PORT=1521)))(CONNECT_DATA=(SID=oltpstud)))";

            // Your SQL query
            string sqlQuery = "select p.pacjent_id, p.imie, p.nazwisko, p.pesel, p.data_urodzenia, m.nr_modelu, m.data_wykonania from pacjenci p join modeleortodontyczne m on p.pacjent_id = m.pacjent_id";

            // Get data from database
            Export export = new Export();
            DataTable dataTable = export.GetDataFromDatabase(connectionString, sqlQuery);

            // Define the file path for the Excel file
            string filePath = "D:\\plik.xlsx";

            // Export to Excel
            export.ExportToExcel(dataTable, filePath);

            // Inform the user
            MessageBox.Show("Data exported to Excel successfully!");
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

        private void button1_Click(object sender, EventArgs e)
        {
            Main();
        }
    }
  

}
