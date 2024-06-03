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

        private void buttonExport_Click(object sender, EventArgs e)
        {

        }
    }
}