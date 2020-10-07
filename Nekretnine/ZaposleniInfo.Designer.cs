namespace Nekretnine
{
    partial class ZaposleniInfo
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
            this.txtJMBG = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStrucna = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtZaposlenje = new System.Windows.Forms.DateTimePicker();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.btnAngazuj = new System.Windows.Forms.Button();
            this.txtPoslovnica = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "JMBG";
            // 
            // txtJMBG
            // 
            this.txtJMBG.Location = new System.Drawing.Point(181, 43);
            this.txtJMBG.MaxLength = 13;
            this.txtJMBG.Name = "txtJMBG";
            this.txtJMBG.Size = new System.Drawing.Size(172, 22);
            this.txtJMBG.TabIndex = 1;
            this.txtJMBG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJMBG_KeyPress);
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(181, 124);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(172, 22);
            this.txtIme.TabIndex = 3;
            this.txtIme.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIme_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "ime";
            // 
            // txtStrucna
            // 
            this.txtStrucna.Location = new System.Drawing.Point(181, 165);
            this.txtStrucna.Name = "txtStrucna";
            this.txtStrucna.Size = new System.Drawing.Size(172, 22);
            this.txtStrucna.TabIndex = 5;
            this.txtStrucna.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStrucna_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "strucna sprema";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "datum zaposlenja";
            // 
            // dtZaposlenje
            // 
            this.dtZaposlenje.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtZaposlenje.Location = new System.Drawing.Point(181, 84);
            this.dtZaposlenje.Name = "dtZaposlenje";
            this.dtZaposlenje.Size = new System.Drawing.Size(172, 22);
            this.dtZaposlenje.TabIndex = 7;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(34, 270);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(110, 31);
            this.btnSacuvaj.TabIndex = 8;
            this.btnSacuvaj.Text = "Sacuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // btnAngazuj
            // 
            this.btnAngazuj.Location = new System.Drawing.Point(181, 270);
            this.btnAngazuj.Name = "btnAngazuj";
            this.btnAngazuj.Size = new System.Drawing.Size(172, 31);
            this.btnAngazuj.TabIndex = 9;
            this.btnAngazuj.Text = "Angazuj agenta";
            this.btnAngazuj.UseVisualStyleBackColor = true;
            this.btnAngazuj.Click += new System.EventHandler(this.btnAngazuj_Click);
            // 
            // txtPoslovnica
            // 
            this.txtPoslovnica.Location = new System.Drawing.Point(181, 206);
            this.txtPoslovnica.Name = "txtPoslovnica";
            this.txtPoslovnica.Size = new System.Drawing.Size(172, 22);
            this.txtPoslovnica.TabIndex = 11;
            this.txtPoslovnica.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPoslovnica_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "id poslovnice";
            // 
            // ZaposleniInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 346);
            this.Controls.Add(this.txtPoslovnica);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAngazuj);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.dtZaposlenje);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtStrucna);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtJMBG);
            this.Controls.Add(this.label1);
            this.Name = "ZaposleniInfo";
            this.Text = "ZaposleniInfo";
            this.Load += new System.EventHandler(this.ZaposleniInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtJMBG;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStrucna;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtZaposlenje;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Button btnAngazuj;
        private System.Windows.Forms.TextBox txtPoslovnica;
        private System.Windows.Forms.Label label5;
    }
}