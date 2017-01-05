namespace Kafe
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
            this.panelMasa = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.ComboIcecek = new System.Windows.Forms.ComboBox();
            this.ComboYemek = new System.Windows.Forms.ComboBox();
            this.numericIcecek = new System.Windows.Forms.NumericUpDown();
            this.numericYemek = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSiparis = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButtonDolar = new System.Windows.Forms.RadioButton();
            this.BtnOde = new System.Windows.Forms.Button();
            this.LabelMasaNo = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericIcecek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericYemek)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMasa
            // 
            this.panelMasa.Location = new System.Drawing.Point(12, 22);
            this.panelMasa.Name = "panelMasa";
            this.panelMasa.Size = new System.Drawing.Size(248, 145);
            this.panelMasa.TabIndex = 0;
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.LabelMasaNo);
            this.panelMenu.Controls.Add(this.ComboIcecek);
            this.panelMenu.Controls.Add(this.ComboYemek);
            this.panelMenu.Controls.Add(this.numericIcecek);
            this.panelMenu.Controls.Add(this.numericYemek);
            this.panelMenu.Controls.Add(this.label2);
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Location = new System.Drawing.Point(12, 181);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(248, 98);
            this.panelMenu.TabIndex = 1;
            // 
            // ComboIcecek
            // 
            this.ComboIcecek.FormattingEnabled = true;
            this.ComboIcecek.Location = new System.Drawing.Point(65, 37);
            this.ComboIcecek.Name = "ComboIcecek";
            this.ComboIcecek.Size = new System.Drawing.Size(121, 21);
            this.ComboIcecek.TabIndex = 2;
            // 
            // ComboYemek
            // 
            this.ComboYemek.FormattingEnabled = true;
            this.ComboYemek.Location = new System.Drawing.Point(65, 10);
            this.ComboYemek.Name = "ComboYemek";
            this.ComboYemek.Size = new System.Drawing.Size(121, 21);
            this.ComboYemek.TabIndex = 2;
            // 
            // numericIcecek
            // 
            this.numericIcecek.Location = new System.Drawing.Point(209, 44);
            this.numericIcecek.Name = "numericIcecek";
            this.numericIcecek.Size = new System.Drawing.Size(36, 20);
            this.numericIcecek.TabIndex = 1;
            // 
            // numericYemek
            // 
            this.numericYemek.Location = new System.Drawing.Point(209, 10);
            this.numericYemek.Name = "numericYemek";
            this.numericYemek.Size = new System.Drawing.Size(36, 20);
            this.numericYemek.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "İçecek";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yemek";
            // 
            // BtnSiparis
            // 
            this.BtnSiparis.Location = new System.Drawing.Point(12, 300);
            this.BtnSiparis.Name = "BtnSiparis";
            this.BtnSiparis.Size = new System.Drawing.Size(248, 23);
            this.BtnSiparis.TabIndex = 2;
            this.BtnSiparis.Text = "Sipariş Ver";
            this.BtnSiparis.UseVisualStyleBackColor = true;
            this.BtnSiparis.Click += new System.EventHandler(this.BtnSiparis_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(304, 25);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(272, 251);
            this.listBox1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButtonDolar);
            this.groupBox1.Location = new System.Drawing.Point(304, 282);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 42);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(128, 17);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(56, 17);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Pound";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(75, 17);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(47, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Euro";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButtonDolar
            // 
            this.radioButtonDolar.AutoSize = true;
            this.radioButtonDolar.Location = new System.Drawing.Point(19, 17);
            this.radioButtonDolar.Name = "radioButtonDolar";
            this.radioButtonDolar.Size = new System.Drawing.Size(50, 17);
            this.radioButtonDolar.TabIndex = 0;
            this.radioButtonDolar.TabStop = true;
            this.radioButtonDolar.Text = "Dolar";
            this.radioButtonDolar.UseVisualStyleBackColor = true;
            // 
            // BtnOde
            // 
            this.BtnOde.Location = new System.Drawing.Point(304, 330);
            this.BtnOde.Name = "BtnOde";
            this.BtnOde.Size = new System.Drawing.Size(184, 23);
            this.BtnOde.TabIndex = 5;
            this.BtnOde.Text = "Ödeme";
            this.BtnOde.UseVisualStyleBackColor = true;
            this.BtnOde.Click += new System.EventHandler(this.BtnOde_Click);
            // 
            // LabelMasaNo
            // 
            this.LabelMasaNo.AutoSize = true;
            this.LabelMasaNo.Location = new System.Drawing.Point(8, 69);
            this.LabelMasaNo.Name = "LabelMasaNo";
            this.LabelMasaNo.Size = new System.Drawing.Size(0, 13);
            this.LabelMasaNo.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 388);
            this.Controls.Add(this.BtnOde);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.BtnSiparis);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelMasa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericIcecek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericYemek)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMasa;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button BtnSiparis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericIcecek;
        private System.Windows.Forms.NumericUpDown numericYemek;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButtonDolar;
        private System.Windows.Forms.Button BtnOde;
        private System.Windows.Forms.ComboBox ComboIcecek;
        private System.Windows.Forms.ComboBox ComboYemek;
        private System.Windows.Forms.Label LabelMasaNo;
    }
}

