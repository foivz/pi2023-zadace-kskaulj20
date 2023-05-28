namespace HR_Assistant
{
    partial class frmPrikazZahtjeva
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
            this.dgvZahtjevi = new System.Windows.Forms.DataGridView();
            this.BtnIzvjestaj = new System.Windows.Forms.Button();
            this.lblDobrodosli = new System.Windows.Forms.Label();
            this.btnObradeni = new System.Windows.Forms.Button();
            this.txtPretrazi = new System.Windows.Forms.TextBox();
            this.btnPretrazi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZahtjevi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvZahtjevi
            // 
            this.dgvZahtjevi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZahtjevi.Location = new System.Drawing.Point(43, 113);
            this.dgvZahtjevi.Name = "dgvZahtjevi";
            this.dgvZahtjevi.RowHeadersWidth = 51;
            this.dgvZahtjevi.RowTemplate.Height = 24;
            this.dgvZahtjevi.Size = new System.Drawing.Size(902, 285);
            this.dgvZahtjevi.TabIndex = 0;
            this.dgvZahtjevi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvZahtjevi_CellContentClick);
            // 
            // BtnIzvjestaj
            // 
            this.BtnIzvjestaj.Location = new System.Drawing.Point(847, 414);
            this.BtnIzvjestaj.Name = "BtnIzvjestaj";
            this.BtnIzvjestaj.Size = new System.Drawing.Size(98, 34);
            this.BtnIzvjestaj.TabIndex = 1;
            this.BtnIzvjestaj.Text = "Izvještaj";
            this.BtnIzvjestaj.UseVisualStyleBackColor = true;
            // 
            // lblDobrodosli
            // 
            this.lblDobrodosli.AutoSize = true;
            this.lblDobrodosli.Location = new System.Drawing.Point(40, 42);
            this.lblDobrodosli.Name = "lblDobrodosli";
            this.lblDobrodosli.Size = new System.Drawing.Size(118, 16);
            this.lblDobrodosli.TabIndex = 4;
            this.lblDobrodosli.Text = "Dobrodošli natrag!";
            // 
            // btnObradeni
            // 
            this.btnObradeni.Location = new System.Drawing.Point(43, 415);
            this.btnObradeni.Name = "btnObradeni";
            this.btnObradeni.Size = new System.Drawing.Size(137, 33);
            this.btnObradeni.TabIndex = 5;
            this.btnObradeni.Text = "Obrađeni zahtjevi";
            this.btnObradeni.UseVisualStyleBackColor = true;
            this.btnObradeni.Click += new System.EventHandler(this.btnObradeni_Click);
            // 
            // txtPretrazi
            // 
            this.txtPretrazi.Location = new System.Drawing.Point(164, 76);
            this.txtPretrazi.Name = "txtPretrazi";
            this.txtPretrazi.Size = new System.Drawing.Size(228, 22);
            this.txtPretrazi.TabIndex = 6;
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Location = new System.Drawing.Point(43, 76);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(115, 23);
            this.btnPretrazi.TabIndex = 7;
            this.btnPretrazi.Text = "Pretraži po ID-u";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // frmPrikazZahtjeva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 488);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.txtPretrazi);
            this.Controls.Add(this.btnObradeni);
            this.Controls.Add(this.lblDobrodosli);
            this.Controls.Add(this.BtnIzvjestaj);
            this.Controls.Add(this.dgvZahtjevi);
            this.Name = "frmPrikazZahtjeva";
            this.Text = "Zaprimljeni zahtjevi";
            this.Load += new System.EventHandler(this.frmPrikazZahtjeva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZahtjevi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvZahtjevi;
        private System.Windows.Forms.Button BtnIzvjestaj;
        private System.Windows.Forms.Label lblDobrodosli;
        private System.Windows.Forms.Button btnObradeni;
        private System.Windows.Forms.TextBox txtPretrazi;
        private System.Windows.Forms.Button btnPretrazi;
    }
}