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
            TextBox currentContainer = ((TextBox)sender);
            int caretPosition = currentContainer.SelectionStart;

            currentContainer.Text = currentContainer.Text.ToUpper();
            currentContainer.SelectionStart = caretPosition++;
        }

        private void imie_inp_TextChanged(object sender, EventArgs e)
        {
            TextBox currentContainer = ((TextBox)sender);
            int caretPosition = currentContainer.SelectionStart;

            currentContainer.Text = currentContainer.Text.ToUpper();
            currentContainer.SelectionStart = caretPosition++;
        }

        private void miejsce_ur_inp_TextChanged(object sender, EventArgs e)
        {
            TextBox currentContainer = ((TextBox)sender);
            int caretPosition = currentContainer.SelectionStart;

            currentContainer.Text = currentContainer.Text.ToUpper();
            currentContainer.SelectionStart = caretPosition++;
        }

        private void miejsowosc_inp_TextChanged(object sender, EventArgs e)
        {
            TextBox currentContainer = ((TextBox)sender);
            int caretPosition = currentContainer.SelectionStart;

            currentContainer.Text = currentContainer.Text.ToUpper();
            currentContainer.SelectionStart = caretPosition++;
        }

        private void poczta_inp_TextChanged(object sender, EventArgs e)
        {
            TextBox currentContainer = ((TextBox)sender);
            int caretPosition = currentContainer.SelectionStart;

            currentContainer.Text = currentContainer.Text.ToUpper();
            currentContainer.SelectionStart = caretPosition++;
        }

        private void ulica_inp_TextChanged(object sender, EventArgs e)
        {
            
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

        private void zatwierdz_btn_Click(object sender, EventArgs e)
        {
            //imie
            if(String.IsNullOrEmpty(imie_inp.Text))
            {
                imie_inp.BackColor=Color.Red;
            }
            else
            {
                imie_inp.BackColor=Color.Green;
            }
            //nazwisko
            if (String.IsNullOrEmpty(nazwisko_inp.Text))
            {
                nazwisko_inp.BackColor = Color.Red;
            }
            else
            {
                nazwisko_inp.BackColor = Color.Green;
            }
            //data
            if (String.IsNullOrEmpty(ur_masked_inp.Text) && ur_masked_inp.MaskFull==false)
            {
                ur_masked_inp.BackColor = Color.Red;
            }
            else
            {
                ur_masked_inp.BackColor = Color.Green;
            }
            if (String.IsNullOrEmpty(poczta_inp.Text))
            {
                poczta_inp.BackColor = Color.Red;
            }
            else
            {
                poczta_inp.BackColor = Color.Green;
            }
            //numer pesel
            if (String.IsNullOrEmpty(pesel_inp.Text))
            {
                pesel_inp.BackColor = Color.Red;
            }
            else
            {
                if (imie_inp.Text.EndsWith("a"))
                {
                    int ostatnie = Convert.ToInt32(pesel_inp.ToString().Substring(2, 2));
                    if (ostatnie % 2 == 0)
                    {
                        pesel_inp.BackColor = Color.Green;
                    }
                    else
                    {
                        pesel_inp.BackColor = Color.Red;
                    }
                        
                }
                else
                {
                    int ostatnie = Convert.ToInt32(pesel_inp.ToString().Substring(2, 2));
                    if (ostatnie % 2 == 0)
                    {
                        pesel_inp.BackColor = Color.Red;
                    }
                    else
                    {
                        pesel_inp.BackColor = Color.Green;
                    }
                }
                pesel_inp.BackColor = Color.Green;
            }
            //miejscowosc
            if (String.IsNullOrEmpty(miejsowosc_inp.Text))
            {
                miejsowosc_inp.BackColor = Color.Red;
            }
            else
            {
                miejsowosc_inp.BackColor = Color.Green;
            }
            //ulica i numer
            if (String.IsNullOrEmpty(ulica_inp.Text))
            {
                ulica_inp.BackColor = Color.Red;
            }
            else
            {
                ulica_inp.BackColor = Color.Green;
            }
            //kod pocztowy
            if (String.IsNullOrEmpty(kod_mskd_input.Text))
            {
                kod_mskd_input.BackColor = Color.Red;
            }
            else
            {
                kod_mskd_input.BackColor = Color.Green;
            }
            if (String.IsNullOrEmpty(poczta_inp.Text))
            {
                poczta_inp.BackColor = Color.Red;
            }
            else
            {
                poczta_inp.BackColor = Color.Green;
            }
            //nr telefonu
            if (String.IsNullOrEmpty(telefon_inp.Text))
            {
                telefon_inp.BackColor = Color.Red;
            }
            else
            {
                telefon_inp.BackColor = Color.Green;
            }
            //mail
            if (String.IsNullOrEmpty(mail_inp.Text) && !mail_inp.Text.Contains("@"))
            {
                mail_inp.BackColor = Color.Red;
            }
            else
            {
                mail_inp.BackColor = Color.Green;
            }
        }

        private void zatwierdz_btn_Click_1(object sender, EventArgs e)
        {
            //imie
            if (String.IsNullOrEmpty(imie_inp.Text))
            {
                imie_inp.BackColor = Color.Red;
            }
            else
            {
                imie_inp.BackColor = Color.Green;
            }
            //nazwisko
            if (String.IsNullOrEmpty(nazwisko_inp.Text))
            {
                nazwisko_inp.BackColor = Color.Red;
            }
            else
            {
                nazwisko_inp.BackColor = Color.Green;
            }
            //data
            if ( ur_masked_inp.MaskFull == false)
            {
                ur_masked_inp.BackColor = Color.Red;
            }
            else
            {
                ur_masked_inp.BackColor = Color.Green;
            }
            if (String.IsNullOrEmpty(miejsce_ur_inp.Text))
            {
                miejsce_ur_inp.BackColor = Color.Red;
            }
            else
            {
                miejsce_ur_inp.BackColor = Color.Green;
            }
            //numer pesel
            if (String.IsNullOrEmpty(pesel_inp.Text))
            {
                pesel_inp.BackColor = Color.Red;
            }
            else
            {
                if (imie_inp.Text.EndsWith("a")== true)
                {
                    int ostatnie = Convert.ToInt32(pesel_inp.ToString().Substring(2, 2));
                    if (ostatnie % 2 == 0)
                    {
                        pesel_inp.BackColor = Color.Green;
                    }
                    else
                    {
                        pesel_inp.BackColor = Color.Red;
                    }

                }
                else
                {
                    int ostatnie = Convert.ToInt32(pesel_inp.Text.ToString().Substring(2, 2));
                    if (ostatnie % 2 == 0)
                    {
                        pesel_inp.BackColor = Color.Red;
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
            }
            else
            {
                miejsowosc_inp.BackColor = Color.Green;
            }
            //ulica i numer
            if (String.IsNullOrEmpty(ulica_inp.Text))
            {
                ulica_inp.BackColor = Color.Red;
            }
            else
            {
                ulica_inp.BackColor = Color.Green;
            }
            //kod pocztowy
            if (kod_mskd_input.MaskFull == false)
            {
                kod_mskd_input.BackColor = Color.Red;
            }
            else
            {
                kod_mskd_input.BackColor = Color.Green;
            }
            if (String.IsNullOrEmpty(poczta_inp.Text))
            {
                poczta_inp.BackColor = Color.Red;
            }
            else
            {
                poczta_inp.BackColor = Color.Green;
            }
            //nr telefonu
            if (String.IsNullOrEmpty(telefon_inp.Text))
            {
                telefon_inp.BackColor = Color.Red;
            }
            else
            {
                telefon_inp.BackColor = Color.Green;
            }
            //mail
            if (String.IsNullOrEmpty(mail_inp.Text) && !mail_inp.Text.Contains("@"))
            {
                mail_inp.BackColor = Color.Red;
            }
            else
            {
                mail_inp.BackColor = Color.Green;
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
            textBox1.Clear();
            textBox1.Text+=nazwisko_inp.Text.ToString();
            textBox1.Text += imie_inp.Text.ToString();
            textBox1.Text += ur_masked_inp.Text.ToString();
            textBox1.Text += miejsce_ur_inp.Text.ToString();
            textBox1.Text += pesel_inp.Text.ToString();
            textBox1.Text += miejsowosc_inp.Text.ToString();
            textBox1.Text += ulica_inp.Text.ToString();
            textBox1.Text += kod_mskd_input.Text.ToString();
            textBox1.Text += poczta_inp.Text.ToString();
            textBox1.Text += telefon_inp.Text.ToString();
            textBox1.Text += mail_inp.Text.ToString();
        }
    }
}