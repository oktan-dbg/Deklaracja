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
            this.pesel_inp = new System.Windows.Forms.MaskedTextBox();
            this.ur_masked_inp = new System.Windows.Forms.MaskedTextBox();
            this.miejsce_ur_inp = new System.Windows.Forms.TextBox();
            this.nazwisko_inp = new System.Windows.Forms.TextBox();
            this.imie_inp = new System.Windows.Forms.TextBox();
            this.pesel_lbl = new System.Windows.Forms.Label();
            this.data_lbl = new System.Windows.Forms.Label();
            this.imie_lbl = new System.Windows.Forms.Label();
            this.nazwisko_lbl = new System.Windows.Forms.Label();
            this.adres_kor_grpbox = new System.Windows.Forms.GroupBox();
            this.kod_mskd_input = new System.Windows.Forms.MaskedTextBox();
            this.mail_inp = new System.Windows.Forms.TextBox();
            this.mail_lbl = new System.Windows.Forms.Label();
            this.poczta_inp = new System.Windows.Forms.TextBox();
            this.miejsowosc_inp = new System.Windows.Forms.TextBox();
            this.telefon_inp = new System.Windows.Forms.TextBox();
            this.ulica_inp = new System.Windows.Forms.TextBox();
            this.telefon_lbl = new System.Windows.Forms.Label();
            this.poczta_lbl = new System.Windows.Forms.Label();
            this.ulica_lbl = new System.Windows.Forms.Label();
            this.miejscowosc_lbl = new System.Windows.Forms.Label();
            this.dec_cmbbox = new System.Windows.Forms.ComboBox();
            this.dec_lbl_1 = new System.Windows.Forms.Label();
            this.dec_lbl_2 = new System.Windows.Forms.Label();
            this.inf_radiobox = new System.Windows.Forms.RadioButton();
            this.prg_radiobox = new System.Windows.Forms.RadioButton();
            this.cmb_INF = new System.Windows.Forms.ComboBox();
            this.projektowanie_lbl = new System.Windows.Forms.Label();
            this.pierwszy_radiobox = new System.Windows.Forms.RadioButton();
            this.kolejny_radiobox = new System.Windows.Forms.RadioButton();
            this.pisemnej_chckbox = new System.Windows.Forms.CheckBox();
            this.praktycznej_chckbox = new System.Windows.Forms.CheckBox();
            this.zatwierdz_btn = new System.Windows.Forms.Button();
            this.wyczysc_btn = new System.Windows.Forms.Button();
            this.zapisz_btn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uczen_dane_grpbox.SuspendLayout();
            this.adres_kor_grpbox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // deklaracja_lbl
            // 
            this.deklaracja_lbl.AutoSize = true;
            this.deklaracja_lbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deklaracja_lbl.Location = new System.Drawing.Point(130, 16);
            this.deklaracja_lbl.Name = "deklaracja_lbl";
            this.deklaracja_lbl.Size = new System.Drawing.Size(334, 20);
            this.deklaracja_lbl.TabIndex = 0;
            this.deklaracja_lbl.Text = "DEKLARACJA PRZYSTĄPIENIA DO EGZAMINU";
            this.deklaracja_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.deklaracja_lbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // uczen_dane_grpbox
            // 
            this.uczen_dane_grpbox.Controls.Add(this.pesel_inp);
            this.uczen_dane_grpbox.Controls.Add(this.ur_masked_inp);
            this.uczen_dane_grpbox.Controls.Add(this.miejsce_ur_inp);
            this.uczen_dane_grpbox.Controls.Add(this.nazwisko_inp);
            this.uczen_dane_grpbox.Controls.Add(this.imie_inp);
            this.uczen_dane_grpbox.Controls.Add(this.pesel_lbl);
            this.uczen_dane_grpbox.Controls.Add(this.data_lbl);
            this.uczen_dane_grpbox.Controls.Add(this.imie_lbl);
            this.uczen_dane_grpbox.Controls.Add(this.nazwisko_lbl);
            this.uczen_dane_grpbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.uczen_dane_grpbox.Location = new System.Drawing.Point(21, 49);
            this.uczen_dane_grpbox.Name = "uczen_dane_grpbox";
            this.uczen_dane_grpbox.Size = new System.Drawing.Size(599, 171);
            this.uczen_dane_grpbox.TabIndex = 1;
            this.uczen_dane_grpbox.TabStop = false;
            this.uczen_dane_grpbox.Text = "Dane osobowe ucznia";
            // 
            // pesel_inp
            // 
            this.pesel_inp.Location = new System.Drawing.Point(211, 131);
            this.pesel_inp.Mask = "00000000000";
            this.pesel_inp.Name = "pesel_inp";
            this.pesel_inp.Size = new System.Drawing.Size(125, 27);
            this.pesel_inp.TabIndex = 10;
            // 
            // ur_masked_inp
            // 
            this.ur_masked_inp.Location = new System.Drawing.Point(211, 96);
            this.ur_masked_inp.Mask = "00/00/0000";
            this.ur_masked_inp.Name = "ur_masked_inp";
            this.ur_masked_inp.Size = new System.Drawing.Size(114, 27);
            this.ur_masked_inp.TabIndex = 9;
            // 
            // miejsce_ur_inp
            // 
            this.miejsce_ur_inp.Location = new System.Drawing.Point(331, 96);
            this.miejsce_ur_inp.Name = "miejsce_ur_inp";
            this.miejsce_ur_inp.Size = new System.Drawing.Size(246, 27);
            this.miejsce_ur_inp.TabIndex = 8;
            this.miejsce_ur_inp.TextChanged += new System.EventHandler(this.miejsce_ur_inp_TextChanged);
            // 
            // nazwisko_inp
            // 
            this.nazwisko_inp.Location = new System.Drawing.Point(211, 34);
            this.nazwisko_inp.Name = "nazwisko_inp";
            this.nazwisko_inp.Size = new System.Drawing.Size(366, 27);
            this.nazwisko_inp.TabIndex = 7;
            this.nazwisko_inp.TextChanged += new System.EventHandler(this.nazwisko_inp_TextChanged);
            // 
            // imie_inp
            // 
            this.imie_inp.Location = new System.Drawing.Point(211, 63);
            this.imie_inp.Name = "imie_inp";
            this.imie_inp.Size = new System.Drawing.Size(366, 27);
            this.imie_inp.TabIndex = 4;
            this.imie_inp.TextChanged += new System.EventHandler(this.imie_inp_TextChanged);
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
            // adres_kor_grpbox
            // 
            this.adres_kor_grpbox.Controls.Add(this.kod_mskd_input);
            this.adres_kor_grpbox.Controls.Add(this.mail_inp);
            this.adres_kor_grpbox.Controls.Add(this.mail_lbl);
            this.adres_kor_grpbox.Controls.Add(this.poczta_inp);
            this.adres_kor_grpbox.Controls.Add(this.miejsowosc_inp);
            this.adres_kor_grpbox.Controls.Add(this.telefon_inp);
            this.adres_kor_grpbox.Controls.Add(this.ulica_inp);
            this.adres_kor_grpbox.Controls.Add(this.telefon_lbl);
            this.adres_kor_grpbox.Controls.Add(this.poczta_lbl);
            this.adres_kor_grpbox.Controls.Add(this.ulica_lbl);
            this.adres_kor_grpbox.Controls.Add(this.miejscowosc_lbl);
            this.adres_kor_grpbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.adres_kor_grpbox.Location = new System.Drawing.Point(21, 237);
            this.adres_kor_grpbox.Name = "adres_kor_grpbox";
            this.adres_kor_grpbox.Size = new System.Drawing.Size(599, 171);
            this.adres_kor_grpbox.TabIndex = 9;
            this.adres_kor_grpbox.TabStop = false;
            this.adres_kor_grpbox.Text = "Adres korespondencyjny";
            // 
            // kod_mskd_input
            // 
            this.kod_mskd_input.Location = new System.Drawing.Point(231, 92);
            this.kod_mskd_input.Mask = "00-0000";
            this.kod_mskd_input.Name = "kod_mskd_input";
            this.kod_mskd_input.Size = new System.Drawing.Size(105, 27);
            this.kod_mskd_input.TabIndex = 27;
            // 
            // mail_inp
            // 
            this.mail_inp.Location = new System.Drawing.Point(434, 128);
            this.mail_inp.Name = "mail_inp";
            this.mail_inp.Size = new System.Drawing.Size(143, 27);
            this.mail_inp.TabIndex = 10;
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
            // poczta_inp
            // 
            this.poczta_inp.Location = new System.Drawing.Point(351, 92);
            this.poczta_inp.Name = "poczta_inp";
            this.poczta_inp.Size = new System.Drawing.Size(226, 27);
            this.poczta_inp.TabIndex = 8;
            this.poczta_inp.TextChanged += new System.EventHandler(this.poczta_inp_TextChanged);
            // 
            // miejsowosc_inp
            // 
            this.miejsowosc_inp.Location = new System.Drawing.Point(231, 30);
            this.miejsowosc_inp.Name = "miejsowosc_inp";
            this.miejsowosc_inp.Size = new System.Drawing.Size(346, 27);
            this.miejsowosc_inp.TabIndex = 7;
            this.miejsowosc_inp.TextChanged += new System.EventHandler(this.miejsowosc_inp_TextChanged);
            // 
            // telefon_inp
            // 
            this.telefon_inp.Location = new System.Drawing.Point(231, 124);
            this.telefon_inp.Name = "telefon_inp";
            this.telefon_inp.Size = new System.Drawing.Size(148, 27);
            this.telefon_inp.TabIndex = 6;
            // 
            // ulica_inp
            // 
            this.ulica_inp.Location = new System.Drawing.Point(231, 59);
            this.ulica_inp.Name = "ulica_inp";
            this.ulica_inp.Size = new System.Drawing.Size(346, 27);
            this.ulica_inp.TabIndex = 4;
            this.ulica_inp.TextChanged += new System.EventHandler(this.ulica_inp_TextChanged);
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
            this.dec_cmbbox.Location = new System.Drawing.Point(311, 448);
            this.dec_cmbbox.Name = "dec_cmbbox";
            this.dec_cmbbox.Size = new System.Drawing.Size(185, 28);
            this.dec_cmbbox.TabIndex = 10;
            this.dec_cmbbox.SelectedIndexChanged += new System.EventHandler(this.dec_cmbbox_SelectedIndexChanged);
            // 
            // dec_lbl_1
            // 
            this.dec_lbl_1.AutoSize = true;
            this.dec_lbl_1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dec_lbl_1.Location = new System.Drawing.Point(37, 426);
            this.dec_lbl_1.Name = "dec_lbl_1";
            this.dec_lbl_1.Size = new System.Drawing.Size(562, 20);
            this.dec_lbl_1.TabIndex = 11;
            this.dec_lbl_1.Text = "Deklaruję przystąpienie do egzaminu potwierdzającego kwalifikacje w zawodzie";
            // 
            // dec_lbl_2
            // 
            this.dec_lbl_2.AutoSize = true;
            this.dec_lbl_2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dec_lbl_2.Location = new System.Drawing.Point(83, 451);
            this.dec_lbl_2.Name = "dec_lbl_2";
            this.dec_lbl_2.Size = new System.Drawing.Size(222, 20);
            this.dec_lbl_2.TabIndex = 12;
            this.dec_lbl_2.Text = "przeprowadzonego w terminie";
            // 
            // inf_radiobox
            // 
            this.inf_radiobox.AutoSize = true;
            this.inf_radiobox.Location = new System.Drawing.Point(320, 8);
            this.inf_radiobox.Name = "inf_radiobox";
            this.inf_radiobox.Size = new System.Drawing.Size(152, 24);
            this.inf_radiobox.TabIndex = 13;
            this.inf_radiobox.TabStop = true;
            this.inf_radiobox.Tag = "a";
            this.inf_radiobox.Text = "technik informatyk";
            this.inf_radiobox.UseVisualStyleBackColor = true;
            this.inf_radiobox.CheckedChanged += new System.EventHandler(this.inf_radiobox_CheckedChanged);
            // 
            // prg_radiobox
            // 
            this.prg_radiobox.AutoSize = true;
            this.prg_radiobox.Location = new System.Drawing.Point(4, 8);
            this.prg_radiobox.Name = "prg_radiobox";
            this.prg_radiobox.Size = new System.Drawing.Size(162, 24);
            this.prg_radiobox.TabIndex = 14;
            this.prg_radiobox.TabStop = true;
            this.prg_radiobox.Tag = "a";
            this.prg_radiobox.Text = "technik programista";
            this.prg_radiobox.UseVisualStyleBackColor = true;
            this.prg_radiobox.CheckedChanged += new System.EventHandler(this.prg_radiobox_CheckedChanged);
            // 
            // cmb_INF
            // 
            this.cmb_INF.FormattingEnabled = true;
            this.cmb_INF.Items.AddRange(new object[] {
            "styczeń",
            "czerwiec"});
            this.cmb_INF.Location = new System.Drawing.Point(23, 527);
            this.cmb_INF.Name = "cmb_INF";
            this.cmb_INF.Size = new System.Drawing.Size(110, 28);
            this.cmb_INF.TabIndex = 15;
            this.cmb_INF.SelectedIndexChanged += new System.EventHandler(this.cmb_INF_SelectedIndexChanged);
            // 
            // projektowanie_lbl
            // 
            this.projektowanie_lbl.AutoSize = true;
            this.projektowanie_lbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.projektowanie_lbl.Location = new System.Drawing.Point(142, 530);
            this.projektowanie_lbl.Name = "projektowanie_lbl";
            this.projektowanie_lbl.Size = new System.Drawing.Size(377, 20);
            this.projektowanie_lbl.TabIndex = 16;
            this.projektowanie_lbl.Text = "Projektowanie, programowanie i testowanie aplikacji";
            // 
            // pierwszy_radiobox
            // 
            this.pierwszy_radiobox.AutoSize = true;
            this.pierwszy_radiobox.Location = new System.Drawing.Point(11, 10);
            this.pierwszy_radiobox.Name = "pierwszy_radiobox";
            this.pierwszy_radiobox.Size = new System.Drawing.Size(133, 24);
            this.pierwszy_radiobox.TabIndex = 17;
            this.pierwszy_radiobox.TabStop = true;
            this.pierwszy_radiobox.Tag = "b";
            this.pierwszy_radiobox.Text = "po raz pierwszy";
            this.pierwszy_radiobox.UseVisualStyleBackColor = true;
            this.pierwszy_radiobox.CheckedChanged += new System.EventHandler(this.pierwszy_radiobox_CheckedChanged_1);
            // 
            // kolejny_radiobox
            // 
            this.kolejny_radiobox.AutoSize = true;
            this.kolejny_radiobox.Location = new System.Drawing.Point(150, 10);
            this.kolejny_radiobox.Name = "kolejny_radiobox";
            this.kolejny_radiobox.Size = new System.Drawing.Size(188, 24);
            this.kolejny_radiobox.TabIndex = 18;
            this.kolejny_radiobox.TabStop = true;
            this.kolejny_radiobox.Tag = "b";
            this.kolejny_radiobox.Text = "po raz kolejny do części";
            this.kolejny_radiobox.UseVisualStyleBackColor = true;
            // 
            // pisemnej_chckbox
            // 
            this.pisemnej_chckbox.AutoSize = true;
            this.pisemnej_chckbox.Location = new System.Drawing.Point(403, 562);
            this.pisemnej_chckbox.Name = "pisemnej_chckbox";
            this.pisemnej_chckbox.Size = new System.Drawing.Size(91, 24);
            this.pisemnej_chckbox.TabIndex = 19;
            this.pisemnej_chckbox.Text = "pisemnej";
            this.pisemnej_chckbox.UseVisualStyleBackColor = true;
            // 
            // praktycznej_chckbox
            // 
            this.praktycznej_chckbox.AutoSize = true;
            this.praktycznej_chckbox.Location = new System.Drawing.Point(500, 562);
            this.praktycznej_chckbox.Name = "praktycznej_chckbox";
            this.praktycznej_chckbox.Size = new System.Drawing.Size(106, 24);
            this.praktycznej_chckbox.TabIndex = 20;
            this.praktycznej_chckbox.Text = "praktycznej";
            this.praktycznej_chckbox.UseVisualStyleBackColor = true;
            // 
            // zatwierdz_btn
            // 
            this.zatwierdz_btn.Location = new System.Drawing.Point(376, 589);
            this.zatwierdz_btn.Name = "zatwierdz_btn";
            this.zatwierdz_btn.Size = new System.Drawing.Size(243, 29);
            this.zatwierdz_btn.TabIndex = 21;
            this.zatwierdz_btn.Text = "Zatwierdź";
            this.zatwierdz_btn.UseVisualStyleBackColor = true;
            this.zatwierdz_btn.Click += new System.EventHandler(this.zatwierdz_btn_Click_1);
            // 
            // wyczysc_btn
            // 
            this.wyczysc_btn.Location = new System.Drawing.Point(650, 589);
            this.wyczysc_btn.Name = "wyczysc_btn";
            this.wyczysc_btn.Size = new System.Drawing.Size(191, 29);
            this.wyczysc_btn.TabIndex = 22;
            this.wyczysc_btn.Text = "Wyczyść";
            this.wyczysc_btn.UseVisualStyleBackColor = true;
            this.wyczysc_btn.Click += new System.EventHandler(this.wyczysc_btn_Click);
            // 
            // zapisz_btn
            // 
            this.zapisz_btn.Location = new System.Drawing.Point(847, 589);
            this.zapisz_btn.Name = "zapisz_btn";
            this.zapisz_btn.Size = new System.Drawing.Size(193, 29);
            this.zapisz_btn.TabIndex = 23;
            this.zapisz_btn.Text = "Zapisz";
            this.zapisz_btn.UseVisualStyleBackColor = true;
            this.zapisz_btn.Click += new System.EventHandler(this.zapisz_btn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(650, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(390, 570);
            this.textBox1.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.prg_radiobox);
            this.panel1.Controls.Add(this.inf_radiobox);
            this.panel1.Location = new System.Drawing.Point(101, 482);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 39);
            this.panel1.TabIndex = 25;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pierwszy_radiobox);
            this.panel2.Controls.Add(this.kolejny_radiobox);
            this.panel2.Location = new System.Drawing.Point(23, 566);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(347, 45);
            this.panel2.TabIndex = 26;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1052, 623);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.zapisz_btn);
            this.Controls.Add(this.wyczysc_btn);
            this.Controls.Add(this.zatwierdz_btn);
            this.Controls.Add(this.praktycznej_chckbox);
            this.Controls.Add(this.pisemnej_chckbox);
            this.Controls.Add(this.projektowanie_lbl);
            this.Controls.Add(this.cmb_INF);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label deklaracja_lbl;
        private GroupBox uczen_dane_grpbox;
        private TextBox miejsce_ur_inp;
        private TextBox nazwisko_inp;
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
        private TextBox ulica_inp;
        private Label telefon_lbl;
        private Label poczta_lbl;
        private Label ulica_lbl;
        private Label miejscowosc_lbl;
        private ComboBox dec_cmbbox;
        private Label dec_lbl_1;
        private Label dec_lbl_2;
        private RadioButton inf_radiobox;
        private RadioButton prg_radiobox;
        private ComboBox cmb_INF;
        private Label projektowanie_lbl;
        private RadioButton pierwszy_radiobox;
        private RadioButton kolejny_radiobox;
        private CheckBox pisemnej_chckbox;
        private CheckBox praktycznej_chckbox;
        private Button zatwierdz_btn;
        private Button wyczysc_btn;
        private Button zapisz_btn;
        private TextBox textBox1;
        private Panel panel1;
        private Panel panel2;
        private MaskedTextBox kod_mskd_input;
        private MaskedTextBox pesel_inp;
        private MaskedTextBox ur_masked_inp;
    }
}