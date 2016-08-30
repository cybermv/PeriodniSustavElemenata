using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Periodni_sustav_elemenata
{
    public partial class kviz_dodatni_simboli_HR : Form
    {
        public kviz_dodatni_simboli_HR()
        {
            InitializeComponent();
        }

        private void kviz_dodatni_simboli_HR_Load(object sender, EventArgs e)
        {
            try
            {
                this.kviz_HR_dodatnoTableAdapter.Fill(this.kviz_database._kviz_HR_dodatno);
                Random randomiser = new Random();
                kviz_HR_dodatnoBindingSource.Position = randomiser.Next(37);
                ime_elementa.Text = ime_elementa.Text + "?";
                status_picture.Image = Periodni_sustav_elemenata.Properties.Resources.slika_prazno;
                if (ime_elementa.Text == "platina")
                    ime_elementa.Text = "platinu";
                if (ime_elementa.Text == "�iva")
                    ime_elementa.Text = "�ivu";
            }
            catch
            {
                MessageBox.Show("Gre�ka prilikom u�itavanja baze podataka", "Gre�ka", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            if (ime_elementa.Text == "platina")
                ime_elementa.Text = "platinu";
            if (ime_elementa.Text == "�iva")
                ime_elementa.Text = "�ivu";

            int rez_netocno = int.Parse(br_netocno.Text);
            int rez_tocno = int.Parse(br_tocno.Text);
            string temp = kemijski_simbol.Text;
            string odg = odgovor.Text;

            if (odg.ToString() == temp.ToString())
            {
                System.Media.SoundPlayer tocno = new System.Media.SoundPlayer(Periodni_sustav_elemenata.Properties.Resources.to�no);
                status.Text = "To�no!";
                tocno.Play();
                rez_tocno++;
                br_tocno.Text = rez_tocno.ToString();
                status_picture.Image = Periodni_sustav_elemenata.Properties.Resources.slika_tocno;
            }
            if (odg.ToString() != temp.ToString())
            {
                System.Media.SoundPlayer netocno = new System.Media.SoundPlayer(Periodni_sustav_elemenata.Properties.Resources.neto�no);
                status.Text = "Neto�no!";
                netocno_status.Text = "Odgovor je: " + temp.ToString();
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
                MessageBox.Show("Kviz zavr�en!  Tvoji rezultati:\r\nBroj to�nih odgovora: " + rez_tocno.ToString() + "\r\nBroj neto�nih odgovora: " + rez_netocno.ToString(), "Kraj kviza", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            Random randomizer = new Random();
            kviz_HR_dodatnoBindingSource.Position = randomizer.Next(37);
            if (ime_elementa.Text == "platina")
                ime_elementa.Text = "platinu";
            if (ime_elementa.Text == "�iva")
                ime_elementa.Text = "�ivu";
            ime_elementa.Text = ime_elementa.Text + "?";
            odgovor.Text = "";
            status_picture.Image = Periodni_sustav_elemenata.Properties.Resources.slika_prazno;
            ime_elementa.Text = ime_elementa.Text.Replace("??", "?");
            ime_elementa.Text = ime_elementa.Text.Replace("???", "?");
            ime_elementa.Text = ime_elementa.Text.Replace("????", "?");
            ime_elementa.Text = ime_elementa.Text.Replace("?????", "?");
        }
    }
}