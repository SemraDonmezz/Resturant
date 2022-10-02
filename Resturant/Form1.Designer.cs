
namespace Resturant
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.corbacmb = new System.Windows.Forms.ComboBox();
            this.yemekcmb = new System.Windows.Forms.ComboBox();
            this.tatlicmb = new System.Windows.Forms.ComboBox();
            this.MasaNo = new System.Windows.Forms.NumericUpDown();
            this.Su_Radio = new System.Windows.Forms.RadioButton();
            this.Cola_Radio = new System.Windows.Forms.RadioButton();
            this.Ayran_Radio = new System.Windows.Forms.RadioButton();
            this.Soda_Radio = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MasaList = new System.Windows.Forms.ListBox();
            this.IcecekList = new System.Windows.Forms.ListBox();
            this.TatliList = new System.Windows.Forms.ListBox();
            this.YemekList = new System.Windows.Forms.ListBox();
            this.CorbaList = new System.Windows.Forms.ListBox();
            this.Siparis_Btn = new System.Windows.Forms.Button();
            this.Toplam = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MasaNo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(48, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Masa Numarası";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Çorbalar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 160);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ana Yemek";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 231);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 37);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tatlı";
            // 
            // corbacmb
            // 
            this.corbacmb.FormattingEnabled = true;
            this.corbacmb.Location = new System.Drawing.Point(234, 98);
            this.corbacmb.Margin = new System.Windows.Forms.Padding(4);
            this.corbacmb.Name = "corbacmb";
            this.corbacmb.Size = new System.Drawing.Size(174, 45);
            this.corbacmb.TabIndex = 4;
            this.corbacmb.SelectedIndexChanged += new System.EventHandler(this.corbacmb_SelectedIndexChanged);
            // 
            // yemekcmb
            // 
            this.yemekcmb.FormattingEnabled = true;
            this.yemekcmb.Location = new System.Drawing.Point(234, 155);
            this.yemekcmb.Margin = new System.Windows.Forms.Padding(4);
            this.yemekcmb.Name = "yemekcmb";
            this.yemekcmb.Size = new System.Drawing.Size(174, 45);
            this.yemekcmb.TabIndex = 7;
            this.yemekcmb.SelectedIndexChanged += new System.EventHandler(this.yemekcmb_SelectedIndexChanged);
            // 
            // tatlicmb
            // 
            this.tatlicmb.FormattingEnabled = true;
            this.tatlicmb.Location = new System.Drawing.Point(234, 219);
            this.tatlicmb.Margin = new System.Windows.Forms.Padding(4);
            this.tatlicmb.Name = "tatlicmb";
            this.tatlicmb.Size = new System.Drawing.Size(174, 45);
            this.tatlicmb.TabIndex = 8;
            this.tatlicmb.SelectedIndexChanged += new System.EventHandler(this.tatlicmb_SelectedIndexChanged);
            // 
            // MasaNo
            // 
            this.MasaNo.Location = new System.Drawing.Point(234, 30);
            this.MasaNo.Margin = new System.Windows.Forms.Padding(4);
            this.MasaNo.Name = "MasaNo";
            this.MasaNo.Size = new System.Drawing.Size(175, 43);
            this.MasaNo.TabIndex = 9;
            // 
            // Su_Radio
            // 
            this.Su_Radio.AutoSize = true;
            this.Su_Radio.Location = new System.Drawing.Point(52, 281);
            this.Su_Radio.Margin = new System.Windows.Forms.Padding(4);
            this.Su_Radio.Name = "Su_Radio";
            this.Su_Radio.Size = new System.Drawing.Size(66, 41);
            this.Su_Radio.TabIndex = 10;
            this.Su_Radio.TabStop = true;
            this.Su_Radio.Text = "Su";
            this.Su_Radio.UseVisualStyleBackColor = true;
            // 
            // Cola_Radio
            // 
            this.Cola_Radio.AutoSize = true;
            this.Cola_Radio.Location = new System.Drawing.Point(295, 281);
            this.Cola_Radio.Margin = new System.Windows.Forms.Padding(4);
            this.Cola_Radio.Name = "Cola_Radio";
            this.Cola_Radio.Size = new System.Drawing.Size(92, 41);
            this.Cola_Radio.TabIndex = 11;
            this.Cola_Radio.TabStop = true;
            this.Cola_Radio.Text = "Cola";
            this.Cola_Radio.UseVisualStyleBackColor = true;
            // 
            // Ayran_Radio
            // 
            this.Ayran_Radio.AutoSize = true;
            this.Ayran_Radio.Location = new System.Drawing.Point(48, 321);
            this.Ayran_Radio.Margin = new System.Windows.Forms.Padding(4);
            this.Ayran_Radio.Name = "Ayran_Radio";
            this.Ayran_Radio.Size = new System.Drawing.Size(110, 41);
            this.Ayran_Radio.TabIndex = 12;
            this.Ayran_Radio.TabStop = true;
            this.Ayran_Radio.Text = "Ayran";
            this.Ayran_Radio.UseVisualStyleBackColor = true;
            // 
            // Soda_Radio
            // 
            this.Soda_Radio.AutoSize = true;
            this.Soda_Radio.Location = new System.Drawing.Point(295, 321);
            this.Soda_Radio.Margin = new System.Windows.Forms.Padding(4);
            this.Soda_Radio.Name = "Soda_Radio";
            this.Soda_Radio.Size = new System.Drawing.Size(99, 41);
            this.Soda_Radio.TabIndex = 13;
            this.Soda_Radio.TabStop = true;
            this.Soda_Radio.Text = "Soda";
            this.Soda_Radio.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MasaList);
            this.groupBox1.Controls.Add(this.IcecekList);
            this.groupBox1.Controls.Add(this.TatliList);
            this.groupBox1.Controls.Add(this.YemekList);
            this.groupBox1.Controls.Add(this.CorbaList);
            this.groupBox1.Location = new System.Drawing.Point(52, 487);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1161, 225);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Siparişler";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // MasaList
            // 
            this.MasaList.FormattingEnabled = true;
            this.MasaList.ImeMode = System.Windows.Forms.ImeMode.On;
            this.MasaList.ItemHeight = 37;
            this.MasaList.Location = new System.Drawing.Point(854, 47);
            this.MasaList.Margin = new System.Windows.Forms.Padding(4);
            this.MasaList.Name = "MasaList";
            this.MasaList.Size = new System.Drawing.Size(173, 115);
            this.MasaList.TabIndex = 15;
            this.MasaList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // IcecekList
            // 
            this.IcecekList.FormattingEnabled = true;
            this.IcecekList.ItemHeight = 37;
            this.IcecekList.Location = new System.Drawing.Point(640, 47);
            this.IcecekList.Margin = new System.Windows.Forms.Padding(4);
            this.IcecekList.Name = "IcecekList";
            this.IcecekList.Size = new System.Drawing.Size(173, 115);
            this.IcecekList.TabIndex = 3;
            this.IcecekList.SelectedIndexChanged += new System.EventHandler(this.IcecekList_SelectedIndexChanged);
            // 
            // TatliList
            // 
            this.TatliList.FormattingEnabled = true;
            this.TatliList.ItemHeight = 37;
            this.TatliList.Location = new System.Drawing.Point(420, 47);
            this.TatliList.Margin = new System.Windows.Forms.Padding(4);
            this.TatliList.Name = "TatliList";
            this.TatliList.Size = new System.Drawing.Size(173, 115);
            this.TatliList.TabIndex = 2;
            // 
            // YemekList
            // 
            this.YemekList.FormattingEnabled = true;
            this.YemekList.ItemHeight = 37;
            this.YemekList.Location = new System.Drawing.Point(212, 47);
            this.YemekList.Margin = new System.Windows.Forms.Padding(4);
            this.YemekList.Name = "YemekList";
            this.YemekList.Size = new System.Drawing.Size(173, 115);
            this.YemekList.TabIndex = 1;
            this.YemekList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // CorbaList
            // 
            this.CorbaList.FormattingEnabled = true;
            this.CorbaList.ItemHeight = 37;
            this.CorbaList.Location = new System.Drawing.Point(9, 47);
            this.CorbaList.Margin = new System.Windows.Forms.Padding(4);
            this.CorbaList.Name = "CorbaList";
            this.CorbaList.Size = new System.Drawing.Size(173, 115);
            this.CorbaList.TabIndex = 0;
            this.CorbaList.SelectedIndexChanged += new System.EventHandler(this.CorbaList_SelectedIndexChanged);
            // 
            // Siparis_Btn
            // 
            this.Siparis_Btn.Location = new System.Drawing.Point(48, 397);
            this.Siparis_Btn.Margin = new System.Windows.Forms.Padding(4);
            this.Siparis_Btn.Name = "Siparis_Btn";
            this.Siparis_Btn.Size = new System.Drawing.Size(177, 50);
            this.Siparis_Btn.TabIndex = 15;
            this.Siparis_Btn.Text = "Siparis Ekle";
            this.Siparis_Btn.UseVisualStyleBackColor = true;
            this.Siparis_Btn.Click += new System.EventHandler(this.Siparis_Btn_Click);
            // 
            // Toplam
            // 
            this.Toplam.AutoSize = true;
            this.Toplam.Location = new System.Drawing.Point(572, 33);
            this.Toplam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Toplam.Name = "Toplam";
            this.Toplam.Size = new System.Drawing.Size(98, 37);
            this.Toplam.TabIndex = 16;
            this.Toplam.Text = "Fatura";
            this.Toplam.Click += new System.EventHandler(this.Toplam_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1159, 749);
            this.Controls.Add(this.Toplam);
            this.Controls.Add(this.Siparis_Btn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Soda_Radio);
            this.Controls.Add(this.Ayran_Radio);
            this.Controls.Add(this.Cola_Radio);
            this.Controls.Add(this.Su_Radio);
            this.Controls.Add(this.MasaNo);
            this.Controls.Add(this.tatlicmb);
            this.Controls.Add(this.yemekcmb);
            this.Controls.Add(this.corbacmb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "Form1";
            this.Text = "Çorbalar";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MasaNo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox corbacmb;
        private System.Windows.Forms.ComboBox yemekcmb;
        private System.Windows.Forms.ComboBox tatlicmb;
        private System.Windows.Forms.NumericUpDown MasaNo;
        private System.Windows.Forms.RadioButton Su_Radio;
        private System.Windows.Forms.RadioButton Cola_Radio;
        private System.Windows.Forms.RadioButton Ayran_Radio;
        private System.Windows.Forms.RadioButton Soda_Radio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox YemekList;
        private System.Windows.Forms.ListBox CorbaList;
        private System.Windows.Forms.ListBox IcecekList;
        private System.Windows.Forms.ListBox TatliList;
        private System.Windows.Forms.ListBox MasaList;
        private System.Windows.Forms.Button Siparis_Btn;
        private System.Windows.Forms.Label Toplam;
    }
}

