namespace OzHakikiUlusoy
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
            this.AdSoyad = new System.Windows.Forms.Label();
            this.TxtMusteriAd = new System.Windows.Forms.TextBox();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.CboxOtobusTuru = new System.Windows.Forms.ComboBox();
            this.Cinsiyet = new System.Windows.Forms.GroupBox();
            this.RbtnKadin = new System.Windows.Forms.RadioButton();
            this.RbtnErkek = new System.Windows.Forms.RadioButton();
            this.LBoxMusteriler = new System.Windows.Forms.ListBox();
            this.Cinsiyet.SuspendLayout();
            this.SuspendLayout();
            // 
            // AdSoyad
            // 
            this.AdSoyad.AutoSize = true;
            this.AdSoyad.Location = new System.Drawing.Point(17, 16);
            this.AdSoyad.Name = "AdSoyad";
            this.AdSoyad.Size = new System.Drawing.Size(57, 13);
            this.AdSoyad.TabIndex = 0;
            this.AdSoyad.Text = " Ad SoyAd";
            // 
            // TxtMusteriAd
            // 
            this.TxtMusteriAd.Location = new System.Drawing.Point(12, 32);
            this.TxtMusteriAd.Name = "TxtMusteriAd";
            this.TxtMusteriAd.Size = new System.Drawing.Size(100, 20);
            this.TxtMusteriAd.TabIndex = 1;
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Location = new System.Drawing.Point(20, 209);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(75, 23);
            this.BtnKaydet.TabIndex = 2;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // CboxOtobusTuru
            // 
            this.CboxOtobusTuru.FormattingEnabled = true;
            this.CboxOtobusTuru.Items.AddRange(new object[] {
            "Travego",
            "Setra"});
            this.CboxOtobusTuru.Location = new System.Drawing.Point(20, 168);
            this.CboxOtobusTuru.Name = "CboxOtobusTuru";
            this.CboxOtobusTuru.Size = new System.Drawing.Size(121, 21);
            this.CboxOtobusTuru.TabIndex = 3;
            // 
            // Cinsiyet
            // 
            this.Cinsiyet.Controls.Add(this.RbtnKadin);
            this.Cinsiyet.Controls.Add(this.RbtnErkek);
            this.Cinsiyet.Location = new System.Drawing.Point(12, 58);
            this.Cinsiyet.Name = "Cinsiyet";
            this.Cinsiyet.Size = new System.Drawing.Size(129, 104);
            this.Cinsiyet.TabIndex = 4;
            this.Cinsiyet.TabStop = false;
            this.Cinsiyet.Text = "Cinsiyet";
            // 
            // RbtnKadin
            // 
            this.RbtnKadin.AutoSize = true;
            this.RbtnKadin.Location = new System.Drawing.Point(8, 44);
            this.RbtnKadin.Name = "RbtnKadin";
            this.RbtnKadin.Size = new System.Drawing.Size(52, 17);
            this.RbtnKadin.TabIndex = 1;
            this.RbtnKadin.TabStop = true;
            this.RbtnKadin.Text = "Kadin";
            this.RbtnKadin.UseVisualStyleBackColor = true;
            // 
            // RbtnErkek
            // 
            this.RbtnErkek.AutoSize = true;
            this.RbtnErkek.Location = new System.Drawing.Point(8, 20);
            this.RbtnErkek.Name = "RbtnErkek";
            this.RbtnErkek.Size = new System.Drawing.Size(53, 17);
            this.RbtnErkek.TabIndex = 0;
            this.RbtnErkek.TabStop = true;
            this.RbtnErkek.Text = "Erkek";
            this.RbtnErkek.UseVisualStyleBackColor = true;
            // 
            // LBoxMusteriler
            // 
            this.LBoxMusteriler.FormattingEnabled = true;
            this.LBoxMusteriler.Location = new System.Drawing.Point(152, 67);
            this.LBoxMusteriler.Name = "LBoxMusteriler";
            this.LBoxMusteriler.Size = new System.Drawing.Size(186, 264);
            this.LBoxMusteriler.TabIndex = 5;
            this.LBoxMusteriler.DoubleClick += new System.EventHandler(this.LBoxMusteriler_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 369);
            this.Controls.Add(this.LBoxMusteriler);
            this.Controls.Add(this.Cinsiyet);
            this.Controls.Add(this.CboxOtobusTuru);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.TxtMusteriAd);
            this.Controls.Add(this.AdSoyad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Cinsiyet.ResumeLayout(false);
            this.Cinsiyet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AdSoyad;
        private System.Windows.Forms.TextBox TxtMusteriAd;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.ComboBox CboxOtobusTuru;
        private System.Windows.Forms.GroupBox Cinsiyet;
        private System.Windows.Forms.RadioButton RbtnKadin;
        private System.Windows.Forms.RadioButton RbtnErkek;
        private System.Windows.Forms.ListBox LBoxMusteriler;
    }
}

