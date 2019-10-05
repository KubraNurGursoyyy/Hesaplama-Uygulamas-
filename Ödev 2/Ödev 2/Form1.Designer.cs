namespace Ödev_2
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbİşlemler = new System.Windows.Forms.TabControl();
            this.tabTekSayılar = new System.Windows.Forms.TabPage();
            this.lstViewTekSayılar = new System.Windows.Forms.ListView();
            this.tabÇiftSayılar = new System.Windows.Forms.TabPage();
            this.lstViewÇiftSayılar = new System.Windows.Forms.ListView();
            this.tabAsalSayılar = new System.Windows.Forms.TabPage();
            this.lstViewAsalSayılar = new System.Windows.Forms.ListView();
            this.tabArmstrongSayıları = new System.Windows.Forms.TabPage();
            this.lstViewArmstrongSayıları = new System.Windows.Forms.ListView();
            this.grpGirişBilgileri = new System.Windows.Forms.GroupBox();
            this.btnİleri = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.mskdtxtBitiş = new System.Windows.Forms.MaskedTextBox();
            this.lblBitiş = new System.Windows.Forms.Label();
            this.mskdtxtBaşlangıç = new System.Windows.Forms.MaskedTextBox();
            this.lblBaşlangıç = new System.Windows.Forms.Label();
            this.ntfyBildirim = new System.Windows.Forms.NotifyIcon(this.components);
            this.tbİşlemler.SuspendLayout();
            this.tabTekSayılar.SuspendLayout();
            this.tabÇiftSayılar.SuspendLayout();
            this.tabAsalSayılar.SuspendLayout();
            this.tabArmstrongSayıları.SuspendLayout();
            this.grpGirişBilgileri.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbİşlemler
            // 
            this.tbİşlemler.Controls.Add(this.tabTekSayılar);
            this.tbİşlemler.Controls.Add(this.tabÇiftSayılar);
            this.tbİşlemler.Controls.Add(this.tabAsalSayılar);
            this.tbİşlemler.Controls.Add(this.tabArmstrongSayıları);
            this.tbİşlemler.Location = new System.Drawing.Point(12, 82);
            this.tbİşlemler.Name = "tbİşlemler";
            this.tbİşlemler.SelectedIndex = 0;
            this.tbİşlemler.Size = new System.Drawing.Size(882, 418);
            this.tbİşlemler.TabIndex = 0;
            // 
            // tabTekSayılar
            // 
            this.tabTekSayılar.BackgroundImage = global::Ödev_2.Properties.Resources._119a6278ef098390d1ffb430d0d08ea205e0936a;
            this.tabTekSayılar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabTekSayılar.Controls.Add(this.lstViewTekSayılar);
            this.tabTekSayılar.Location = new System.Drawing.Point(4, 22);
            this.tabTekSayılar.Name = "tabTekSayılar";
            this.tabTekSayılar.Padding = new System.Windows.Forms.Padding(3);
            this.tabTekSayılar.Size = new System.Drawing.Size(874, 392);
            this.tabTekSayılar.TabIndex = 0;
            this.tabTekSayılar.Text = "Tek Sayılar";
            this.tabTekSayılar.UseVisualStyleBackColor = true;
            // 
            // lstViewTekSayılar
            // 
            this.lstViewTekSayılar.BackColor = System.Drawing.Color.DarkGray;
            this.lstViewTekSayılar.Location = new System.Drawing.Point(6, 6);
            this.lstViewTekSayılar.Name = "lstViewTekSayılar";
            this.lstViewTekSayılar.Size = new System.Drawing.Size(285, 380);
            this.lstViewTekSayılar.TabIndex = 1;
            this.lstViewTekSayılar.UseCompatibleStateImageBehavior = false;
            this.lstViewTekSayılar.View = System.Windows.Forms.View.List;
            // 
            // tabÇiftSayılar
            // 
            this.tabÇiftSayılar.BackgroundImage = global::Ödev_2.Properties.Resources._119a6278ef098390d1ffb430d0d08ea205e0936a;
            this.tabÇiftSayılar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabÇiftSayılar.Controls.Add(this.lstViewÇiftSayılar);
            this.tabÇiftSayılar.Location = new System.Drawing.Point(4, 22);
            this.tabÇiftSayılar.Name = "tabÇiftSayılar";
            this.tabÇiftSayılar.Padding = new System.Windows.Forms.Padding(3);
            this.tabÇiftSayılar.Size = new System.Drawing.Size(874, 392);
            this.tabÇiftSayılar.TabIndex = 1;
            this.tabÇiftSayılar.Text = "Çift Sayılar";
            this.tabÇiftSayılar.UseVisualStyleBackColor = true;
            // 
            // lstViewÇiftSayılar
            // 
            this.lstViewÇiftSayılar.BackColor = System.Drawing.Color.DarkGray;
            this.lstViewÇiftSayılar.Location = new System.Drawing.Point(6, 6);
            this.lstViewÇiftSayılar.Name = "lstViewÇiftSayılar";
            this.lstViewÇiftSayılar.Size = new System.Drawing.Size(285, 380);
            this.lstViewÇiftSayılar.TabIndex = 0;
            this.lstViewÇiftSayılar.UseCompatibleStateImageBehavior = false;
            this.lstViewÇiftSayılar.View = System.Windows.Forms.View.List;
            // 
            // tabAsalSayılar
            // 
            this.tabAsalSayılar.BackgroundImage = global::Ödev_2.Properties.Resources._119a6278ef098390d1ffb430d0d08ea205e0936a;
            this.tabAsalSayılar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabAsalSayılar.Controls.Add(this.lstViewAsalSayılar);
            this.tabAsalSayılar.Location = new System.Drawing.Point(4, 22);
            this.tabAsalSayılar.Name = "tabAsalSayılar";
            this.tabAsalSayılar.Padding = new System.Windows.Forms.Padding(3);
            this.tabAsalSayılar.Size = new System.Drawing.Size(874, 392);
            this.tabAsalSayılar.TabIndex = 2;
            this.tabAsalSayılar.Text = "Asal Sayılar";
            this.tabAsalSayılar.UseVisualStyleBackColor = true;
            // 
            // lstViewAsalSayılar
            // 
            this.lstViewAsalSayılar.BackColor = System.Drawing.Color.DarkGray;
            this.lstViewAsalSayılar.Location = new System.Drawing.Point(3, 6);
            this.lstViewAsalSayılar.Name = "lstViewAsalSayılar";
            this.lstViewAsalSayılar.Size = new System.Drawing.Size(288, 379);
            this.lstViewAsalSayılar.TabIndex = 0;
            this.lstViewAsalSayılar.UseCompatibleStateImageBehavior = false;
            this.lstViewAsalSayılar.View = System.Windows.Forms.View.List;
            // 
            // tabArmstrongSayıları
            // 
            this.tabArmstrongSayıları.BackgroundImage = global::Ödev_2.Properties.Resources._119a6278ef098390d1ffb430d0d08ea205e0936a;
            this.tabArmstrongSayıları.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabArmstrongSayıları.Controls.Add(this.lstViewArmstrongSayıları);
            this.tabArmstrongSayıları.Location = new System.Drawing.Point(4, 22);
            this.tabArmstrongSayıları.Name = "tabArmstrongSayıları";
            this.tabArmstrongSayıları.Padding = new System.Windows.Forms.Padding(3);
            this.tabArmstrongSayıları.Size = new System.Drawing.Size(874, 392);
            this.tabArmstrongSayıları.TabIndex = 3;
            this.tabArmstrongSayıları.Text = "Armstrong Sayıları";
            this.tabArmstrongSayıları.UseVisualStyleBackColor = true;
            // 
            // lstViewArmstrongSayıları
            // 
            this.lstViewArmstrongSayıları.BackColor = System.Drawing.Color.DarkGray;
            this.lstViewArmstrongSayıları.Location = new System.Drawing.Point(7, 7);
            this.lstViewArmstrongSayıları.Name = "lstViewArmstrongSayıları";
            this.lstViewArmstrongSayıları.Size = new System.Drawing.Size(284, 379);
            this.lstViewArmstrongSayıları.TabIndex = 0;
            this.lstViewArmstrongSayıları.UseCompatibleStateImageBehavior = false;
            this.lstViewArmstrongSayıları.View = System.Windows.Forms.View.List;
            // 
            // grpGirişBilgileri
            // 
            this.grpGirişBilgileri.BackColor = System.Drawing.Color.Transparent;
            this.grpGirişBilgileri.Controls.Add(this.btnİleri);
            this.grpGirişBilgileri.Controls.Add(this.btnGeri);
            this.grpGirişBilgileri.Controls.Add(this.btnHesapla);
            this.grpGirişBilgileri.Controls.Add(this.mskdtxtBitiş);
            this.grpGirişBilgileri.Controls.Add(this.lblBitiş);
            this.grpGirişBilgileri.Controls.Add(this.mskdtxtBaşlangıç);
            this.grpGirişBilgileri.Controls.Add(this.lblBaşlangıç);
            this.grpGirişBilgileri.Location = new System.Drawing.Point(12, 12);
            this.grpGirişBilgileri.Name = "grpGirişBilgileri";
            this.grpGirişBilgileri.Size = new System.Drawing.Size(882, 64);
            this.grpGirişBilgileri.TabIndex = 1;
            this.grpGirişBilgileri.TabStop = false;
            this.grpGirişBilgileri.Text = "Giriş Bilgileri";
            // 
            // btnİleri
            // 
            this.btnİleri.Location = new System.Drawing.Point(758, 23);
            this.btnİleri.Name = "btnİleri";
            this.btnİleri.Size = new System.Drawing.Size(75, 23);
            this.btnİleri.TabIndex = 4;
            this.btnİleri.Text = "İleri  >>";
            this.btnİleri.UseVisualStyleBackColor = true;
            this.btnİleri.Click += new System.EventHandler(this.btnİleri_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(677, 23);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(75, 23);
            this.btnGeri.TabIndex = 3;
            this.btnGeri.Text = "<<  Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(424, 23);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(75, 23);
            this.btnHesapla.TabIndex = 2;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // mskdtxtBitiş
            // 
            this.mskdtxtBitiş.Location = new System.Drawing.Point(301, 25);
            this.mskdtxtBitiş.Mask = "00000";
            this.mskdtxtBitiş.Name = "mskdtxtBitiş";
            this.mskdtxtBitiş.Size = new System.Drawing.Size(100, 20);
            this.mskdtxtBitiş.TabIndex = 1;
            this.mskdtxtBitiş.Text = "10000";
            this.mskdtxtBitiş.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskdtxtBitiş.ValidatingType = typeof(int);
            // 
            // lblBitiş
            // 
            this.lblBitiş.AutoSize = true;
            this.lblBitiş.Location = new System.Drawing.Point(269, 28);
            this.lblBitiş.Name = "lblBitiş";
            this.lblBitiş.Size = new System.Drawing.Size(26, 13);
            this.lblBitiş.TabIndex = 2;
            this.lblBitiş.Text = "Bitiş";
            // 
            // mskdtxtBaşlangıç
            // 
            this.mskdtxtBaşlangıç.BeepOnError = true;
            this.mskdtxtBaşlangıç.Location = new System.Drawing.Point(122, 25);
            this.mskdtxtBaşlangıç.Mask = "0000";
            this.mskdtxtBaşlangıç.Name = "mskdtxtBaşlangıç";
            this.mskdtxtBaşlangıç.Size = new System.Drawing.Size(100, 20);
            this.mskdtxtBaşlangıç.TabIndex = 0;
            this.mskdtxtBaşlangıç.Text = "1";
            this.mskdtxtBaşlangıç.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskdtxtBaşlangıç.ValidatingType = typeof(int);
            // 
            // lblBaşlangıç
            // 
            this.lblBaşlangıç.AutoSize = true;
            this.lblBaşlangıç.Location = new System.Drawing.Point(63, 28);
            this.lblBaşlangıç.Name = "lblBaşlangıç";
            this.lblBaşlangıç.Size = new System.Drawing.Size(53, 13);
            this.lblBaşlangıç.TabIndex = 0;
            this.lblBaşlangıç.Text = "Başlangıç";
            // 
            // ntfyBildirim
            // 
            this.ntfyBildirim.BalloonTipText = "Uygulama Açıldı";
            this.ntfyBildirim.BalloonTipTitle = "Hesaplama Programı";
            this.ntfyBildirim.Icon = ((System.Drawing.Icon)(resources.GetObject("ntfyBildirim.Icon")));
            this.ntfyBildirim.Tag = "";
            this.ntfyBildirim.Text = "Uygulama Açıldı";
            this.ntfyBildirim.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ödev_2.Properties.Resources._119a6278ef098390d1ffb430d0d08ea205e0936a;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(934, 525);
            this.Controls.Add(this.grpGirişBilgileri);
            this.Controls.Add(this.tbİşlemler);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.tbİşlemler.ResumeLayout(false);
            this.tabTekSayılar.ResumeLayout(false);
            this.tabÇiftSayılar.ResumeLayout(false);
            this.tabAsalSayılar.ResumeLayout(false);
            this.tabArmstrongSayıları.ResumeLayout(false);
            this.grpGirişBilgileri.ResumeLayout(false);
            this.grpGirişBilgileri.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbİşlemler;
        private System.Windows.Forms.TabPage tabTekSayılar;
        private System.Windows.Forms.TabPage tabÇiftSayılar;
        private System.Windows.Forms.TabPage tabAsalSayılar;
        private System.Windows.Forms.TabPage tabArmstrongSayıları;
        private System.Windows.Forms.GroupBox grpGirişBilgileri;
        private System.Windows.Forms.MaskedTextBox mskdtxtBitiş;
        private System.Windows.Forms.Label lblBitiş;
        private System.Windows.Forms.MaskedTextBox mskdtxtBaşlangıç;
        private System.Windows.Forms.Label lblBaşlangıç;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Button btnİleri;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.ListView lstViewÇiftSayılar;
        private System.Windows.Forms.ListView lstViewTekSayılar;
        private System.Windows.Forms.ListView lstViewAsalSayılar;
        private System.Windows.Forms.ListView lstViewArmstrongSayıları;
        private System.Windows.Forms.NotifyIcon ntfyBildirim;
    }
}

