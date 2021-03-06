using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Periodni_sustav_elemenata
{
    public partial class kviz_dodatni_nazivi_IT : Form
    {
        public kviz_dodatni_nazivi_IT()
        {
            InitializeComponent();
        }

        private void kviz_dodatni_nazivi_IT_Load(object sender, EventArgs e)
        {
            try
            {
                this.kviz_IT_dodatnoTableAdapter.Fill(this.kviz_database._kviz_IT_dodatno);
                Random randomiser = new Random();
                kviz_IT_dodatnoBindingSource.Position = randomiser.Next(37);
                kemijski_simbol.Text =  kemijski_simbol.Text + "?";
                status_picture.Image = Periodni_sustav_elemenata.Properties.Resources.slika_prazno;
            }
            catch
            {
                MessageBox.Show("Errore durante l' accesso alla database", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            int rez_netocno = int.Parse(br_netocno.Text);
            int rez_tocno = int.Parse(br_tocno.Text);
            string temp = ime_elementa.Text;
            string odg = odgovor.Text.ToLowerInvariant();

            if (odg.ToString() == temp.ToString())
            {
                System.Media.SoundPlayer tocno = new System.Media.SoundPlayer(Periodni_sustav_elemenata.Properties.Resources.točno);
                status.Text = "Correto!";
                tocno.Play();
                rez_tocno++;
                br_tocno.Text = rez_tocno.ToString();
                status_picture.Image = Periodni_sustav_elemenata.Properties.Resources.slika_tocno;
            }
            if (odg.ToString() != temp.ToString())
            {
                System.Media.SoundPlayer netocno = new System.Media.SoundPlayer(Periodni_sustav_elemenata.Properties.Resources.netočno);
                status.Text = "Sbagliato!";
                netocno_status.Text = "La risposta è: " + temp.ToString();
                netocno.Play();
                rez_netocno++;
                br_netocno.Text = rez_netocno.ToString();
                status_picture.Image = Periodni_sustav_elemenata.Properties.Resources.slika_netocno;
            }

            ok_button.Enabled = false;
        }

        private void next_Click(object sender, EventArgs e)
        {
            if (odgovor.Text == "")
            {
                int rez_netocno = int.Parse(br_netocno.Text);
                int rez_tocno = int.Parse(br_tocno.Text);
                rez_netocno++;
                br_netocno.Text = rez_netocno.ToString();
            }
            ok_button.Enabled = true;
            int broj_klikova = int.Parse(broj.Text);
            status.Text = "";
            netocno_status.Text = "";
            broj_klikova++;
            broj.Text = broj_klikova.ToString();
            if (broj.Text == "37")
            {
                int rez_netocno = int.Parse(br_netocno.Text);
                int rez_tocno = int.Parse(br_tocno.Text);
                MessageBox.Show("Quiz finito!  I resultati:\r\nNumero di risposte correte: " + rez_tocno.ToString() + "\r\nNumero di risposte sbagliate: " + rez_netocno.ToString(), "Quiz finito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            Random randomizer = new Random();
            kviz_IT_dodatnoBindingSource.Position = randomizer.Next(37);
            kemijski_simbol.Text = kemijski_simbol.Text + "?";
            odgovor.Text = "";
            status_picture.Image = Periodni_sustav_elemenata.Properties.Resources.slika_prazno;
            kemijski_simbol.Text = kemijski_simbol.Text.Replace("??", "?");
            kemijski_simbol.Text = kemijski_simbol.Text.Replace("???", "?");
            kemijski_simbol.Text = kemijski_simbol.Text.Replace("????", "?");
            kemijski_simbol.Text = kemijski_simbol.Text.Replace("?????", "?");
        }
    }
}