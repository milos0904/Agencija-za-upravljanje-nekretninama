namespace Nekretnine
{
    partial class KupoprodajniUgovor
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
            this.txtIDProdavca = new System.Windows.Forms.TextBox();
            this.txtIDMusterije = new System.Windows.Forms.TextBox();
            this.btnKupiStambenu = new System.Windows.Forms.Button();
            this.idZaposlenog = new System.Windows.Forms.Label();
            this.txtIDZaposlenog = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID prodavca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID musterije";
            // 
            // txtIDProdavca
            // 
            this.txtIDProdavca.Location = new System.Drawing.Point(115, 42);
            this.txtIDProdavca.Name = "txtIDProdavca";
            this.txtIDProdavca.Size = new System.Drawing.Size(100, 22);
            this.txtIDProdavca.TabIndex = 2;
            this.txtIDProdavca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDProdavca_KeyPress);
            // 
            // txtIDMusterije
            // 
            this.txtIDMusterije.Location = new System.Drawing.Point(115, 80);
            this.txtIDMusterije.Name = "txtIDMusterije";
            this.txtIDMusterije.Size = new System.Drawing.Size(100, 22);
            this.txtIDMusterije.TabIndex = 3;
            this.txtIDMusterije.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDMusterije_KeyPress);
            // 
            // btnKupiStambenu
            // 
            this.btnKupiStambenu.Location = new System.Drawing.Point(115, 153);
            this.btnKupiStambenu.Name = "btnKupiStambenu";
            this.btnKupiStambenu.Size = new System.Drawing.Size(100, 27);
            this.btnKupiStambenu.TabIndex = 4;
            this.btnKupiStambenu.Text = "Kupi";
            this.btnKupiStambenu.UseVisualStyleBackColor = true;
            this.btnKupiStambenu.Click += new System.EventHandler(this.btnKupiStambenu_Click);
            // 
            // idZaposlenog
            // 
            this.idZaposlenog.AutoSize = true;
            this.idZaposlenog.Location = new System.Drawing.Point(14, 113);
            this.idZaposlenog.Name = "idZaposlenog";
            this.idZaposlenog.Size = new System.Drawing.Size(49, 17);
            this.idZaposlenog.TabIndex = 5;
            this.idZaposlenog.Text = "Vas ID";
            // 
            // txtIDZaposlenog
            // 
            this.txtIDZaposlenog.Location = new System.Drawing.Point(115, 113);
            this.txtIDZaposlenog.Name = "txtIDZaposlenog";
            this.txtIDZaposlenog.Size = new System.Drawing.Size(100, 22);
            this.txtIDZaposlenog.TabIndex = 6;
            this.txtIDZaposlenog.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDZaposlenog_KeyPress);
            // 
            // KupoprodajniUgovor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 192);
            this.Controls.Add(this.txtIDZaposlenog);
            this.Controls.Add(this.idZaposlenog);
            this.Controls.Add(this.btnKupiStambenu);
            this.Controls.Add(this.txtIDMusterije);
            this.Controls.Add(this.txtIDProdavca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KupoprodajniUgovor";
            this.Text = "KupoprodajniUgovor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDProdavca;
        private System.Windows.Forms.TextBox txtIDMusterije;
        private System.Windows.Forms.Button btnKupiStambenu;
        private System.Windows.Forms.Label idZaposlenog;
        private System.Windows.Forms.TextBox txtIDZaposlenog;
    }
}