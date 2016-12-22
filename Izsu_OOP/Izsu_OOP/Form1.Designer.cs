namespace IZSU_OOP
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtAboneNo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ListBoxAboneler = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RadioBtnKurum = new System.Windows.Forms.RadioButton();
            this.RadioBtnEv = new System.Windows.Forms.RadioButton();
            this.TxtAdSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtOncekiSayac = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtSonSayac = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ListBoxOdenenler = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Abone No";
            // 
            // TxtAboneNo
            // 
            this.TxtAboneNo.Location = new System.Drawing.Point(125, 4);
            this.TxtAboneNo.Name = "TxtAboneNo";
            this.TxtAboneNo.Size = new System.Drawing.Size(156, 20);
            this.TxtAboneNo.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(15, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(265, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Kayıt Ekle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ListBoxAboneler
            // 
            this.ListBoxAboneler.FormattingEnabled = true;
            this.ListBoxAboneler.Location = new System.Drawing.Point(15, 221);
            this.ListBoxAboneler.Name = "ListBoxAboneler";
            this.ListBoxAboneler.Size = new System.Drawing.Size(120, 95);
            this.ListBoxAboneler.TabIndex = 3;
            this.ListBoxAboneler.DoubleClick += new System.EventHandler(this.ListBoxOdenecekler_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RadioBtnKurum);
            this.groupBox1.Controls.Add(this.RadioBtnEv);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(15, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 50);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Abone Türü";
            // 
            // RadioBtnKurum
            // 
            this.RadioBtnKurum.AutoSize = true;
            this.RadioBtnKurum.Location = new System.Drawing.Point(173, 22);
            this.RadioBtnKurum.Name = "RadioBtnKurum";
            this.RadioBtnKurum.Size = new System.Drawing.Size(72, 21);
            this.RadioBtnKurum.TabIndex = 1;
            this.RadioBtnKurum.TabStop = true;
            this.RadioBtnKurum.Text = "Kurum";
            this.RadioBtnKurum.UseVisualStyleBackColor = true;
            // 
            // RadioBtnEv
            // 
            this.RadioBtnEv.AutoSize = true;
            this.RadioBtnEv.Location = new System.Drawing.Point(110, 22);
            this.RadioBtnEv.Name = "RadioBtnEv";
            this.RadioBtnEv.Size = new System.Drawing.Size(44, 21);
            this.RadioBtnEv.TabIndex = 0;
            this.RadioBtnEv.TabStop = true;
            this.RadioBtnEv.Text = "Ev";
            this.RadioBtnEv.UseVisualStyleBackColor = true;
            // 
            // TxtAdSoyad
            // 
            this.TxtAdSoyad.Location = new System.Drawing.Point(125, 30);
            this.TxtAdSoyad.Name = "TxtAdSoyad";
            this.TxtAdSoyad.Size = new System.Drawing.Size(156, 20);
            this.TxtAdSoyad.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "İsim Soyisim";
            // 
            // TxtOncekiSayac
            // 
            this.TxtOncekiSayac.Location = new System.Drawing.Point(125, 56);
            this.TxtOncekiSayac.Name = "TxtOncekiSayac";
            this.TxtOncekiSayac.Size = new System.Drawing.Size(156, 20);
            this.TxtOncekiSayac.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Önceki Sayaç";
            // 
            // TxtSonSayac
            // 
            this.TxtSonSayac.Location = new System.Drawing.Point(125, 84);
            this.TxtSonSayac.Name = "TxtSonSayac";
            this.TxtSonSayac.Size = new System.Drawing.Size(156, 20);
            this.TxtSonSayac.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Son Sayaç";
            // 
            // ListBoxOdenenler
            // 
            this.ListBoxOdenenler.FormattingEnabled = true;
            this.ListBoxOdenenler.Location = new System.Drawing.Point(153, 221);
            this.ListBoxOdenenler.Name = "ListBoxOdenenler";
            this.ListBoxOdenenler.Size = new System.Drawing.Size(120, 95);
            this.ListBoxOdenenler.TabIndex = 11;
            this.ListBoxOdenenler.DoubleClick += new System.EventHandler(this.ListBoxOdenenler_DoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Aboneler";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(150, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ödenenler";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 330);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ListBoxOdenenler);
            this.Controls.Add(this.TxtSonSayac);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtOncekiSayac);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtAdSoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ListBoxAboneler);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtAboneNo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "İZSU";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtAboneNo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox ListBoxAboneler;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RadioBtnKurum;
        private System.Windows.Forms.RadioButton RadioBtnEv;
        private System.Windows.Forms.TextBox TxtAdSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtOncekiSayac;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtSonSayac;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox ListBoxOdenenler;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

