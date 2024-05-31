using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modelarz
{
    public partial class Wizyty : Form
    {
        public Wizyty()
        {
            InitializeComponent();

            //SetData();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm";

            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.ShowUpDown = true;
            dateTimePicker2.CustomFormat = "HH:mm";

        }

        public Wizyty(DateTime selectedDate)
        {
            InitializeComponent();
        }

        void SaveDataToFile()
        {

            String imie = textBox1.Text;
            String nazwisko = textBox2.Text;
            String data = dateTimePicker1.Value.ToString("dd-MM-yyyy");
            String godzina = dateTimePicker2.Value.ToString("HH:mm");

            if (imie == "" || nazwisko == "" || data == "" || godzina == "")
            {
                MessageBox.Show("Wszystkie pola muszą być wypełnione");
                return;
            }

            String path = "visits.txt";
            String text = data + ";" + imie + ";" + nazwisko + ";" + godzina + Environment.NewLine;

            System.IO.File.AppendAllText(path, text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveDataToFile();
            ClearData();
            MessageBox.Show("Dodano wizytę");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        void ClearData()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            //dateTimePicker1.Value = DateTime.Now;
            //dateTimePicker2.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 12, 0, 0);
        }

        void SetData()
        {
            //dateTimePicker1.Value = DateTime.Now;
            //dateTimePicker2.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 12, 0, 0);
        }
    }
}
