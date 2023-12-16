namespace Hamburgerci
{
    partial class SiparisFormu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SiparisFormu));
            nudAdet = new NumericUpDown();
            btnSiparisEkle = new Button();
            label3 = new Label();
            label1 = new Label();
            label4 = new Label();
            cboMenuSec = new ComboBox();
            rdbKucuk = new RadioButton();
            rdbOrta = new RadioButton();
            rdbBuyuk = new RadioButton();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            grbBoyut = new GroupBox();
            btnSil = new Button();
            btnYeniSiparis = new Button();
            lblToplam = new Label();
            label2 = new Label();
            lstMevcutSiparisler = new ListBox();
            flpEkstraMalzemeler = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)nudAdet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            grbBoyut.SuspendLayout();
            SuspendLayout();
            // 
            // nudAdet
            // 
            nudAdet.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            nudAdet.Location = new Point(70, 488);
            nudAdet.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudAdet.Name = "nudAdet";
            nudAdet.Size = new Size(220, 31);
            nudAdet.TabIndex = 12;
            nudAdet.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnSiparisEkle
            // 
            btnSiparisEkle.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSiparisEkle.Location = new Point(12, 534);
            btnSiparisEkle.Name = "btnSiparisEkle";
            btnSiparisEkle.Size = new Size(265, 61);
            btnSiparisEkle.TabIndex = 11;
            btnSiparisEkle.Text = "SİPARİŞ EKLE";
            btnSiparisEkle.UseVisualStyleBackColor = true;
            btnSiparisEkle.Click += btnSiparisEkle_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(8, 490);
            label3.Name = "label3";
            label3.Size = new Size(56, 25);
            label3.TabIndex = 10;
            label3.Text = "ADET";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(8, 213);
            label1.Name = "label1";
            label1.Size = new Size(100, 16);
            label1.TabIndex = 7;
            label1.Text = "MENÜ SEÇİN";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(8, 259);
            label4.Name = "label4";
            label4.Size = new Size(108, 16);
            label4.TabIndex = 13;
            label4.Text = "BOYUT SEÇİN";
            // 
            // cboMenuSec
            // 
            cboMenuSec.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            cboMenuSec.FormattingEnabled = true;
            cboMenuSec.Location = new Point(8, 232);
            cboMenuSec.Name = "cboMenuSec";
            cboMenuSec.Size = new Size(252, 24);
            cboMenuSec.TabIndex = 14;
            // 
            // rdbKucuk
            // 
            rdbKucuk.AutoSize = true;
            rdbKucuk.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            rdbKucuk.Location = new Point(6, 13);
            rdbKucuk.Name = "rdbKucuk";
            rdbKucuk.Size = new Size(83, 29);
            rdbKucuk.TabIndex = 15;
            rdbKucuk.TabStop = true;
            rdbKucuk.Text = "Küçük";
            rdbKucuk.UseVisualStyleBackColor = true;
            // 
            // rdbOrta
            // 
            rdbOrta.AutoSize = true;
            rdbOrta.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            rdbOrta.Location = new Point(95, 13);
            rdbOrta.Name = "rdbOrta";
            rdbOrta.Size = new Size(69, 29);
            rdbOrta.TabIndex = 16;
            rdbOrta.TabStop = true;
            rdbOrta.Text = "Orta";
            rdbOrta.UseVisualStyleBackColor = true;
            // 
            // rdbBuyuk
            // 
            rdbBuyuk.AutoSize = true;
            rdbBuyuk.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            rdbBuyuk.Location = new Point(171, 13);
            rdbBuyuk.Name = "rdbBuyuk";
            rdbBuyuk.Size = new Size(81, 29);
            rdbBuyuk.TabIndex = 17;
            rdbBuyuk.TabStop = true;
            rdbBuyuk.Text = "Büyük";
            rdbBuyuk.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(8, 329);
            label5.Name = "label5";
            label5.Size = new Size(118, 19);
            label5.TabIndex = 18;
            label5.Text = "MALZEME SEÇİN";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(8, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(307, 198);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // grbBoyut
            // 
            grbBoyut.Controls.Add(rdbKucuk);
            grbBoyut.Controls.Add(rdbOrta);
            grbBoyut.Controls.Add(rdbBuyuk);
            grbBoyut.Location = new Point(12, 278);
            grbBoyut.Name = "grbBoyut";
            grbBoyut.Size = new Size(268, 48);
            grbBoyut.TabIndex = 28;
            grbBoyut.TabStop = false;
            grbBoyut.Text = "groupBox1";
            // 
            // btnSil
            // 
            btnSil.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSil.Location = new Point(596, 451);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(106, 46);
            btnSil.TabIndex = 38;
            btnSil.Text = "Sipariş Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnYeniSiparis
            // 
            btnYeniSiparis.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnYeniSiparis.Location = new Point(492, 451);
            btnYeniSiparis.Name = "btnYeniSiparis";
            btnYeniSiparis.Size = new Size(98, 47);
            btnYeniSiparis.TabIndex = 37;
            btnYeniSiparis.Text = "Yeni Sipariş";
            btnYeniSiparis.UseVisualStyleBackColor = true;
            btnYeniSiparis.Click += btnYeniSiparis_Click;
            // 
            // lblToplam
            // 
            lblToplam.AutoSize = true;
            lblToplam.BackColor = Color.Transparent;
            lblToplam.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblToplam.ForeColor = Color.Red;
            lblToplam.Location = new Point(630, 534);
            lblToplam.Margin = new Padding(4, 0, 4, 0);
            lblToplam.Name = "lblToplam";
            lblToplam.Size = new Size(72, 30);
            lblToplam.TabIndex = 36;
            lblToplam.Text = "₺ 0.00";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(451, 534);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(171, 30);
            label2.TabIndex = 35;
            label2.Text = "TOPLAM TUTAR:";
            // 
            // lstMevcutSiparisler
            // 
            lstMevcutSiparisler.FormattingEnabled = true;
            lstMevcutSiparisler.ItemHeight = 15;
            lstMevcutSiparisler.Location = new Point(339, 12);
            lstMevcutSiparisler.Name = "lstMevcutSiparisler";
            lstMevcutSiparisler.Size = new Size(363, 424);
            lstMevcutSiparisler.TabIndex = 39;
            // 
            // flpEkstraMalzemeler
            // 
            flpEkstraMalzemeler.Location = new Point(12, 351);
            flpEkstraMalzemeler.Name = "flpEkstraMalzemeler";
            flpEkstraMalzemeler.Size = new Size(252, 126);
            flpEkstraMalzemeler.TabIndex = 40;
            // 
            // SiparisFormu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(725, 604);
            Controls.Add(flpEkstraMalzemeler);
            Controls.Add(lstMevcutSiparisler);
            Controls.Add(btnSil);
            Controls.Add(btnYeniSiparis);
            Controls.Add(lblToplam);
            Controls.Add(label2);
            Controls.Add(grbBoyut);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(cboMenuSec);
            Controls.Add(label4);
            Controls.Add(nudAdet);
            Controls.Add(btnSiparisEkle);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "SiparisFormu";
            Text = "SiparisFormu";
            Load += SiparisFormu_Load;
            ((System.ComponentModel.ISupportInitialize)nudAdet).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            grbBoyut.ResumeLayout(false);
            grbBoyut.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown nudAdet;
        private Button btnSiparisEkle;
        private Label label3;
        private Label label1;
        private Label label4;
        private ComboBox cboMenuSec;
        private RadioButton rdbKucuk;
        private RadioButton rdbOrta;
        private RadioButton rdbBuyuk;
        private Label label5;
        private PictureBox pictureBox1;
        private GroupBox grbBoyut;
        private Button btnSil;
        private Button btnYeniSiparis;
        private Label lblToplam;
        private Label label2;
        private ListBox lstMevcutSiparisler;
        private FlowLayoutPanel flpEkstraMalzemeler;
    }
}