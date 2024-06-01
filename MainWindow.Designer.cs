﻿using System.Collections.Generic;
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonExport = new System.Windows.Forms.Button();
            this.buttonImport = new System.Windows.Forms.Button();
            this.buttonEdycja = new System.Windows.Forms.Button();
            this.buttonKatalog = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonHome = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMenu.BackColor = System.Drawing.Color.LightGray;
            this.panelMenu.Controls.Add(this.buttonExport);
            this.panelMenu.Controls.Add(this.buttonImport);
            this.panelMenu.Controls.Add(this.buttonEdycja);
            this.panelMenu.Controls.Add(this.buttonKatalog);
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Controls.Add(this.buttonHome);
            this.panelMenu.Controls.Add(this.btnExit);
            this.panelMenu.Location = new System.Drawing.Point(-1, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(172, 613);
            this.panelMenu.TabIndex = 1;
            // 
            // buttonExport
            // 
            this.buttonExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.buttonExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExport.FlatAppearance.BorderSize = 0;
            this.buttonExport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonExport.Location = new System.Drawing.Point(13, 232);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(153, 44);
            this.buttonExport.TabIndex = 6;
            this.buttonExport.Text = "Eksportuj dane";
            this.buttonExport.UseVisualStyleBackColor = false;
            // 
            // buttonImport
            // 
            this.buttonImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.buttonImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonImport.FlatAppearance.BorderSize = 0;
            this.buttonImport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonImport.Location = new System.Drawing.Point(13, 182);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(153, 44);
            this.buttonImport.TabIndex = 5;
            this.buttonImport.Text = "Importuj dane";
            this.buttonImport.UseVisualStyleBackColor = false;
            // 
            // buttonEdycja
            // 
            this.buttonEdycja.Location = new System.Drawing.Point(13, 132);
            this.buttonEdycja.Name = "buttonEdycja";
            this.buttonEdycja.Size = new System.Drawing.Size(153, 44);
            this.buttonEdycja.TabIndex = 4;
            this.buttonEdycja.Text = "Edycja pacjentów";
            this.buttonEdycja.UseVisualStyleBackColor = true;
            this.buttonEdycja.Click += new System.EventHandler(this.buttonEdycja_Click);
            // 
            // buttonKatalog
            // 
            this.buttonKatalog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.buttonKatalog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonKatalog.FlatAppearance.BorderSize = 0;
            this.buttonKatalog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonKatalog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKatalog.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonKatalog.Location = new System.Drawing.Point(13, 82);
            this.buttonKatalog.Name = "buttonKatalog";
            this.buttonKatalog.Size = new System.Drawing.Size(153, 44);
            this.buttonKatalog.TabIndex = 3;
            this.buttonKatalog.Text = "Katalog pacjentów";
            this.buttonKatalog.UseVisualStyleBackColor = false;
            this.buttonKatalog.Click += new System.EventHandler(this.buttonKatalog_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(53, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Menu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonHome
            // 
            this.buttonHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.buttonHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHome.FlatAppearance.BorderSize = 0;
            this.buttonHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonHome.Location = new System.Drawing.Point(13, 32);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(153, 44);
            this.buttonHome.TabIndex = 1;
            this.buttonHome.Text = "Ekran główny";
            this.buttonHome.UseVisualStyleBackColor = false;
            this.buttonHome.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(13, 555);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(153, 44);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Zakończ";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelMain.Location = new System.Drawing.Point(171, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(713, 613);
            this.panelMain.TabIndex = 3;
            // 
            // MainWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(884, 611);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelMenu);
            this.MinimumSize = new System.Drawing.Size(900, 650);
            this.Name = "MainWindow";
            this.Text = "Modelarz";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonKatalog;
        private System.Windows.Forms.Button buttonEdycja;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.Button buttonImport;

    }
}
