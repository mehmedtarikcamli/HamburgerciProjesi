namespace Hamburgerci
{
    partial class EkstraEklemeFormu
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
            label1 = new Label();
            label2 = new Label();
            txtEkstraMalzemeAd = new TextBox();
            label3 = new Label();
            btnEkstraMalzemeKaydet = new Button();
            nudEkstraMalzemeFiyat = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nudEkstraMalzemeFiyat).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(383, 37);
            label1.TabIndex = 0;
            label1.Text = "EKSTRA MALZEME BİLGİLERİ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 75);
            label2.Name = "label2";
            label2.Size = new Size(178, 25);
            label2.TabIndex = 1;
            label2.Text = "Ekstra Malzeme Adı:";
            // 
            // txtEkstraMalzemeAd
            // 
            txtEkstraMalzemeAd.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtEkstraMalzemeAd.Location = new Point(211, 72);
            txtEkstraMalzemeAd.Name = "txtEkstraMalzemeAd";
            txtEkstraMalzemeAd.Size = new Size(333, 31);
            txtEkstraMalzemeAd.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(130, 124);
            label3.Name = "label3";
            label3.Size = new Size(60, 25);
            label3.TabIndex = 3;
            label3.Text = "Fiyatı:";
            // 
            // btnEkstraMalzemeKaydet
            // 
            btnEkstraMalzemeKaydet.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEkstraMalzemeKaydet.Location = new Point(211, 175);
            btnEkstraMalzemeKaydet.Name = "btnEkstraMalzemeKaydet";
            btnEkstraMalzemeKaydet.Size = new Size(333, 93);
            btnEkstraMalzemeKaydet.TabIndex = 5;
            btnEkstraMalzemeKaydet.Text = "EKSTRA MALZEMEYİ KAYDET";
            btnEkstraMalzemeKaydet.UseVisualStyleBackColor = true;
            btnEkstraMalzemeKaydet.Click += btnEkstraMalzemeKaydet_Click;
            // 
            // nudEkstraMalzemeFiyat
            // 
            nudEkstraMalzemeFiyat.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            nudEkstraMalzemeFiyat.Location = new Point(211, 122);
            nudEkstraMalzemeFiyat.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudEkstraMalzemeFiyat.Name = "nudEkstraMalzemeFiyat";
            nudEkstraMalzemeFiyat.Size = new Size(333, 31);
            nudEkstraMalzemeFiyat.TabIndex = 6;
            // 
            // EkstraEklemeFormu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 286);
            Controls.Add(nudEkstraMalzemeFiyat);
            Controls.Add(btnEkstraMalzemeKaydet);
            Controls.Add(label3);
            Controls.Add(txtEkstraMalzemeAd);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EkstraEklemeFormu";
            StartPosition = FormStartPosition.CenterParent;
            Text = "EkstraEklemeFormu";
            ((System.ComponentModel.ISupportInitialize)nudEkstraMalzemeFiyat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtEkstraMalzemeAd;
        private Label label3;
        private Button btnEkstraMalzemeKaydet;
        private NumericUpDown nudEkstraMalzemeFiyat;
    }
}