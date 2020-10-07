namespace Nekretnine
{
    partial class KvartInfo
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
            this.btnSacuvajIzmene = new System.Windows.Forms.Button();
            this.txtPoslovnica = new System.Windows.Forms.TextBox();
            this.txtGradskaZona = new System.Windows.Forms.TextBox();
            this.lblPoslovnica = new System.Windows.Forms.Label();
            this.lblGradskaZona = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSacuvajIzmene
            // 
            this.btnSacuvajIzmene.Location = new System.Drawing.Point(114, 116);
            this.btnSacuvajIzmene.Name = "btnSacuvajIzmene";
            this.btnSacuvajIzmene.Size = new System.Drawing.Size(100, 48);
            this.btnSacuvajIzmene.TabIndex = 15;
            this.btnSacuvajIzmene.Text = "Sacuvaj";
            this.btnSacuvajIzmene.UseVisualStyleBackColor = true;
            this.btnSacuvajIzmene.Click += new System.EventHandler(this.btnSacuvajIzmene_Click);
            // 
            // txtPoslovnica
            // 
            this.txtPoslovnica.Location = new System.Drawing.Point(114, 57);
            this.txtPoslovnica.MaxLength = 13;
            this.txtPoslovnica.Name = "txtPoslovnica";
            this.txtPoslovnica.Size = new System.Drawing.Size(100, 22);
            this.txtPoslovnica.TabIndex = 13;
            this.txtPoslovnica.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPoslovnica_KeyPress);
            // 
            // txtGradskaZona
            // 
            this.txtGradskaZona.Location = new System.Drawing.Point(114, 22);
            this.txtGradskaZona.Name = "txtGradskaZona";
            this.txtGradskaZona.Size = new System.Drawing.Size(100, 22);
            this.txtGradskaZona.TabIndex = 11;
            // 
            // lblPoslovnica
            // 
            this.lblPoslovnica.AutoSize = true;
            this.lblPoslovnica.Location = new System.Drawing.Point(8, 57);
            this.lblPoslovnica.Name = "lblPoslovnica";
            this.lblPoslovnica.Size = new System.Drawing.Size(92, 17);
            this.lblPoslovnica.TabIndex = 10;
            this.lblPoslovnica.Text = "ID poslovnice";
            // 
            // lblGradskaZona
            // 
            this.lblGradskaZona.AutoSize = true;
            this.lblGradskaZona.Location = new System.Drawing.Point(3, 22);
            this.lblGradskaZona.Name = "lblGradskaZona";
            this.lblGradskaZona.Size = new System.Drawing.Size(97, 17);
            this.lblGradskaZona.TabIndex = 9;
            this.lblGradskaZona.Text = "Gradska zona";
            // 
            // KvartInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 220);
            this.Controls.Add(this.btnSacuvajIzmene);
            this.Controls.Add(this.txtPoslovnica);
            this.Controls.Add(this.txtGradskaZona);
            this.Controls.Add(this.lblPoslovnica);
            this.Controls.Add(this.lblGradskaZona);
            this.Name = "KvartInfo";
            this.Text = "KvartInfo";
            this.Load += new System.EventHandler(this.KvartInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSacuvajIzmene;
        private System.Windows.Forms.TextBox txtPoslovnica;
        private System.Windows.Forms.TextBox txtGradskaZona;
        private System.Windows.Forms.Label lblPoslovnica;
        private System.Windows.Forms.Label lblGradskaZona;
    }
}