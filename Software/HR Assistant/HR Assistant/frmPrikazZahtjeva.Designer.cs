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
            this.dgvUloga = new System.Windows.Forms.DataGridView();
            this.dgvKor_Ime = new System.Windows.Forms.DataGridView();
            this.lblDobrodosli = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZahtjevi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUloga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKor_Ime)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvZahtjevi
            // 
            this.dgvZahtjevi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZahtjevi.Location = new System.Drawing.Point(43, 88);
            this.dgvZahtjevi.Name = "dgvZahtjevi";
            this.dgvZahtjevi.RowHeadersWidth = 51;
            this.dgvZahtjevi.RowTemplate.Height = 24;
            this.dgvZahtjevi.Size = new System.Drawing.Size(711, 284);
            this.dgvZahtjevi.TabIndex = 0;
            this.dgvZahtjevi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvZahtjevi_CellContentClick);
            // 
            // BtnIzvjestaj
            // 
            this.BtnIzvjestaj.Location = new System.Drawing.Point(656, 395);
            this.BtnIzvjestaj.Name = "BtnIzvjestaj";
            this.BtnIzvjestaj.Size = new System.Drawing.Size(98, 34);
            this.BtnIzvjestaj.TabIndex = 1;
            this.BtnIzvjestaj.Text = "Izvještaj";
            this.BtnIzvjestaj.UseVisualStyleBackColor = true;
            // 
            // dgvUloga
            // 
            this.dgvUloga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUloga.Location = new System.Drawing.Point(613, 29);
            this.dgvUloga.Name = "dgvUloga";
            this.dgvUloga.RowHeadersWidth = 51;
            this.dgvUloga.RowTemplate.Height = 24;
            this.dgvUloga.Size = new System.Drawing.Size(140, 30);
            this.dgvUloga.TabIndex = 2;
            // 
            // dgvKor_Ime
            // 
            this.dgvKor_Ime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKor_Ime.Location = new System.Drawing.Point(136, 29);
            this.dgvKor_Ime.Name = "dgvKor_Ime";
            this.dgvKor_Ime.RowHeadersWidth = 51;
            this.dgvKor_Ime.RowTemplate.Height = 24;
            this.dgvKor_Ime.Size = new System.Drawing.Size(87, 29);
            this.dgvKor_Ime.TabIndex = 3;
            this.dgvKor_Ime.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKor_Ime_CellContentClick);
            // 
            // lblDobrodosli
            // 
            this.lblDobrodosli.AutoSize = true;
            this.lblDobrodosli.Location = new System.Drawing.Point(40, 42);
            this.lblDobrodosli.Name = "lblDobrodosli";
            this.lblDobrodosli.Size = new System.Drawing.Size(80, 16);
            this.lblDobrodosli.TabIndex = 4;
            this.lblDobrodosli.Text = "Dobrodošli, ";
            // 
            // frmPrikazZahtjeva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDobrodosli);
            this.Controls.Add(this.dgvKor_Ime);
            this.Controls.Add(this.dgvUloga);
            this.Controls.Add(this.BtnIzvjestaj);
            this.Controls.Add(this.dgvZahtjevi);
            this.Name = "frmPrikazZahtjeva";
            this.Text = "Zaprimljeni zahtjevi";
            this.Load += new System.EventHandler(this.frmPrikazZahtjeva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZahtjevi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUloga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKor_Ime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvZahtjevi;
        private System.Windows.Forms.Button BtnIzvjestaj;
        private System.Windows.Forms.DataGridView dgvUloga;
        private System.Windows.Forms.DataGridView dgvKor_Ime;
        private System.Windows.Forms.Label lblDobrodosli;
    }
}