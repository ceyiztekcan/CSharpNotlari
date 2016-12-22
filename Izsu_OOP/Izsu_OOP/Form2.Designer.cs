namespace IZSU_OOP
{
    partial class Form2
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
            this.TxtOncekiSayac = new System.Windows.Forms.TextBox();
            this.TxtAdSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtGuncelborc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnOde = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtSonrakiSayac = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtBMusteriTuru = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Önceki Sayaç";
            // 
            // TxtOncekiSayac
            // 
            this.TxtOncekiSayac.Location = new System.Drawing.Point(152, 68);
            this.TxtOncekiSayac.Name = "TxtOncekiSayac";
            this.TxtOncekiSayac.ReadOnly = true;
            this.TxtOncekiSayac.Size = new System.Drawing.Size(150, 20);
            this.TxtOncekiSayac.TabIndex = 1;
            // 
            // TxtAdSoyad
            // 
            this.TxtAdSoyad.Location = new System.Drawing.Point(152, 32);
            this.TxtAdSoyad.Name = "TxtAdSoyad";
            this.TxtAdSoyad.ReadOnly = true;
            this.TxtAdSoyad.Size = new System.Drawing.Size(150, 20);
            this.TxtAdSoyad.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "İsim Soy İsim";
            // 
            // TxtGuncelborc
            // 
            this.TxtGuncelborc.Location = new System.Drawing.Point(152, 167);
            this.TxtGuncelborc.Name = "TxtGuncelborc";
            this.TxtGuncelborc.ReadOnly = true;
            this.TxtGuncelborc.Size = new System.Drawing.Size(150, 20);
            this.TxtGuncelborc.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(29, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Güncel Borç";
            // 
            // BtnOde
            // 
            this.BtnOde.Location = new System.Drawing.Point(185, 193);
            this.BtnOde.Name = "BtnOde";
            this.BtnOde.Size = new System.Drawing.Size(75, 23);
            this.BtnOde.TabIndex = 6;
            this.BtnOde.Text = "Öde";
            this.BtnOde.UseVisualStyleBackColor = true;
            this.BtnOde.Click += new System.EventHandler(this.BtnOde_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(6, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Sonraki Sayaç";
            // 
            // TxtSonrakiSayac
            // 
            this.TxtSonrakiSayac.Location = new System.Drawing.Point(152, 94);
            this.TxtSonrakiSayac.Name = "TxtSonrakiSayac";
            this.TxtSonrakiSayac.ReadOnly = true;
            this.TxtSonrakiSayac.Size = new System.Drawing.Size(150, 20);
            this.TxtSonrakiSayac.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(6, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Müşteri Tipi";
            // 
            // TxtBMusteriTuru
            // 
            this.TxtBMusteriTuru.Location = new System.Drawing.Point(152, 120);
            this.TxtBMusteriTuru.Name = "TxtBMusteriTuru";
            this.TxtBMusteriTuru.ReadOnly = true;
            this.TxtBMusteriTuru.Size = new System.Drawing.Size(150, 20);
            this.TxtBMusteriTuru.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 261);
            this.Controls.Add(this.BtnOde);
            this.Controls.Add(this.TxtGuncelborc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtAdSoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtBMusteriTuru);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtSonrakiSayac);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtOncekiSayac);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Müşteri Bilgileri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtOncekiSayac;
        private System.Windows.Forms.TextBox TxtAdSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtGuncelborc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnOde;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtSonrakiSayac;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtBMusteriTuru;
    }
}