namespace Nekretnine
{
    partial class PoslovnicaInfo
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
            this.lblRadnoVreme = new System.Windows.Forms.Label();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.lblSef = new System.Windows.Forms.Label();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.txtRadnoVreme = new System.Windows.Forms.TextBox();
            this.txtSef = new System.Windows.Forms.TextBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.btnSacuvajIzmene = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRadnoVreme
            // 
            this.lblRadnoVreme.AutoSize = true;
            this.lblRadnoVreme.Location = new System.Drawing.Point(0, 57);
            this.lblRadnoVreme.Name = "lblRadnoVreme";
            this.lblRadnoVreme.Size = new System.Drawing.Size(93, 17);
            this.lblRadnoVreme.TabIndex = 0;
            this.lblRadnoVreme.Text = "Radno vreme";
            // 
            // lblAdresa
            // 
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.Location = new System.Drawing.Point(40, 25);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(53, 17);
            this.lblAdresa.TabIndex = 1;
            this.lblAdresa.Text = "Adresa";
            // 
            // lblSef
            // 
            this.lblSef.AutoSize = true;
            this.lblSef.Location = new System.Drawing.Point(16, 88);
            this.lblSef.Name = "lblSef";
            this.lblSef.Size = new System.Drawing.Size(77, 17);
            this.lblSef.TabIndex = 2;
            this.lblSef.Text = "JMBG sefa";
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(116, 25);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(100, 22);
            this.txtAdresa.TabIndex = 3;
            // 
            // txtRadnoVreme
            // 
            this.txtRadnoVreme.Location = new System.Drawing.Point(116, 57);
            this.txtRadnoVreme.Name = "txtRadnoVreme";
            this.txtRadnoVreme.Size = new System.Drawing.Size(100, 22);
            this.txtRadnoVreme.TabIndex = 4;
            // 
            // txtSef
            // 
            this.txtSef.Location = new System.Drawing.Point(116, 88);
            this.txtSef.MaxLength = 13;
            this.txtSef.Name = "txtSef";
            this.txtSef.Size = new System.Drawing.Size(100, 22);
            this.txtSef.TabIndex = 5;
            this.txtSef.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSef_KeyPress);
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(116, 125);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(100, 48);
            this.btnSacuvaj.TabIndex = 6;
            this.btnSacuvaj.Text = "Sacuvaj poslovnicu";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // btnSacuvajIzmene
            // 
            this.btnSacuvajIzmene.Location = new System.Drawing.Point(116, 125);
            this.btnSacuvajIzmene.Name = "btnSacuvajIzmene";
            this.btnSacuvajIzmene.Size = new System.Drawing.Size(100, 48);
            this.btnSacuvajIzmene.TabIndex = 7;
            this.btnSacuvajIzmene.Text = "Sacuvaj izmene";
            this.btnSacuvajIzmene.UseVisualStyleBackColor = true;
            this.btnSacuvajIzmene.Visible = false;
            this.btnSacuvajIzmene.Click += new System.EventHandler(this.btnSacuvajIzmene_Click);
            // 
            // PoslovnicaInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 235);
            this.Controls.Add(this.btnSacuvajIzmene);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.txtSef);
            this.Controls.Add(this.txtRadnoVreme);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.lblSef);
            this.Controls.Add(this.lblAdresa);
            this.Controls.Add(this.lblRadnoVreme);
            this.MaximizeBox = false;
            this.Name = "PoslovnicaInfo";
            this.Text = "PoslovnicaInfo";
            this.Load += new System.EventHandler(this.PoslovnicaInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRadnoVreme;
        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.Label lblSef;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.TextBox txtRadnoVreme;
        private System.Windows.Forms.TextBox txtSef;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Button btnSacuvajIzmene;
    }
}