
namespace DapperOrmWinTrackingFood
{
    partial class MainForm
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
            this.btnConn = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.lKullanici = new System.Windows.Forms.ListBox();
            this.btnKullanıcıEkle = new System.Windows.Forms.Button();
            this.tAd = new System.Windows.Forms.TextBox();
            this.tSoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tUSoyad = new System.Windows.Forms.TextBox();
            this.tUAdi = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tDId = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConn
            // 
            this.btnConn.Location = new System.Drawing.Point(47, 21);
            this.btnConn.Name = "btnConn";
            this.btnConn.Size = new System.Drawing.Size(156, 47);
            this.btnConn.TabIndex = 0;
            this.btnConn.Text = "Bağlantı kontrol Et";
            this.btnConn.UseVisualStyleBackColor = true;
            this.btnConn.Click += new System.EventHandler(this.btnConn_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(222, 21);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(198, 47);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "Kullanıcları Getir";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // lKullanici
            // 
            this.lKullanici.FormattingEnabled = true;
            this.lKullanici.ItemHeight = 15;
            this.lKullanici.Location = new System.Drawing.Point(222, 75);
            this.lKullanici.Name = "lKullanici";
            this.lKullanici.Size = new System.Drawing.Size(198, 229);
            this.lKullanici.TabIndex = 2;
            // 
            // btnKullanıcıEkle
            // 
            this.btnKullanıcıEkle.Location = new System.Drawing.Point(435, 79);
            this.btnKullanıcıEkle.Name = "btnKullanıcıEkle";
            this.btnKullanıcıEkle.Size = new System.Drawing.Size(259, 47);
            this.btnKullanıcıEkle.TabIndex = 3;
            this.btnKullanıcıEkle.Text = "Kullanıcı Ekle";
            this.btnKullanıcıEkle.UseVisualStyleBackColor = true;
            this.btnKullanıcıEkle.Click += new System.EventHandler(this.btnKullanıcıEkle_Click);
            // 
            // tAd
            // 
            this.tAd.Location = new System.Drawing.Point(517, 21);
            this.tAd.Name = "tAd";
            this.tAd.Size = new System.Drawing.Size(177, 23);
            this.tAd.TabIndex = 4;
            // 
            // tSoyad
            // 
            this.tSoyad.Location = new System.Drawing.Point(517, 50);
            this.tSoyad.Name = "tSoyad";
            this.tSoyad.Size = new System.Drawing.Size(177, 23);
            this.tSoyad.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(435, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(435, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Soyadı:";
            // 
            // tUSoyad
            // 
            this.tUSoyad.Location = new System.Drawing.Point(840, 83);
            this.tUSoyad.Name = "tUSoyad";
            this.tUSoyad.Size = new System.Drawing.Size(177, 23);
            this.tUSoyad.TabIndex = 10;
            // 
            // tUAdi
            // 
            this.tUAdi.Location = new System.Drawing.Point(840, 54);
            this.tUAdi.Name = "tUAdi";
            this.tUAdi.Size = new System.Drawing.Size(177, 23);
            this.tUAdi.TabIndex = 9;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(758, 112);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(259, 47);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Kullanıcı Güncelleme";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(758, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Soyadı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(758, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Adı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(758, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Id:";
            // 
            // TId
            // 
            this.TId.Location = new System.Drawing.Point(840, 21);
            this.TId.Name = "TId";
            this.TId.Size = new System.Drawing.Size(177, 23);
            this.TId.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(444, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Id:";
            // 
            // tDId
            // 
            this.tDId.Location = new System.Drawing.Point(526, 229);
            this.tDId.Name = "tDId";
            this.tDId.Size = new System.Drawing.Size(177, 23);
            this.tDId.TabIndex = 16;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(444, 258);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(259, 47);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Kullanıcı Silme";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tDId);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tUSoyad);
            this.Controls.Add(this.tUAdi);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tSoyad);
            this.Controls.Add(this.tAd);
            this.Controls.Add(this.btnKullanıcıEkle);
            this.Controls.Add(this.lKullanici);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnConn);
            this.Name = "MainForm";
            this.Text = "Ana Sayfa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConn;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.ListBox lKullanici;
        private System.Windows.Forms.Button btnKullanıcıEkle;
        private System.Windows.Forms.TextBox tAd;
        private System.Windows.Forms.TextBox tSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tUSoyad;
        private System.Windows.Forms.TextBox tUAdi;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tDId;
        private System.Windows.Forms.Button btnDelete;
    }
}

