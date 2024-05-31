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
        }

        public Wizyty(DateTime selectedDate)
        {
            InitializeComponent();
        }

        void SaveDataToFile()
        {
            String imie = textBox1.Text;
            String nazwisko = textBox2.Text;
            String data = textBox3.Text;

            if (imie == "" || nazwisko == "" || data == "")
            {
                MessageBox.Show("Wszystkie pola muszą być wypełnione");
                return;
            }

            String path = "visits.txt";
            String text = imie + " " + nazwisko + " " + data + Environment.NewLine;

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
            textBox3.Text = "";
        }

       
    }
}
