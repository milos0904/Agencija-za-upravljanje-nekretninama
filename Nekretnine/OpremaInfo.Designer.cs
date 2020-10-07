namespace Nekretnine
{
    partial class OpremaInfo
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
            this.txtOprema = new System.Windows.Forms.TextBox();
            this.btnDodajOpremu = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv opreme";
            // 
            // txtOprema
            // 
            this.txtOprema.Location = new System.Drawing.Point(113, 45);
            this.txtOprema.Name = "txtOprema";
            this.txtOprema.Size = new System.Drawing.Size(100, 22);
            this.txtOprema.TabIndex = 1;
            // 
            // btnDodajOpremu
            // 
            this.btnDodajOpremu.Location = new System.Drawing.Point(113, 84);
            this.btnDodajOpremu.Name = "btnDodajOpremu";
            this.btnDodajOpremu.Size = new System.Drawing.Size(100, 23);
            this.btnDodajOpremu.TabIndex = 2;
            this.btnDodajOpremu.Text = "Dodaj";
            this.btnDodajOpremu.UseVisualStyleBackColor = true;
            this.btnDodajOpremu.Click += new System.EventHandler(this.btnDodajOpremu_Click);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(113, 84);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(100, 46);
            this.btnIzmeni.TabIndex = 3;
            this.btnIzmeni.Text = "Sacuvaj izmene";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Visible = false;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // OpremaInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 142);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.btnDodajOpremu);
            this.Controls.Add(this.txtOprema);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OpremaInfo";
            this.Text = "OpremaInfo";
            this.Load += new System.EventHandler(this.OpremaInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOprema;
        private System.Windows.Forms.Button btnDodajOpremu;
        private System.Windows.Forms.Button btnIzmeni;
    }
}