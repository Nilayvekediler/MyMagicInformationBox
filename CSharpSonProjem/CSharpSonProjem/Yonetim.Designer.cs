
namespace CSharpSonProjem
{
    partial class Yonetim
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
            this.dataGridYonetici = new System.Windows.Forms.DataGridView();
            this.dataGridKullanici = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEkleYonetici = new System.Windows.Forms.Button();
            this.btnSilYonetici = new System.Windows.Forms.Button();
            this.btnGuncelleYonetici = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtEposta = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtAraYonetici = new System.Windows.Forms.TextBox();
            this.txtAraKullanıcı = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSilKullanici = new System.Windows.Forms.Button();
            this.btnSilBilgi = new System.Windows.Forms.Button();
            this.txtAraBilgi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridBilgi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridYonetici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKullanici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBilgi)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridYonetici
            // 
            this.dataGridYonetici.AllowUserToAddRows = false;
            this.dataGridYonetici.AllowUserToDeleteRows = false;
            this.dataGridYonetici.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridYonetici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridYonetici.Location = new System.Drawing.Point(108, 144);
            this.dataGridYonetici.Name = "dataGridYonetici";
            this.dataGridYonetici.ReadOnly = true;
            this.dataGridYonetici.RowHeadersWidth = 51;
            this.dataGridYonetici.RowTemplate.Height = 24;
            this.dataGridYonetici.Size = new System.Drawing.Size(769, 140);
            this.dataGridYonetici.TabIndex = 0;
            this.dataGridYonetici.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridYonetici_CellEnter);
            // 
            // dataGridKullanici
            // 
            this.dataGridKullanici.AllowUserToAddRows = false;
            this.dataGridKullanici.AllowUserToDeleteRows = false;
            this.dataGridKullanici.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridKullanici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridKullanici.Location = new System.Drawing.Point(105, 353);
            this.dataGridKullanici.Name = "dataGridKullanici";
            this.dataGridKullanici.ReadOnly = true;
            this.dataGridKullanici.RowHeadersWidth = 51;
            this.dataGridKullanici.RowTemplate.Height = 24;
            this.dataGridKullanici.Size = new System.Drawing.Size(772, 133);
            this.dataGridKullanici.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Yöneticiler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ad Soyad :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kullanıcılar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(225, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "E-posta :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(225, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Şifre :";
            // 
            // btnEkleYonetici
            // 
            this.btnEkleYonetici.Location = new System.Drawing.Point(517, 13);
            this.btnEkleYonetici.Name = "btnEkleYonetici";
            this.btnEkleYonetici.Size = new System.Drawing.Size(75, 23);
            this.btnEkleYonetici.TabIndex = 8;
            this.btnEkleYonetici.Text = "Ekle";
            this.btnEkleYonetici.UseVisualStyleBackColor = true;
            this.btnEkleYonetici.Click += new System.EventHandler(this.btnEkleYonetici_Click);
            // 
            // btnSilYonetici
            // 
            this.btnSilYonetici.Location = new System.Drawing.Point(517, 49);
            this.btnSilYonetici.Name = "btnSilYonetici";
            this.btnSilYonetici.Size = new System.Drawing.Size(75, 23);
            this.btnSilYonetici.TabIndex = 9;
            this.btnSilYonetici.Text = "Sil";
            this.btnSilYonetici.UseVisualStyleBackColor = true;
            this.btnSilYonetici.Click += new System.EventHandler(this.btnSilYonetici_Click);
            // 
            // btnGuncelleYonetici
            // 
            this.btnGuncelleYonetici.Location = new System.Drawing.Point(517, 82);
            this.btnGuncelleYonetici.Name = "btnGuncelleYonetici";
            this.btnGuncelleYonetici.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelleYonetici.TabIndex = 10;
            this.btnGuncelleYonetici.Text = "Güncelle";
            this.btnGuncelleYonetici.UseVisualStyleBackColor = true;
            this.btnGuncelleYonetici.Click += new System.EventHandler(this.btnGuncelleYonetici_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(225, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ara";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(329, 14);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(161, 22);
            this.txtAd.TabIndex = 12;
            // 
            // txtEposta
            // 
            this.txtEposta.Location = new System.Drawing.Point(329, 49);
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.Size = new System.Drawing.Size(161, 22);
            this.txtEposta.TabIndex = 13;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(329, 77);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(161, 22);
            this.txtSifre.TabIndex = 14;
            // 
            // txtAraYonetici
            // 
            this.txtAraYonetici.Location = new System.Drawing.Point(329, 116);
            this.txtAraYonetici.Name = "txtAraYonetici";
            this.txtAraYonetici.Size = new System.Drawing.Size(161, 22);
            this.txtAraYonetici.TabIndex = 15;
            this.txtAraYonetici.TextChanged += new System.EventHandler(this.txtAraYonetici_TextChanged);
            // 
            // txtAraKullanıcı
            // 
            this.txtAraKullanıcı.Location = new System.Drawing.Point(307, 314);
            this.txtAraKullanıcı.Name = "txtAraKullanıcı";
            this.txtAraKullanıcı.Size = new System.Drawing.Size(161, 22);
            this.txtAraKullanıcı.TabIndex = 17;
            this.txtAraKullanıcı.TextChanged += new System.EventHandler(this.txtAraKullanıcı_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(205, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Ara";
            // 
            // btnSilKullanici
            // 
            this.btnSilKullanici.Location = new System.Drawing.Point(549, 313);
            this.btnSilKullanici.Name = "btnSilKullanici";
            this.btnSilKullanici.Size = new System.Drawing.Size(75, 23);
            this.btnSilKullanici.TabIndex = 18;
            this.btnSilKullanici.Text = "Sil";
            this.btnSilKullanici.UseVisualStyleBackColor = true;
            this.btnSilKullanici.Click += new System.EventHandler(this.btnSilKullanici_Click);
            // 
            // btnSilBilgi
            // 
            this.btnSilBilgi.Location = new System.Drawing.Point(549, 514);
            this.btnSilBilgi.Name = "btnSilBilgi";
            this.btnSilBilgi.Size = new System.Drawing.Size(75, 23);
            this.btnSilBilgi.TabIndex = 23;
            this.btnSilBilgi.Text = "Sil";
            this.btnSilBilgi.UseVisualStyleBackColor = true;
            this.btnSilBilgi.Click += new System.EventHandler(this.btnSilBilgi_Click);
            // 
            // txtAraBilgi
            // 
            this.txtAraBilgi.Location = new System.Drawing.Point(307, 515);
            this.txtAraBilgi.Name = "txtAraBilgi";
            this.txtAraBilgi.Size = new System.Drawing.Size(161, 22);
            this.txtAraBilgi.TabIndex = 22;
            this.txtAraBilgi.TextChanged += new System.EventHandler(this.txtAraBilgi_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(205, 514);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "Ara";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(105, 514);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "Bilgiler";
            // 
            // dataGridBilgi
            // 
            this.dataGridBilgi.AllowUserToAddRows = false;
            this.dataGridBilgi.AllowUserToDeleteRows = false;
            this.dataGridBilgi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridBilgi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBilgi.Location = new System.Drawing.Point(105, 554);
            this.dataGridBilgi.Name = "dataGridBilgi";
            this.dataGridBilgi.ReadOnly = true;
            this.dataGridBilgi.RowHeadersWidth = 51;
            this.dataGridBilgi.RowTemplate.Height = 24;
            this.dataGridBilgi.Size = new System.Drawing.Size(772, 118);
            this.dataGridBilgi.TabIndex = 19;
            // 
            // Yonetim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(992, 684);
            this.Controls.Add(this.btnSilBilgi);
            this.Controls.Add(this.txtAraBilgi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridBilgi);
            this.Controls.Add(this.btnSilKullanici);
            this.Controls.Add(this.txtAraKullanıcı);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAraYonetici);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtEposta);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnGuncelleYonetici);
            this.Controls.Add(this.btnSilYonetici);
            this.Controls.Add(this.btnEkleYonetici);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridKullanici);
            this.Controls.Add(this.dataGridYonetici);
            this.Name = "Yonetim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yönetim";
            this.Load += new System.EventHandler(this.Yonetim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridYonetici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKullanici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBilgi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridYonetici;
        private System.Windows.Forms.DataGridView dataGridKullanici;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEkleYonetici;
        private System.Windows.Forms.Button btnSilYonetici;
        private System.Windows.Forms.Button btnGuncelleYonetici;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtEposta;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtAraYonetici;
        private System.Windows.Forms.TextBox txtAraKullanıcı;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSilKullanici;
        private System.Windows.Forms.Button btnSilBilgi;
        private System.Windows.Forms.TextBox txtAraBilgi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridBilgi;
    }
}