namespace IZSU_RSS
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.BtnGetir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ListBSuKesintileri = new System.Windows.Forms.ListBox();
            this.ListBhaberler = new System.Windows.Forms.ListBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(40, 100);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(184, 95);
            this.listBox1.TabIndex = 0;
            // 
            // BtnGetir
            // 
            this.BtnGetir.Location = new System.Drawing.Point(40, 38);
            this.BtnGetir.Name = "BtnGetir";
            this.BtnGetir.Size = new System.Drawing.Size(184, 23);
            this.BtnGetir.TabIndex = 1;
            this.BtnGetir.Text = "Ne Varsa Getir";
            this.BtnGetir.UseVisualStyleBackColor = true;
            this.BtnGetir.Click += new System.EventHandler(this.BtnGetir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // ListBSuKesintileri
            // 
            this.ListBSuKesintileri.FormattingEnabled = true;
            this.ListBSuKesintileri.Location = new System.Drawing.Point(230, 100);
            this.ListBSuKesintileri.Name = "ListBSuKesintileri";
            this.ListBSuKesintileri.Size = new System.Drawing.Size(495, 95);
            this.ListBSuKesintileri.TabIndex = 3;
            this.ListBSuKesintileri.DoubleClick += new System.EventHandler(this.ListBSuKesintileri_DoubleClick);
            // 
            // ListBhaberler
            // 
            this.ListBhaberler.FormattingEnabled = true;
            this.ListBhaberler.Location = new System.Drawing.Point(51, 227);
            this.ListBhaberler.Name = "ListBhaberler";
            this.ListBhaberler.Size = new System.Drawing.Size(674, 95);
            this.ListBhaberler.TabIndex = 3;
            this.ListBhaberler.DoubleClick += new System.EventHandler(this.ListBhaberler_DoubleClick);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(759, 100);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(306, 222);
            this.webBrowser1.TabIndex = 4;
            
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 347);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.ListBhaberler);
            this.Controls.Add(this.ListBSuKesintileri);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnGetir);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button BtnGetir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ListBSuKesintileri;
        private System.Windows.Forms.ListBox ListBhaberler;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

