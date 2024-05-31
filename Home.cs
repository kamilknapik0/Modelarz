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
            string fileName = "visits.txt";
            string directoryPath = AppDomain.CurrentDomain.BaseDirectory;
            string filePath = directoryPath + fileName;
            string[,] appointments = LoadDataToArray(filePath);

            InitializeComponent();
            InitializeTimer();
            FillCalendar(tableLayoutPanel1, DateTime.Now.Year, DateTime.Now.Month, appointments);
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

        public void FillCalendar(TableLayoutPanel tableLayoutPanel1, int year, int month, string[,] appointments)
        {
            DateTime firstDateOfMonth = new DateTime(year, month, 1);
            int daysInMonth = DateTime.DaysInMonth(year, month);
            int dayOfWeek = ((int)firstDateOfMonth.DayOfWeek + 6) % 7;

            int currentRowIndex = 1;
            int currentColumnIndex = dayOfWeek;

            for (int day = 1; day <= daysInMonth; day++)
            {
                DateTime currenDate = new DateTime(year, month, day);
                bool hasAppointment = false;

                for (int i=0; i<appointments.GetLength(0); i++)
                {
                    DateTime appointmentDate = DateTime.ParseExact(appointments[i, 0], "dd-MM-yyyy", null);
                    if (currenDate == appointmentDate)
                    {
                        hasAppointment = true;
                        break;
                    }
                }


                Label dayLabel = new Label
                {
                    Text = hasAppointment ? day.ToString() + " (W)" : day.ToString(),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Fill
                };

                tableLayoutPanel1.Controls.Add(dayLabel, currentColumnIndex, currentRowIndex);

                currentColumnIndex++;

                if (currentColumnIndex > 6)
                {
                    currentColumnIndex = 0;
                    currentRowIndex++;
                }

                if (day == DateTime.Now.Day)
                {
                    dayLabel.BackColor = Color.FromArgb(227, 227, 227);
                    dayLabel.Dock = DockStyle.Fill;
                    dayLabel.Margin = new Padding(0);
                }
            }
        }

        public void AddCallendarEvent(TableLayoutPanel tableLayoutPanel1, int year, int month)
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                if (control is Label label && label.Text != "")
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
                string[,] appointments = LoadDataToArray(filePath);

                string [,] dataArray = LoadDataToArray(filePath);
                string[,] newDataArray = SortDatesClosestToToday(dataArray);

                tableLayoutPanel2.Controls.Clear();
                tableLayoutPanel2.RowStyles.Clear();
                tableLayoutPanel2.ColumnCount = 3;
                tableLayoutPanel2.RowCount = 2;


                for (int i = 0; i < newDataArray.GetLength(0); i++)
                {
                        Label label = new Label
                        {
                            Text = newDataArray[i, 0],
                            TextAlign = ContentAlignment.MiddleCenter,
                            Dock = DockStyle.Fill
                        };
                        tableLayoutPanel2.Controls.Add(label, i, 0); // Dodajemy etykietę do odpowiedniej kolumny i wiersza
                }

                for (int i = 0; i < newDataArray.GetLength(0); i++)
                {
                    Label label = new Label
                    {
                        Text = newDataArray[i, 1] + " " + newDataArray[i, 2] + "\n Godzina: " + newDataArray[i, 3],
                        TextAlign = ContentAlignment.MiddleCenter,
                        Dock = DockStyle.Fill
                    };
                    tableLayoutPanel2.Controls.Add(label, i, 1); // Dodajemy etykietę do odpowiedniej kolumny i wiersza
                }

            }
        }

        public void AddCallendarAppointment(DateTime selectedDate)
        {
            using (Wizyty wizyty = new Wizyty(selectedDate))
            {
                wizyty.ShowDialog();
                if (wizyty.DialogResult == DialogResult.OK)
                {
                    //tu sie bedzie dodawalo wizyte w formularzu wizyta
                    //zapisuje z formularza do pliku/bazy i zaznacza to na kalendarzu
                }
            }
        }

        public string[,] LoadDataToArray(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;

            string[,] dataArray = new string[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] elements = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    dataArray[i, j] = elements[j];
                }
            }
            return dataArray;
        }

        public string[,] SortDatesClosestToToday(string[,] dataArray)
        {
            DateTime today = DateTime.Now.Date; // Pobranie dzisiejszej daty bez czasu
            int rows = dataArray.GetLength(0);
            int columns = dataArray.GetLength(1);

            // Konwersja dat z tablicy na DateTime i obliczenie różnicy dni względem dzisiejszej daty
            List<Tuple<DateTime, int>> datesWithIndex = new List<Tuple<DateTime, int>>();
            for (int i = 0; i < rows; i++)
            {
                DateTime date = DateTime.ParseExact(dataArray[i, 0], "dd-MM-yyyy", null); // Konwersja daty
                if (date >= today) // Uwzględniamy tylko daty dzisiejsze lub późniejsze
                {
                    datesWithIndex.Add(new Tuple<DateTime, int>(date, i));
                }
            }

            // Sortowanie listy dat względem różnicy dni (najbliższe dzisiejszej dacie będą na początku)
            datesWithIndex.Sort((a, b) => (a.Item1 - today).Days.CompareTo((b.Item1 - today).Days));

            // Tworzenie nowej tablicy z posortowanymi danymi
            int numberOfRows = Math.Min(3, datesWithIndex.Count); // Zakładamy, że chcemy tylko 3 najbliższe daty, lub mniej jeśli mniej dat w pliku
            string[,] sortedDataArray = new string[numberOfRows, columns];
            for (int i = 0; i < numberOfRows; i++)
            {
                int originalIndex = datesWithIndex[i].Item2;
                for (int j = 0; j < columns; j++)
                {
                    sortedDataArray[i, j] = dataArray[originalIndex, j];
                }
            }

            return sortedDataArray; // Zwrócenie posortowanej tablicy
        }


        public Boolean CheckFile(string fileName)
        {
            string directoryPath = AppDomain.CurrentDomain.BaseDirectory;
            string filePath = directoryPath + fileName;

            if (File.Exists(filePath))
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