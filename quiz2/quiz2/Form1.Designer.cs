namespace quiz2
{
    partial class Form1
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
            this.LabelAbone = new System.Windows.Forms.Label();
            this.TxtBAdSoyad = new System.Windows.Forms.TextBox();
            this.GboxAboneTipi = new System.Windows.Forms.GroupBox();
            this.RbtnEv = new System.Windows.Forms.RadioButton();
            this.RbtnSirket = new System.Windows.Forms.RadioButton();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.listBAbone = new System.Windows.Forms.ListBox();
            this.listBOdenen = new System.Windows.Forms.ListBox();
            this.TxtBIlkIndex = new System.Windows.Forms.TextBox();
            this.TxtBSonIndex = new System.Windows.Forms.TextBox();
            this.LblIlkIndex = new System.Windows.Forms.Label();
            this.LblSonIndex = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GboxAboneTipi.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelAbone
            // 
            this.LabelAbone.AutoSize = true;
            this.LabelAbone.Location = new System.Drawing.Point(13, 13);
            this.LabelAbone.Name = "LabelAbone";
            this.LabelAbone.Size = new System.Drawing.Size(56, 13);
            this.LabelAbone.TabIndex = 0;
            this.LabelAbone.Text = "Abone Adi";
            // 
            // TxtBAdSoyad
            // 
            this.TxtBAdSoyad.Location = new System.Drawing.Point(12, 29);
            this.TxtBAdSoyad.Name = "TxtBAdSoyad";
            this.TxtBAdSoyad.Size = new System.Drawing.Size(100, 20);
            this.TxtBAdSoyad.TabIndex = 1;
            // 
            // GboxAboneTipi
            // 
            this.GboxAboneTipi.Controls.Add(this.RbtnSirket);
            this.GboxAboneTipi.Controls.Add(this.RbtnEv);
            this.GboxAboneTipi.Location = new System.Drawing.Point(12, 67);
            this.GboxAboneTipi.Name = "GboxAboneTipi";
            this.GboxAboneTipi.Size = new System.Drawing.Size(108, 100);
            this.GboxAboneTipi.TabIndex = 2;
            this.GboxAboneTipi.TabStop = false;
            this.GboxAboneTipi.Text = "Abone Tipi";
            // 
            // RbtnEv
            // 
            this.RbtnEv.AutoSize = true;
            this.RbtnEv.Location = new System.Drawing.Point(7, 20);
            this.RbtnEv.Name = "RbtnEv";
            this.RbtnEv.Size = new System.Drawing.Size(38, 17);
            this.RbtnEv.TabIndex = 0;
            this.RbtnEv.TabStop = true;
            this.RbtnEv.Text = "Ev";
            this.RbtnEv.UseVisualStyleBackColor = true;
            // 
            // RbtnSirket
            // 
            this.RbtnSirket.AutoSize = true;
            this.RbtnSirket.Location = new System.Drawing.Point(7, 55);
            this.RbtnSirket.Name = "RbtnSirket";
            this.RbtnSirket.Size = new System.Drawing.Size(52, 17);
            this.RbtnSirket.TabIndex = 1;
            this.RbtnSirket.TabStop = true;
            this.RbtnSirket.Text = "Şirket";
            this.RbtnSirket.UseVisualStyleBackColor = true;
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Location = new System.Drawing.Point(115, 252);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(75, 23);
            this.BtnKaydet.TabIndex = 3;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // listBAbone
            // 
            this.listBAbone.FormattingEnabled = true;
            this.listBAbone.Location = new System.Drawing.Point(12, 302);
            this.listBAbone.Name = "listBAbone";
            this.listBAbone.Size = new System.Drawing.Size(120, 95);
            this.listBAbone.TabIndex = 4;
            this.listBAbone.DoubleClick += new System.EventHandler(this.listBAbone_DoubleClick);
            // 
            // listBOdenen
            // 
            this.listBOdenen.FormattingEnabled = true;
            this.listBOdenen.Location = new System.Drawing.Point(163, 302);
            this.listBOdenen.Name = "listBOdenen";
            this.listBOdenen.Size = new System.Drawing.Size(120, 95);
            this.listBOdenen.TabIndex = 5;
            // 
            // TxtBIlkIndex
            // 
            this.TxtBIlkIndex.Location = new System.Drawing.Point(99, 185);
            this.TxtBIlkIndex.Name = "TxtBIlkIndex";
            this.TxtBIlkIndex.Size = new System.Drawing.Size(100, 20);
            this.TxtBIlkIndex.TabIndex = 6;
            // 
            // TxtBSonIndex
            // 
            this.TxtBSonIndex.Location = new System.Drawing.Point(99, 226);
            this.TxtBSonIndex.Name = "TxtBSonIndex";
            this.TxtBSonIndex.Size = new System.Drawing.Size(100, 20);
            this.TxtBSonIndex.TabIndex = 7;
            // 
            // LblIlkIndex
            // 
            this.LblIlkIndex.AutoSize = true;
            this.LblIlkIndex.Location = new System.Drawing.Point(112, 169);
            this.LblIlkIndex.Name = "LblIlkIndex";
            this.LblIlkIndex.Size = new System.Drawing.Size(70, 13);
            this.LblIlkIndex.TabIndex = 8;
            this.LblIlkIndex.Text = "Önceki İndex";
            // 
            // LblSonIndex
            // 
            this.LblSonIndex.AutoSize = true;
            this.LblSonIndex.Location = new System.Drawing.Point(127, 208);
            this.LblSonIndex.Name = "LblSonIndex";
            this.LblSonIndex.Size = new System.Drawing.Size(55, 13);
            this.LblSonIndex.TabIndex = 9;
            this.LblSonIndex.Text = "Son İndex";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ödenecekler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ödenenler";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 409);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblSonIndex);
            this.Controls.Add(this.LblIlkIndex);
            this.Controls.Add(this.TxtBSonIndex);
            this.Controls.Add(this.TxtBIlkIndex);
            this.Controls.Add(this.listBOdenen);
            this.Controls.Add(this.listBAbone);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.GboxAboneTipi);
            this.Controls.Add(this.TxtBAdSoyad);
            this.Controls.Add(this.LabelAbone);
            this.Name = "Form1";
            this.Text = "Izsu";
            this.GboxAboneTipi.ResumeLayout(false);
            this.GboxAboneTipi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelAbone;
        private System.Windows.Forms.TextBox TxtBAdSoyad;
        private System.Windows.Forms.GroupBox GboxAboneTipi;
        private System.Windows.Forms.RadioButton RbtnSirket;
        private System.Windows.Forms.RadioButton RbtnEv;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.ListBox listBAbone;
        private System.Windows.Forms.ListBox listBOdenen;
        private System.Windows.Forms.TextBox TxtBIlkIndex;
        private System.Windows.Forms.TextBox TxtBSonIndex;
        private System.Windows.Forms.Label LblIlkIndex;
        private System.Windows.Forms.Label LblSonIndex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

