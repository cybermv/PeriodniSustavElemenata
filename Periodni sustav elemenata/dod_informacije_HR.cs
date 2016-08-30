using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Periodni_sustav_elemenata
{
    public partial class dod_informacije_HR : Form
    {
        public dod_informacije_HR()
        {
            InitializeComponent();
        }

        private void kviz_simboli_run_Click(object sender, EventArgs e)
        {
            dodatne_informacije_tekst.Text = "";
            kviz_dodatni_simboli_HR p = new kviz_dodatni_simboli_HR();
            p.ShowDialog();
        }

        private void kviz_nazivi_run_Click(object sender, EventArgs e)
        {
            dodatne_informacije_tekst.Text = "";
            kviz_dodatni_nazivi_HR p = new kviz_dodatni_nazivi_HR();
            p.ShowDialog();
        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void vodik_Click(object sender, EventArgs e)
        {
            dodatne_informacije_tekst.Text =
                "-Najlakši plin u svemiru" + Environment.NewLine +
                "-Bezbojan, bezmirisan, i lako zapaljiv" + Environment.NewLine +
                "-Molekulska formula - H2" + Environment.NewLine +
                "-Najèešæi spoj - voda (H2O)" + Environment.NewLine +
                "-Valencija - jednovalentan" + Environment.NewLine +
                "-Èesto se pojavljuje u organskim spojevima s ugljikom" + Environment.NewLine +
                "-Èini 3/4 mase svemira" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine;
        }

        private void kisik_Click(object sender, EventArgs e)
        {
            dodatne_informacije_tekst.Text =
                "-Plin potreban za disanje ljudi i životinja" + Environment.NewLine +
                "-Bezbojan, bezmirisan i zapaljiv" + Environment.NewLine +
                "-Molekulska formula - O2" + Environment.NewLine +
                " Valencija - dvovalentan" + Environment.NewLine +
                "-Spojen s vodikom daje vodu (H2O), a spojen s metalima tvori okside." + Environment.NewLine +
                "-Pripada skupini halkogenih elemenata(16. skupina)" + Environment.NewLine +
                "-Èini 2/3 mase ljudskog tijela" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine;
        }

        private void dušik_Click(object sender, EventArgs e)
        {
            dodatne_informacije_tekst.Text =
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine;
        }

        private void fosfor_Click(object sender, EventArgs e)
        {
            dodatne_informacije_tekst.Text =
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine;
        }

        private void klor_Click(object sender, EventArgs e)
        {
            dodatne_informacije_tekst.Text =
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine;
        }

        private void ugljik_Click(object sender, EventArgs e)
        {
            dodatne_informacije_tekst.Text =
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine;
        }

        private void helij_Click(object sender, EventArgs e)
        {
            dodatne_informacije_tekst.Text =
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine;
        }

        private void neon_Click(object sender, EventArgs e)
        {
            dodatne_informacije_tekst.Text =
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine;
        }

        private void kripton_Click(object sender, EventArgs e)
        {
            dodatne_informacije_tekst.Text =
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine;
        }

        private void argon_Click(object sender, EventArgs e)
        {
            dodatne_informacije_tekst.Text =
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine;
        }

        private void fluor_Click(object sender, EventArgs e)
        {
            dodatne_informacije_tekst.Text =
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine;
        }

        private void živa_Click(object sender, EventArgs e)
        {
            dodatne_informacije_tekst.Text =
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine;
        }

        private void brom_Click(object sender, EventArgs e)
        {
            dodatne_informacije_tekst.Text =
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine;
        }

        private void kositar_Click(object sender, EventArgs e)
        {
            dodatne_informacije_tekst.Text =
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine;
        }

        private void cink_Click(object sender, EventArgs e)
        {
            dodatne_informacije_tekst.Text =
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine;
        }

        private void krom_Click(object sender, EventArgs e)
        {
            dodatne_informacije_tekst.Text =
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine;
        }

        private void radij_Click(object sender, EventArgs e)
        {
            dodatne_informacije_tekst.Text =
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine;
        }

        private void magnezij_Click(object sender, EventArgs e)
        {
            dodatne_informacije_tekst.Text =
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine;
        }

        private void jod_Click(object sender, EventArgs e)
        {
            dodatne_informacije_tekst.Text =
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine;
        }

        private void litij_Click(object sender, EventArgs e)
        {
            dodatne_informacije_tekst.Text =
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine;
        }

        private void nikal_Click(object sender, EventArgs e)
        {
            dodatne_informacije_tekst.Text =
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine;
        }

        private void sumpor_Click(object sender, EventArgs e)
        {
            dodatne_informacije_tekst.Text =
                "-Èvrsta tvar žute boje" + Environment.NewLine +
                "-Nema magnetsko svojstvo" + Environment.NewLine +
                "-Neotrovna tvar" + Environment.NewLine +
                "-Molekulska formula - S8" + Environment.NewLine +
                "-Valencija - više valencija (8, 6, 4)" + Environment.NewLine +
                "-Pripada skupini halkogenih elemenata(16. skupina)" + Environment.NewLine +
                "-Alotropske modifikacije: -Monoklinski" + Environment.NewLine +
                "                          -Rompski" + Environment.NewLine +
                "-Najèešæi spojevi: -Sumporov (IV) oksid (SO2)" + Environment.NewLine +
                "                   -Sumporasta kiselina (H2SO3)" + Environment.NewLine +
                "                   -Sumporov (VI) oksid (SO3)" + Environment.NewLine +
                "                   -Sumporna kiselina (H2SO4)" + Environment.NewLine;
        }

        private void bor_Click(object sender, EventArgs e)
        {
            dodatne_informacije_tekst.Text =
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine;
        }

        private void arsen_Click(object sender, EventArgs e)
        {
            dodatne_informacije_tekst.Text =
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine;
        }

        private void aluminij_Click(object sender, EventArgs e)
        {
            dodatne_informacije_tekst.Text =
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine;
        }

        private void olovo_Click(object sender, EventArgs e)
        {
            dodatne_informacije_tekst.Text =
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine;
        }

        private void natrij_Click(object sender, EventArgs e)
        {
            dodatne_informacije_tekst.Text =
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine;
        }

        private void talij_Click(object sender, EventArgs e)
        {
            dodatne_informacije_tekst.Text =
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine;
        }

        private void silicij_Click(object sender, EventArgs e)
        {
            dodatne_informacije_tekst.Text =
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine;
        }

        private void željezo_Click(object sender, EventArgs e)
        {
            dodatne_informacije_tekst.Text =
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine;
        }

        private void bakar_Click(object sender, EventArgs e)
        {
            dodatne_informacije_tekst.Text =
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine;
        }

        private void zlato_Click(object sender, EventArgs e)
        {
            dodatne_informacije_tekst.Text =
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine;
        }

        private void platina_Click(object sender, EventArgs e)
        {
            dodatne_informacije_tekst.Text =
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine;
        }

        private void mangan_Click(object sender, EventArgs e)
        {
            dodatne_informacije_tekst.Text =
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine;
        }

        private void kalij_Click(object sender, EventArgs e)
        {
            dodatne_informacije_tekst.Text =
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine;
        }

        private void srebro_Click(object sender, EventArgs e)
        {
            dodatne_informacije_tekst.Text =
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine;
        }

        private void kalcij_Click(object sender, EventArgs e)
        {
            dodatne_informacije_tekst.Text =
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine +
                "" + Environment.NewLine;
        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void kvizNazivaElemenataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dodatne_informacije_tekst.Text = "";
            kviz_dodatni_nazivi_HR p = new kviz_dodatni_nazivi_HR();
            p.ShowDialog();
        }

        private void kvizSimbolaElemenataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dodatne_informacije_tekst.Text = "";
            kviz_dodatni_simboli_HR p = new kviz_dodatni_simboli_HR();
            p.ShowDialog();
        }
    }
}