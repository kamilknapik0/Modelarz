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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            Home frm = new Home()
            {
                TopLevel = false,
                Dock = DockStyle.Fill
            };
            frm.FormBorderStyle = FormBorderStyle.None;
            this.panelMain.Controls.Add(frm);
            frm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close(); 
       
            //komentarz
            //komentarz
        }

        private void button1_Click(object sender, EventArgs e)
        {
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
        }
    }
}
