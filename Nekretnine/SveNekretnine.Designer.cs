namespace Nekretnine
{
    partial class SveNekretnine
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
            this.listViewSvePoslovne = new System.Windows.Forms.ListView();
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDodajPoslovnu = new System.Windows.Forms.Button();
            this.btnIzmeniPoslovnu = new System.Windows.Forms.Button();
            this.btnObrisiPoslovnu = new System.Windows.Forms.Button();
            this.btnKupiPoslovnu = new System.Windows.Forms.Button();
            this.btnIznajmiPoslovnu = new System.Windows.Forms.Button();
            this.btnIznajmiStambenu = new System.Windows.Forms.Button();
            this.btnKupiStambenu = new System.Windows.Forms.Button();
            this.btnObrisiStabmenu = new System.Windows.Forms.Button();
            this.btnIzmeniStambenu = new System.Windows.Forms.Button();
            this.btnDodajStambenu = new System.Windows.Forms.Button();
            this.lblPoslovne = new System.Windows.Forms.Label();
            this.lblStambene = new System.Windows.Forms.Label();
            this.listViewStambene = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDodajOpremu = new System.Windows.Forms.Button();
            this.btnIzmeniOpremu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewSvePoslovne
            // 
            this.listViewSvePoslovne.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewSvePoslovne.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18,
            this.columnHeader19,
            this.columnHeader20,
            this.columnHeader21});
            this.listViewSvePoslovne.Location = new System.Drawing.Point(12, 40);
            this.listViewSvePoslovne.Name = "listViewSvePoslovne";
            this.listViewSvePoslovne.Size = new System.Drawing.Size(985, 285);
            this.listViewSvePoslovne.TabIndex = 0;
            this.listViewSvePoslovne.UseCompatibleStateImageBehavior = false;
            this.listViewSvePoslovne.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "ID";
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Ulica";
            this.columnHeader12.Width = 123;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Broj";
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Sprat";
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Datum izgradnje";
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Cena";
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Prodaja/iznajmljivanje";
            this.columnHeader17.Width = 171;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Sala";
            this.columnHeader18.Width = 55;
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "Kvart";
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "ID Prodavca";
            this.columnHeader20.Width = 116;
            // 
            // columnHeader21
            // 
            this.columnHeader21.Text = "Oprema";
            this.columnHeader21.Width = 85;
            // 
            // btnDodajPoslovnu
            // 
            this.btnDodajPoslovnu.Location = new System.Drawing.Point(12, 340);
            this.btnDodajPoslovnu.Name = "btnDodajPoslovnu";
            this.btnDodajPoslovnu.Size = new System.Drawing.Size(75, 32);
            this.btnDodajPoslovnu.TabIndex = 1;
            this.btnDodajPoslovnu.Text = "Dodaj";
            this.btnDodajPoslovnu.UseVisualStyleBackColor = true;
            this.btnDodajPoslovnu.Click += new System.EventHandler(this.btnDodajPoslovnu_Click);
            // 
            // btnIzmeniPoslovnu
            // 
            this.btnIzmeniPoslovnu.Location = new System.Drawing.Point(93, 340);
            this.btnIzmeniPoslovnu.Name = "btnIzmeniPoslovnu";
            this.btnIzmeniPoslovnu.Size = new System.Drawing.Size(75, 32);
            this.btnIzmeniPoslovnu.TabIndex = 2;
            this.btnIzmeniPoslovnu.Text = "Izmeni";
            this.btnIzmeniPoslovnu.UseVisualStyleBackColor = true;
            this.btnIzmeniPoslovnu.Click += new System.EventHandler(this.btnIzmeniPoslovnu_Click);
            // 
            // btnObrisiPoslovnu
            // 
            this.btnObrisiPoslovnu.Location = new System.Drawing.Point(174, 340);
            this.btnObrisiPoslovnu.Name = "btnObrisiPoslovnu";
            this.btnObrisiPoslovnu.Size = new System.Drawing.Size(75, 32);
            this.btnObrisiPoslovnu.TabIndex = 3;
            this.btnObrisiPoslovnu.Text = "Obrisi";
            this.btnObrisiPoslovnu.UseVisualStyleBackColor = true;
            this.btnObrisiPoslovnu.Click += new System.EventHandler(this.btnObrisiPoslovnu_Click);
            // 
            // btnKupiPoslovnu
            // 
            this.btnKupiPoslovnu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKupiPoslovnu.Location = new System.Drawing.Point(841, 331);
            this.btnKupiPoslovnu.Name = "btnKupiPoslovnu";
            this.btnKupiPoslovnu.Size = new System.Drawing.Size(75, 32);
            this.btnKupiPoslovnu.TabIndex = 4;
            this.btnKupiPoslovnu.Text = "Kupi";
            this.btnKupiPoslovnu.UseVisualStyleBackColor = true;
            this.btnKupiPoslovnu.Click += new System.EventHandler(this.btnKupiPoslovnu_Click);
            // 
            // btnIznajmiPoslovnu
            // 
            this.btnIznajmiPoslovnu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIznajmiPoslovnu.Location = new System.Drawing.Point(922, 331);
            this.btnIznajmiPoslovnu.Name = "btnIznajmiPoslovnu";
            this.btnIznajmiPoslovnu.Size = new System.Drawing.Size(75, 32);
            this.btnIznajmiPoslovnu.TabIndex = 5;
            this.btnIznajmiPoslovnu.Text = "Iznajmi";
            this.btnIznajmiPoslovnu.UseVisualStyleBackColor = true;
            this.btnIznajmiPoslovnu.Click += new System.EventHandler(this.btnIznajmiPoslovnu_Click);
            // 
            // btnIznajmiStambenu
            // 
            this.btnIznajmiStambenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIznajmiStambenu.Location = new System.Drawing.Point(922, 738);
            this.btnIznajmiStambenu.Name = "btnIznajmiStambenu";
            this.btnIznajmiStambenu.Size = new System.Drawing.Size(75, 32);
            this.btnIznajmiStambenu.TabIndex = 11;
            this.btnIznajmiStambenu.Text = "Iznajmi";
            this.btnIznajmiStambenu.UseVisualStyleBackColor = true;
            this.btnIznajmiStambenu.Click += new System.EventHandler(this.btnIznajmiStambenu_Click);
            // 
            // btnKupiStambenu
            // 
            this.btnKupiStambenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKupiStambenu.Location = new System.Drawing.Point(841, 738);
            this.btnKupiStambenu.Name = "btnKupiStambenu";
            this.btnKupiStambenu.Size = new System.Drawing.Size(75, 32);
            this.btnKupiStambenu.TabIndex = 10;
            this.btnKupiStambenu.Text = "Kupi";
            this.btnKupiStambenu.UseVisualStyleBackColor = true;
            this.btnKupiStambenu.Click += new System.EventHandler(this.btnKupiStambenu_Click);
            // 
            // btnObrisiStabmenu
            // 
            this.btnObrisiStabmenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnObrisiStabmenu.Location = new System.Drawing.Point(177, 738);
            this.btnObrisiStabmenu.Name = "btnObrisiStabmenu";
            this.btnObrisiStabmenu.Size = new System.Drawing.Size(75, 32);
            this.btnObrisiStabmenu.TabIndex = 9;
            this.btnObrisiStabmenu.Text = "Obrisi";
            this.btnObrisiStabmenu.UseVisualStyleBackColor = true;
            this.btnObrisiStabmenu.Click += new System.EventHandler(this.btnObrisiStabmenu_Click);
            // 
            // btnIzmeniStambenu
            // 
            this.btnIzmeniStambenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnIzmeniStambenu.Location = new System.Drawing.Point(96, 738);
            this.btnIzmeniStambenu.Name = "btnIzmeniStambenu";
            this.btnIzmeniStambenu.Size = new System.Drawing.Size(75, 32);
            this.btnIzmeniStambenu.TabIndex = 8;
            this.btnIzmeniStambenu.Text = "Izmeni";
            this.btnIzmeniStambenu.UseVisualStyleBackColor = true;
            this.btnIzmeniStambenu.Click += new System.EventHandler(this.btnIzmeniStambenu_Click);
            // 
            // btnDodajStambenu
            // 
            this.btnDodajStambenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDodajStambenu.Location = new System.Drawing.Point(15, 738);
            this.btnDodajStambenu.Name = "btnDodajStambenu";
            this.btnDodajStambenu.Size = new System.Drawing.Size(75, 32);
            this.btnDodajStambenu.TabIndex = 7;
            this.btnDodajStambenu.Text = "Dodaj";
            this.btnDodajStambenu.UseVisualStyleBackColor = true;
            this.btnDodajStambenu.Click += new System.EventHandler(this.btnDodajStambenu_Click);
            // 
            // lblPoslovne
            // 
            this.lblPoslovne.AutoSize = true;
            this.lblPoslovne.Location = new System.Drawing.Point(12, 9);
            this.lblPoslovne.Name = "lblPoslovne";
            this.lblPoslovne.Size = new System.Drawing.Size(137, 17);
            this.lblPoslovne.TabIndex = 12;
            this.lblPoslovne.Text = "Poslovne nekretnine";
            // 
            // lblStambene
            // 
            this.lblStambene.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStambene.AutoSize = true;
            this.lblStambene.Location = new System.Drawing.Point(9, 402);
            this.lblStambene.Name = "lblStambene";
            this.lblStambene.Size = new System.Drawing.Size(143, 17);
            this.lblStambene.TabIndex = 13;
            this.lblStambene.Text = "Stambene nekretnine";
            // 
            // listViewStambene
            // 
            this.listViewStambene.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewStambene.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.listViewStambene.Location = new System.Drawing.Point(12, 431);
            this.listViewStambene.Name = "listViewStambene";
            this.listViewStambene.Size = new System.Drawing.Size(986, 301);
            this.listViewStambene.TabIndex = 14;
            this.listViewStambene.UseCompatibleStateImageBehavior = false;
            this.listViewStambene.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ulica";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Broj";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Sprat";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Datum izgradnje";
            this.columnHeader5.Width = 115;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Cena";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Prodaja/Iznajmljivanje";
            this.columnHeader7.Width = 149;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Broj kupatila";
            this.columnHeader8.Width = 102;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Zona";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "ID Prodavca";
            // 
            // btnDodajOpremu
            // 
            this.btnDodajOpremu.Location = new System.Drawing.Point(255, 340);
            this.btnDodajOpremu.Name = "btnDodajOpremu";
            this.btnDodajOpremu.Size = new System.Drawing.Size(124, 32);
            this.btnDodajOpremu.TabIndex = 15;
            this.btnDodajOpremu.Text = "Dodaj opremu";
            this.btnDodajOpremu.UseVisualStyleBackColor = true;
            this.btnDodajOpremu.Click += new System.EventHandler(this.btnDodajOpremu_Click);
            // 
            // btnIzmeniOpremu
            // 
            this.btnIzmeniOpremu.Location = new System.Drawing.Point(385, 340);
            this.btnIzmeniOpremu.Name = "btnIzmeniOpremu";
            this.btnIzmeniOpremu.Size = new System.Drawing.Size(120, 32);
            this.btnIzmeniOpremu.TabIndex = 16;
            this.btnIzmeniOpremu.Text = "Izmeni opremu";
            this.btnIzmeniOpremu.UseVisualStyleBackColor = true;
            this.btnIzmeniOpremu.Click += new System.EventHandler(this.btnIzmeniOpremu_Click);
            // 
            // SveNekretnine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 803);
            this.Controls.Add(this.btnIzmeniOpremu);
            this.Controls.Add(this.btnDodajOpremu);
            this.Controls.Add(this.listViewStambene);
            this.Controls.Add(this.lblStambene);
            this.Controls.Add(this.lblPoslovne);
            this.Controls.Add(this.btnIznajmiStambenu);
            this.Controls.Add(this.btnKupiStambenu);
            this.Controls.Add(this.btnObrisiStabmenu);
            this.Controls.Add(this.btnIzmeniStambenu);
            this.Controls.Add(this.btnDodajStambenu);
            this.Controls.Add(this.btnIznajmiPoslovnu);
            this.Controls.Add(this.btnKupiPoslovnu);
            this.Controls.Add(this.btnObrisiPoslovnu);
            this.Controls.Add(this.btnIzmeniPoslovnu);
            this.Controls.Add(this.btnDodajPoslovnu);
            this.Controls.Add(this.listViewSvePoslovne);
            this.Name = "SveNekretnine";
            this.Text = "SveNekretnine";
            this.Load += new System.EventHandler(this.SveNekretnine_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewSvePoslovne;
        private System.Windows.Forms.Button btnDodajPoslovnu;
        private System.Windows.Forms.Button btnIzmeniPoslovnu;
        private System.Windows.Forms.Button btnObrisiPoslovnu;
        private System.Windows.Forms.Button btnKupiPoslovnu;
        private System.Windows.Forms.Button btnIznajmiPoslovnu;
        private System.Windows.Forms.Button btnIznajmiStambenu;
        private System.Windows.Forms.Button btnKupiStambenu;
        private System.Windows.Forms.Button btnObrisiStabmenu;
        private System.Windows.Forms.Button btnIzmeniStambenu;
        private System.Windows.Forms.Button btnDodajStambenu;
        private System.Windows.Forms.Label lblPoslovne;
        private System.Windows.Forms.Label lblStambene;
        private System.Windows.Forms.ListView listViewStambene;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private System.Windows.Forms.ColumnHeader columnHeader21;
        private System.Windows.Forms.Button btnDodajOpremu;
        private System.Windows.Forms.Button btnIzmeniOpremu;
    }
}