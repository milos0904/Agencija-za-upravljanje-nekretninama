namespace Nekretnine
{
    partial class Poslovnice
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
            this.btnDodajPoslovnicu = new System.Windows.Forms.Button();
            this.btnObrisiSelektovanu = new System.Windows.Forms.Button();
            this.btnIzmeniPoslovnicu = new System.Windows.Forms.Button();
            this.listViewSvePoslovnice = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnDodajPoslovnicu
            // 
            this.btnDodajPoslovnicu.Location = new System.Drawing.Point(377, 12);
            this.btnDodajPoslovnicu.Name = "btnDodajPoslovnicu";
            this.btnDodajPoslovnicu.Size = new System.Drawing.Size(167, 35);
            this.btnDodajPoslovnicu.TabIndex = 1;
            this.btnDodajPoslovnicu.Text = "Dodaj poslovnicu";
            this.btnDodajPoslovnicu.UseVisualStyleBackColor = true;
            this.btnDodajPoslovnicu.Click += new System.EventHandler(this.btnDodajPoslovnicu_Click);
            // 
            // btnObrisiSelektovanu
            // 
            this.btnObrisiSelektovanu.Location = new System.Drawing.Point(377, 53);
            this.btnObrisiSelektovanu.Name = "btnObrisiSelektovanu";
            this.btnObrisiSelektovanu.Size = new System.Drawing.Size(167, 32);
            this.btnObrisiSelektovanu.TabIndex = 2;
            this.btnObrisiSelektovanu.Text = "Obrisi poslovnicu";
            this.btnObrisiSelektovanu.UseVisualStyleBackColor = true;
            this.btnObrisiSelektovanu.Click += new System.EventHandler(this.btnObrisiSelektovanu_Click);
            // 
            // btnIzmeniPoslovnicu
            // 
            this.btnIzmeniPoslovnicu.Location = new System.Drawing.Point(377, 91);
            this.btnIzmeniPoslovnicu.Name = "btnIzmeniPoslovnicu";
            this.btnIzmeniPoslovnicu.Size = new System.Drawing.Size(167, 30);
            this.btnIzmeniPoslovnicu.TabIndex = 3;
            this.btnIzmeniPoslovnicu.Text = "Izmeni poslovnicu";
            this.btnIzmeniPoslovnicu.UseVisualStyleBackColor = true;
            this.btnIzmeniPoslovnicu.Click += new System.EventHandler(this.btnIzmeniPoslovnicu_Click);
            // 
            // listViewSvePoslovnice
            // 
            this.listViewSvePoslovnice.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewSvePoslovnice.Location = new System.Drawing.Point(12, 12);
            this.listViewSvePoslovnice.Name = "listViewSvePoslovnice";
            this.listViewSvePoslovnice.Size = new System.Drawing.Size(340, 426);
            this.listViewSvePoslovnice.TabIndex = 4;
            this.listViewSvePoslovnice.UseCompatibleStateImageBehavior = false;
            this.listViewSvePoslovnice.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Adresa";
            this.columnHeader2.Width = 130;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Radno vreme";
            this.columnHeader3.Width = 142;
            // 
            // Poslovnice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 450);
            this.Controls.Add(this.listViewSvePoslovnice);
            this.Controls.Add(this.btnIzmeniPoslovnicu);
            this.Controls.Add(this.btnObrisiSelektovanu);
            this.Controls.Add(this.btnDodajPoslovnicu);
            this.MaximizeBox = false;
            this.Name = "Poslovnice";
            this.Text = "Poslovnice";
            this.Load += new System.EventHandler(this.Poslovnice_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDodajPoslovnicu;
        private System.Windows.Forms.Button btnObrisiSelektovanu;
        private System.Windows.Forms.Button btnIzmeniPoslovnicu;
        private System.Windows.Forms.ListView listViewSvePoslovnice;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}