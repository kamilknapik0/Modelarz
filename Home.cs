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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            InitializeTimer();
            FillCalendar(tableLayoutPanel1, DateTime.Now.Year, DateTime.Now.Month);
            AddCallendarEvent(tableLayoutPanel1, DateTime.Now.Year, DateTime.Now.Month);
            UpcomingVisits(tableLayoutPanel2);
        }

        Dictionary<DateTime, List<string>> appointments = new Dictionary<DateTime, List<string>>();

        private void InitializeTimer()
        {
            timer1.Interval = 1000; // Ustawienie interwału na 1 sekundę
            timer1.Tick += timer1_Tick; // Podłączenie zdarzenia Tick
            timer1.Start(); // Uruchomienie timera
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelDate.Text = DateTime.Now.ToString("d MMMM yyyy HH:mm");
        }

        public void FillCalendar(TableLayoutPanel tableLayoutPanel1, int year, int month)
        {
            DateTime firstDateOfMonth = new DateTime(year, month, 1);
            int daysInMonth = DateTime.DaysInMonth(year, month);
            int dayOfWeek = ((int)firstDateOfMonth.DayOfWeek + 6) % 7;

            int currentRowIndex = 1;
            int currentColumnIndex = dayOfWeek;

            for(int day = 1; day <= daysInMonth; day++)
            {
                Label dayLabel = new Label
                {
                    Text = day.ToString(),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Fill
                };

                tableLayoutPanel1.Controls.Add(dayLabel, currentColumnIndex, currentRowIndex);

                currentColumnIndex++;

                if(currentColumnIndex > 6)
                {
                    currentColumnIndex = 0;
                    currentRowIndex++;
                }

                if(day == DateTime.Now.Day)
                {
                    dayLabel.BackColor = Color.FromArgb(227, 227, 227);
                    dayLabel.Dock = DockStyle.Fill;
                    dayLabel.Margin = new Padding(0);
                }
            }
        }

        public void AddCallendarEvent(TableLayoutPanel tableLayoutPanel1, int year, int month) 
        { 
            foreach(Control control in tableLayoutPanel1.Controls)
            {
                if(control is Label label && label.Text != "")
                {
                    label.Click += (sender, e) =>
                    {
                        Label clickedLabel = sender as Label;
                        DateTime selectedDate = new DateTime(year, month, int.Parse(clickedLabel.Text));
                        //dodac wywolanie formularza do dodania wizyty
                        AddCallendarAppointment(selectedDate);
                    };
                }
            }
        }

        public void UpcomingVisits(TableLayoutPanel tableLayoutPanel2)
        {
            if (CheckFile("visits.txt"))
            {   
                string fileName = "visits.txt";
                string directoryPath = AppDomain.CurrentDomain.BaseDirectory;
                string filePath = directoryPath + fileName;
                string[] lines = File.ReadAllLines(filePath); //wszystkie linie z pliku
                int row = 0;

                foreach (var line in lines)
                {
                    string[] elements = line.Split(';'); //rozdzielenie linii na elementy

                    // Dodajemy etykietę z datą do pierwszego wiersza
                    Label dateLabel = new Label
                    {
                        Text = elements[0],
                        TextAlign = ContentAlignment.MiddleCenter,
                        Dock = DockStyle.Fill
                    };
                    tableLayoutPanel2.Controls.Add(dateLabel, 0, row);

                    // Dodajemy etykiety z pozostałymi elementami do drugiego wiersza
                    for (int column = 0; column < elements.Length - 1; column++)
                    {
                        Label label = new Label
                        {
                            Text = elements[column + 1], // +1, ponieważ pomijamy datę, która jest już dodana
                            TextAlign = ContentAlignment.MiddleCenter,
                            Dock = DockStyle.Fill
                        };
                        tableLayoutPanel2.Controls.Add(label, column, row + 1); // Dodajemy do następnego wiersza
                    }

                    row += 2; // Przeskakujemy o dwa wiersze, aby umożliwić oddzielenie daty od pozostałych danych
                }
            }
        }

        public void AddCallendarAppointment(DateTime selectedDate)
        {
            using (Wizyty wizyty = new Wizyty(selectedDate))
            {
                wizyty.ShowDialog();
                if(wizyty.DialogResult == DialogResult.OK)
                {
                    //tu sie bedzie dodawalo wizyte w formularzu wizyta
                    //zapisuje z formularza do pliku/bazy i zaznacza to na kalendarzu
                }
            }
        }

        public Boolean CheckFile(string fileName)
        {
            string directoryPath = AppDomain.CurrentDomain.BaseDirectory;
            string filePath = directoryPath + fileName;

            if(File.Exists(filePath))
            {
                return true;
            }
            else if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
                return true;
            }
            else
            {
               return false;
            }
            
        }


        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelDate_Click(object sender, EventArgs e)
        {

        }

        private void labelThur_Click(object sender, EventArgs e)
        {

        }
    }
}
