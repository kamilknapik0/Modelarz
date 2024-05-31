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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            InitializeTimer();
            FillCalendar(tableLayoutPanel1, DateTime.Now.Year, DateTime.Now.Month);
            AddCallendarEvent(tableLayoutPanel1, DateTime.Now.Year, DateTime.Now.Month);
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


        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelDate_Click(object sender, EventArgs e)
        {

        }

        private void labelThur_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddAppointment_Click(object sender, EventArgs e)
        {
            Wizyty wizytyForm = new Wizyty();
            wizytyForm.Show();
        }
    }
}
