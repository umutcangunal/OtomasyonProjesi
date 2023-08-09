namespace Otobüsrojesi
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.label12 = new System.Windows.Forms.Label();
            this.button_temizle = new System.Windows.Forms.Button();
            this.button_kaydet = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox_cinsiyet = new System.Windows.Forms.ComboBox();
            this.textBox_tel = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_tc = new System.Windows.Forms.TextBox();
            this.comboBox_yas = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_soyisim = new System.Windows.Forms.TextBox();
            this.textBox_isim = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox_adet = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker_tarih = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_saat = new System.Windows.Forms.ComboBox();
            this.comboBox_nereden = new System.Windows.Forms.ComboBox();
            this.comboBox_nereye = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(291, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(272, 37);
            this.label12.TabIndex = 33;
            this.label12.Text = "BİLET SATIN AL";
            // 
            // button_temizle
            // 
            this.button_temizle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_temizle.Location = new System.Drawing.Point(796, 230);
            this.button_temizle.Name = "button_temizle";
            this.button_temizle.Size = new System.Drawing.Size(93, 40);
            this.button_temizle.TabIndex = 32;
            this.button_temizle.Text = "YENİ+";
            this.button_temizle.UseVisualStyleBackColor = false;
            this.button_temizle.Click += new System.EventHandler(this.button_temizle_Click);
            // 
            // button_kaydet
            // 
            this.button_kaydet.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_kaydet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_kaydet.Location = new System.Drawing.Point(796, 174);
            this.button_kaydet.Name = "button_kaydet";
            this.button_kaydet.Size = new System.Drawing.Size(93, 40);
            this.button_kaydet.TabIndex = 30;
            this.button_kaydet.Text = "KAYDET";
            this.button_kaydet.UseVisualStyleBackColor = false;
            this.button_kaydet.Click += new System.EventHandler(this.button_kaydet_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.comboBox_cinsiyet);
            this.groupBox2.Controls.Add(this.textBox_tel);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.textBox_tc);
            this.groupBox2.Controls.Add(this.comboBox_yas);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBox_soyisim);
            this.groupBox2.Controls.Add(this.textBox_isim);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(110, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 218);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kişisel Bilgiler";
            // 
            // comboBox_cinsiyet
            // 
            this.comboBox_cinsiyet.FormattingEnabled = true;
            this.comboBox_cinsiyet.Items.AddRange(new object[] {
            "ERKEK",
            "KADIN",
            "DİĞER"});
            this.comboBox_cinsiyet.Location = new System.Drawing.Point(152, 176);
            this.comboBox_cinsiyet.Name = "comboBox_cinsiyet";
            this.comboBox_cinsiyet.Size = new System.Drawing.Size(121, 25);
            this.comboBox_cinsiyet.TabIndex = 19;
            // 
            // textBox_tel
            // 
            this.textBox_tel.Location = new System.Drawing.Point(152, 146);
            this.textBox_tel.Name = "textBox_tel";
            this.textBox_tel.Size = new System.Drawing.Size(121, 24);
            this.textBox_tel.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 153);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 17);
            this.label10.TabIndex = 16;
            this.label10.Text = "TELEFON:";
            // 
            // textBox_tc
            // 
            this.textBox_tc.Location = new System.Drawing.Point(152, 25);
            this.textBox_tc.Name = "textBox_tc";
            this.textBox_tc.Size = new System.Drawing.Size(121, 24);
            this.textBox_tc.TabIndex = 15;
            // 
            // comboBox_yas
            // 
            this.comboBox_yas.FormattingEnabled = true;
            this.comboBox_yas.Items.AddRange(new object[] {
            "0-6",
            "7-12",
            "13-17",
            "18+"});
            this.comboBox_yas.Location = new System.Drawing.Point(152, 114);
            this.comboBox_yas.Name = "comboBox_yas";
            this.comboBox_yas.Size = new System.Drawing.Size(121, 25);
            this.comboBox_yas.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 34);
            this.label8.TabIndex = 14;
            this.label8.Text = "T.C. Kimlik:\r\n ";
            // 
            // textBox_soyisim
            // 
            this.textBox_soyisim.Location = new System.Drawing.Point(152, 86);
            this.textBox_soyisim.Name = "textBox_soyisim";
            this.textBox_soyisim.Size = new System.Drawing.Size(121, 24);
            this.textBox_soyisim.TabIndex = 13;
            // 
            // textBox_isim
            // 
            this.textBox_isim.Location = new System.Drawing.Point(152, 58);
            this.textBox_isim.Name = "textBox_isim";
            this.textBox_isim.Size = new System.Drawing.Size(121, 24);
            this.textBox_isim.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Yaş Kategorisi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Cinsiyet:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Soyisim:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "İsim:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.comboBox_adet);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateTimePicker_tarih);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox_saat);
            this.groupBox1.Controls.Add(this.comboBox_nereden);
            this.groupBox1.Controls.Add(this.comboBox_nereye);
            this.groupBox1.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(468, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 218);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gidiş - Geliş İşlemleri";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(270, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 17);
            this.label11.TabIndex = 20;
            // 
            // comboBox_adet
            // 
            this.comboBox_adet.FormattingEnabled = true;
            this.comboBox_adet.Items.AddRange(new object[] {
            "1"});
            this.comboBox_adet.Location = new System.Drawing.Point(148, 138);
            this.comboBox_adet.Name = "comboBox_adet";
            this.comboBox_adet.Size = new System.Drawing.Size(158, 25);
            this.comboBox_adet.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "Bilet Adeti :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nereye :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sefer Saatleri :";
            // 
            // dateTimePicker_tarih
            // 
            this.dateTimePicker_tarih.Location = new System.Drawing.Point(69, 179);
            this.dateTimePicker_tarih.Name = "dateTimePicker_tarih";
            this.dateTimePicker_tarih.Size = new System.Drawing.Size(200, 24);
            this.dateTimePicker_tarih.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nereden : ";
            // 
            // comboBox_saat
            // 
            this.comboBox_saat.FormattingEnabled = true;
            this.comboBox_saat.Items.AddRange(new object[] {
            "06:00",
            "06:30(Express)",
            "08:00",
            "09:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00",
            "21:00",
            "22:00",
            "23:00",
            "00:00",
            "01:15",
            "03:00(Express)",
            "05:00(Express)"});
            this.comboBox_saat.Location = new System.Drawing.Point(148, 102);
            this.comboBox_saat.Name = "comboBox_saat";
            this.comboBox_saat.Size = new System.Drawing.Size(158, 25);
            this.comboBox_saat.TabIndex = 5;
            // 
            // comboBox_nereden
            // 
            this.comboBox_nereden.FormattingEnabled = true;
            this.comboBox_nereden.Items.AddRange(new object[] {
            "ADANA",
            "ANKARA",
            "ANTALYA",
            "AYDIN",
            "BALIKKESİR",
            "BURSA",
            "DENİZLİ",
            "DİYARBAKIR",
            "ERZURUM",
            "ESKİŞEHİR",
            "GAZİANTEP",
            "HATAY",
            "İSTANBUL(AND)",
            "İSTANBUL(AVR)",
            "İZMİR",
            "KAHRAMANMARAŞ",
            "KAYSERİ",
            "KOCAELİ",
            "KONYA",
            "MALATYA",
            "MANİSA",
            "MARDİN",
            "MERSİN",
            "MUĞLA",
            "ORDU",
            "SAKARYA",
            "SAMSUN",
            "ŞANLIURFA",
            "TEKİRDAĞ",
            "TRABZON",
            "VAN",
            "GÜRCİSTAN",
            "BULGARİSTAN",
            "YUNANİSTAN"});
            this.comboBox_nereden.Location = new System.Drawing.Point(148, 23);
            this.comboBox_nereden.Name = "comboBox_nereden";
            this.comboBox_nereden.Size = new System.Drawing.Size(158, 25);
            this.comboBox_nereden.TabIndex = 1;
            // 
            // comboBox_nereye
            // 
            this.comboBox_nereye.FormattingEnabled = true;
            this.comboBox_nereye.Items.AddRange(new object[] {
            "ADANA",
            "ANKARA",
            "ANTALYA",
            "AYDIN",
            "BALIKKESİR",
            "BURSA",
            "DENİZLİ",
            "DİYARBAKIR",
            "ERZURUM",
            "ESKİŞEHİR",
            "GAZİANTEP",
            "HATAY",
            "İSTANBUL(AND)",
            "İSTANBUL(AVR)",
            "İZMİR",
            "KAHRAMANMARAŞ",
            "KAYSERİ",
            "KOCAELİ",
            "KONYA",
            "MALATYA",
            "MANİSA",
            "MARDİN",
            "MERSİN",
            "MUĞLA",
            "ORDU",
            "SAKARYA",
            "SAMSUN",
            "ŞANLIURFA",
            "TEKİRDAĞ",
            "TRABZON",
            "VAN",
            "GÜRCİSTAN",
            "BULGARİSTAN",
            "YUNANİSTAN"});
            this.comboBox_nereye.Location = new System.Drawing.Point(148, 61);
            this.comboBox_nereye.Name = "comboBox_nereye";
            this.comboBox_nereye.Size = new System.Drawing.Size(158, 25);
            this.comboBox_nereye.TabIndex = 2;
            this.comboBox_nereye.SelectedIndexChanged += new System.EventHandler(this.comboBox_nereye_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(29, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 44);
            this.button1.TabIndex = 34;
            this.button1.Text = "GERİ DÖN";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(94, 423);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(722, 13);
            this.label13.TabIndex = 35;
            this.label13.Text = "İÇİŞLERİ BAKANLIĞI GENELGESİ DOĞRULTUSUNDA SADECE VALİLİK İZNİ OLAN VATANDAŞLAR Y" +
    "OLCULUK YAPABİLİR.";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(189, 448);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(505, 13);
            this.label14.TabIndex = 36;
            this.label14.Text = "YOLCULUK İZİN BELGELERİNİZ ARAÇ KALKIŞI SIRASINDA KONTROL EDİLECEKTİR.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(396, 352);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(945, 509);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button_temizle);
            this.Controls.Add(this.button_kaydet);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button_temizle;
        private System.Windows.Forms.Button button_kaydet;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox_cinsiyet;
        private System.Windows.Forms.TextBox textBox_tel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_tc;
        private System.Windows.Forms.ComboBox comboBox_yas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_soyisim;
        private System.Windows.Forms.TextBox textBox_isim;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox_adet;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker_tarih;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_saat;
        private System.Windows.Forms.ComboBox comboBox_nereden;
        private System.Windows.Forms.ComboBox comboBox_nereye;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}