namespace Modelarz
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelHome = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelTop.Controls.Add(this.labelDate);
            this.panelTop.Controls.Add(this.labelHome);
            this.panelTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panelTop.Location = new System.Drawing.Point(12, 12);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(673, 84);
            this.panelTop.TabIndex = 0;
            this.panelTop.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // labelDate
            // 
            this.labelDate.Location = new System.Drawing.Point(0, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(212, 23);
            this.labelDate.TabIndex = 0;
            // 
            // labelHome
            // 
            this.labelHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHome.Location = new System.Drawing.Point(266, 0);
            this.labelHome.Name = "labelHome";
            this.labelHome.Size = new System.Drawing.Size(122, 25);
            this.labelHome.TabIndex = 0;
            this.labelHome.Text = "Ekran Główny";
            this.labelHome.Click += new System.EventHandler(this.labelHome_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(12, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(673, 120);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(12, 228);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(673, 228);
            this.panel3.TabIndex = 2;
            // 
            // Home
            // 
            this.ClientSize = new System.Drawing.Size(697, 468);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelTop);
            this.Name = "Home";
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelHome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Timer timer1;
    }
}