namespace Deklaracja
{
    partial class Form1
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
            this.deklaracja_lbl = new System.Windows.Forms.Label();
            this.uczen_dane_grpbox = new System.Windows.Forms.GroupBox();
            this.nazwisko_lbl = new System.Windows.Forms.Label();
            this.imie_lbl = new System.Windows.Forms.Label();
            this.data_lbl = new System.Windows.Forms.Label();
            this.pesel_lbl = new System.Windows.Forms.Label();
            this.imie_inp = new System.Windows.Forms.TextBox();
            this.ur_inp = new System.Windows.Forms.TextBox();
            this.pesel_inp = new System.Windows.Forms.TextBox();
            this.nazwisko_inp = new System.Windows.Forms.TextBox();
            this.miejsce_ur_inp = new System.Windows.Forms.TextBox();
            this.adres_kor_grpbox = new System.Windows.Forms.GroupBox();
            this.poczta_inp = new System.Windows.Forms.TextBox();
            this.miejsowosc_inp = new System.Windows.Forms.TextBox();
            this.telefon_inp = new System.Windows.Forms.TextBox();
            this.kod_inp = new System.Windows.Forms.TextBox();
            this.ulica_inp = new System.Windows.Forms.TextBox();
            this.telefon_lbl = new System.Windows.Forms.Label();
            this.poczta_lbl = new System.Windows.Forms.Label();
            this.ulica_lbl = new System.Windows.Forms.Label();
            this.miejscowosc_lbl = new System.Windows.Forms.Label();
            this.dec_cmbbox = new System.Windows.Forms.ComboBox();
            this.mail_lbl = new System.Windows.Forms.Label();
            this.mail_inp = new System.Windows.Forms.TextBox();
            this.dec_lbl_1 = new System.Windows.Forms.Label();
            this.dec_lbl_2 = new System.Windows.Forms.Label();
            this.uczen_dane_grpbox.SuspendLayout();
            this.adres_kor_grpbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // deklaracja_lbl
            // 
            this.deklaracja_lbl.AutoSize = true;
            this.deklaracja_lbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deklaracja_lbl.Location = new System.Drawing.Point(130, 27);
            this.deklaracja_lbl.Name = "deklaracja_lbl";
            this.deklaracja_lbl.Size = new System.Drawing.Size(334, 20);
            this.deklaracja_lbl.TabIndex = 0;
            this.deklaracja_lbl.Text = "DEKLARACJA PRZYSTĄPIENIA DO EGZAMINU";
            this.deklaracja_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.deklaracja_lbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // uczen_dane_grpbox
            // 
            this.uczen_dane_grpbox.Controls.Add(this.miejsce_ur_inp);
            this.uczen_dane_grpbox.Controls.Add(this.nazwisko_inp);
            this.uczen_dane_grpbox.Controls.Add(this.pesel_inp);
            this.uczen_dane_grpbox.Controls.Add(this.ur_inp);
            this.uczen_dane_grpbox.Controls.Add(this.imie_inp);
            this.uczen_dane_grpbox.Controls.Add(this.pesel_lbl);
            this.uczen_dane_grpbox.Controls.Add(this.data_lbl);
            this.uczen_dane_grpbox.Controls.Add(this.imie_lbl);
            this.uczen_dane_grpbox.Controls.Add(this.nazwisko_lbl);
            this.uczen_dane_grpbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.uczen_dane_grpbox.Location = new System.Drawing.Point(21, 70);
            this.uczen_dane_grpbox.Name = "uczen_dane_grpbox";
            this.uczen_dane_grpbox.Size = new System.Drawing.Size(599, 171);
            this.uczen_dane_grpbox.TabIndex = 1;
            this.uczen_dane_grpbox.TabStop = false;
            this.uczen_dane_grpbox.Text = "Dane osobowe ucznia";
            // 
            // nazwisko_lbl
            // 
            this.nazwisko_lbl.AutoSize = true;
            this.nazwisko_lbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nazwisko_lbl.Location = new System.Drawing.Point(30, 37);
            this.nazwisko_lbl.Name = "nazwisko_lbl";
            this.nazwisko_lbl.Size = new System.Drawing.Size(80, 20);
            this.nazwisko_lbl.TabIndex = 0;
            this.nazwisko_lbl.Text = "Nazwisko:";
            // 
            // imie_lbl
            // 
            this.imie_lbl.AutoSize = true;
            this.imie_lbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.imie_lbl.Location = new System.Drawing.Point(30, 63);
            this.imie_lbl.Name = "imie_lbl";
            this.imie_lbl.Size = new System.Drawing.Size(104, 20);
            this.imie_lbl.TabIndex = 1;
            this.imie_lbl.Text = "Imię(imiona):";
            // 
            // data_lbl
            // 
            this.data_lbl.AutoSize = true;
            this.data_lbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.data_lbl.Location = new System.Drawing.Point(30, 99);
            this.data_lbl.Name = "data_lbl";
            this.data_lbl.Size = new System.Drawing.Size(183, 20);
            this.data_lbl.TabIndex = 2;
            this.data_lbl.Text = "Data i miejsce urodzenia:";
            // 
            // pesel_lbl
            // 
            this.pesel_lbl.AutoSize = true;
            this.pesel_lbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pesel_lbl.Location = new System.Drawing.Point(30, 131);
            this.pesel_lbl.Name = "pesel_lbl";
            this.pesel_lbl.Size = new System.Drawing.Size(107, 20);
            this.pesel_lbl.TabIndex = 3;
            this.pesel_lbl.Text = "Numer PESEL:";
            // 
            // imie_inp
            // 
            this.imie_inp.Location = new System.Drawing.Point(211, 63);
            this.imie_inp.Name = "imie_inp";
            this.imie_inp.Size = new System.Drawing.Size(366, 27);
            this.imie_inp.TabIndex = 4;
            // 
            // ur_inp
            // 
            this.ur_inp.Location = new System.Drawing.Point(211, 96);
            this.ur_inp.Name = "ur_inp";
            this.ur_inp.Size = new System.Drawing.Size(99, 27);
            this.ur_inp.TabIndex = 5;
            // 
            // pesel_inp
            // 
            this.pesel_inp.Location = new System.Drawing.Point(211, 128);
            this.pesel_inp.Name = "pesel_inp";
            this.pesel_inp.Size = new System.Drawing.Size(125, 27);
            this.pesel_inp.TabIndex = 6;
            // 
            // nazwisko_inp
            // 
            this.nazwisko_inp.Location = new System.Drawing.Point(211, 34);
            this.nazwisko_inp.Name = "nazwisko_inp";
            this.nazwisko_inp.Size = new System.Drawing.Size(366, 27);
            this.nazwisko_inp.TabIndex = 7;
            // 
            // miejsce_ur_inp
            // 
            this.miejsce_ur_inp.Location = new System.Drawing.Point(331, 96);
            this.miejsce_ur_inp.Name = "miejsce_ur_inp";
            this.miejsce_ur_inp.Size = new System.Drawing.Size(246, 27);
            this.miejsce_ur_inp.TabIndex = 8;
            // 
            // adres_kor_grpbox
            // 
            this.adres_kor_grpbox.Controls.Add(this.mail_inp);
            this.adres_kor_grpbox.Controls.Add(this.mail_lbl);
            this.adres_kor_grpbox.Controls.Add(this.poczta_inp);
            this.adres_kor_grpbox.Controls.Add(this.miejsowosc_inp);
            this.adres_kor_grpbox.Controls.Add(this.telefon_inp);
            this.adres_kor_grpbox.Controls.Add(this.kod_inp);
            this.adres_kor_grpbox.Controls.Add(this.ulica_inp);
            this.adres_kor_grpbox.Controls.Add(this.telefon_lbl);
            this.adres_kor_grpbox.Controls.Add(this.poczta_lbl);
            this.adres_kor_grpbox.Controls.Add(this.ulica_lbl);
            this.adres_kor_grpbox.Controls.Add(this.miejscowosc_lbl);
            this.adres_kor_grpbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.adres_kor_grpbox.Location = new System.Drawing.Point(21, 273);
            this.adres_kor_grpbox.Name = "adres_kor_grpbox";
            this.adres_kor_grpbox.Size = new System.Drawing.Size(599, 171);
            this.adres_kor_grpbox.TabIndex = 9;
            this.adres_kor_grpbox.TabStop = false;
            this.adres_kor_grpbox.Text = "Adres korespondencyjny";
            // 
            // poczta_inp
            // 
            this.poczta_inp.Location = new System.Drawing.Point(351, 92);
            this.poczta_inp.Name = "poczta_inp";
            this.poczta_inp.Size = new System.Drawing.Size(226, 27);
            this.poczta_inp.TabIndex = 8;
            // 
            // miejsowosc_inp
            // 
            this.miejsowosc_inp.Location = new System.Drawing.Point(231, 30);
            this.miejsowosc_inp.Name = "miejsowosc_inp";
            this.miejsowosc_inp.Size = new System.Drawing.Size(346, 27);
            this.miejsowosc_inp.TabIndex = 7;
            // 
            // telefon_inp
            // 
            this.telefon_inp.Location = new System.Drawing.Point(231, 124);
            this.telefon_inp.Name = "telefon_inp";
            this.telefon_inp.Size = new System.Drawing.Size(148, 27);
            this.telefon_inp.TabIndex = 6;
            // 
            // kod_inp
            // 
            this.kod_inp.Location = new System.Drawing.Point(231, 92);
            this.kod_inp.Name = "kod_inp";
            this.kod_inp.Size = new System.Drawing.Size(99, 27);
            this.kod_inp.TabIndex = 5;
            // 
            // ulica_inp
            // 
            this.ulica_inp.Location = new System.Drawing.Point(231, 59);
            this.ulica_inp.Name = "ulica_inp";
            this.ulica_inp.Size = new System.Drawing.Size(346, 27);
            this.ulica_inp.TabIndex = 4;
            // 
            // telefon_lbl
            // 
            this.telefon_lbl.AutoSize = true;
            this.telefon_lbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.telefon_lbl.Location = new System.Drawing.Point(30, 131);
            this.telefon_lbl.Name = "telefon_lbl";
            this.telefon_lbl.Size = new System.Drawing.Size(201, 20);
            this.telefon_lbl.TabIndex = 3;
            this.telefon_lbl.Text = "nr telefonu z kireunkowym:";
            // 
            // poczta_lbl
            // 
            this.poczta_lbl.AutoSize = true;
            this.poczta_lbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.poczta_lbl.Location = new System.Drawing.Point(30, 99);
            this.poczta_lbl.Name = "poczta_lbl";
            this.poczta_lbl.Size = new System.Drawing.Size(170, 20);
            this.poczta_lbl.TabIndex = 2;
            this.poczta_lbl.Text = "Kod pocztowy i poczta:";
            // 
            // ulica_lbl
            // 
            this.ulica_lbl.AutoSize = true;
            this.ulica_lbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ulica_lbl.Location = new System.Drawing.Point(30, 63);
            this.ulica_lbl.Name = "ulica_lbl";
            this.ulica_lbl.Size = new System.Drawing.Size(148, 20);
            this.ulica_lbl.TabIndex = 1;
            this.ulica_lbl.Text = "ulica i numer domu:";
            // 
            // miejscowosc_lbl
            // 
            this.miejscowosc_lbl.AutoSize = true;
            this.miejscowosc_lbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.miejscowosc_lbl.Location = new System.Drawing.Point(30, 37);
            this.miejscowosc_lbl.Name = "miejscowosc_lbl";
            this.miejscowosc_lbl.Size = new System.Drawing.Size(101, 20);
            this.miejscowosc_lbl.TabIndex = 0;
            this.miejscowosc_lbl.Text = "miejscowość:";
            // 
            // dec_cmbbox
            // 
            this.dec_cmbbox.FormattingEnabled = true;
            this.dec_cmbbox.Items.AddRange(new object[] {
            "styczeń",
            "czerwiec"});
            this.dec_cmbbox.Location = new System.Drawing.Point(325, 479);
            this.dec_cmbbox.Name = "dec_cmbbox";
            this.dec_cmbbox.Size = new System.Drawing.Size(185, 28);
            this.dec_cmbbox.TabIndex = 10;
            // 
            // mail_lbl
            // 
            this.mail_lbl.AutoSize = true;
            this.mail_lbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mail_lbl.Location = new System.Drawing.Point(385, 131);
            this.mail_lbl.Name = "mail_lbl";
            this.mail_lbl.Size = new System.Drawing.Size(43, 20);
            this.mail_lbl.TabIndex = 9;
            this.mail_lbl.Text = "mail:";
            // 
            // mail_inp
            // 
            this.mail_inp.Location = new System.Drawing.Point(434, 128);
            this.mail_inp.Name = "mail_inp";
            this.mail_inp.Size = new System.Drawing.Size(143, 27);
            this.mail_inp.TabIndex = 10;
            // 
            // dec_lbl_1
            // 
            this.dec_lbl_1.AutoSize = true;
            this.dec_lbl_1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dec_lbl_1.Location = new System.Drawing.Point(51, 457);
            this.dec_lbl_1.Name = "dec_lbl_1";
            this.dec_lbl_1.Size = new System.Drawing.Size(562, 20);
            this.dec_lbl_1.TabIndex = 11;
            this.dec_lbl_1.Text = "Deklaruję przystąpienie do egzaminu potwierdzającego kwalifikacje w zawodzie";
            // 
            // dec_lbl_2
            // 
            this.dec_lbl_2.AutoSize = true;
            this.dec_lbl_2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dec_lbl_2.Location = new System.Drawing.Point(97, 482);
            this.dec_lbl_2.Name = "dec_lbl_2";
            this.dec_lbl_2.Size = new System.Drawing.Size(222, 20);
            this.dec_lbl_2.TabIndex = 12;
            this.dec_lbl_2.Text = "przeprowadzonego w terminie";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1052, 623);
            this.Controls.Add(this.dec_lbl_2);
            this.Controls.Add(this.dec_lbl_1);
            this.Controls.Add(this.dec_cmbbox);
            this.Controls.Add(this.adres_kor_grpbox);
            this.Controls.Add(this.uczen_dane_grpbox);
            this.Controls.Add(this.deklaracja_lbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.uczen_dane_grpbox.ResumeLayout(false);
            this.uczen_dane_grpbox.PerformLayout();
            this.adres_kor_grpbox.ResumeLayout(false);
            this.adres_kor_grpbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label deklaracja_lbl;
        private GroupBox uczen_dane_grpbox;
        private TextBox miejsce_ur_inp;
        private TextBox nazwisko_inp;
        private TextBox pesel_inp;
        private TextBox ur_inp;
        private TextBox imie_inp;
        private Label pesel_lbl;
        private Label data_lbl;
        private Label imie_lbl;
        private Label nazwisko_lbl;
        private GroupBox adres_kor_grpbox;
        private TextBox mail_inp;
        private Label mail_lbl;
        private TextBox poczta_inp;
        private TextBox miejsowosc_inp;
        private TextBox telefon_inp;
        private TextBox kod_inp;
        private TextBox ulica_inp;
        private Label telefon_lbl;
        private Label poczta_lbl;
        private Label ulica_lbl;
        private Label miejscowosc_lbl;
        private ComboBox dec_cmbbox;
        private Label dec_lbl_1;
        private Label dec_lbl_2;
    }
}