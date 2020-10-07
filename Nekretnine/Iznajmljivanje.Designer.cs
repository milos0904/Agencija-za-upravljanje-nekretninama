namespace Nekretnine
{
    partial class Iznajmljivanje
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnIznajmi = new System.Windows.Forms.Button();
            this.txtIDmusterije = new System.Windows.Forms.TextBox();
            this.txtStanarina = new System.Windows.Forms.TextBox();
            this.txtIDProdavca = new System.Windows.Forms.TextBox();
            this.txtIDZaposlenog = new System.Windows.Forms.TextBox();
            this.dateTimepocetak = new System.Windows.Forms.DateTimePicker();
            this.dateTimekraj = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stanarina";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Datum pocetka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Datum isteka";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "ID musterije";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "ID prodavca";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "ID zaposlenog";
            // 
            // btnIznajmi
            // 
            this.btnIznajmi.Location = new System.Drawing.Point(128, 205);
            this.btnIznajmi.Name = "btnIznajmi";
            this.btnIznajmi.Size = new System.Drawing.Size(100, 29);
            this.btnIznajmi.TabIndex = 6;
            this.btnIznajmi.Text = "Izajmi";
            this.btnIznajmi.UseVisualStyleBackColor = true;
            this.btnIznajmi.Click += new System.EventHandler(this.btnIznajmi_Click);
            // 
            // txtIDmusterije
            // 
            this.txtIDmusterije.Location = new System.Drawing.Point(128, 111);
            this.txtIDmusterije.Name = "txtIDmusterije";
            this.txtIDmusterije.Size = new System.Drawing.Size(130, 22);
            this.txtIDmusterije.TabIndex = 7;
            this.txtIDmusterije.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDmusterije_KeyPress);
            // 
            // txtStanarina
            // 
            this.txtStanarina.Location = new System.Drawing.Point(128, 21);
            this.txtStanarina.Name = "txtStanarina";
            this.txtStanarina.Size = new System.Drawing.Size(130, 22);
            this.txtStanarina.TabIndex = 8;
            this.txtStanarina.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStanarina_KeyPress);
            // 
            // txtIDProdavca
            // 
            this.txtIDProdavca.Location = new System.Drawing.Point(128, 139);
            this.txtIDProdavca.Name = "txtIDProdavca";
            this.txtIDProdavca.Size = new System.Drawing.Size(130, 22);
            this.txtIDProdavca.TabIndex = 9;
            this.txtIDProdavca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDProdavca_KeyPress);
            // 
            // txtIDZaposlenog
            // 
            this.txtIDZaposlenog.Location = new System.Drawing.Point(128, 167);
            this.txtIDZaposlenog.Name = "txtIDZaposlenog";
            this.txtIDZaposlenog.Size = new System.Drawing.Size(130, 22);
            this.txtIDZaposlenog.TabIndex = 10;
            this.txtIDZaposlenog.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDZaposlenog_KeyPress);
            // 
            // dateTimepocetak
            // 
            this.dateTimepocetak.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimepocetak.Location = new System.Drawing.Point(128, 53);
            this.dateTimepocetak.Name = "dateTimepocetak";
            this.dateTimepocetak.Size = new System.Drawing.Size(130, 22);
            this.dateTimepocetak.TabIndex = 11;
            // 
            // dateTimekraj
            // 
            this.dateTimekraj.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimekraj.Location = new System.Drawing.Point(128, 82);
            this.dateTimekraj.Name = "dateTimekraj";
            this.dateTimekraj.Size = new System.Drawing.Size(130, 22);
            this.dateTimekraj.TabIndex = 12;
            // 
            // Iznajmljivanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 257);
            this.Controls.Add(this.dateTimekraj);
            this.Controls.Add(this.dateTimepocetak);
            this.Controls.Add(this.txtIDZaposlenog);
            this.Controls.Add(this.txtIDProdavca);
            this.Controls.Add(this.txtStanarina);
            this.Controls.Add(this.txtIDmusterije);
            this.Controls.Add(this.btnIznajmi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Iznajmljivanje";
            this.Text = "Iznajmljivanje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnIznajmi;
        private System.Windows.Forms.TextBox txtIDmusterije;
        private System.Windows.Forms.TextBox txtStanarina;
        private System.Windows.Forms.TextBox txtIDProdavca;
        private System.Windows.Forms.TextBox txtIDZaposlenog;
        private System.Windows.Forms.DateTimePicker dateTimepocetak;
        private System.Windows.Forms.DateTimePicker dateTimekraj;
    }
}