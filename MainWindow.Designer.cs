using System.Collections.Generic;
using System.Windows.Forms;

namespace Modelarz
{
    partial class MainWindow
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonExport = new System.Windows.Forms.Button();
            this.buttonKatalog = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.siticoneButton1 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneButton2 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneButton3 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneButton4 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMenu.BackColor = System.Drawing.Color.White;
            this.panelMenu.Controls.Add(this.siticoneButton4);
            this.panelMenu.Controls.Add(this.siticoneButton3);
            this.panelMenu.Controls.Add(this.siticoneButton2);
            this.panelMenu.Controls.Add(this.siticoneButton1);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Controls.Add(this.buttonExport);
            this.panelMenu.Controls.Add(this.buttonKatalog);
            this.panelMenu.Controls.Add(this.buttonHome);
            this.panelMenu.Controls.Add(this.btnExit);
            this.panelMenu.Location = new System.Drawing.Point(-1, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(125, 613);
            this.panelMenu.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(121, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 613);
            this.panel1.TabIndex = 0;
            // 
            // buttonExport
            // 
            this.buttonExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.buttonExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExport.FlatAppearance.BorderSize = 0;
            this.buttonExport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.buttonExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonExport.Image = ((System.Drawing.Image)(resources.GetObject("buttonExport.Image")));
            this.buttonExport.Location = new System.Drawing.Point(22, 112);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(80, 44);
            this.buttonExport.TabIndex = 6;
            this.buttonExport.UseVisualStyleBackColor = false;
            this.buttonExport.Visible = false;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // buttonKatalog
            // 
            this.buttonKatalog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.buttonKatalog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonKatalog.FlatAppearance.BorderSize = 0;
            this.buttonKatalog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.buttonKatalog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKatalog.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonKatalog.Image = ((System.Drawing.Image)(resources.GetObject("buttonKatalog.Image")));
            this.buttonKatalog.Location = new System.Drawing.Point(22, 62);
            this.buttonKatalog.Name = "buttonKatalog";
            this.buttonKatalog.Size = new System.Drawing.Size(80, 44);
            this.buttonKatalog.TabIndex = 3;
            this.buttonKatalog.UseVisualStyleBackColor = false;
            this.buttonKatalog.Visible = false;
            this.buttonKatalog.Click += new System.EventHandler(this.buttonKatalog_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.buttonHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHome.FlatAppearance.BorderSize = 0;
            this.buttonHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonHome.Image = global::Modelarz.Properties.Resources.home;
            this.buttonHome.Location = new System.Drawing.Point(22, 12);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(80, 44);
            this.buttonHome.TabIndex = 1;
            this.buttonHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonHome.UseVisualStyleBackColor = false;
            this.buttonHome.Visible = false;
            this.buttonHome.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(22, 555);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 44);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Visible = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Location = new System.Drawing.Point(122, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(762, 613);
            this.panelMain.TabIndex = 3;
            // 
            // siticoneButton1
            // 
            this.siticoneButton1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.siticoneButton1.BorderRadius = 10;
            this.siticoneButton1.BorderThickness = 2;
            this.siticoneButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.siticoneButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButton1.ForeColor = System.Drawing.Color.Black;
            this.siticoneButton1.Image = ((System.Drawing.Image)(resources.GetObject("siticoneButton1.Image")));
            this.siticoneButton1.ImageSize = new System.Drawing.Size(25, 25);
            this.siticoneButton1.Location = new System.Drawing.Point(22, 12);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.Size = new System.Drawing.Size(80, 45);
            this.siticoneButton1.TabIndex = 7;
            this.siticoneButton1.Click += new System.EventHandler(this.siticoneButton1_Click);
            this.siticoneButton1.MouseEnter += new System.EventHandler(this.siticoneButton1_MouseEnter);
            // 
            // siticoneButton2
            // 
            this.siticoneButton2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneButton2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.siticoneButton2.BorderRadius = 10;
            this.siticoneButton2.BorderThickness = 2;
            this.siticoneButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.siticoneButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButton2.ForeColor = System.Drawing.Color.Black;
            this.siticoneButton2.Image = ((System.Drawing.Image)(resources.GetObject("siticoneButton2.Image")));
            this.siticoneButton2.ImageSize = new System.Drawing.Size(25, 25);
            this.siticoneButton2.Location = new System.Drawing.Point(22, 63);
            this.siticoneButton2.Name = "siticoneButton2";
            this.siticoneButton2.Size = new System.Drawing.Size(80, 45);
            this.siticoneButton2.TabIndex = 8;
            this.siticoneButton2.Click += new System.EventHandler(this.siticoneButton2_Click);
            this.siticoneButton2.MouseEnter += new System.EventHandler(this.siticoneButton2_MouseEnter);
            // 
            // siticoneButton3
            // 
            this.siticoneButton3.BackColor = System.Drawing.Color.Transparent;
            this.siticoneButton3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.siticoneButton3.BorderRadius = 10;
            this.siticoneButton3.BorderThickness = 2;
            this.siticoneButton3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.siticoneButton3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButton3.ForeColor = System.Drawing.Color.Black;
            this.siticoneButton3.Image = ((System.Drawing.Image)(resources.GetObject("siticoneButton3.Image")));
            this.siticoneButton3.ImageSize = new System.Drawing.Size(32, 32);
            this.siticoneButton3.Location = new System.Drawing.Point(22, 114);
            this.siticoneButton3.Name = "siticoneButton3";
            this.siticoneButton3.Size = new System.Drawing.Size(80, 45);
            this.siticoneButton3.TabIndex = 9;
            this.siticoneButton3.Click += new System.EventHandler(this.siticoneButton3_Click);
            this.siticoneButton3.MouseEnter += new System.EventHandler(this.siticoneButton3_MouseEnter);
            // 
            // siticoneButton4
            // 
            this.siticoneButton4.BackColor = System.Drawing.Color.Transparent;
            this.siticoneButton4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.siticoneButton4.BorderRadius = 10;
            this.siticoneButton4.BorderThickness = 2;
            this.siticoneButton4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.siticoneButton4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButton4.ForeColor = System.Drawing.Color.Black;
            this.siticoneButton4.Image = ((System.Drawing.Image)(resources.GetObject("siticoneButton4.Image")));
            this.siticoneButton4.ImageSize = new System.Drawing.Size(32, 32);
            this.siticoneButton4.Location = new System.Drawing.Point(22, 554);
            this.siticoneButton4.Name = "siticoneButton4";
            this.siticoneButton4.Size = new System.Drawing.Size(80, 45);
            this.siticoneButton4.TabIndex = 10;
            this.siticoneButton4.Click += new System.EventHandler(this.siticoneButton4_Click);
            this.siticoneButton4.MouseEnter += new System.EventHandler(this.siticoneButton4_MouseEnter);
            // 
            // MainWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(884, 611);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(900, 650);
            this.MinimumSize = new System.Drawing.Size(900, 650);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modelarz";
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonKatalog;
        private System.Windows.Forms.Button buttonExport;
        private Panel panel1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton3;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton2;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton4;
    }
}
