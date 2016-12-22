namespace IZSU_OOP
{
    partial class Form3
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
            this.TxtBAdSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBSonOdenen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtBToplamOdeme = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad";
            // 
            // TxtBAdSoyad
            // 
            this.TxtBAdSoyad.Location = new System.Drawing.Point(103, 14);
            this.TxtBAdSoyad.Name = "TxtBAdSoyad";
            this.TxtBAdSoyad.Size = new System.Drawing.Size(100, 20);
            this.TxtBAdSoyad.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Son Ödenen";
            // 
            // TxtBSonOdenen
            // 
            this.TxtBSonOdenen.Location = new System.Drawing.Point(103, 40);
            this.TxtBSonOdenen.Name = "TxtBSonOdenen";
            this.TxtBSonOdenen.Size = new System.Drawing.Size(100, 20);
            this.TxtBSonOdenen.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Toplam Ödeme";
            // 
            // TxtBToplamOdeme
            // 
            this.TxtBToplamOdeme.Location = new System.Drawing.Point(103, 66);
            this.TxtBToplamOdeme.Name = "TxtBToplamOdeme";
            this.TxtBToplamOdeme.Size = new System.Drawing.Size(100, 20);
            this.TxtBToplamOdeme.TabIndex = 1;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.TxtBToplamOdeme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtBSonOdenen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtBAdSoyad);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBAdSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtBSonOdenen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtBToplamOdeme;
    }
}