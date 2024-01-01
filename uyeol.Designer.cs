using System.Windows.Forms;
using System;

namespace ChitChat
{
    partial class uyeol
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox pbProfilResmi;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uyeol));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label5 = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnProfilResmiSec = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnKayitOl = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtEmail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtDogrulamaSifresi = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pbProfilResmi = new System.Windows.Forms.PictureBox();
            this.txtProfilResmi = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtKullaniciAdi = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtSifre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilResmi)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.bunifuImageButton2);
            this.bunifuGradientPanel1.Controls.Add(this.label5);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuImageButton1);
            this.bunifuGradientPanel1.Controls.Add(this.btnProfilResmiSec);
            this.bunifuGradientPanel1.Controls.Add(this.btnKayitOl);
            this.bunifuGradientPanel1.Controls.Add(this.label3);
            this.bunifuGradientPanel1.Controls.Add(this.label2);
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox2);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox1);
            this.bunifuGradientPanel1.Controls.Add(this.txtEmail);
            this.bunifuGradientPanel1.Controls.Add(this.txtDogrulamaSifresi);
            this.bunifuGradientPanel1.Controls.Add(this.pbProfilResmi);
            this.bunifuGradientPanel1.Controls.Add(this.txtProfilResmi);
            this.bunifuGradientPanel1.Controls.Add(this.txtKullaniciAdi);
            this.bunifuGradientPanel1.Controls.Add(this.txtSifre);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.DodgerBlue;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Orange;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(734, 411);
            this.bunifuGradientPanel1.TabIndex = 29;
            this.bunifuGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuGradientPanel1_Paint);
            this.bunifuGradientPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bunifuGradientPanel1_MouseDown);
            this.bunifuGradientPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bunifuGradientPanel1_MouseMove);
            this.bunifuGradientPanel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bunifuGradientPanel1_MouseUp);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.Image = global::ChitChat.Properties.Resources.left_arrow;
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(656, 12);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(30, 30);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 39;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(196, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 38;
            this.label5.Text = "E-Mail";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = global::ChitChat.Properties.Resources.close;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(692, 12);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(30, 30);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 37;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // btnProfilResmiSec
            // 
            this.btnProfilResmiSec.ActiveBorderThickness = 1;
            this.btnProfilResmiSec.ActiveCornerRadius = 20;
            this.btnProfilResmiSec.ActiveFillColor = System.Drawing.Color.White;
            this.btnProfilResmiSec.ActiveForecolor = System.Drawing.Color.DodgerBlue;
            this.btnProfilResmiSec.ActiveLineColor = System.Drawing.Color.DodgerBlue;
            this.btnProfilResmiSec.BackColor = System.Drawing.Color.Transparent;
            this.btnProfilResmiSec.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProfilResmiSec.BackgroundImage")));
            this.btnProfilResmiSec.ButtonText = "Profil Resmi Ekle";
            this.btnProfilResmiSec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfilResmiSec.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnProfilResmiSec.ForeColor = System.Drawing.Color.White;
            this.btnProfilResmiSec.IdleBorderThickness = 1;
            this.btnProfilResmiSec.IdleCornerRadius = 20;
            this.btnProfilResmiSec.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnProfilResmiSec.IdleForecolor = System.Drawing.Color.White;
            this.btnProfilResmiSec.IdleLineColor = System.Drawing.Color.White;
            this.btnProfilResmiSec.Location = new System.Drawing.Point(572, 231);
            this.btnProfilResmiSec.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnProfilResmiSec.Name = "btnProfilResmiSec";
            this.btnProfilResmiSec.Size = new System.Drawing.Size(150, 30);
            this.btnProfilResmiSec.TabIndex = 36;
            this.btnProfilResmiSec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnProfilResmiSec.Click += new System.EventHandler(this.btnProfilResmiSec_Click_1);
            // 
            // btnKayitOl
            // 
            this.btnKayitOl.ActiveBorderThickness = 1;
            this.btnKayitOl.ActiveCornerRadius = 20;
            this.btnKayitOl.ActiveFillColor = System.Drawing.Color.White;
            this.btnKayitOl.ActiveForecolor = System.Drawing.Color.DodgerBlue;
            this.btnKayitOl.ActiveLineColor = System.Drawing.Color.DodgerBlue;
            this.btnKayitOl.BackColor = System.Drawing.Color.Transparent;
            this.btnKayitOl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKayitOl.BackgroundImage")));
            this.btnKayitOl.ButtonText = "Kayıt Ol";
            this.btnKayitOl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKayitOl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKayitOl.ForeColor = System.Drawing.Color.White;
            this.btnKayitOl.IdleBorderThickness = 1;
            this.btnKayitOl.IdleCornerRadius = 20;
            this.btnKayitOl.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnKayitOl.IdleForecolor = System.Drawing.Color.White;
            this.btnKayitOl.IdleLineColor = System.Drawing.Color.White;
            this.btnKayitOl.Location = new System.Drawing.Point(304, 351);
            this.btnKayitOl.Margin = new System.Windows.Forms.Padding(5);
            this.btnKayitOl.Name = "btnKayitOl";
            this.btnKayitOl.Size = new System.Drawing.Size(174, 41);
            this.btnKayitOl.TabIndex = 35;
            this.btnKayitOl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnKayitOl.Click += new System.EventHandler(this.btnKayitOl_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(177, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 33;
            this.label3.Text = "Şifre Tekrar";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(201, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Şifre";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(176, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::ChitChat.Properties.Resources.HEMEN;
            this.pictureBox2.Location = new System.Drawing.Point(227, 37);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(330, 93);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::ChitChat.Properties.Resources.ChitChat_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Control;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.HintForeColor = System.Drawing.Color.DimGray;
            this.txtEmail.HintText = "kullaniciadi@example.com";
            this.txtEmail.isPassword = false;
            this.txtEmail.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtEmail.LineIdleColor = System.Drawing.Color.Orange;
            this.txtEmail.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txtEmail.LineThickness = 3;
            this.txtEmail.Location = new System.Drawing.Point(292, 315);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 25);
            this.txtEmail.TabIndex = 26;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtDogrulamaSifresi
            // 
            this.txtDogrulamaSifresi.BackColor = System.Drawing.SystemColors.Control;
            this.txtDogrulamaSifresi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDogrulamaSifresi.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtDogrulamaSifresi.ForeColor = System.Drawing.Color.Black;
            this.txtDogrulamaSifresi.HintForeColor = System.Drawing.Color.DimGray;
            this.txtDogrulamaSifresi.HintText = "••••••";
            this.txtDogrulamaSifresi.isPassword = true;
            this.txtDogrulamaSifresi.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtDogrulamaSifresi.LineIdleColor = System.Drawing.Color.Orange;
            this.txtDogrulamaSifresi.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txtDogrulamaSifresi.LineThickness = 3;
            this.txtDogrulamaSifresi.Location = new System.Drawing.Point(292, 277);
            this.txtDogrulamaSifresi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDogrulamaSifresi.Name = "txtDogrulamaSifresi";
            this.txtDogrulamaSifresi.Size = new System.Drawing.Size(200, 25);
            this.txtDogrulamaSifresi.TabIndex = 28;
            this.txtDogrulamaSifresi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pbProfilResmi
            // 
            this.pbProfilResmi.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pbProfilResmi.Image = global::ChitChat.Properties.Resources.boşprofil;
            this.pbProfilResmi.Location = new System.Drawing.Point(572, 48);
            this.pbProfilResmi.Name = "pbProfilResmi";
            this.pbProfilResmi.Size = new System.Drawing.Size(150, 150);
            this.pbProfilResmi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProfilResmi.TabIndex = 9;
            this.pbProfilResmi.TabStop = false;
            // 
            // txtProfilResmi
            // 
            this.txtProfilResmi.BackColor = System.Drawing.SystemColors.Control;
            this.txtProfilResmi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProfilResmi.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtProfilResmi.ForeColor = System.Drawing.Color.Black;
            this.txtProfilResmi.HintForeColor = System.Drawing.Color.DimGray;
            this.txtProfilResmi.HintText = "...";
            this.txtProfilResmi.isPassword = false;
            this.txtProfilResmi.LineFocusedColor = System.Drawing.Color.Orange;
            this.txtProfilResmi.LineIdleColor = System.Drawing.Color.DodgerBlue;
            this.txtProfilResmi.LineMouseHoverColor = System.Drawing.Color.DarkOrange;
            this.txtProfilResmi.LineThickness = 3;
            this.txtProfilResmi.Location = new System.Drawing.Point(572, 207);
            this.txtProfilResmi.Margin = new System.Windows.Forms.Padding(4);
            this.txtProfilResmi.Name = "txtProfilResmi";
            this.txtProfilResmi.Size = new System.Drawing.Size(150, 23);
            this.txtProfilResmi.TabIndex = 27;
            this.txtProfilResmi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.BackColor = System.Drawing.SystemColors.Control;
            this.txtKullaniciAdi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtKullaniciAdi.ForeColor = System.Drawing.Color.Black;
            this.txtKullaniciAdi.HintForeColor = System.Drawing.Color.DimGray;
            this.txtKullaniciAdi.HintText = "Örn: talla.yavuz";
            this.txtKullaniciAdi.isPassword = false;
            this.txtKullaniciAdi.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtKullaniciAdi.LineIdleColor = System.Drawing.Color.Orange;
            this.txtKullaniciAdi.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txtKullaniciAdi.LineThickness = 3;
            this.txtKullaniciAdi.Location = new System.Drawing.Point(292, 201);
            this.txtKullaniciAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(200, 25);
            this.txtKullaniciAdi.TabIndex = 24;
            this.txtKullaniciAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtSifre
            // 
            this.txtSifre.BackColor = System.Drawing.SystemColors.Control;
            this.txtSifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSifre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSifre.ForeColor = System.Drawing.Color.Black;
            this.txtSifre.HintForeColor = System.Drawing.Color.DimGray;
            this.txtSifre.HintText = "••••••";
            this.txtSifre.isPassword = true;
            this.txtSifre.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtSifre.LineIdleColor = System.Drawing.Color.Orange;
            this.txtSifre.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txtSifre.LineThickness = 3;
            this.txtSifre.Location = new System.Drawing.Point(292, 239);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(4);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(200, 25);
            this.txtSifre.TabIndex = 25;
            this.txtSifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // uyeol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 411);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "uyeol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilResmi)).EndInit();
            this.ResumeLayout(false);

        }

        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSifre;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtKullaniciAdi;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtEmail;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtProfilResmi;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDogrulamaSifresi;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label1;
        private Label label3;
        private Bunifu.Framework.UI.BunifuThinButton2 btnKayitOl;
        private Bunifu.Framework.UI.BunifuThinButton2 btnProfilResmiSec;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Label label5;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
    }
}
