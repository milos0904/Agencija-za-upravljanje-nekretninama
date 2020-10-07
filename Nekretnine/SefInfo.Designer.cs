namespace Nekretnine
{
    partial class SefInfo
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
            this.txtPoslovnica = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtZaposlenje = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtJMBG = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtPostavljanja = new System.Windows.Forms.DateTimePicker();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPoslovnica
            // 
            this.txtPoslovnica.Location = new System.Drawing.Point(180, 197);
            this.txtPoslovnica.Name = "txtPoslovnica";
            this.txtPoslovnica.Size = new System.Drawing.Size(172, 22);
            this.txtPoslovnica.TabIndex = 21;
            this.txtPoslovnica.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPoslovnica_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "id poslovnice";
            // 
            // dtZaposlenje
            // 
            this.dtZaposlenje.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtZaposlenje.Location = new System.Drawing.Point(180, 75);
            this.dtZaposlenje.Name = "dtZaposlenje";
            this.dtZaposlenje.Size = new System.Drawing.Size(172, 22);
            this.dtZaposlenje.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "datum zaposlenja";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "datum postavljanja";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(180, 115);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(172, 22);
            this.txtIme.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "ime";
            // 
            // txtJMBG
            // 
            this.txtJMBG.Location = new System.Drawing.Point(180, 34);
            this.txtJMBG.MaxLength = 13;
            this.txtJMBG.Name = "txtJMBG";
            this.txtJMBG.Size = new System.Drawing.Size(172, 22);
            this.txtJMBG.TabIndex = 13;
            this.txtJMBG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJMBG_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "JMBG";
            // 
            // dtPostavljanja
            // 
            this.dtPostavljanja.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPostavljanja.Location = new System.Drawing.Point(180, 156);
            this.dtPostavljanja.Name = "dtPostavljanja";
            this.dtPostavljanja.Size = new System.Drawing.Size(172, 22);
            this.dtPostavljanja.TabIndex = 22;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(33, 239);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(319, 32);
            this.btnSacuvaj.TabIndex = 23;
            this.btnSacuvaj.Text = "Sacuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // SefInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 289);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.dtPostavljanja);
            this.Controls.Add(this.txtPoslovnica);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtZaposlenje);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtJMBG);
            this.Controls.Add(this.label1);
            this.Name = "SefInfo";
            this.Text = "SefInfo";
            this.Load += new System.EventHandler(this.SefInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPoslovnica;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtZaposlenje;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtJMBG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtPostavljanja;
        private System.Windows.Forms.Button btnSacuvaj;
    }
}