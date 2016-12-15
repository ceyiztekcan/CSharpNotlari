namespace OtobusFirmasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CBoxOtobusTuru = new System.Windows.Forms.ComboBox();
            this.panelTravego = new System.Windows.Forms.Panel();
            this.panelSetra = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Kaydet = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RBtnKadin = new System.Windows.Forms.RadioButton();
            this.RBtnErkek = new System.Windows.Forms.RadioButton();
            this.TxtYolcuIsim = new System.Windows.Forms.TextBox();
            this.LabelKoltukNo = new System.Windows.Forms.Label();
            this.LabelOtobusTuru = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(632, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Otobüs Türü";
            // 
            // CBoxOtobusTuru
            // 
            this.CBoxOtobusTuru.FormattingEnabled = true;
            this.CBoxOtobusTuru.Items.AddRange(new object[] {
            "Travego",
            "Setra"});
            this.CBoxOtobusTuru.Location = new System.Drawing.Point(15, 157);
            this.CBoxOtobusTuru.Name = "CBoxOtobusTuru";
            this.CBoxOtobusTuru.Size = new System.Drawing.Size(121, 21);
            this.CBoxOtobusTuru.TabIndex = 2;
            this.CBoxOtobusTuru.SelectedIndexChanged += new System.EventHandler(this.CBoxOtobusTuru_SelectedIndexChanged);
            // 
            // panelTravego
            // 
            this.panelTravego.Location = new System.Drawing.Point(153, 157);
            this.panelTravego.Name = "panelTravego";
            this.panelTravego.Size = new System.Drawing.Size(204, 438);
            this.panelTravego.TabIndex = 3;
            // 
            // panelSetra
            // 
            this.panelSetra.Location = new System.Drawing.Point(156, 157);
            this.panelSetra.Name = "panelSetra";
            this.panelSetra.Size = new System.Drawing.Size(204, 463);
            this.panelSetra.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Kaydet);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.TxtYolcuIsim);
            this.groupBox1.Controls.Add(this.LabelKoltukNo);
            this.groupBox1.Controls.Add(this.LabelOtobusTuru);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(407, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 238);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Bilgileri";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-3, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Otobüs Turu :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Koltuk No :";
            // 
            // Kaydet
            // 
            this.Kaydet.Location = new System.Drawing.Point(58, 177);
            this.Kaydet.Name = "Kaydet";
            this.Kaydet.Size = new System.Drawing.Size(75, 23);
            this.Kaydet.TabIndex = 3;
            this.Kaydet.Text = "Kaydet";
            this.Kaydet.UseVisualStyleBackColor = true;
            this.Kaydet.Click += new System.EventHandler(this.Kaydet_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RBtnKadin);
            this.groupBox2.Controls.Add(this.RBtnErkek);
            this.groupBox2.Location = new System.Drawing.Point(6, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(166, 51);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cinsiyet";
            // 
            // RBtnKadin
            // 
            this.RBtnKadin.AutoSize = true;
            this.RBtnKadin.Location = new System.Drawing.Point(94, 19);
            this.RBtnKadin.Name = "RBtnKadin";
            this.RBtnKadin.Size = new System.Drawing.Size(52, 17);
            this.RBtnKadin.TabIndex = 0;
            this.RBtnKadin.TabStop = true;
            this.RBtnKadin.Text = "Kadın";
            this.RBtnKadin.UseVisualStyleBackColor = true;
            // 
            // RBtnErkek
            // 
            this.RBtnErkek.AutoSize = true;
            this.RBtnErkek.Location = new System.Drawing.Point(3, 19);
            this.RBtnErkek.Name = "RBtnErkek";
            this.RBtnErkek.Size = new System.Drawing.Size(53, 17);
            this.RBtnErkek.TabIndex = 0;
            this.RBtnErkek.TabStop = true;
            this.RBtnErkek.Text = "Erkek";
            this.RBtnErkek.UseVisualStyleBackColor = true;
            // 
            // TxtYolcuIsim
            // 
            this.TxtYolcuIsim.Location = new System.Drawing.Point(0, 44);
            this.TxtYolcuIsim.Name = "TxtYolcuIsim";
            this.TxtYolcuIsim.Size = new System.Drawing.Size(100, 20);
            this.TxtYolcuIsim.TabIndex = 1;
            // 
            // LabelKoltukNo
            // 
            this.LabelKoltukNo.AutoSize = true;
            this.LabelKoltukNo.Location = new System.Drawing.Point(87, 134);
            this.LabelKoltukNo.Name = "LabelKoltukNo";
            this.LabelKoltukNo.Size = new System.Drawing.Size(13, 13);
            this.LabelKoltukNo.TabIndex = 0;
            this.LabelKoltukNo.Text = "0";
            // 
            // LabelOtobusTuru
            // 
            this.LabelOtobusTuru.AutoSize = true;
            this.LabelOtobusTuru.Location = new System.Drawing.Point(87, 161);
            this.LabelOtobusTuru.Name = "LabelOtobusTuru";
            this.LabelOtobusTuru.Size = new System.Drawing.Size(10, 13);
            this.LabelOtobusTuru.TabIndex = 0;
            this.LabelOtobusTuru.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ad Soyad";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 688);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelSetra);
            this.Controls.Add(this.panelTravego);
            this.Controls.Add(this.CBoxOtobusTuru);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBoxOtobusTuru;
        private System.Windows.Forms.Panel panelTravego;
        private System.Windows.Forms.Panel panelSetra;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RBtnKadin;
        private System.Windows.Forms.RadioButton RBtnErkek;
        private System.Windows.Forms.TextBox TxtYolcuIsim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Kaydet;
        private System.Windows.Forms.Label LabelKoltukNo;
        private System.Windows.Forms.Label LabelOtobusTuru;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

