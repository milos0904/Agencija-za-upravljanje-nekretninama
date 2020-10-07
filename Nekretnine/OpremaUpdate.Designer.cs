namespace Nekretnine
{
    partial class OpremaUpdate
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
            this.listViewOpreme = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnObrisiOpremu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewOpreme
            // 
            this.listViewOpreme.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewOpreme.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewOpreme.Location = new System.Drawing.Point(12, 12);
            this.listViewOpreme.Name = "listViewOpreme";
            this.listViewOpreme.Size = new System.Drawing.Size(249, 178);
            this.listViewOpreme.TabIndex = 0;
            this.listViewOpreme.UseCompatibleStateImageBehavior = false;
            this.listViewOpreme.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Oprema";
            this.columnHeader2.Width = 83;
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnIzmeni.Location = new System.Drawing.Point(12, 196);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(75, 31);
            this.btnIzmeni.TabIndex = 1;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // btnObrisiOpremu
            // 
            this.btnObrisiOpremu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnObrisiOpremu.Location = new System.Drawing.Point(93, 196);
            this.btnObrisiOpremu.Name = "btnObrisiOpremu";
            this.btnObrisiOpremu.Size = new System.Drawing.Size(89, 31);
            this.btnObrisiOpremu.TabIndex = 2;
            this.btnObrisiOpremu.Text = "Obrisi";
            this.btnObrisiOpremu.UseVisualStyleBackColor = true;
            this.btnObrisiOpremu.Click += new System.EventHandler(this.btnObrisiOpremu_Click);
            // 
            // OpremaUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 239);
            this.Controls.Add(this.btnObrisiOpremu);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.listViewOpreme);
            this.MaximizeBox = false;
            this.Name = "OpremaUpdate";
            this.Text = "OpremaUpdate";
            this.Load += new System.EventHandler(this.OpremaUpdate_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewOpreme;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnObrisiOpremu;
    }
}