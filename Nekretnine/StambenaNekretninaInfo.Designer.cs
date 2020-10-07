namespace Nekretnine
{
    partial class StambenaNekretninaInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtUlica = new System.Windows.Forms.TextBox();
            this.txtCenaStambene = new System.Windows.Forms.TextBox();
            this.numericBroj = new System.Windows.Forms.NumericUpDown();
            this.numericSprat = new System.Windows.Forms.NumericUpDown();
            this.datumIzgradnje = new System.Windows.Forms.DateTimePicker();
            this.radioProdaja = new System.Windows.Forms.RadioButton();
            this.radioIznajmljivanje = new System.Windows.Forms.RadioButton();
            this.btnDodajStambenu = new System.Windows.Forms.Button();
            this.btnIzmeniStambenu = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numIDKvarta = new System.Windows.Forms.NumericUpDown();
            this.numIDProdavca = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numBrojKupatila = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericBroj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSprat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIDKvarta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIDProdavca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBrojKupatila)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sprat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Naziv ulice";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Broj";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 226);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 17);
            this.label10.TabIndex = 11;
            this.label10.Text = "Cena";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 17);
            this.label11.TabIndex = 10;
            this.label11.Text = "Datum izgradnje";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 155);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(144, 17);
            this.label12.TabIndex = 9;
            this.label12.Text = "Prodaja/Iznajmljivanje";
            // 
            // txtUlica
            // 
            this.txtUlica.Location = new System.Drawing.Point(161, 32);
            this.txtUlica.Name = "txtUlica";
            this.txtUlica.Size = new System.Drawing.Size(197, 22);
            this.txtUlica.TabIndex = 12;
            // 
            // txtCenaStambene
            // 
            this.txtCenaStambene.Location = new System.Drawing.Point(161, 226);
            this.txtCenaStambene.Name = "txtCenaStambene";
            this.txtCenaStambene.Size = new System.Drawing.Size(197, 22);
            this.txtCenaStambene.TabIndex = 13;
            this.txtCenaStambene.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCenaStambene_KeyPress);
            // 
            // numericBroj
            // 
            this.numericBroj.Location = new System.Drawing.Point(161, 63);
            this.numericBroj.Name = "numericBroj";
            this.numericBroj.Size = new System.Drawing.Size(197, 22);
            this.numericBroj.TabIndex = 14;
            // 
            // numericSprat
            // 
            this.numericSprat.Location = new System.Drawing.Point(161, 91);
            this.numericSprat.Name = "numericSprat";
            this.numericSprat.Size = new System.Drawing.Size(197, 22);
            this.numericSprat.TabIndex = 15;
            // 
            // datumIzgradnje
            // 
            this.datumIzgradnje.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datumIzgradnje.Location = new System.Drawing.Point(161, 120);
            this.datumIzgradnje.Name = "datumIzgradnje";
            this.datumIzgradnje.Size = new System.Drawing.Size(197, 22);
            this.datumIzgradnje.TabIndex = 16;
            // 
            // radioProdaja
            // 
            this.radioProdaja.AutoSize = true;
            this.radioProdaja.Checked = true;
            this.radioProdaja.Location = new System.Drawing.Point(162, 155);
            this.radioProdaja.Name = "radioProdaja";
            this.radioProdaja.Size = new System.Drawing.Size(78, 21);
            this.radioProdaja.TabIndex = 17;
            this.radioProdaja.TabStop = true;
            this.radioProdaja.Text = "Prodaja";
            this.radioProdaja.UseVisualStyleBackColor = true;
            // 
            // radioIznajmljivanje
            // 
            this.radioIznajmljivanje.AutoSize = true;
            this.radioIznajmljivanje.Location = new System.Drawing.Point(246, 155);
            this.radioIznajmljivanje.Name = "radioIznajmljivanje";
            this.radioIznajmljivanje.Size = new System.Drawing.Size(112, 21);
            this.radioIznajmljivanje.TabIndex = 18;
            this.radioIznajmljivanje.TabStop = true;
            this.radioIznajmljivanje.Text = "Iznajmljivanje";
            this.radioIznajmljivanje.UseVisualStyleBackColor = true;
            // 
            // btnDodajStambenu
            // 
            this.btnDodajStambenu.Location = new System.Drawing.Point(161, 316);
            this.btnDodajStambenu.Name = "btnDodajStambenu";
            this.btnDodajStambenu.Size = new System.Drawing.Size(197, 27);
            this.btnDodajStambenu.TabIndex = 19;
            this.btnDodajStambenu.Text = "Dodaj";
            this.btnDodajStambenu.UseVisualStyleBackColor = true;
            this.btnDodajStambenu.Click += new System.EventHandler(this.btnDodajStambenu_Click);
            // 
            // btnIzmeniStambenu
            // 
            this.btnIzmeniStambenu.Location = new System.Drawing.Point(161, 317);
            this.btnIzmeniStambenu.Name = "btnIzmeniStambenu";
            this.btnIzmeniStambenu.Size = new System.Drawing.Size(197, 26);
            this.btnIzmeniStambenu.TabIndex = 20;
            this.btnIzmeniStambenu.Text = "Izmeni";
            this.btnIzmeniStambenu.UseVisualStyleBackColor = true;
            this.btnIzmeniStambenu.Visible = false;
            this.btnIzmeniStambenu.Click += new System.EventHandler(this.btnIzmeniStambenu_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "ID kvarta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "ID prodavca";
            // 
            // numIDKvarta
            // 
            this.numIDKvarta.Location = new System.Drawing.Point(161, 259);
            this.numIDKvarta.Name = "numIDKvarta";
            this.numIDKvarta.Size = new System.Drawing.Size(197, 22);
            this.numIDKvarta.TabIndex = 23;
            // 
            // numIDProdavca
            // 
            this.numIDProdavca.Location = new System.Drawing.Point(161, 287);
            this.numIDProdavca.Name = "numIDProdavca";
            this.numIDProdavca.Size = new System.Drawing.Size(198, 22);
            this.numIDProdavca.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "Broj kupatila";
            // 
            // numBrojKupatila
            // 
            this.numBrojKupatila.Location = new System.Drawing.Point(161, 186);
            this.numBrojKupatila.Name = "numBrojKupatila";
            this.numBrojKupatila.Size = new System.Drawing.Size(197, 22);
            this.numBrojKupatila.TabIndex = 26;
            this.numBrojKupatila.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // StambenaNekretninaInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 427);
            this.Controls.Add(this.numBrojKupatila);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numIDProdavca);
            this.Controls.Add(this.numIDKvarta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnIzmeniStambenu);
            this.Controls.Add(this.btnDodajStambenu);
            this.Controls.Add(this.radioIznajmljivanje);
            this.Controls.Add(this.radioProdaja);
            this.Controls.Add(this.datumIzgradnje);
            this.Controls.Add(this.numericSprat);
            this.Controls.Add(this.numericBroj);
            this.Controls.Add(this.txtCenaStambene);
            this.Controls.Add(this.txtUlica);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StambenaNekretninaInfo";
            this.Text = "StambenaNekretninaInfo";
            this.Load += new System.EventHandler(this.StambenaNekretninaInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericBroj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSprat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIDKvarta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIDProdavca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBrojKupatila)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtUlica;
        private System.Windows.Forms.TextBox txtCenaStambene;
        private System.Windows.Forms.NumericUpDown numericBroj;
        private System.Windows.Forms.NumericUpDown numericSprat;
        private System.Windows.Forms.DateTimePicker datumIzgradnje;
        private System.Windows.Forms.RadioButton radioProdaja;
        private System.Windows.Forms.RadioButton radioIznajmljivanje;
        private System.Windows.Forms.Button btnDodajStambenu;
        private System.Windows.Forms.Button btnIzmeniStambenu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numIDKvarta;
        private System.Windows.Forms.NumericUpDown numIDProdavca;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numBrojKupatila;
    }
}