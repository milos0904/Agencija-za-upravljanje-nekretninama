namespace Nekretnine
{
    partial class Form1
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
            this.btnUcitajNekretninu = new System.Windows.Forms.Button();
            this.btnDodavanjeNoveNekretnine = new System.Windows.Forms.Button();
            this.btnVezaManytoOne = new System.Windows.Forms.Button();
            this.btnUcitajMusteriju = new System.Windows.Forms.Button();
            this.btnDodajMusteriju = new System.Windows.Forms.Button();
            this.btnOneToMany = new System.Windows.Forms.Button();
            this.btnPrikaziAgenta = new System.Windows.Forms.Button();
            this.btnDodajAgenta = new System.Windows.Forms.Button();
            this.btnManyToOne = new System.Windows.Forms.Button();
            this.btnDodajUgovor = new System.Windows.Forms.Button();
            this.btnUcitajUgovor = new System.Windows.Forms.Button();
            this.btnManyToOneUgovori = new System.Windows.Forms.Button();
            this.btnUcitajKvart = new System.Windows.Forms.Button();
            this.btnDodajKvart = new System.Windows.Forms.Button();
            this.btnMantyToOneK = new System.Windows.Forms.Button();
            this.btnUcitajOpremu = new System.Windows.Forms.Button();
            this.btnDodajOpemu = new System.Windows.Forms.Button();
            this.btnManyToOneO = new System.Windows.Forms.Button();
            this.btnUcitajPoslovnicu = new System.Windows.Forms.Button();
            this.btnDodajPoslovnicu = new System.Windows.Forms.Button();
            this.btnVezaOneToMany = new System.Windows.Forms.Button();
            this.btnManyToOnePoslovnica = new System.Windows.Forms.Button();
            this.btnUcitajProdavca = new System.Windows.Forms.Button();
            this.btnDodajProdavca = new System.Windows.Forms.Button();
            this.btnVezaOneToManyProdavac = new System.Windows.Forms.Button();
            this.btnUcitajZaposlenog = new System.Windows.Forms.Button();
            this.btnDodajZaposlenog = new System.Windows.Forms.Button();
            this.btnVezaManyToOneZaposlen = new System.Windows.Forms.Button();
            this.btnOneToManyZaposleni = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUcitajNekretninu
            // 
            this.btnUcitajNekretninu.Location = new System.Drawing.Point(36, 22);
            this.btnUcitajNekretninu.Name = "btnUcitajNekretninu";
            this.btnUcitajNekretninu.Size = new System.Drawing.Size(222, 35);
            this.btnUcitajNekretninu.TabIndex = 0;
            this.btnUcitajNekretninu.Text = "Ucitaj podatka o nekretnini";
            this.btnUcitajNekretninu.UseVisualStyleBackColor = true;
            this.btnUcitajNekretninu.Click += new System.EventHandler(this.btnUcitajNekretninu_Click);
            // 
            // btnDodavanjeNoveNekretnine
            // 
            this.btnDodavanjeNoveNekretnine.Location = new System.Drawing.Point(36, 63);
            this.btnDodavanjeNoveNekretnine.Name = "btnDodavanjeNoveNekretnine";
            this.btnDodavanjeNoveNekretnine.Size = new System.Drawing.Size(222, 35);
            this.btnDodavanjeNoveNekretnine.TabIndex = 1;
            this.btnDodavanjeNoveNekretnine.Text = "Dodavanje nove nekretnine";
            this.btnDodavanjeNoveNekretnine.UseVisualStyleBackColor = true;
            this.btnDodavanjeNoveNekretnine.Click += new System.EventHandler(this.btnDodavanjeNoveNekretnine_Click);
            // 
            // btnVezaManytoOne
            // 
            this.btnVezaManytoOne.Location = new System.Drawing.Point(36, 104);
            this.btnVezaManytoOne.Name = "btnVezaManytoOne";
            this.btnVezaManytoOne.Size = new System.Drawing.Size(222, 30);
            this.btnVezaManytoOne.TabIndex = 3;
            this.btnVezaManytoOne.Text = "Veza Many-to-One N";
            this.btnVezaManytoOne.UseVisualStyleBackColor = true;
            this.btnVezaManytoOne.Click += new System.EventHandler(this.btnVezaManytoOne_Click);
            // 
            // btnUcitajMusteriju
            // 
            this.btnUcitajMusteriju.Location = new System.Drawing.Point(36, 140);
            this.btnUcitajMusteriju.Name = "btnUcitajMusteriju";
            this.btnUcitajMusteriju.Size = new System.Drawing.Size(222, 28);
            this.btnUcitajMusteriju.TabIndex = 4;
            this.btnUcitajMusteriju.Text = "Ucitaj musteriju";
            this.btnUcitajMusteriju.UseVisualStyleBackColor = true;
            this.btnUcitajMusteriju.Click += new System.EventHandler(this.btnUcitajMusteriju_Click);
            // 
            // btnDodajMusteriju
            // 
            this.btnDodajMusteriju.Location = new System.Drawing.Point(36, 174);
            this.btnDodajMusteriju.Name = "btnDodajMusteriju";
            this.btnDodajMusteriju.Size = new System.Drawing.Size(222, 29);
            this.btnDodajMusteriju.TabIndex = 5;
            this.btnDodajMusteriju.Text = "Dodaj musteriju";
            this.btnDodajMusteriju.UseVisualStyleBackColor = true;
            this.btnDodajMusteriju.Click += new System.EventHandler(this.btnDodajMusteriju_Click);
            // 
            // btnOneToMany
            // 
            this.btnOneToMany.Location = new System.Drawing.Point(36, 209);
            this.btnOneToMany.Name = "btnOneToMany";
            this.btnOneToMany.Size = new System.Drawing.Size(222, 28);
            this.btnOneToMany.TabIndex = 6;
            this.btnOneToMany.Text = "Veza One-to-Many M";
            this.btnOneToMany.UseVisualStyleBackColor = true;
            this.btnOneToMany.Click += new System.EventHandler(this.btnOneToMany_Click);
            // 
            // btnPrikaziAgenta
            // 
            this.btnPrikaziAgenta.Location = new System.Drawing.Point(36, 243);
            this.btnPrikaziAgenta.Name = "btnPrikaziAgenta";
            this.btnPrikaziAgenta.Size = new System.Drawing.Size(222, 28);
            this.btnPrikaziAgenta.TabIndex = 7;
            this.btnPrikaziAgenta.Text = "Ucitaj podatke o agentu";
            this.btnPrikaziAgenta.UseVisualStyleBackColor = true;
            this.btnPrikaziAgenta.Click += new System.EventHandler(this.btnPrikaziAgenta_Click);
            // 
            // btnDodajAgenta
            // 
            this.btnDodajAgenta.Location = new System.Drawing.Point(36, 277);
            this.btnDodajAgenta.Name = "btnDodajAgenta";
            this.btnDodajAgenta.Size = new System.Drawing.Size(222, 30);
            this.btnDodajAgenta.TabIndex = 8;
            this.btnDodajAgenta.Text = "Dodaj agenta";
            this.btnDodajAgenta.UseVisualStyleBackColor = true;
            this.btnDodajAgenta.Click += new System.EventHandler(this.btnDodajAgenta_Click);
            // 
            // btnManyToOne
            // 
            this.btnManyToOne.Location = new System.Drawing.Point(36, 313);
            this.btnManyToOne.Name = "btnManyToOne";
            this.btnManyToOne.Size = new System.Drawing.Size(222, 28);
            this.btnManyToOne.TabIndex = 9;
            this.btnManyToOne.Text = "Veza Many-to-One A";
            this.btnManyToOne.UseVisualStyleBackColor = true;
            this.btnManyToOne.Click += new System.EventHandler(this.btnManyToOne_Click);
            // 
            // btnDodajUgovor
            // 
            this.btnDodajUgovor.Location = new System.Drawing.Point(36, 347);
            this.btnDodajUgovor.Name = "btnDodajUgovor";
            this.btnDodajUgovor.Size = new System.Drawing.Size(222, 31);
            this.btnDodajUgovor.TabIndex = 10;
            this.btnDodajUgovor.Text = "Dodaj ugovor";
            this.btnDodajUgovor.UseVisualStyleBackColor = true;
            this.btnDodajUgovor.Click += new System.EventHandler(this.btnDodajUgovor_Click);
            // 
            // btnUcitajUgovor
            // 
            this.btnUcitajUgovor.Location = new System.Drawing.Point(36, 384);
            this.btnUcitajUgovor.Name = "btnUcitajUgovor";
            this.btnUcitajUgovor.Size = new System.Drawing.Size(222, 28);
            this.btnUcitajUgovor.TabIndex = 11;
            this.btnUcitajUgovor.Text = "Ucitaj ugovor";
            this.btnUcitajUgovor.UseVisualStyleBackColor = true;
            this.btnUcitajUgovor.Click += new System.EventHandler(this.btnUcitajUgovor_Click);
            // 
            // btnManyToOneUgovori
            // 
            this.btnManyToOneUgovori.Location = new System.Drawing.Point(36, 423);
            this.btnManyToOneUgovori.Name = "btnManyToOneUgovori";
            this.btnManyToOneUgovori.Size = new System.Drawing.Size(222, 35);
            this.btnManyToOneUgovori.TabIndex = 12;
            this.btnManyToOneUgovori.Text = "Veza Many-to-One U";
            this.btnManyToOneUgovori.UseVisualStyleBackColor = true;
            this.btnManyToOneUgovori.Click += new System.EventHandler(this.btnManyToOneUgovori_Click);
            // 
            // btnUcitajKvart
            // 
            this.btnUcitajKvart.Location = new System.Drawing.Point(299, 22);
            this.btnUcitajKvart.Name = "btnUcitajKvart";
            this.btnUcitajKvart.Size = new System.Drawing.Size(163, 35);
            this.btnUcitajKvart.TabIndex = 13;
            this.btnUcitajKvart.Text = "Ucitaj kvart";
            this.btnUcitajKvart.UseVisualStyleBackColor = true;
            this.btnUcitajKvart.Click += new System.EventHandler(this.btnUcitajKvart_Click);
            // 
            // btnDodajKvart
            // 
            this.btnDodajKvart.Location = new System.Drawing.Point(299, 63);
            this.btnDodajKvart.Name = "btnDodajKvart";
            this.btnDodajKvart.Size = new System.Drawing.Size(163, 35);
            this.btnDodajKvart.TabIndex = 14;
            this.btnDodajKvart.Text = "Dodaj kvart";
            this.btnDodajKvart.UseVisualStyleBackColor = true;
            this.btnDodajKvart.Click += new System.EventHandler(this.btnDodajKvart_Click);
            // 
            // btnMantyToOneK
            // 
            this.btnMantyToOneK.Location = new System.Drawing.Point(299, 104);
            this.btnMantyToOneK.Name = "btnMantyToOneK";
            this.btnMantyToOneK.Size = new System.Drawing.Size(163, 30);
            this.btnMantyToOneK.TabIndex = 15;
            this.btnMantyToOneK.Text = "Veza Many-to-One K";
            this.btnMantyToOneK.UseVisualStyleBackColor = true;
            this.btnMantyToOneK.Click += new System.EventHandler(this.btnMantyToOneK_Click);
            // 
            // btnUcitajOpremu
            // 
            this.btnUcitajOpremu.Location = new System.Drawing.Point(299, 140);
            this.btnUcitajOpremu.Name = "btnUcitajOpremu";
            this.btnUcitajOpremu.Size = new System.Drawing.Size(163, 28);
            this.btnUcitajOpremu.TabIndex = 16;
            this.btnUcitajOpremu.Text = "Ucitaj opremu";
            this.btnUcitajOpremu.UseVisualStyleBackColor = true;
            this.btnUcitajOpremu.Click += new System.EventHandler(this.btnUcitajOpremu_Click);
            // 
            // btnDodajOpemu
            // 
            this.btnDodajOpemu.Location = new System.Drawing.Point(299, 174);
            this.btnDodajOpemu.Name = "btnDodajOpemu";
            this.btnDodajOpemu.Size = new System.Drawing.Size(163, 29);
            this.btnDodajOpemu.TabIndex = 17;
            this.btnDodajOpemu.Text = "Dodaj opremu";
            this.btnDodajOpemu.UseVisualStyleBackColor = true;
            this.btnDodajOpemu.Click += new System.EventHandler(this.btnDodajOpemu_Click);
            // 
            // btnManyToOneO
            // 
            this.btnManyToOneO.Location = new System.Drawing.Point(299, 209);
            this.btnManyToOneO.Name = "btnManyToOneO";
            this.btnManyToOneO.Size = new System.Drawing.Size(163, 28);
            this.btnManyToOneO.TabIndex = 18;
            this.btnManyToOneO.Text = "Veza Many-to-One O";
            this.btnManyToOneO.UseVisualStyleBackColor = true;
            this.btnManyToOneO.Click += new System.EventHandler(this.btnManyToOneO_Click);
            // 
            // btnUcitajPoslovnicu
            // 
            this.btnUcitajPoslovnicu.Location = new System.Drawing.Point(299, 243);
            this.btnUcitajPoslovnicu.Name = "btnUcitajPoslovnicu";
            this.btnUcitajPoslovnicu.Size = new System.Drawing.Size(163, 28);
            this.btnUcitajPoslovnicu.TabIndex = 19;
            this.btnUcitajPoslovnicu.Text = "Ucitaj poslovnicu";
            this.btnUcitajPoslovnicu.UseVisualStyleBackColor = true;
            this.btnUcitajPoslovnicu.Click += new System.EventHandler(this.btnUcitajPoslovnicu_Click);
            // 
            // btnDodajPoslovnicu
            // 
            this.btnDodajPoslovnicu.Location = new System.Drawing.Point(299, 277);
            this.btnDodajPoslovnicu.Name = "btnDodajPoslovnicu";
            this.btnDodajPoslovnicu.Size = new System.Drawing.Size(163, 30);
            this.btnDodajPoslovnicu.TabIndex = 20;
            this.btnDodajPoslovnicu.Text = "Dodaj poslovnicu";
            this.btnDodajPoslovnicu.UseVisualStyleBackColor = true;
            this.btnDodajPoslovnicu.Click += new System.EventHandler(this.btnDodajPoslovnicu_Click);
            // 
            // btnVezaOneToMany
            // 
            this.btnVezaOneToMany.Location = new System.Drawing.Point(299, 313);
            this.btnVezaOneToMany.Name = "btnVezaOneToMany";
            this.btnVezaOneToMany.Size = new System.Drawing.Size(163, 28);
            this.btnVezaOneToMany.TabIndex = 21;
            this.btnVezaOneToMany.Text = "Vaza One-To-Many P";
            this.btnVezaOneToMany.UseVisualStyleBackColor = true;
            this.btnVezaOneToMany.Click += new System.EventHandler(this.btnVezaOneToMany_Click);
            // 
            // btnManyToOnePoslovnica
            // 
            this.btnManyToOnePoslovnica.Location = new System.Drawing.Point(299, 347);
            this.btnManyToOnePoslovnica.Name = "btnManyToOnePoslovnica";
            this.btnManyToOnePoslovnica.Size = new System.Drawing.Size(163, 31);
            this.btnManyToOnePoslovnica.TabIndex = 22;
            this.btnManyToOnePoslovnica.Text = "Veza Many-To-One P";
            this.btnManyToOnePoslovnica.UseVisualStyleBackColor = true;
            this.btnManyToOnePoslovnica.Click += new System.EventHandler(this.btnManyToOnePoslovnica_Click);
            // 
            // btnUcitajProdavca
            // 
            this.btnUcitajProdavca.Location = new System.Drawing.Point(299, 384);
            this.btnUcitajProdavca.Name = "btnUcitajProdavca";
            this.btnUcitajProdavca.Size = new System.Drawing.Size(163, 28);
            this.btnUcitajProdavca.TabIndex = 23;
            this.btnUcitajProdavca.Text = "Ucitaj prodavca";
            this.btnUcitajProdavca.UseVisualStyleBackColor = true;
            this.btnUcitajProdavca.Click += new System.EventHandler(this.btnUcitajProdavca_Click);
            // 
            // btnDodajProdavca
            // 
            this.btnDodajProdavca.Location = new System.Drawing.Point(299, 423);
            this.btnDodajProdavca.Name = "btnDodajProdavca";
            this.btnDodajProdavca.Size = new System.Drawing.Size(163, 35);
            this.btnDodajProdavca.TabIndex = 24;
            this.btnDodajProdavca.Text = "Dodaj prodavca";
            this.btnDodajProdavca.UseVisualStyleBackColor = true;
            this.btnDodajProdavca.Click += new System.EventHandler(this.btnDodajProdavca_Click);
            // 
            // btnVezaOneToManyProdavac
            // 
            this.btnVezaOneToManyProdavac.Location = new System.Drawing.Point(493, 22);
            this.btnVezaOneToManyProdavac.Name = "btnVezaOneToManyProdavac";
            this.btnVezaOneToManyProdavac.Size = new System.Drawing.Size(195, 35);
            this.btnVezaOneToManyProdavac.TabIndex = 25;
            this.btnVezaOneToManyProdavac.Text = "Veza One-To-Many Prod.";
            this.btnVezaOneToManyProdavac.UseVisualStyleBackColor = true;
            this.btnVezaOneToManyProdavac.Click += new System.EventHandler(this.btnVezaOneToManyProdavac_Click);
            // 
            // btnUcitajZaposlenog
            // 
            this.btnUcitajZaposlenog.Location = new System.Drawing.Point(493, 63);
            this.btnUcitajZaposlenog.Name = "btnUcitajZaposlenog";
            this.btnUcitajZaposlenog.Size = new System.Drawing.Size(195, 35);
            this.btnUcitajZaposlenog.TabIndex = 26;
            this.btnUcitajZaposlenog.Text = "Ucitaj zaposlenog";
            this.btnUcitajZaposlenog.UseVisualStyleBackColor = true;
            this.btnUcitajZaposlenog.Click += new System.EventHandler(this.btnUcitajZaposlenog_Click);
            // 
            // btnDodajZaposlenog
            // 
            this.btnDodajZaposlenog.Location = new System.Drawing.Point(493, 104);
            this.btnDodajZaposlenog.Name = "btnDodajZaposlenog";
            this.btnDodajZaposlenog.Size = new System.Drawing.Size(195, 30);
            this.btnDodajZaposlenog.TabIndex = 27;
            this.btnDodajZaposlenog.Text = "Dodaj zaposlenog";
            this.btnDodajZaposlenog.UseVisualStyleBackColor = true;
            this.btnDodajZaposlenog.Click += new System.EventHandler(this.btnDodajZaposlenog_Click);
            // 
            // btnVezaManyToOneZaposlen
            // 
            this.btnVezaManyToOneZaposlen.Location = new System.Drawing.Point(493, 140);
            this.btnVezaManyToOneZaposlen.Name = "btnVezaManyToOneZaposlen";
            this.btnVezaManyToOneZaposlen.Size = new System.Drawing.Size(195, 28);
            this.btnVezaManyToOneZaposlen.TabIndex = 28;
            this.btnVezaManyToOneZaposlen.Text = "Veza Many-to-One Z";
            this.btnVezaManyToOneZaposlen.UseVisualStyleBackColor = true;
            this.btnVezaManyToOneZaposlen.Click += new System.EventHandler(this.btnVezaManyToOneZaposlen_Click);
            // 
            // btnOneToManyZaposleni
            // 
            this.btnOneToManyZaposleni.Location = new System.Drawing.Point(493, 174);
            this.btnOneToManyZaposleni.Name = "btnOneToManyZaposleni";
            this.btnOneToManyZaposleni.Size = new System.Drawing.Size(195, 29);
            this.btnOneToManyZaposleni.TabIndex = 29;
            this.btnOneToManyZaposleni.Text = "Veza One-To-Many Z";
            this.btnOneToManyZaposleni.UseVisualStyleBackColor = true;
            this.btnOneToManyZaposleni.Click += new System.EventHandler(this.btnOneToManyZaposleni_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 526);
            this.Controls.Add(this.btnOneToManyZaposleni);
            this.Controls.Add(this.btnVezaManyToOneZaposlen);
            this.Controls.Add(this.btnDodajZaposlenog);
            this.Controls.Add(this.btnUcitajZaposlenog);
            this.Controls.Add(this.btnVezaOneToManyProdavac);
            this.Controls.Add(this.btnDodajProdavca);
            this.Controls.Add(this.btnUcitajProdavca);
            this.Controls.Add(this.btnManyToOnePoslovnica);
            this.Controls.Add(this.btnVezaOneToMany);
            this.Controls.Add(this.btnDodajPoslovnicu);
            this.Controls.Add(this.btnUcitajPoslovnicu);
            this.Controls.Add(this.btnManyToOneO);
            this.Controls.Add(this.btnDodajOpemu);
            this.Controls.Add(this.btnUcitajOpremu);
            this.Controls.Add(this.btnMantyToOneK);
            this.Controls.Add(this.btnDodajKvart);
            this.Controls.Add(this.btnUcitajKvart);
            this.Controls.Add(this.btnManyToOneUgovori);
            this.Controls.Add(this.btnUcitajUgovor);
            this.Controls.Add(this.btnDodajUgovor);
            this.Controls.Add(this.btnManyToOne);
            this.Controls.Add(this.btnDodajAgenta);
            this.Controls.Add(this.btnPrikaziAgenta);
            this.Controls.Add(this.btnOneToMany);
            this.Controls.Add(this.btnDodajMusteriju);
            this.Controls.Add(this.btnUcitajMusteriju);
            this.Controls.Add(this.btnVezaManytoOne);
            this.Controls.Add(this.btnDodavanjeNoveNekretnine);
            this.Controls.Add(this.btnUcitajNekretninu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUcitajNekretninu;
        private System.Windows.Forms.Button btnDodavanjeNoveNekretnine;
        private System.Windows.Forms.Button btnVezaManytoOne;
        private System.Windows.Forms.Button btnUcitajMusteriju;
        private System.Windows.Forms.Button btnDodajMusteriju;
        private System.Windows.Forms.Button btnOneToMany;
        private System.Windows.Forms.Button btnPrikaziAgenta;
        private System.Windows.Forms.Button btnDodajAgenta;
        private System.Windows.Forms.Button btnManyToOne;
        private System.Windows.Forms.Button btnDodajUgovor;
        private System.Windows.Forms.Button btnUcitajUgovor;
        private System.Windows.Forms.Button btnManyToOneUgovori;
        private System.Windows.Forms.Button btnUcitajKvart;
        private System.Windows.Forms.Button btnDodajKvart;
        private System.Windows.Forms.Button btnMantyToOneK;
        private System.Windows.Forms.Button btnUcitajOpremu;
        private System.Windows.Forms.Button btnDodajOpemu;
        private System.Windows.Forms.Button btnManyToOneO;
        private System.Windows.Forms.Button btnUcitajPoslovnicu;
        private System.Windows.Forms.Button btnDodajPoslovnicu;
        private System.Windows.Forms.Button btnVezaOneToMany;
        private System.Windows.Forms.Button btnManyToOnePoslovnica;
        private System.Windows.Forms.Button btnUcitajProdavca;
        private System.Windows.Forms.Button btnDodajProdavca;
        private System.Windows.Forms.Button btnVezaOneToManyProdavac;
        private System.Windows.Forms.Button btnUcitajZaposlenog;
        private System.Windows.Forms.Button btnDodajZaposlenog;
        private System.Windows.Forms.Button btnVezaManyToOneZaposlen;
        private System.Windows.Forms.Button btnOneToManyZaposleni;
    }
}

