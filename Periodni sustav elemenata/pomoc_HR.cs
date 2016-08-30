using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Periodni_sustav_elemenata
{
    public partial class pomoc_HR : Form
    {
        public pomoc_HR()
        {
            InitializeComponent();
        }

        private void instalacijaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(@"M:\Mateovi dokumenti\Dokumenti\Visual Studio 2005\Projects\Periodni sustav elemenata\Periodni sustav elemenata\Pomoæ\instalacija.htm");
        }

        private void informacijeOElementimaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(@"M:\Mateovi dokumenti\Dokumenti\Visual Studio 2005\Projects\Periodni sustav elemenata\Periodni sustav elemenata\Pomoæ\informacije_o_elementima.htm");
        }

        private void kvizoviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(Periodni_sustav_elemenata.Properties.Resources.kvizovi);
        }

        private void spremanjePodatakaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(@"M:\Mateovi dokumenti\Dokumenti\Visual Studio 2005\Projects\Periodni sustav elemenata\Periodni sustav elemenata\Pomoæ\spremanje_podataka.htm");
        }

        private void ostaleOpcijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(@"M:\Mateovi dokumenti\Dokumenti\Visual Studio 2005\Projects\Periodni sustav elemenata\Periodni sustav elemenata\Pomoæ\ostale_opcije.htm");
        }

        private void pomoc_HR_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate(@"M:\Mateovi dokumenti\Dokumenti\Visual Studio 2005\Projects\Periodni sustav elemenata\Periodni sustav elemenata\Pomoæ\uvod.htm");
        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}