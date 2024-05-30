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
            panelTop.Controls.Add(labelHome);
            InitializeTimer();
        }

        private void labelHome_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void InitializeTimer()
        {
            timer1.Interval = 1000; // Ustawienie interwału na 1 sekundę
            timer1.Tick += timer1_Tick; // Podłączenie zdarzenia Tick
            timer1.Start(); // Uruchomienie timera
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelDate.Text = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
        }
    }
}
