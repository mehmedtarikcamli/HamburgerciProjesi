﻿namespace Hamburgerci
{
    partial class SiparisBilgiFormu
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
            lstTumSiparisler = new ListBox();
            label3 = new Label();
            label5 = new Label();
            label7 = new Label();
            lblToplamSiparis = new Label();
            lblEkstraMalzemeGeliri = new Label();
            lblCiro = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(232, 37);
            label1.TabIndex = 7;
            label1.Text = "TÜM SİPARİŞLER";
            // 
            // lstTumSiparisler
            // 
            lstTumSiparisler.FormattingEnabled = true;
            lstTumSiparisler.ItemHeight = 15;
            lstTumSiparisler.Location = new Point(22, 59);
            lstTumSiparisler.Name = "lstTumSiparisler";
            lstTumSiparisler.Size = new Size(367, 379);
            lstTumSiparisler.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(421, 59);
            label3.Name = "label3";
            label3.Size = new Size(50, 28);
            label3.TabIndex = 10;
            label3.Text = "Ciro";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(421, 139);
            label5.Name = "label5";
            label5.Size = new Size(210, 28);
            label5.TabIndex = 12;
            label5.Text = "Toplam Sipariş Sayısı";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(421, 220);
            label7.Name = "label7";
            label7.Size = new Size(219, 28);
            label7.TabIndex = 14;
            label7.Text = "Ekstra Malzeme Geliri";
            // 
            // lblToplamSiparis
            // 
            lblToplamSiparis.AutoSize = true;
            lblToplamSiparis.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblToplamSiparis.ForeColor = Color.IndianRed;
            lblToplamSiparis.Location = new Point(421, 184);
            lblToplamSiparis.Name = "lblToplamSiparis";
            lblToplamSiparis.Size = new Size(19, 20);
            lblToplamSiparis.TabIndex = 0;
            lblToplamSiparis.Text = "0";
            // 
            // lblEkstraMalzemeGeliri
            // 
            lblEkstraMalzemeGeliri.AutoSize = true;
            lblEkstraMalzemeGeliri.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblEkstraMalzemeGeliri.ForeColor = Color.IndianRed;
            lblEkstraMalzemeGeliri.Location = new Point(421, 268);
            lblEkstraMalzemeGeliri.Name = "lblEkstraMalzemeGeliri";
            lblEkstraMalzemeGeliri.Size = new Size(54, 20);
            lblEkstraMalzemeGeliri.TabIndex = 5;
            lblEkstraMalzemeGeliri.Text = "₺0,00";
            // 
            // lblCiro
            // 
            lblCiro.AutoSize = true;
            lblCiro.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCiro.ForeColor = Color.IndianRed;
            lblCiro.Location = new Point(421, 105);
            lblCiro.Name = "lblCiro";
            lblCiro.Size = new Size(54, 20);
            lblCiro.TabIndex = 4;
            lblCiro.Text = "₺0,00";
            // 
            // SiparisBilgiFormu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(673, 458);
            Controls.Add(lblEkstraMalzemeGeliri);
            Controls.Add(lblToplamSiparis);
            Controls.Add(lblCiro);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(lstTumSiparisler);
            Controls.Add(label1);
            Name = "SiparisBilgiFormu";
            Text = "SiparisBilgiFormu";
            Load += SiparisBilgiFormu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstTumSiparisler;
        private Label label3;
        private Label label5;
        private Label label7;
        private Label lblToplamSiparis;
        private Label lblEkstraMalzemeGeliri;
        private Label lblCiro;
    }
}