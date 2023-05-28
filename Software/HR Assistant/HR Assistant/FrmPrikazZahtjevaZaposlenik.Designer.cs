namespace HR_Assistant
{
    partial class FrmPrikazZahtjevaZaposlenik
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
            this.dgvZahtjeviZaposlenik = new System.Windows.Forms.DataGridView();
            this.btnDodajZahtjev = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.lblDobrodosli = new System.Windows.Forms.Label();
            this.btnOdjava = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZahtjeviZaposlenik)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvZahtjeviZaposlenik
            // 
            this.dgvZahtjeviZaposlenik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZahtjeviZaposlenik.Location = new System.Drawing.Point(81, 76);
            this.dgvZahtjeviZaposlenik.Name = "dgvZahtjeviZaposlenik";
            this.dgvZahtjeviZaposlenik.RowHeadersWidth = 51;
            this.dgvZahtjeviZaposlenik.RowTemplate.Height = 24;
            this.dgvZahtjeviZaposlenik.Size = new System.Drawing.Size(709, 320);
            this.dgvZahtjeviZaposlenik.TabIndex = 0;
            this.dgvZahtjeviZaposlenik.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvZahtjeviZaposlenik_CellContentClick);
            // 
            // btnDodajZahtjev
            // 
            this.btnDodajZahtjev.Location = new System.Drawing.Point(81, 434);
            this.btnDodajZahtjev.Name = "btnDodajZahtjev";
            this.btnDodajZahtjev.Size = new System.Drawing.Size(104, 38);
            this.btnDodajZahtjev.TabIndex = 1;
            this.btnDodajZahtjev.Text = "Novi zahtjev";
            this.btnDodajZahtjev.UseVisualStyleBackColor = true;
            this.btnDodajZahtjev.Click += new System.EventHandler(this.btnDodajZahtjev_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(231, 434);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(102, 38);
            this.btnObrisi.TabIndex = 2;
            this.btnObrisi.Text = "Obriši zahtjev";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // lblDobrodosli
            // 
            this.lblDobrodosli.AutoSize = true;
            this.lblDobrodosli.Location = new System.Drawing.Point(78, 36);
            this.lblDobrodosli.Name = "lblDobrodosli";
            this.lblDobrodosli.Size = new System.Drawing.Size(77, 16);
            this.lblDobrodosli.TabIndex = 3;
            this.lblDobrodosli.Text = "Dobrodošli!";
            // 
            // btnOdjava
            // 
            this.btnOdjava.Location = new System.Drawing.Point(709, 36);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(81, 29);
            this.btnOdjava.TabIndex = 4;
            this.btnOdjava.Text = "Odjava";
            this.btnOdjava.UseVisualStyleBackColor = true;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // FrmPrikazZahtjevaZaposlenik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 495);
            this.Controls.Add(this.btnOdjava);
            this.Controls.Add(this.lblDobrodosli);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnDodajZahtjev);
            this.Controls.Add(this.dgvZahtjeviZaposlenik);
            this.Name = "FrmPrikazZahtjevaZaposlenik";
            this.Text = "Moji zahtjevi";
            this.Load += new System.EventHandler(this.FrmPrikazZahtjevaZaposlenik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZahtjeviZaposlenik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvZahtjeviZaposlenik;
        private System.Windows.Forms.Button btnDodajZahtjev;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Label lblDobrodosli;
        private System.Windows.Forms.Button btnOdjava;
    }
}