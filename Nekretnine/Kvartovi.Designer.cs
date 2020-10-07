namespace Nekretnine
{
    partial class Kvartovi
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
            this.listViewKvartovi = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDodajKvart = new System.Windows.Forms.Button();
            this.btnObrisiKvart = new System.Windows.Forms.Button();
            this.btnIzmeniKvart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewKvartovi
            // 
            this.listViewKvartovi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.listViewKvartovi.Location = new System.Drawing.Point(12, 12);
            this.listViewKvartovi.Name = "listViewKvartovi";
            this.listViewKvartovi.Size = new System.Drawing.Size(340, 426);
            this.listViewKvartovi.TabIndex = 4;
            this.listViewKvartovi.UseCompatibleStateImageBehavior = false;
            this.listViewKvartovi.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ID";
            this.columnHeader3.Width = 122;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "gradska zona";
            this.columnHeader4.Width = 203;
            // 
            // btnDodajKvart
            // 
            this.btnDodajKvart.Location = new System.Drawing.Point(377, 12);
            this.btnDodajKvart.Name = "btnDodajKvart";
            this.btnDodajKvart.Size = new System.Drawing.Size(167, 35);
            this.btnDodajKvart.TabIndex = 5;
            this.btnDodajKvart.Text = "Dodaj kvart";
            this.btnDodajKvart.UseVisualStyleBackColor = true;
            this.btnDodajKvart.Click += new System.EventHandler(this.btnDodajKvart_Click);
            // 
            // btnObrisiKvart
            // 
            this.btnObrisiKvart.Location = new System.Drawing.Point(377, 53);
            this.btnObrisiKvart.Name = "btnObrisiKvart";
            this.btnObrisiKvart.Size = new System.Drawing.Size(167, 35);
            this.btnObrisiKvart.TabIndex = 6;
            this.btnObrisiKvart.Text = "Obrisi kvart";
            this.btnObrisiKvart.UseVisualStyleBackColor = true;
            this.btnObrisiKvart.Click += new System.EventHandler(this.btnObrisiKvart_Click);
            // 
            // btnIzmeniKvart
            // 
            this.btnIzmeniKvart.Location = new System.Drawing.Point(377, 94);
            this.btnIzmeniKvart.Name = "btnIzmeniKvart";
            this.btnIzmeniKvart.Size = new System.Drawing.Size(167, 35);
            this.btnIzmeniKvart.TabIndex = 7;
            this.btnIzmeniKvart.Text = "Izmeni kvart";
            this.btnIzmeniKvart.UseVisualStyleBackColor = true;
            this.btnIzmeniKvart.Click += new System.EventHandler(this.btnIzmeniKvart_Click);
            // 
            // Kvartovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 450);
            this.Controls.Add(this.btnIzmeniKvart);
            this.Controls.Add(this.btnObrisiKvart);
            this.Controls.Add(this.btnDodajKvart);
            this.Controls.Add(this.listViewKvartovi);
            this.Name = "Kvartovi";
            this.Text = "Kvartovi";
            this.Load += new System.EventHandler(this.Kvartovi_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView listViewKvartovi;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnDodajKvart;
        private System.Windows.Forms.Button btnObrisiKvart;
        private System.Windows.Forms.Button btnIzmeniKvart;
    }
}