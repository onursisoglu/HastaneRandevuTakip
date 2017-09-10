namespace Randevu_Takip
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_Hasta_Sayisi = new System.Windows.Forms.Label();
            this.lb_Hastalar = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.checkB_Erkek = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_Dakika = new System.Windows.Forms.ComboBox();
            this.cb_Saat = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dt_Randevu_Tarihi = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_Doktor_Secimi = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_Brans_Secimi = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dt_DogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_AdSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_KimlikNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_Hasta_Sayisi);
            this.groupBox1.Controls.Add(this.lb_Hastalar);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btn_Ekle);
            this.groupBox1.Controls.Add(this.btn_Sil);
            this.groupBox1.Controls.Add(this.checkB_Erkek);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cb_Dakika);
            this.groupBox1.Controls.Add(this.cb_Saat);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dt_Randevu_Tarihi);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cb_Doktor_Secimi);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cb_Brans_Secimi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dt_DogumTarihi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_AdSoyad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_KimlikNo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(532, 290);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Hasta Kayıt";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lbl_Hasta_Sayisi
            // 
            this.lbl_Hasta_Sayisi.AutoSize = true;
            this.lbl_Hasta_Sayisi.Location = new System.Drawing.Point(337, 227);
            this.lbl_Hasta_Sayisi.Name = "lbl_Hasta_Sayisi";
            this.lbl_Hasta_Sayisi.Size = new System.Drawing.Size(90, 13);
            this.lbl_Hasta_Sayisi.TabIndex = 20;
            this.lbl_Hasta_Sayisi.Text = "Toplam {0} Hasta";
            // 
            // lb_Hastalar
            // 
            this.lb_Hastalar.FormattingEnabled = true;
            this.lb_Hastalar.Location = new System.Drawing.Point(337, 34);
            this.lb_Hastalar.Name = "lb_Hastalar";
            this.lb_Hastalar.Size = new System.Drawing.Size(167, 186);
            this.lb_Hastalar.TabIndex = 19;
            this.lb_Hastalar.SelectedIndexChanged += new System.EventHandler(this.lb_Hastalar_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(334, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Tüm Hastalar";
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Location = new System.Drawing.Point(175, 245);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_Ekle.TabIndex = 17;
            this.btn_Ekle.Text = "Ekle";
            this.btn_Ekle.UseVisualStyleBackColor = true;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // btn_Sil
            // 
            this.btn_Sil.Location = new System.Drawing.Point(94, 245);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(75, 23);
            this.btn_Sil.TabIndex = 17;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // checkB_Erkek
            // 
            this.checkB_Erkek.AutoSize = true;
            this.checkB_Erkek.Location = new System.Drawing.Point(94, 216);
            this.checkB_Erkek.Name = "checkB_Erkek";
            this.checkB_Erkek.Size = new System.Drawing.Size(54, 17);
            this.checkB_Erkek.TabIndex = 16;
            this.checkB_Erkek.Text = "Erkek";
            this.checkB_Erkek.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Cinsiyet:";
            // 
            // cb_Dakika
            // 
            this.cb_Dakika.FormattingEnabled = true;
            this.cb_Dakika.Items.AddRange(new object[] {
            "00",
            "30"});
            this.cb_Dakika.Location = new System.Drawing.Point(160, 189);
            this.cb_Dakika.Name = "cb_Dakika";
            this.cb_Dakika.Size = new System.Drawing.Size(55, 21);
            this.cb_Dakika.TabIndex = 14;
            // 
            // cb_Saat
            // 
            this.cb_Saat.FormattingEnabled = true;
            this.cb_Saat.Items.AddRange(new object[] {
            "09",
            "10",
            "11",
            "13",
            "14",
            "15",
            "16",
            "17"});
            this.cb_Saat.Location = new System.Drawing.Point(94, 189);
            this.cb_Saat.Name = "cb_Saat";
            this.cb_Saat.Size = new System.Drawing.Size(60, 21);
            this.cb_Saat.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Randevu Saati:";
            // 
            // dt_Randevu_Tarihi
            // 
            this.dt_Randevu_Tarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_Randevu_Tarihi.Location = new System.Drawing.Point(94, 162);
            this.dt_Randevu_Tarihi.Name = "dt_Randevu_Tarihi";
            this.dt_Randevu_Tarihi.Size = new System.Drawing.Size(200, 20);
            this.dt_Randevu_Tarihi.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Randevu Tarihi:";
            // 
            // cb_Doktor_Secimi
            // 
            this.cb_Doktor_Secimi.FormattingEnabled = true;
            this.cb_Doktor_Secimi.Location = new System.Drawing.Point(94, 135);
            this.cb_Doktor_Secimi.Name = "cb_Doktor_Secimi";
            this.cb_Doktor_Secimi.Size = new System.Drawing.Size(121, 21);
            this.cb_Doktor_Secimi.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Doktor Seçimi:";
            // 
            // cb_Brans_Secimi
            // 
            this.cb_Brans_Secimi.FormattingEnabled = true;
            this.cb_Brans_Secimi.Items.AddRange(new object[] {
            "Ortopedi",
            "Kardiyoloji",
            "Göz",
            "Rehabilitasyon"});
            this.cb_Brans_Secimi.Location = new System.Drawing.Point(94, 108);
            this.cb_Brans_Secimi.Name = "cb_Brans_Secimi";
            this.cb_Brans_Secimi.Size = new System.Drawing.Size(121, 21);
            this.cb_Brans_Secimi.TabIndex = 7;
            this.cb_Brans_Secimi.SelectedIndexChanged += new System.EventHandler(this.cb_Brans_Secimi_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Branş Seçimi:";
            // 
            // dt_DogumTarihi
            // 
            this.dt_DogumTarihi.Location = new System.Drawing.Point(94, 82);
            this.dt_DogumTarihi.Name = "dt_DogumTarihi";
            this.dt_DogumTarihi.Size = new System.Drawing.Size(200, 20);
            this.dt_DogumTarihi.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Doğum Tarihi:";
            // 
            // txt_AdSoyad
            // 
            this.txt_AdSoyad.Location = new System.Drawing.Point(94, 56);
            this.txt_AdSoyad.Name = "txt_AdSoyad";
            this.txt_AdSoyad.Size = new System.Drawing.Size(100, 20);
            this.txt_AdSoyad.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adı Soyadı:";
            // 
            // txt_KimlikNo
            // 
            this.txt_KimlikNo.Location = new System.Drawing.Point(94, 30);
            this.txt_KimlikNo.Name = "txt_KimlikNo";
            this.txt_KimlikNo.Size = new System.Drawing.Size(100, 20);
            this.txt_KimlikNo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kimlik No:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 318);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(650, 176);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bugün Beklenen Randevular";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(644, 157);
            this.dataGridView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 506);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Randevu Takip Sistemi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_Hasta_Sayisi;
        private System.Windows.Forms.ListBox lb_Hastalar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.CheckBox checkB_Erkek;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_Dakika;
        private System.Windows.Forms.ComboBox cb_Saat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dt_Randevu_Tarihi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_Doktor_Secimi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_Brans_Secimi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dt_DogumTarihi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_AdSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_KimlikNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

