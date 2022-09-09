using System.Text.RegularExpressions;

namespace Deklaracja
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dec_cmbbox.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_INF.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void inf_radiobox_CheckedChanged(object sender, EventArgs e)
        {
            cmb_INF.Items.Clear();
            cmb_INF.Items.Add("INF.02");
            cmb_INF.Items.Add("INF.03");
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nazwisko_inp_TextChanged(object sender, EventArgs e)
        {
            nazwisko_inp.BackColor = Color.White;
            TextBox currentContainer = ((TextBox)sender);
            int caretPosition = currentContainer.SelectionStart;

            currentContainer.Text = currentContainer.Text.ToUpper();
            currentContainer.SelectionStart = caretPosition++;
        }

        private void imie_inp_TextChanged(object sender, EventArgs e)
        {
            imie_inp.BackColor = Color.White;
            TextBox currentContainer = ((TextBox)sender);
            int caretPosition = currentContainer.SelectionStart;

            currentContainer.Text = currentContainer.Text.ToUpper();
            currentContainer.SelectionStart = caretPosition++;
        }

        private void miejsce_ur_inp_TextChanged(object sender, EventArgs e)
        {
            miejsce_ur_inp.BackColor = Color.White;
            TextBox currentContainer = ((TextBox)sender);
            int caretPosition = currentContainer.SelectionStart;

            currentContainer.Text = currentContainer.Text.ToUpper();
            currentContainer.SelectionStart = caretPosition++;
        }

        private void miejsowosc_inp_TextChanged(object sender, EventArgs e)
        {
            miejsowosc_inp.BackColor = Color.White;
            TextBox currentContainer = ((TextBox)sender);
            int caretPosition = currentContainer.SelectionStart;

            currentContainer.Text = currentContainer.Text.ToUpper();
            currentContainer.SelectionStart = caretPosition++;
        }

        private void poczta_inp_TextChanged(object sender, EventArgs e)
        {
            poczta_inp.BackColor = Color.White;
            TextBox currentContainer = ((TextBox)sender);
            int caretPosition = currentContainer.SelectionStart;

            currentContainer.Text = currentContainer.Text.ToUpper();
            currentContainer.SelectionStart = caretPosition++;
        }

        private void ulica_inp_TextChanged(object sender, EventArgs e)
        {
            ulica_inp.BackColor = Color.White;
        }

        private void dec_cmbbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void prg_radiobox_CheckedChanged(object sender, EventArgs e)
        {
            cmb_INF.Items.Clear();
            cmb_INF.Items.Add("INF.03");
            cmb_INF.Items.Add("INF.04");
        }

        private void cmb_INF_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmb_INF.SelectedItem.ToString()=="INF.02")
            {
                projektowanie_lbl.Text = "Administracja i ekspolacja systemów komputerowych, urz¹dzeñ peryferyjnych i lokalmcych sieci komputerowych";
            }else if (cmb_INF.SelectedItem.ToString() == "INF.03")
            {
                projektowanie_lbl.Text = "Tworzenie i administrowanie stronami i apliakcjami internetowymi oraz bazami danych";
            }else if(cmb_INF.SelectedItem.ToString() == "INF.04")
            {
                projektowanie_lbl.Text = "Projektowanie, programowanie i testowanie aplikacji";
            }
            
        }

        private void pierwszy_radiobox_CheckedChanged(object sender, EventArgs e)
        {
            if (pierwszy_radiobox.Checked)
            {
                pisemnej_chckbox.Enabled = false;
                praktycznej_chckbox.Enabled = false;
            }
            else
            {
                pisemnej_chckbox.Enabled = true;
                praktycznej_chckbox.Enabled = true;
            }
        }

        

        private void zatwierdz_btn_Click_1(object sender, EventArgs e)
        {
            var puste = 0;
            //imie
            if (String.IsNullOrEmpty(imie_inp.Text))
            {
                imie_inp.BackColor = Color.Red;
                puste++;
            }
            else
            {
                imie_inp.BackColor = Color.Green;
            }
            //nazwisko
            if (String.IsNullOrEmpty(nazwisko_inp.Text))
            {
                nazwisko_inp.BackColor = Color.Red;
                puste++;
            }
            else
            {
                nazwisko_inp.BackColor = Color.Green;
            }
            //data
            if ( ur_masked_inp.MaskFull == false)
            {
                ur_masked_inp.BackColor = Color.Red;
                puste++;
            }
            else
            {
                ur_masked_inp.BackColor = Color.Green;
            }
            if (String.IsNullOrEmpty(miejsce_ur_inp.Text))
            {
                miejsce_ur_inp.BackColor = Color.Red;
                puste++;
            }
            else
            {
                miejsce_ur_inp.BackColor = Color.Green;
            }
            //numer pesel
            if (String.IsNullOrEmpty(pesel_inp.Text))
            {
                pesel_inp.BackColor = Color.Red;
                puste++;
            }
            else
            {
                if (imie_inp.Text.EndsWith("A")== true)
                {
                    int ostatnie = Convert.ToInt32(pesel_inp.Text.ToString().Substring(9, 1));
                    if (ostatnie % 2 == 0)
                    {
                        pesel_inp.BackColor = Color.Green;
                    }
                    else
                    {
                        pesel_inp.BackColor = Color.Red;
                        puste++;
                    }

                }
                else
                {
                    int ostatnie = Convert.ToInt32(pesel_inp.Text.ToString().Substring(9, 1));
                    if (ostatnie % 2 == 0)
                    {
                        pesel_inp.BackColor = Color.Red;
                        puste++;
                    }
                    else
                    {
                        pesel_inp.BackColor = Color.Green;
                    }
                }
               
            }
            //miejscowosc
            if (String.IsNullOrEmpty(miejsowosc_inp.Text))
            {
                miejsowosc_inp.BackColor = Color.Red;
                puste++;
            }
            else
            {
                miejsowosc_inp.BackColor = Color.Green;
            }
            //ulica i numer
            if (String.IsNullOrEmpty(ulica_inp.Text))
            {
                ulica_inp.BackColor = Color.Red;
                puste++;
            }
            else
            {
                ulica_inp.BackColor = Color.Green;
            }
            //kod pocztowy
            if (kod_mskd_input.MaskFull == false)
            {
                kod_mskd_input.BackColor = Color.Red;
                puste++;
            }
            else
            {
                kod_mskd_input.BackColor = Color.Green;
            }
            if (String.IsNullOrEmpty(poczta_inp.Text))
            {
                poczta_inp.BackColor = Color.Red;
                puste++;
            }
            else
            {
                poczta_inp.BackColor = Color.Green;
            }
            //nr telefonu
            if (String.IsNullOrEmpty(telefon_inp.Text))
            {
                telefon_inp.BackColor = Color.Red;
                puste++;
            }
            else
            {
                telefon_inp.BackColor = Color.Green;
            }
            //mail
            if (String.IsNullOrEmpty(mail_inp.Text) || mail_inp.Text.Contains("@")==false || (String.IsNullOrEmpty(mail_inp.Text) && mail_inp.Text.Contains("@") == false))
            {
                mail_inp.BackColor = Color.Red;
                puste++;
            }
            else
            {
                mail_inp.BackColor = Color.Green;
            }
            //if(true)
            if(puste == 0)
            {
                textBox1.Clear();
                var przystêpowanie = "";
                var czesc = "";
                var zawod = "";
                var symbol = "";
                if (pierwszy_radiobox.Checked == true)
                {
                    przystêpowanie = "po raz pierwszy";
                }
                else
                {
                    przystêpowanie = "po raz kolejny";
                }
                if(pisemnej_chckbox.Checked == true)
                {
                    czesc = "pisemnej";

                }else if(pisemnej_chckbox.Checked == true && praktycznej_chckbox.Checked == true)
                {
                    czesc = "praktycznej i pisemnej";
                }
                else
                {
                    czesc = "praktycznej";
                }
                
                if(prg_radiobox.Checked == true)
                {
                    zawod = "programista";
                    symbol = "351406";
                }
                else
                {
                    zawod = "informatyk";
                    symbol = "351203";
                }
                
                textBox1.Text = 
                    "Deklarujê przyst¹pienie do egzaminu potwierdzaj¹cego kwalifikacje w zawodzie przeprowadzonego w terminie "+ dec_cmbbox.Text.ToString()+ System.Environment.NewLine+ System.Environment.NewLine +
                    "Dane osobowe ucznia:"+ System.Environment.NewLine +
                    "Nazwisko:      "+ nazwisko_inp.Text.ToString() + System.Environment.NewLine +
                    "Imiê(imiona):      " + imie_inp.Text.ToString() + System.Environment.NewLine +
                    "Data i miejsce urodzenia:      " + ur_masked_inp.Text.ToString() +"  "+ miejsce_ur_inp.Text.ToString() + System.Environment.NewLine +
                    "Numer PESEL:      " + pesel_inp.Text.ToString() + System.Environment.NewLine + System.Environment.NewLine +
                    "Adres Korespondencyjny:   "+ System.Environment.NewLine +
                    "Miejscowoœæ:      " + miejsowosc_inp.Text.ToString() + System.Environment.NewLine +
                    "Ulica i numer domu:      " + ulica_inp.Text.ToString() + System.Environment.NewLine +
                    "Kod pocztowy i poczta:      " + kod_mskd_input.Text.ToString()+", "+ poczta_inp.Text.ToString() + System.Environment.NewLine +
                    "Numer telefonu z kierunkowym:      " +"+48 " +telefon_inp.Text.ToString() + System.Environment.NewLine +
                    "Email :      " + mail_inp.Text.ToString() + System.Environment.NewLine + System.Environment.NewLine +
                    "Deklarujê przyst¹pienie do egzaminu "+przystêpowanie+" do czêœci "+ czesc + System.Environment.NewLine + System.Environment.NewLine +
                    "Oznaczenie kwalyfikacji zgodne z podstaw¹ programow¹: "+ cmb_INF.Text.ToString()+"."+ System.Environment.NewLine+
                    "Nazwa kwalyfikacji: "+ projektowanie_lbl.Text.ToString()+ System.Environment.NewLine + System.Environment.NewLine +
                    "Symbol cyfrowy zawodu: "+ symbol+ System.Environment.NewLine+
                    "Zawód: "+zawod
                    ;
               
            }
        }

        private void pierwszy_radiobox_CheckedChanged_1(object sender, EventArgs e)
        {
            if (pierwszy_radiobox.Checked)
            {
                pisemnej_chckbox.Enabled = false;
                praktycznej_chckbox.Enabled = false;
            }
            else
            {
                pisemnej_chckbox.Enabled = true;
                praktycznej_chckbox.Enabled = true;
            }
        }

        private void wyczysc_btn_Click(object sender, EventArgs e)
        {
            nazwisko_inp.Clear();
            imie_inp.Clear();
            ur_masked_inp.Clear();
            miejsce_ur_inp.Clear();
            pesel_inp.Clear();
            miejsowosc_inp.Clear();
            ulica_inp.Clear();
            kod_mskd_input.Clear();
            poczta_inp.Clear();
            telefon_inp.Clear();
            mail_inp.Clear();
            textBox1.Clear();
        }

        private void zapisz_btn_Click(object sender, EventArgs e)
        {
            TextWriter txt = new StreamWriter("C:\\Users\\oktaw\\Downloads\\demo.txt");
            txt.Write(textBox1.Text);
            txt.Close();
        }

        private void ur_masked_inp_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            ur_masked_inp.BackColor = Color.White;
        }

        private void pesel_inp_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            pesel_inp.BackColor = Color.White;
        }

        private void kod_mskd_input_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            kod_mskd_input.BackColor = Color.White;
        }

        private void telefon_inp_TextChanged(object sender, EventArgs e)
        {
            telefon_inp.BackColor = Color.White;
        }

        private void mail_inp_TextChanged(object sender, EventArgs e)
        {
            mail_inp.BackColor = Color.White;
        }
    }
}