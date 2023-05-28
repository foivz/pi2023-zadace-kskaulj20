namespace HR_Assistant
{
    partial class FrmObradeniZahtjevi
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
            this.dgvObradeni = new System.Windows.Forms.DataGridView();
            this.btnUredu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObradeni)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvObradeni
            // 
            this.dgvObradeni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObradeni.Location = new System.Drawing.Point(47, 28);
            this.dgvObradeni.Name = "dgvObradeni";
            this.dgvObradeni.RowHeadersWidth = 51;
            this.dgvObradeni.RowTemplate.Height = 24;
            this.dgvObradeni.Size = new System.Drawing.Size(700, 364);
            this.dgvObradeni.TabIndex = 0;
            this.dgvObradeni.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvObradeni_CellContentClick);
            // 
            // btnUredu
            // 
            this.btnUredu.Location = new System.Drawing.Point(315, 409);
            this.btnUredu.Name = "btnUredu";
            this.btnUredu.Size = new System.Drawing.Size(110, 29);
            this.btnUredu.TabIndex = 1;
            this.btnUredu.Text = "U redu";
            this.btnUredu.UseVisualStyleBackColor = true;
            this.btnUredu.Click += new System.EventHandler(this.btnUredu_Click);
            // 
            // FrmObradeniZahtjevi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUredu);
            this.Controls.Add(this.dgvObradeni);
            this.Name = "FrmObradeniZahtjevi";
            this.Text = "Obrađeni zahtjevi";
            this.Load += new System.EventHandler(this.FrmObradeniZahtjevi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvObradeni)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvObradeni;
        private System.Windows.Forms.Button btnUredu;
    }
}