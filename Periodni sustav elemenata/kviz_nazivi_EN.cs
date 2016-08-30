using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Periodni_sustav_elemenata
{
    public partial class kviz_nazivi_EN : Form
    {
        public kviz_nazivi_EN()
        {
            InitializeComponent();
        }

        private void kviz_nazivi_EN_Load(object sender, EventArgs e)
        {
            
            try
            {
                this.kviz_ENTableAdapter.Fill(this.kviz_database._kviz_EN);
                Random randomiser = new Random();
                kviz_ENBindingSource.Position = randomiser.Next(118);
                kemijski_simbol.Text = kemijski_simbol.Text + "?";
                status_picture.Image = Periodni_sustav_elemenata.Properties.Resources.slika_prazno;
            }
            catch
            {
                MessageBox.Show("Error during loading quiz database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                System.Media.SoundPlayer tocno = new System.Media.SoundPlayer(Periodni_sustav_elemenata.Properties.Resources.toèno);
                status.Text = "Correct!";
                tocno.Play();
                rez_tocno++;
                br_tocno.Text = rez_tocno.ToString();
                status_picture.Image = Periodni_sustav_elemenata.Properties.Resources.slika_tocno;
            }
            if (odg.ToString() != temp.ToString())
            {
                System.Media.SoundPlayer netocno = new System.Media.SoundPlayer(Periodni_sustav_elemenata.Properties.Resources.netoèno);
                status.Text = "Incorrect!";
                netocno_status.Text = "The answer is: " + temp.ToString();
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
            int broj_klikova = int.Parse(broj_rn.Text);
            status.Text = "";
            netocno_status.Text = "";
            broj_klikova++;
            broj_rn.Text = broj_klikova.ToString();
            if (broj_rn.Text == "20")
            {
                int rez_netocno = int.Parse(br_netocno.Text);
                int rez_tocno = int.Parse(br_tocno.Text);
                MessageBox.Show("Quiz over!  Results:\r\nNumber of correct answers: " + rez_tocno.ToString() + "\r\nNumber of incorrect answers: " + rez_netocno.ToString(), "Quiz over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            Random randomizer = new Random();
            kviz_ENBindingSource.Position = randomizer.Next(118);
            kemijski_simbol.Text = kemijski_simbol.Text + "?";
            odgovor.Text = "";
            status_picture.Image = Periodni_sustav_elemenata.Properties.Resources.slika_prazno;
            kemijski_simbol.Text = kemijski_simbol.Text.Replace("??", "?");
            kemijski_simbol.Text = kemijski_simbol.Text.Replace("???", "?");
            kemijski_simbol.Text = kemijski_simbol.Text.Replace("????", "?");
            kemijski_simbol.Text = kemijski_simbol.Text.Replace("?????", "?");
        }

        private void hELPToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string temp = ime_elementa.Text;
            MessageBox.Show("The answer is: " + temp.ToString(), "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}