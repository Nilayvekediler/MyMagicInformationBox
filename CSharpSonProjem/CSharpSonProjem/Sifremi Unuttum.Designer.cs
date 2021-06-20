
namespace CSharpSonProjem
{
    partial class SifreYenileme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SifreYenileme));
            this.btnGönder = new System.Windows.Forms.Button();
            this.txteposta1 = new System.Windows.Forms.TextBox();
            this.txtKullaniciAd1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSifreYenile = new System.Windows.Forms.Button();
            this.txtYeniSifre = new System.Windows.Forms.TextBox();
            this.txtGuvenlikKodu = new System.Windows.Forms.TextBox();
            this.GiriseDon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGönder
            // 
            this.btnGönder.BackColor = System.Drawing.SystemColors.Info;
            this.btnGönder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGönder.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGönder.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGönder.Location = new System.Drawing.Point(365, 348);
            this.btnGönder.Name = "btnGönder";
            this.btnGönder.Size = new System.Drawing.Size(281, 42);
            this.btnGönder.TabIndex = 9;
            this.btnGönder.Text = "Güvenlik Kodu Gönder!";
            this.btnGönder.UseVisualStyleBackColor = false;
            this.btnGönder.Click += new System.EventHandler(this.btnGönder_Click);
            // 
            // txteposta1
            // 
            this.txteposta1.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txteposta1.Location = new System.Drawing.Point(452, 210);
            this.txteposta1.Name = "txteposta1";
            this.txteposta1.Size = new System.Drawing.Size(238, 30);
            this.txteposta1.TabIndex = 8;
            // 
            // txtKullaniciAd1
            // 
            this.txtKullaniciAd1.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciAd1.Location = new System.Drawing.Point(452, 170);
            this.txtKullaniciAd1.Name = "txtKullaniciAd1";
            this.txtKullaniciAd1.Size = new System.Drawing.Size(238, 30);
            this.txtKullaniciAd1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(307, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "E-Mail :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(307, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(178, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(756, 30);
            this.label3.TabIndex = 10;
            this.label3.Text = "Bilgilerinizi giriniz ve mail adresinize gelen güvenlik kodu ile şifrenizi yenile" +
    "yebilirsiniz!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(306, 424);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 30);
            this.label4.TabIndex = 11;
            this.label4.Text = "Güvenlik Kodu :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(306, 459);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 30);
            this.label5.TabIndex = 12;
            this.label5.Text = "Yeni Şifre :";
            // 
            // btnSifreYenile
            // 
            this.btnSifreYenile.BackColor = System.Drawing.SystemColors.Info;
            this.btnSifreYenile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSifreYenile.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSifreYenile.Location = new System.Drawing.Point(416, 577);
            this.btnSifreYenile.Name = "btnSifreYenile";
            this.btnSifreYenile.Size = new System.Drawing.Size(178, 44);
            this.btnSifreYenile.TabIndex = 13;
            this.btnSifreYenile.Text = "Şifremi Yenile!";
            this.btnSifreYenile.UseVisualStyleBackColor = false;
            this.btnSifreYenile.Click += new System.EventHandler(this.btnSifreYenile_Click);
            // 
            // txtYeniSifre
            // 
            this.txtYeniSifre.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYeniSifre.Location = new System.Drawing.Point(452, 464);
            this.txtYeniSifre.Name = "txtYeniSifre";
            this.txtYeniSifre.PasswordChar = '*';
            this.txtYeniSifre.Size = new System.Drawing.Size(238, 30);
            this.txtYeniSifre.TabIndex = 15;
            // 
            // txtGuvenlikKodu
            // 
            this.txtGuvenlikKodu.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGuvenlikKodu.Location = new System.Drawing.Point(452, 424);
            this.txtGuvenlikKodu.Name = "txtGuvenlikKodu";
            this.txtGuvenlikKodu.Size = new System.Drawing.Size(238, 30);
            this.txtGuvenlikKodu.TabIndex = 14;
            // 
            // GiriseDon
            // 
            this.GiriseDon.BackColor = System.Drawing.SystemColors.Info;
            this.GiriseDon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GiriseDon.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GiriseDon.Location = new System.Drawing.Point(45, 23);
            this.GiriseDon.Name = "GiriseDon";
            this.GiriseDon.Size = new System.Drawing.Size(117, 102);
            this.GiriseDon.TabIndex = 16;
            this.GiriseDon.Text = "Giriş Ekranına Geri Dön";
            this.GiriseDon.UseVisualStyleBackColor = false;
            this.GiriseDon.Click += new System.EventHandler(this.GiriseDon_Click);
            // 
            // SifreYenileme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(992, 684);
            this.Controls.Add(this.GiriseDon);
            this.Controls.Add(this.txtYeniSifre);
            this.Controls.Add(this.txtGuvenlikKodu);
            this.Controls.Add(this.btnSifreYenile);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGönder);
            this.Controls.Add(this.txteposta1);
            this.Controls.Add(this.txtKullaniciAd1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SifreYenileme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sifremi Unuttum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGönder;
        private System.Windows.Forms.TextBox txteposta1;
        private System.Windows.Forms.TextBox txtKullaniciAd1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSifreYenile;
        private System.Windows.Forms.TextBox txtYeniSifre;
        private System.Windows.Forms.TextBox txtGuvenlikKodu;
        private System.Windows.Forms.Button GiriseDon;
    }
}