namespace HR_Assistant
{
    partial class FrmNoviZahtjev
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
            this.cboRazlog = new System.Windows.Forms.ComboBox();
            this.txtKomentar = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPodnesiZahtjev = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.txtPocetak = new System.Windows.Forms.TextBox();
            this.txtKraj = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboRazlog
            // 
            this.cboRazlog.FormattingEnabled = true;
            this.cboRazlog.Location = new System.Drawing.Point(34, 253);
            this.cboRazlog.Name = "cboRazlog";
            this.cboRazlog.Size = new System.Drawing.Size(302, 24);
            this.cboRazlog.TabIndex = 2;
            // 
            // txtKomentar
            // 
            this.txtKomentar.Location = new System.Drawing.Point(34, 336);
            this.txtKomentar.Name = "txtKomentar";
            this.txtKomentar.Size = new System.Drawing.Size(302, 150);
            this.txtKomentar.TabIndex = 3;
            this.txtKomentar.Text = "";
            this.txtKomentar.TextChanged += new System.EventHandler(this.txtKomentar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Početak odsustva:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Završetak odsustva:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Razlog odsustva:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Komentar (opcionalno):";
            // 
            // btnPodnesiZahtjev
            // 
            this.btnPodnesiZahtjev.Location = new System.Drawing.Point(64, 541);
            this.btnPodnesiZahtjev.Name = "btnPodnesiZahtjev";
            this.btnPodnesiZahtjev.Size = new System.Drawing.Size(112, 30);
            this.btnPodnesiZahtjev.TabIndex = 8;
            this.btnPodnesiZahtjev.Text = "Podnesi zahtjev";
            this.btnPodnesiZahtjev.UseVisualStyleBackColor = true;
            this.btnPodnesiZahtjev.Click += new System.EventHandler(this.btnPodnesiZahtjev_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(237, 541);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(99, 30);
            this.btnOdustani.TabIndex = 9;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            // 
            // txtPocetak
            // 
            this.txtPocetak.Location = new System.Drawing.Point(34, 91);
            this.txtPocetak.Name = "txtPocetak";
            this.txtPocetak.Size = new System.Drawing.Size(100, 22);
            this.txtPocetak.TabIndex = 10;
            // 
            // txtKraj
            // 
            this.txtKraj.Location = new System.Drawing.Point(34, 181);
            this.txtKraj.Name = "txtKraj";
            this.txtKraj.Size = new System.Drawing.Size(100, 22);
            this.txtKraj.TabIndex = 11;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(295, 91);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(78, 22);
            this.txtId.TabIndex = 12;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(292, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "ID zahtjev:";
            // 
            // FrmNoviZahtjev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 617);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtKraj);
            this.Controls.Add(this.txtPocetak);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnPodnesiZahtjev);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKomentar);
            this.Controls.Add(this.cboRazlog);
            this.Name = "FrmNoviZahtjev";
            this.Text = "Novi zahtjev";
            this.Load += new System.EventHandler(this.FrmNoviZahtjev_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cboRazlog;
        private System.Windows.Forms.RichTextBox txtKomentar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPodnesiZahtjev;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.TextBox txtPocetak;
        private System.Windows.Forms.TextBox txtKraj;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label5;
    }
}