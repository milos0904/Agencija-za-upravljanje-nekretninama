namespace Nekretnine
{
    partial class ZaposleniISefovi
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
            this.btnObrisiSefa = new System.Windows.Forms.Button();
            this.btnObrisiZaposlenog = new System.Windows.Forms.Button();
            this.btnIzmeniSefa = new System.Windows.Forms.Button();
            this.btnIzmeniZaposlenog = new System.Windows.Forms.Button();
            this.btnDodajSefa = new System.Windows.Forms.Button();
            this.btnDodajZaposlenog = new System.Windows.Forms.Button();
            this.listViewSefovi = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewZaposleni = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnObrisiSefa
            // 
            this.btnObrisiSefa.Location = new System.Drawing.Point(796, 411);
            this.btnObrisiSefa.Name = "btnObrisiSefa";
            this.btnObrisiSefa.Size = new System.Drawing.Size(131, 29);
            this.btnObrisiSefa.TabIndex = 15;
            this.btnObrisiSefa.Text = "Obrisi";
            this.btnObrisiSefa.UseVisualStyleBackColor = true;
            this.btnObrisiSefa.Click += new System.EventHandler(this.btnObrisiSefa_Click);
            // 
            // btnObrisiZaposlenog
            // 
            this.btnObrisiZaposlenog.Location = new System.Drawing.Point(796, 120);
            this.btnObrisiZaposlenog.Name = "btnObrisiZaposlenog";
            this.btnObrisiZaposlenog.Size = new System.Drawing.Size(131, 29);
            this.btnObrisiZaposlenog.TabIndex = 14;
            this.btnObrisiZaposlenog.Text = "Obrisi";
            this.btnObrisiZaposlenog.UseVisualStyleBackColor = true;
            this.btnObrisiZaposlenog.Click += new System.EventHandler(this.btnObrisiZaposlenog_Click);
            // 
            // btnIzmeniSefa
            // 
            this.btnIzmeniSefa.Location = new System.Drawing.Point(796, 376);
            this.btnIzmeniSefa.Name = "btnIzmeniSefa";
            this.btnIzmeniSefa.Size = new System.Drawing.Size(131, 29);
            this.btnIzmeniSefa.TabIndex = 13;
            this.btnIzmeniSefa.Text = "Izmeni";
            this.btnIzmeniSefa.UseVisualStyleBackColor = true;
            this.btnIzmeniSefa.Click += new System.EventHandler(this.btnIzmeniSefa_Click);
            // 
            // btnIzmeniZaposlenog
            // 
            this.btnIzmeniZaposlenog.Location = new System.Drawing.Point(796, 85);
            this.btnIzmeniZaposlenog.Name = "btnIzmeniZaposlenog";
            this.btnIzmeniZaposlenog.Size = new System.Drawing.Size(131, 29);
            this.btnIzmeniZaposlenog.TabIndex = 12;
            this.btnIzmeniZaposlenog.Text = "Izmeni";
            this.btnIzmeniZaposlenog.UseVisualStyleBackColor = true;
            this.btnIzmeniZaposlenog.Click += new System.EventHandler(this.btnIzmeniZaposlenog_Click);
            // 
            // btnDodajSefa
            // 
            this.btnDodajSefa.Location = new System.Drawing.Point(796, 341);
            this.btnDodajSefa.Name = "btnDodajSefa";
            this.btnDodajSefa.Size = new System.Drawing.Size(131, 29);
            this.btnDodajSefa.TabIndex = 11;
            this.btnDodajSefa.Text = "Dodaj";
            this.btnDodajSefa.UseVisualStyleBackColor = true;
            this.btnDodajSefa.Click += new System.EventHandler(this.btnDodajSefa_Click);
            // 
            // btnDodajZaposlenog
            // 
            this.btnDodajZaposlenog.Location = new System.Drawing.Point(796, 50);
            this.btnDodajZaposlenog.Name = "btnDodajZaposlenog";
            this.btnDodajZaposlenog.Size = new System.Drawing.Size(131, 29);
            this.btnDodajZaposlenog.TabIndex = 10;
            this.btnDodajZaposlenog.Text = "Dodaj";
            this.btnDodajZaposlenog.UseVisualStyleBackColor = true;
            this.btnDodajZaposlenog.Click += new System.EventHandler(this.btnDodajZaposlenog_Click);
            // 
            // listViewSefovi
            // 
            this.listViewSefovi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.listViewSefovi.Location = new System.Drawing.Point(12, 327);
            this.listViewSefovi.Name = "listViewSefovi";
            this.listViewSefovi.Size = new System.Drawing.Size(756, 229);
            this.listViewSefovi.TabIndex = 9;
            this.listViewSefovi.UseCompatibleStateImageBehavior = false;
            this.listViewSefovi.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "ID";
            this.columnHeader6.Width = 80;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "JMBG";
            this.columnHeader7.Width = 113;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "datum zaposlenja";
            this.columnHeader8.Width = 118;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "ime";
            this.columnHeader9.Width = 132;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "datum postavljanja";
            this.columnHeader10.Width = 200;
            // 
            // listViewZaposleni
            // 
            this.listViewZaposleni.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewZaposleni.Location = new System.Drawing.Point(12, 32);
            this.listViewZaposleni.Name = "listViewZaposleni";
            this.listViewZaposleni.Size = new System.Drawing.Size(756, 229);
            this.listViewZaposleni.TabIndex = 8;
            this.listViewZaposleni.UseCompatibleStateImageBehavior = false;
            this.listViewZaposleni.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "JMBG";
            this.columnHeader2.Width = 113;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "datum zaposlenja";
            this.columnHeader3.Width = 118;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ime";
            this.columnHeader4.Width = 132;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "strucna sprema";
            this.columnHeader5.Width = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Šefovi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Zaposleni";
            // 
            // ZaposleniISefovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 568);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnObrisiSefa);
            this.Controls.Add(this.btnObrisiZaposlenog);
            this.Controls.Add(this.btnIzmeniSefa);
            this.Controls.Add(this.btnIzmeniZaposlenog);
            this.Controls.Add(this.btnDodajSefa);
            this.Controls.Add(this.btnDodajZaposlenog);
            this.Controls.Add(this.listViewSefovi);
            this.Controls.Add(this.listViewZaposleni);
            this.Name = "ZaposleniISefovi";
            this.Text = "ZaposleniISefovi";
            this.Load += new System.EventHandler(this.ZaposleniISefovi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnObrisiSefa;
        private System.Windows.Forms.Button btnObrisiZaposlenog;
        private System.Windows.Forms.Button btnIzmeniSefa;
        private System.Windows.Forms.Button btnIzmeniZaposlenog;
        private System.Windows.Forms.Button btnDodajSefa;
        private System.Windows.Forms.Button btnDodajZaposlenog;
        private System.Windows.Forms.ListView listViewSefovi;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ListView listViewZaposleni;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}