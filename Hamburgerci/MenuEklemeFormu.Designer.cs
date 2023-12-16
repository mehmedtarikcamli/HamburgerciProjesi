namespace Hamburgerci
{
    partial class MenuEklemeFormu
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
            btnMenuKaydet = new Button();
            label3 = new Label();
            txtMenuAd = new TextBox();
            label2 = new Label();
            label1 = new Label();
            nudMenuFiyat = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nudMenuFiyat).BeginInit();
            SuspendLayout();
            // 
            // btnMenuKaydet
            // 
            btnMenuKaydet.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnMenuKaydet.Location = new Point(116, 161);
            btnMenuKaydet.Name = "btnMenuKaydet";
            btnMenuKaydet.Size = new Size(333, 93);
            btnMenuKaydet.TabIndex = 11;
            btnMenuKaydet.Text = "MENÜYÜ KAYDET";
            btnMenuKaydet.UseVisualStyleBackColor = true;
            btnMenuKaydet.Click += btnMenuKaydet_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(50, 110);
            label3.Name = "label3";
            label3.Size = new Size(60, 25);
            label3.TabIndex = 9;
            label3.Text = "Fiyatı:";
            // 
            // txtMenuAd
            // 
            txtMenuAd.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtMenuAd.Location = new Point(116, 58);
            txtMenuAd.Name = "txtMenuAd";
            txtMenuAd.Size = new Size(333, 31);
            txtMenuAd.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 61);
            label2.Name = "label2";
            label2.Size = new Size(98, 25);
            label2.TabIndex = 7;
            label2.Text = "Menü Adı:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(227, 37);
            label1.TabIndex = 6;
            label1.Text = "MENÜ BİLGİLERİ";
            // 
            // nudMenuFiyat
            // 
            nudMenuFiyat.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            nudMenuFiyat.Location = new Point(116, 108);
            nudMenuFiyat.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudMenuFiyat.Name = "nudMenuFiyat";
            nudMenuFiyat.Size = new Size(333, 31);
            nudMenuFiyat.TabIndex = 12;
            // 
            // MenuEklemeFormu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 263);
            Controls.Add(nudMenuFiyat);
            Controls.Add(btnMenuKaydet);
            Controls.Add(label3);
            Controls.Add(txtMenuAd);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MenuEklemeFormu";
            Text = "MenuEklemeFormu";
            ((System.ComponentModel.ISupportInitialize)nudMenuFiyat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMenuKaydet;
        private Label label3;
        private TextBox txtMenuAd;
        private Label label2;
        private Label label1;
        private NumericUpDown nudMenuFiyat;
    }
}