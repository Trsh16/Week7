namespace WinFormsApp3
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
            this.textBox_Kalimat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Huruf = new System.Windows.Forms.TextBox();
            this.textBox_Menjadi = new System.Windows.Forms.TextBox();
            this.button_Konversi = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label_Hasil = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Masukkan Kalimat";
            // 
            // textBox_Kalimat
            // 
            this.textBox_Kalimat.Location = new System.Drawing.Point(177, 25);
            this.textBox_Kalimat.Name = "textBox_Kalimat";
            this.textBox_Kalimat.Size = new System.Drawing.Size(312, 31);
            this.textBox_Kalimat.TabIndex = 1;
            this.textBox_Kalimat.TextChanged += new System.EventHandler(this.textBox_Kalimat_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Masukkan Huruf";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Menjadi";
            // 
            // textBox_Huruf
            // 
            this.textBox_Huruf.Location = new System.Drawing.Point(177, 80);
            this.textBox_Huruf.Name = "textBox_Huruf";
            this.textBox_Huruf.Size = new System.Drawing.Size(90, 31);
            this.textBox_Huruf.TabIndex = 4;
            this.textBox_Huruf.TextChanged += new System.EventHandler(this.textBox_Huruf_TextChanged);
            // 
            // textBox_Menjadi
            // 
            this.textBox_Menjadi.Location = new System.Drawing.Point(399, 80);
            this.textBox_Menjadi.Name = "textBox_Menjadi";
            this.textBox_Menjadi.Size = new System.Drawing.Size(90, 31);
            this.textBox_Menjadi.TabIndex = 5;
            this.textBox_Menjadi.TextChanged += new System.EventHandler(this.textBox_Menjadi_TextChanged);
            // 
            // button_Konversi
            // 
            this.button_Konversi.Location = new System.Drawing.Point(177, 140);
            this.button_Konversi.Name = "button_Konversi";
            this.button_Konversi.Size = new System.Drawing.Size(312, 34);
            this.button_Konversi.TabIndex = 6;
            this.button_Konversi.Text = "Konversi";
            this.button_Konversi.UseVisualStyleBackColor = true;
            this.button_Konversi.Click += new System.EventHandler(this.button_Konversi_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hasil : ";
            // 
            // label_Hasil
            // 
            this.label_Hasil.AutoSize = true;
            this.label_Hasil.Location = new System.Drawing.Point(177, 208);
            this.label_Hasil.Name = "label_Hasil";
            this.label_Hasil.Size = new System.Drawing.Size(0, 25);
            this.label_Hasil.TabIndex = 8;
            this.label_Hasil.Click += new System.EventHandler(this.label_Hasil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 272);
            this.Controls.Add(this.label_Hasil);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_Konversi);
            this.Controls.Add(this.textBox_Menjadi);
            this.Controls.Add(this.textBox_Huruf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Kalimat);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBox_Kalimat;
        private Label label2;
        private Label label3;
        private TextBox textBox_Huruf;
        private TextBox textBox_Menjadi;
        private Button button_Konversi;
        private Label label4;
        private Label label_Hasil;
    }
}