namespace KentKart_OOP
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtBBakiye = new System.Windows.Forms.TextBox();
            this.GboxOkulAdi = new System.Windows.Forms.GroupBox();
            this.TxtBOkulAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.RBtnTam = new System.Windows.Forms.RadioButton();
            this.RbtnOgretmen = new System.Windows.Forms.RadioButton();
            this.RBtnOgrenci = new System.Windows.Forms.RadioButton();
            this.LstBoxYolcular = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.GboxOkulAdi.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtBBakiye);
            this.groupBox1.Controls.Add(this.GboxOkulAdi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BtnEkle);
            this.groupBox1.Controls.Add(this.RBtnTam);
            this.groupBox1.Controls.Add(this.RbtnOgretmen);
            this.groupBox1.Controls.Add(this.RBtnOgrenci);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 130);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kart Oluştur";
            // 
            // TxtBBakiye
            // 
            this.TxtBBakiye.Location = new System.Drawing.Point(148, 39);
            this.TxtBBakiye.Name = "TxtBBakiye";
            this.TxtBBakiye.Size = new System.Drawing.Size(100, 23);
            this.TxtBBakiye.TabIndex = 3;
            // 
            // GboxOkulAdi
            // 
            this.GboxOkulAdi.Controls.Add(this.TxtBOkulAdi);
            this.GboxOkulAdi.Location = new System.Drawing.Point(142, 68);
            this.GboxOkulAdi.Name = "GboxOkulAdi";
            this.GboxOkulAdi.Size = new System.Drawing.Size(122, 54);
            this.GboxOkulAdi.TabIndex = 3;
            this.GboxOkulAdi.TabStop = false;
            this.GboxOkulAdi.Text = "Okul Adı";
            // 
            // TxtBOkulAdi
            // 
            this.TxtBOkulAdi.Location = new System.Drawing.Point(6, 22);
            this.TxtBOkulAdi.Name = "TxtBOkulAdi";
            this.TxtBOkulAdi.Size = new System.Drawing.Size(100, 23);
            this.TxtBOkulAdi.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(145, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bakiye";
            // 
            // BtnEkle
            // 
            this.BtnEkle.Location = new System.Drawing.Point(18, 101);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(75, 23);
            this.BtnEkle.TabIndex = 1;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.UseVisualStyleBackColor = true;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // RBtnTam
            // 
            this.RBtnTam.AutoSize = true;
            this.RBtnTam.Location = new System.Drawing.Point(18, 22);
            this.RBtnTam.Name = "RBtnTam";
            this.RBtnTam.Size = new System.Drawing.Size(54, 21);
            this.RBtnTam.TabIndex = 0;
            this.RBtnTam.TabStop = true;
            this.RBtnTam.Text = "Tam";
            this.RBtnTam.UseVisualStyleBackColor = true;
            // 
            // RbtnOgretmen
            // 
            this.RbtnOgretmen.AutoSize = true;
            this.RbtnOgretmen.Location = new System.Drawing.Point(17, 68);
            this.RbtnOgretmen.Name = "RbtnOgretmen";
            this.RbtnOgretmen.Size = new System.Drawing.Size(89, 21);
            this.RbtnOgretmen.TabIndex = 0;
            this.RbtnOgretmen.TabStop = true;
            this.RbtnOgretmen.Text = "Öğretmen";
            this.RbtnOgretmen.UseVisualStyleBackColor = true;
            // 
            // RBtnOgrenci
            // 
            this.RBtnOgrenci.AutoSize = true;
            this.RBtnOgrenci.Location = new System.Drawing.Point(17, 45);
            this.RBtnOgrenci.Name = "RBtnOgrenci";
            this.RBtnOgrenci.Size = new System.Drawing.Size(76, 21);
            this.RBtnOgrenci.TabIndex = 0;
            this.RBtnOgrenci.TabStop = true;
            this.RBtnOgrenci.Text = "Öğrenci";
            this.RBtnOgrenci.UseVisualStyleBackColor = true;
            this.RBtnOgrenci.CheckedChanged += new System.EventHandler(this.RBtnOgrenci_CheckedChanged);
            // 
            // LstBoxYolcular
            // 
            this.LstBoxYolcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LstBoxYolcular.FormattingEnabled = true;
            this.LstBoxYolcular.ItemHeight = 16;
            this.LstBoxYolcular.Location = new System.Drawing.Point(15, 165);
            this.LstBoxYolcular.Name = "LstBoxYolcular";
            this.LstBoxYolcular.Size = new System.Drawing.Size(279, 100);
            this.LstBoxYolcular.TabIndex = 1;
            this.LstBoxYolcular.DoubleClick += new System.EventHandler(this.LstBoxYolcular_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Yolcular";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 338);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LstBoxYolcular);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GboxOkulAdi.ResumeLayout(false);
            this.GboxOkulAdi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.RadioButton RBtnTam;
        private System.Windows.Forms.RadioButton RbtnOgretmen;
        private System.Windows.Forms.RadioButton RBtnOgrenci;
        private System.Windows.Forms.ListBox LstBoxYolcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBOkulAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox GboxOkulAdi;
        private System.Windows.Forms.TextBox TxtBBakiye;
    }
}

