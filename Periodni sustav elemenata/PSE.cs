using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Periodni_sustav_elemenata;
using System.IO;

namespace Periosni_sustav_elemenata
{
    public partial class PSE_main : Form
    {
        public PSE_main()
        {
            InitializeComponent();
        }

        //
        //***POČETAK KODA ZA PRIKAZ INFORMACIJA O ELEMENTU***
        //

        private void vodik_Click(object sender, EventArgs e)
        {   
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Vodik";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Hydrogen";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Idrogeno";
            atomski_broj.Text = "1";
            atomska_masa.Text = "1,007";
            radioaktivnost.Text = "Ne";
            veličina_atoma.Text = "21 pm";
            stanje_atoma.Text = "Plin";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.vodik;
        }

        private void button73_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Helij";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Helium";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Elio";
            atomski_broj.Text = "2";
            atomska_masa.Text = "4,002";
            radioaktivnost.Text = "Ne";
            veličina_atoma.Text = "31 pm";
            stanje_atoma.Text = "Plin";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.helij;
        }

        private void litij_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Litij";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Lithium";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Litio";
            atomski_broj.Text = "3";
            atomska_masa.Text = "6,941";
            radioaktivnost.Text = "Ne";
            veličina_atoma.Text = "145 pm";
            stanje_atoma.Text = "Krutina"; 
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.litij;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Berilij";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Berylium";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Berilio";
            atomski_broj.Text = "4";
            atomska_masa.Text = "9,012";
            radioaktivnost.Text = "Ne";
            veličina_atoma.Text = "105 pm";
            stanje_atoma.Text = "Krutina";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.berilij;
        }

        private void button47_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Bor";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Boron";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Boro";
            atomski_broj.Text = "5";
            atomska_masa.Text = "10,81";
            radioaktivnost.Text = "Ne";
            veličina_atoma.Text = "85 pm";
            stanje_atoma.Text = "Krutina";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.bor;
        }

        private void button55_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Ugljik";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Carbon";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Carbone";
            atomski_broj.Text = "6";
            atomska_masa.Text = "12,01";
            radioaktivnost.Text = "Ne";
            veličina_atoma.Text = "70 pm";
            stanje_atoma.Text = "Krutina";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.ugljik;
        }

        private void button53_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Dušik";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Nitrogen";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Azoto";
            atomski_broj.Text = "7";
            atomska_masa.Text = "14";
            radioaktivnost.Text = "Ne";
            veličina_atoma.Text = "65 pm";
            stanje_atoma.Text = "Plin";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.dušik;
        }

        private void button64_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Kisik";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Oxygen";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Ossigeno";
            atomski_broj.Text = "8";
            atomska_masa.Text = "15,99";
            radioaktivnost.Text = "Ne";
            veličina_atoma.Text = "60 pm";
            stanje_atoma.Text = "Plin";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.kisik;
        }

        private void button63_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Fluor";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Fluorine";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Fluoro";
            atomski_broj.Text = "9";
            atomska_masa.Text = "18,99";
            radioaktivnost.Text = "Ne";
            veličina_atoma.Text = "50 pm";
            stanje_atoma.Text = "Plin";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.fluor;
        }

        private void button74_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Neon";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Neon";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Neon";
            atomski_broj.Text = "10";
            atomska_masa.Text = "20,17";
            radioaktivnost.Text = "Ne";
            veličina_atoma.Text = "51 pm";
            stanje_atoma.Text = "Plin";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.neon;
        }

        private void natrij_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Natrij";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Sodium";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Sodio";
            atomski_broj.Text = "11";
            atomska_masa.Text = "22,98";
            radioaktivnost.Text = "Ne";
            veličina_atoma.Text = "180 pm";
            stanje_atoma.Text = "Krutina";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.natrij;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Magnezij";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Magnesium";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Magnesio";
            atomski_broj.Text = "12";
            atomska_masa.Text = "24,30";
            radioaktivnost.Text = "Ne";
            veličina_atoma.Text = "150 pm";
            stanje_atoma.Text = "Krutina";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.magnezij;
        }

        private void button48_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Aluminij";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Aluminium";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Alluminio";
            atomski_broj.Text = "13";
            atomska_masa.Text = "26,98";
            radioaktivnost.Text = "Ne";
            veličina_atoma.Text = "125 pm";
            stanje_atoma.Text = "Krutina";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.aluminij;
        }

        private void button56_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Silicij";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Silicon";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Silicio";
            atomski_broj.Text = "14";
            atomska_masa.Text = "28,08";
            radioaktivnost.Text = "Ne";
            veličina_atoma.Text = "110 pm";
            stanje_atoma.Text = "Krutina";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.silicij;
        }

        private void button54_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Fosfor";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Phosphorus";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Fosforo";
            atomski_broj.Text = "15";
            atomska_masa.Text = "30,97";
            radioaktivnost.Text = "Ne";
            veličina_atoma.Text = "100 pm";
            stanje_atoma.Text = "Krutina";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.fosfor;
        }

        private void button65_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Sumpor";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Sulphur";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Zolfo";
            atomski_broj.Text = "16";
            atomska_masa.Text = "32,06";
            radioaktivnost.Text = "Ne";
            veličina_atoma.Text = "100 pm";
            stanje_atoma.Text = "Krutina";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.sumpor;
        }

        private void button69_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Klor";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Chlorine";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Cloro";
            atomski_broj.Text = "17";
            atomska_masa.Text = "35,45";
            radioaktivnost.Text = "Ne";
            veličina_atoma.Text = "100 pm";
            stanje_atoma.Text = "Plin";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.klor;
        }

        private void button75_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Argon";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Argon";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Argon";
            atomski_broj.Text = "18";
            atomska_masa.Text = "39,94";
            radioaktivnost.Text = "Ne";
            veličina_atoma.Text = "71 pm";
            stanje_atoma.Text = "Plin";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.argon;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Kalij";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Potassium";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Potassio";
            atomski_broj.Text = "19";
            atomska_masa.Text = "39,09";
            radioaktivnost.Text = "Ne";
            veličina_atoma.Text = "220 pm";
            stanje_atoma.Text = "Krutina";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.kalij;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Kalcij";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Calcium";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Calcio";
            atomski_broj.Text = "20";
            atomska_masa.Text = "40,07";
            radioaktivnost.Text = "Ne";
            veličina_atoma.Text = "180 pm";
            stanje_atoma.Text = "Krutina";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.kalcij;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Skandij";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Scandium";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Scandio";
            atomski_broj.Text = "21";
            atomska_masa.Text = "44,95";
            radioaktivnost.Text = "Ne";
            veličina_atoma.Text = "160 pm";
            stanje_atoma.Text = "Krutina";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.skandij;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Titanij";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Titanium";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Titanio";
            atomski_broj.Text = "22";
            atomska_masa.Text = "47,86";
            radioaktivnost.Text = "Ne";
            veličina_atoma.Text = "140 pm";
            stanje_atoma.Text = "Krutina";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.titanij;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Vanadij";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Vanadium";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Vanadio";
            atomski_broj.Text = "23";
            atomska_masa.Text = "50,94";
            radioaktivnost.Text = "Ne";
            veličina_atoma.Text = "135 pm";
            stanje_atoma.Text = "Krutina";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.vanadij;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Krom";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Chromium";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Cromo";
            atomski_broj.Text = "24";
            atomska_masa.Text = "51,99";
            radioaktivnost.Text = "Ne";
            veličina_atoma.Text = "140 pm";
            stanje_atoma.Text = "Krutina";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.krom;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Mangan";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Manganese";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Manganese";
            atomski_broj.Text = "25";
            atomska_masa.Text = "54,93";
            radioaktivnost.Text = "Ne";
            veličina_atoma.Text = "140 pm";
            stanje_atoma.Text = "Krutina";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.mangan;
        }

        private void button35_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Željezo";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Iron";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Ferro";
            atomski_broj.Text = "26";
            atomska_masa.Text = "55,84";
            radioaktivnost.Text = "Ne";
            veličina_atoma.Text = "140 pm";
            stanje_atoma.Text = "Krutina";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.željezo;
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Kobalt";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Cobalt";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Cobalto";
            atomski_broj.Text = "27";
            atomska_masa.Text = "58,93";
            radioaktivnost.Text = "Ne";
            veličina_atoma.Text = "135 pm";
            stanje_atoma.Text = "Krutina";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.kobalt;
        }

        private void button39_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Nikal";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Nickel";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Nichel";
            atomski_broj.Text = "28";
            atomska_masa.Text = "58,69";
            radioaktivnost.Text = "Ne";
            veličina_atoma.Text = "135 pm";
            stanje_atoma.Text = "Krutina";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.nikal;
        }

        private void button44_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Bakar";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Copper";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Rame";
            atomski_broj.Text = "29";
            atomska_masa.Text = "63,54";
            radioaktivnost.Text = "Ne";
            veličina_atoma.Text = "135 pm";
            stanje_atoma.Text = "Krutina";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.bakar;
        }

        private void button42_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Cink";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Zinc";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Zinco";
            atomski_broj.Text = "30";
            atomska_masa.Text = "65,40";
            radioaktivnost.Text = "Ne";
            veličina_atoma.Text = "135 pm";
            stanje_atoma.Text = "Krutina";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.cink;
        }

        private void button49_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Galij";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Gallium";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Gallio";
            atomski_broj.Text = "31";
            atomska_masa.Text = "69,72";
            radioaktivnost.Text = "Ne";
            veličina_atoma.Text = "130 pm";
            stanje_atoma.Text = "Krutina";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.galij;
        }

        private void button57_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Germanij";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Germanium";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Germanio";
            atomski_broj.Text = "32";
            atomska_masa.Text = "72,64";
            radioaktivnost.Text = "Ne";
            veličina_atoma.Text = "125 pm";
            stanje_atoma.Text = "Krutina";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.germanij;
        }

        private void button60_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Arsen";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Arsenic";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Arsenico";
            atomski_broj.Text = "33";
            atomska_masa.Text = "74,92";
            radioaktivnost.Text = "Ne";
            veličina_atoma.Text = "115 pm";
            stanje_atoma.Text = "Krutina"; 
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.arsen;
        }

        private void button66_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Selenij";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Selenium";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Selenio";
            atomski_broj.Text = "34";
            atomska_masa.Text = "78,96";
            radioaktivnost.Text = "Ne";
            veličina_atoma.Text = "115 pm";
            stanje_atoma.Text = "Krutina";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.selenij;
        }

        private void button70_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Brom";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Bromine";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Bromo";
            atomski_broj.Text = "35";
            atomska_masa.Text = "79,90";
            radioaktivnost.Text = "Ne";
            veličina_atoma.Text = "115 pm";
            stanje_atoma.Text = "Tekućina";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.brom;
        }

        private void button76_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Kripton";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Krypton";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Krypton";
            atomski_broj.Text = "36";
            atomska_masa.Text = "83,79";
            radioaktivnost.Text = "Ne";
            veličina_atoma.Text = "103 pm";
            stanje_atoma.Text = "Plin";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.kripton;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Rubidij";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Rubidium";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Rubidio";
            atomski_broj.Text = "37";
            atomska_masa.Text = "85,46";
            radioaktivnost.Text = "Ne";
            veličina_atoma.Text = "235 pm";
            stanje_atoma.Text = "Krutina";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.rubidij;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Stroncij";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Strontium";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Stronzio";
            atomski_broj.Text = "38";
            atomska_masa.Text = "87,62";
            radioaktivnost.Text = "Ne";
            veličina_atoma.Text = "200 pm";
            stanje_atoma.Text = "Krutina";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.stroncij;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Itrij";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Yttrium";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Yttrio";
            atomski_broj.Text = "39";
            atomska_masa.Text = "88,90";
            radioaktivnost.Text = "Ne";
            veličina_atoma.Text = "180 pm";
            stanje_atoma.Text = "Krutina";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.itrij;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Cirkonij";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Zirconium";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Zirconio";
            atomski_broj.Text = "40";
            atomska_masa.Text = "91,22";
            radioaktivnost.Text = "Ne";
            veličina_atoma.Text = "155 pm";
            stanje_atoma.Text = "Krutina";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.cirkonij;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Niobij";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Niobium";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Niobio";
            atomski_broj.Text = "41";
            atomska_masa.Text = "92,90";
            radioaktivnost.Text = "Ne";
            veličina_atoma.Text = "145 pm";
            stanje_atoma.Text = "Krutina";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.niobij;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Molbiden";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Molybdenum";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Molibdeno";
            atomski_broj.Text = "42";
            atomska_masa.Text = "95,94";
            radioaktivnost.Text = "Ne";
            veličina_atoma.Text = "145 pm";
            stanje_atoma.Text = "Krutina";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.molbiden;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Tehnecij";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Technetium";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Tecnezio";
            atomski_broj.Text = "43";
            atomska_masa.Text = "98";
            radioaktivnost.Text = "Da";
            veličina_atoma.Text = "135 pm";
            stanje_atoma.Text = "Sintetičan";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.tehnecij;
        }

        private void button36_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Rutenij";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Ruthenium";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Rutenio";
            atomski_broj.Text = "44";
            atomska_masa.Text = "101";
            radioaktivnost.Text = "Ne";
            veličina_atoma.Text = "130 pm";
            stanje_atoma.Text = "Krutina";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.rutenij;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Rodij";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Rhodium";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Rodio";
            atomski_broj.Text = "45";
            atomska_masa.Text = "102,9";
            radioaktivnost.Text = "Ne";
            veličina_atoma.Text = "135 pm";
            stanje_atoma.Text = "Krutina";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.rodij;
        }

        private void button40_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Paladij";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Palladium";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Palladio";
            atomski_broj.Text = "46";
            atomska_masa.Text = "106,4";
            radioaktivnost.Text = "Ne";
            veličina_atoma.Text = "140 pm";
            stanje_atoma.Text = "Krutina";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.paladij;
        }

        private void button45_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Srebro";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Silver";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Argento";
            atomski_broj.Text = "47";
            atomska_masa.Text = "107,8";
            radioaktivnost.Text = "Ne";
            veličina_atoma.Text = "160 pm";
            stanje_atoma.Text = "Krutina";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.srebro;
        }

        private void button43_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Kadmij";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Cadmium";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Cadmio";
            atomski_broj.Text = "48";
            atomska_masa.Text = "112,4";
            radioaktivnost.Text = "Ne";
            veličina_atoma.Text = "155 pm";
            stanje_atoma.Text = "Krutina";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.kadmij;
        }

        private void button51_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Indij";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Indium";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Indio";
            atomski_broj.Text = "49";
            atomska_masa.Text = "114,8";
            radioaktivnost.Text = "Ne";
            veličina_atoma.Text = "155 pm";
            stanje_atoma.Text = "Krutina";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.indij;
        }

        private void button58_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Kositar";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Tin";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Stagno";
            atomski_broj.Text = "50";
            atomska_masa.Text = "118,7";
            radioaktivnost.Text = "Ne";
            veličina_atoma.Text = "145 pm";
            stanje_atoma.Text = "Krutina";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.kositar;
        }

        private void button61_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Antimon";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Antimony";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Antimonio";
            atomski_broj.Text = "51";
            atomska_masa.Text = "121,7";
            radioaktivnost.Text = "Ne";
            veličina_atoma.Text = "145 pm";
            stanje_atoma.Text = "Krutina";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.antimon;
        }

        private void button67_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Telurij";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Tellurium";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Tellurio";
            atomski_broj.Text = "52";
            atomska_masa.Text = "127,6";
            radioaktivnost.Text = "Ne";
            veličina_atoma.Text = "140 pm";
            stanje_atoma.Text = "Krutina";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.telurij;
        }

        private void button71_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Jod";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Iodine";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Iodio";
            atomski_broj.Text = "53";
            atomska_masa.Text = "126,9";
            radioaktivnost.Text = "Ne";
            veličina_atoma.Text = "140 pm";
            stanje_atoma.Text = "Krutina";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.jod;
        }

        private void button77_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Ksenon";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Xenon";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Xenon";
            atomski_broj.Text = "54";
            atomska_masa.Text = "131,2";
            radioaktivnost.Text = "Ne";
            veličina_atoma.Text = "124 pm";
            stanje_atoma.Text = "Plin";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.ksenon;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Cezij";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Caesium";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Cesio";
            atomski_broj.Text = "55";
            atomska_masa.Text = "132,9";
            radioaktivnost.Text = "Ne";
            veličina_atoma.Text = "260 pm";
            stanje_atoma.Text = "Krutina";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.cezij;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Barij";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Barium";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Bario";
            atomski_broj.Text = "56";
            atomska_masa.Text = "137,3";
            radioaktivnost.Text = "Ne";
            veličina_atoma.Text = "215 pm";
            stanje_atoma.Text = "Krutina";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.barij;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Hafnij";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Hafnium";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Hafnio";
            atomski_broj.Text = "72";
            atomska_masa.Text = "178,4";
            radioaktivnost.Text = "Ne";
            veličina_atoma.Text = "155 pm";
            stanje_atoma.Text = "Krutina";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.hafnij;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Tantal";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Tantalum";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Tantalio";
            atomski_broj.Text = "73";
            atomska_masa.Text = "180,9";
            radioaktivnost.Text = "Ne";
            veličina_atoma.Text = "145 pm";
            stanje_atoma.Text = "Krutina";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.tantal;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Volfram";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Tungsten";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Wolframio";
            atomski_broj.Text = "74";
            atomska_masa.Text = "183,8";
            radioaktivnost.Text = "Ne";
            veličina_atoma.Text = "135 pm";
            stanje_atoma.Text = "Krutina";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.volfram;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Renij";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Rhenium";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Renio";
            atomski_broj.Text = "75";
            atomska_masa.Text = "186,2";
            radioaktivnost.Text = "Ne";
            veličina_atoma.Text = "135 pm";
            stanje_atoma.Text = "Krutina";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.renij;
        }

        private void button37_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Osmij";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Osmium";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Osmio";
            atomski_broj.Text = "76";
            atomska_masa.Text = "190,2";
            radioaktivnost.Text = "Ne";
            veličina_atoma.Text = "130 pm";
            stanje_atoma.Text = "Krutina";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.osmij;
        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Iridij";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Iridium";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Iridio";
            atomski_broj.Text = "77";
            atomska_masa.Text = "192,2";
            radioaktivnost.Text = "Ne";
            veličina_atoma.Text = "135 pm";
            stanje_atoma.Text = "Krutina";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.iridij;
        }

        private void button41_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Platina";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Platinum";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Platino";
            atomski_broj.Text = "78";
            atomska_masa.Text = "195,0";
            radioaktivnost.Text = "Ne";
            veličina_atoma.Text = "135 pm";
            stanje_atoma.Text = "Krutina";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.platina;
        }

        private void button46_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Zlato";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Gold";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Oro";
            atomski_broj.Text = "79";
            atomska_masa.Text = "196,9";
            radioaktivnost.Text = "Ne";
            veličina_atoma.Text = "135 pm";
            stanje_atoma.Text = "Krutina";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.zlato;
        }

        private void button50_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Živa";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Mercury";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Mercurio";
            atomski_broj.Text = "80";
            atomska_masa.Text = "200,5";
            radioaktivnost.Text = "Ne";
            veličina_atoma.Text = "150 pm";
            stanje_atoma.Text = "Tekućina";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.živa;
        }

        private void button52_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Talij";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Thallium";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Tallio";
            atomski_broj.Text = "81";
            atomska_masa.Text = "204,3";
            radioaktivnost.Text = "Ne";
            veličina_atoma.Text = "190 pm";
            stanje_atoma.Text = "Krutina";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.talij;
        }

        private void button59_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Olovo";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Lead";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Piombo";
            atomski_broj.Text = "82";
            atomska_masa.Text = "207,2";
            radioaktivnost.Text = "Ne";
            veličina_atoma.Text = "180 pm";
            stanje_atoma.Text = "Krutina";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.olovo;
        }

        private void button62_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Bizmut";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Bizmuth";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Bismuto";
            atomski_broj.Text = "83";
            atomska_masa.Text = "208,9";
            radioaktivnost.Text = "Ne";
            veličina_atoma.Text = "160 pm";
            stanje_atoma.Text = "Krutina";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.bizmut;
        }

        private void button68_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Polonij";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Polonium";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Polonio";
            atomski_broj.Text = "84";
            atomska_masa.Text = "209";
            radioaktivnost.Text = "Da";
            veličina_atoma.Text = "190 pm";
            stanje_atoma.Text = "Krutina";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.polonij;
        }

        private void button72_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Astat";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Astatine";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Astato";
            atomski_broj.Text = "85";
            atomska_masa.Text = "210";
            radioaktivnost.Text = "Da";
            veličina_atoma.Text = "145 pm";
            stanje_atoma.Text = "Krutina";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.astat;
        }

        private void button78_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Radon";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Radon";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Radon";
            atomski_broj.Text = "86";
            atomska_masa.Text = "222";
            radioaktivnost.Text = "Da";
            veličina_atoma.Text = "134 pm";
            stanje_atoma.Text = "Plin";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.radon;
        }

        private void button110_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Lantan";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Lanthanum";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Lantanio";
            atomski_broj.Text = "57";
            atomska_masa.Text = "138,9";
            radioaktivnost.Text = "Ne";
            veličina_atoma.Text = "195 pm";
            stanje_atoma.Text = "Krutina";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.lantan;
        }

        private void button105_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Cerij";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Cerium";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Cerio";
            atomski_broj.Text = "58";
            atomska_masa.Text = "140,1";
            radioaktivnost.Text = "Ne";
            veličina_atoma.Text = "185 pm";
            stanje_atoma.Text = "Krutina";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.cerij;
        }

        private void button106_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Praseodimij";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Praseodymium";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Praseodimio";
            atomski_broj.Text = "59";
            atomska_masa.Text = "140,9";
            radioaktivnost.Text = "Ne";
            veličina_atoma.Text = "185 pm";
            stanje_atoma.Text = "Krutina";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.praseodimij;
        }

        private void button107_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Neodimij";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Neodymium";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Neodimio";
            atomski_broj.Text = "60";
            atomska_masa.Text = "144,2";
            radioaktivnost.Text = "Ne";
            veličina_atoma.Text = "185 pm";
            stanje_atoma.Text = "Krutina";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.neodimij;
        }

        private void button108_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Prometij";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Promethium";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Promezio";
            atomski_broj.Text = "61";
            atomska_masa.Text = "145";
            radioaktivnost.Text = "Da";
            veličina_atoma.Text = "185 pm";
            stanje_atoma.Text = "Sintetičan";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.prometij;
        }

        private void button109_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Samarij";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Samarium";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Samario";
            atomski_broj.Text = "62";
            atomska_masa.Text = "150,3";
            radioaktivnost.Text = "Ne";
            veličina_atoma.Text = "185 pm";
            stanje_atoma.Text = "Krutina";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.samarij;
        }

        private void button99_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Europij";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Europium";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Europio";
            atomski_broj.Text = "63";
            atomska_masa.Text = "151,9";
            radioaktivnost.Text = "Ne";
            veličina_atoma.Text = "185 pm";
            stanje_atoma.Text = "Krutina";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.europij;
        }

        private void button104_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Gadolinij";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Gadolinium";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Gadolinio";
            atomski_broj.Text = "64";
            atomska_masa.Text = "157,2";
            radioaktivnost.Text = "Ne";
            veličina_atoma.Text = "180 pm";
            stanje_atoma.Text = "Krutina";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.gadolinij;
        }

        private void button103_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Terbij";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Terbium";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Terbio";
            atomski_broj.Text = "65";
            atomska_masa.Text = "158,9";
            radioaktivnost.Text = "Ne";
            veličina_atoma.Text = "175 pm";
            stanje_atoma.Text = "Krutina";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.terbij;
        }

        private void button102_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Disprosij";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Dysprosium";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Disprosio";
            atomski_broj.Text = "66";
            atomska_masa.Text = "162,5";
            radioaktivnost.Text = "Ne";
            veličina_atoma.Text = "175 pm";
            stanje_atoma.Text = "Krutina";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.disprosij;
        }

        private void button101_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Holmij";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Holmium";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Holmio";
            atomski_broj.Text = "67";
            atomska_masa.Text = "164,9";
            radioaktivnost.Text = "Ne";
            veličina_atoma.Text = "175 pm";
            stanje_atoma.Text = "Krutina";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.holmij;
        }

        private void button100_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Erbij";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Erbium";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Erbio";
            atomski_broj.Text = "68";
            atomska_masa.Text = "167,2";
            radioaktivnost.Text = "Ne";
            veličina_atoma.Text = "175 pm";
            stanje_atoma.Text = "Krutina";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.erbij;
        }

        private void button114_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Tulij";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Thulium";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Tulio";
            atomski_broj.Text = "69";
            atomska_masa.Text = "168,9";
            radioaktivnost.Text = "Ne";
            veličina_atoma.Text = "175 pm";
            stanje_atoma.Text = "Krutina";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.tulij;
        }

        private void button115_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Iterbij";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Ytterbium";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Ytterbio";
            atomski_broj.Text = "70";
            atomska_masa.Text = "173";
            radioaktivnost.Text = "Ne";
            veličina_atoma.Text = "175 pm";
            stanje_atoma.Text = "Krutina";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.iterbij;
        }

        private void button128_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Lutetij";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Lutetium";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Lutezio";
            atomski_broj.Text = "71";
            atomska_masa.Text = "174,9";
            radioaktivnost.Text = "Ne";
            veličina_atoma.Text = "175 pm";
            stanje_atoma.Text = "Krutina";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.lutetij;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Francij";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Francium";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Francio";
            atomski_broj.Text = "87";
            atomska_masa.Text = "223";
            radioaktivnost.Text = "Da";
            veličina_atoma.Text = "270 pm";
            stanje_atoma.Text = "Krutina";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.francij;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Radij";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Radium";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Radio";
            atomski_broj.Text = "88";
            atomska_masa.Text = "226";
            radioaktivnost.Text = "Da";
            veličina_atoma.Text = "233 pm";
            stanje_atoma.Text = "Krutina";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.radij;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Ruterfordij";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Rutherfordium";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Rutherfordio";
            atomski_broj.Text = "104";
            atomska_masa.Text = "261";
            radioaktivnost.Text = "Da";
            veličina_atoma.Text = "nepoznato";
            stanje_atoma.Text = "Sintetičan";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.ruterfordij;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Dubnij";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Dubnium";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Dubnio";
            atomski_broj.Text = "105";
            atomska_masa.Text = "262";
            radioaktivnost.Text = "Da";
            veličina_atoma.Text = "nepoznato";
            stanje_atoma.Text = "Sintetičan";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.dubnij;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Seaborgij";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Seaborgium";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Seaborgio";
            atomski_broj.Text = "106";
            atomska_masa.Text = "266";
            radioaktivnost.Text = "Da";
            veličina_atoma.Text = "nepoznato";
            stanje_atoma.Text = "Sintetičan";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.seaborgij;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Bohrij";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Seaborgij";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Bohrio";
            atomski_broj.Text = "107";
            atomska_masa.Text = "264";
            radioaktivnost.Text = "Da";
            veličina_atoma.Text = "nepoznato";
            stanje_atoma.Text = "Sintetičan";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.bohrij;
        }

        private void button38_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Hassij";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Hassium";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Hassio";
            atomski_broj.Text = "108";
            atomska_masa.Text = "269";
            radioaktivnost.Text = "Da";
            veličina_atoma.Text = "nepoznato";
            stanje_atoma.Text = "Sintetičan";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.hassij;
        }

        private void button34_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Meitnerij";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Meitnerium";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Meitnerio";
            atomski_broj.Text = "109";
            atomska_masa.Text = "268";
            radioaktivnost.Text = "Da";
            veličina_atoma.Text = "nepoznato";
            stanje_atoma.Text = "Sintetičan";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.meitnerij;
        }

        private void button87_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Darmstadtij";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Darmstadtium";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Darmstadtium";
            atomski_broj.Text = "110";
            atomska_masa.Text = "281";
            radioaktivnost.Text = "Da";
            veličina_atoma.Text = "nepoznato";
            stanje_atoma.Text = "Sintetičan";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.darmstardij;
        }

        private void button88_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Roetgenij";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Roetgenium";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Roetgenio";
            atomski_broj.Text = "111";
            atomska_masa.Text = "272";
            radioaktivnost.Text = "Da";
            veličina_atoma.Text = "nepoznato";
            stanje_atoma.Text = "Sintetičan";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.roetgenij;
        }

        private void button89_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Ununubij";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Ununbium";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Ununubio";
            atomski_broj.Text = "112";
            atomska_masa.Text = "285";
            radioaktivnost.Text = "Da";
            veličina_atoma.Text = "nepoznato";
            stanje_atoma.Text = "Sintetičan";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.ununubij;
        }

        private void button90_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Unutercij";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Ununutrium";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Unuterzio";
            atomski_broj.Text = "113";
            atomska_masa.Text = "284";
            radioaktivnost.Text = "Da";
            veličina_atoma.Text = "nepoznato";
            stanje_atoma.Text = "Sintetičan";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.ununutrij;
        }

        private void button91_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Unukvadrij";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Ununquadium";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Unuquadio";
            atomski_broj.Text = "114";
            atomska_masa.Text = "289";
            radioaktivnost.Text = "Da";
            veličina_atoma.Text = "nepoznato";
            stanje_atoma.Text = "Sintetičan";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.unukvadrij;
        }

        private void button92_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Unupentij";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Ununpentium";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Unupentio";
            atomski_broj.Text = "115";
            atomska_masa.Text = "288";
            radioaktivnost.Text = "Da";
            veličina_atoma.Text = "nepoznato";
            stanje_atoma.Text = "Sintetičan";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.unupentij;
        }

        private void button93_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Unuheksij";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Ununhexium";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Unuhexio";
            atomski_broj.Text = "116";
            atomska_masa.Text = "292";
            radioaktivnost.Text = "Da";
            veličina_atoma.Text = "nepoznato";
            stanje_atoma.Text = "Sintetičan";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.unuheksij;
        }

        private void button94_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Unuseptij";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Ununseptium";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Unuseptio";
            atomski_broj.Text = "117";
            atomska_masa.Text = "nepoznato";
            radioaktivnost.Text = "Da";
            veličina_atoma.Text = "nepoznato";
            stanje_atoma.Text = "Sintetičan";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.unuseptij;
        }

        private void button95_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Ununoktij";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Ununoctium";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Ununoctio";
            atomski_broj.Text = "118";
            atomska_masa.Text = "nepoznato";
            radioaktivnost.Text = "Da";
            veličina_atoma.Text = "nepoznato";
            stanje_atoma.Text = "Sintetičan";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.ununoktij;
        }

        private void button120_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Aktin";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Actinium";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Attinio";
            atomski_broj.Text = "89";
            atomska_masa.Text = "227";
            radioaktivnost.Text = "Da";
            veličina_atoma.Text = "188 pm";
            stanje_atoma.Text = "Krutina";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.aktin;
        }

        private void button113_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Torij";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Thorium";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Torio";
            atomski_broj.Text = "90";
            atomska_masa.Text = "232";
            radioaktivnost.Text = "Da";
            veličina_atoma.Text = "180 pm";
            stanje_atoma.Text = "Krutina";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.torij;
        }

        private void button116_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Protaktinij";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Protactinium";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Protoattinio";
            atomski_broj.Text = "91";
            atomska_masa.Text = "231";
            radioaktivnost.Text = "Da";
            veličina_atoma.Text = "180 pm";
            stanje_atoma.Text = "Krutina";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.protaktinij;
        }

        private void button117_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Uranij";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Uranium";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Uranio";
            atomski_broj.Text = "92";
            atomska_masa.Text = "238";
            radioaktivnost.Text = "Da";
            veličina_atoma.Text = "175 pm";
            stanje_atoma.Text = "Krutina";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.uranij;
        }

        private void button118_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Neptunij";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Netunium";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Nettunio";
            atomski_broj.Text = "93";
            atomska_masa.Text = "237";
            radioaktivnost.Text = "Da";
            veličina_atoma.Text = "175 pm";
            stanje_atoma.Text = "Sintetičan";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.neptunij;
        }

        private void button119_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Plutonij";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Plutonium";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Plutonio";
            atomski_broj.Text = "94";
            atomska_masa.Text = "244";
            radioaktivnost.Text = "Da";
            veličina_atoma.Text = "175 pm";
            stanje_atoma.Text = "Sintetičan";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.plutonij;
        }

        private void button126_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Americij";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Americium";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Americio";
            atomski_broj.Text = "95";
            atomska_masa.Text = "243";
            radioaktivnost.Text = "Da";
            veličina_atoma.Text = "175 pm";
            stanje_atoma.Text = "Sintetičan";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.americij;
        }

        private void button121_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Kurij";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Curium";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Curio";
            atomski_broj.Text = "96";
            atomska_masa.Text = "247";
            radioaktivnost.Text = "Da";
            veličina_atoma.Text = "135 pm";
            stanje_atoma.Text = "Sintetičan";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.kurij;
        }

        private void button122_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Berkelij";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Berkelium";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Berkelio";
            atomski_broj.Text = "97";
            atomska_masa.Text = "247";
            radioaktivnost.Text = "Da";
            veličina_atoma.Text = "nepoznato";
            stanje_atoma.Text = "Sintetičan";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.berkelij;
        }

        private void button123_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Kalifornij";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Californium";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Californio";
            atomski_broj.Text = "98";
            atomska_masa.Text = "251";
            radioaktivnost.Text = "Da";
            veličina_atoma.Text = "nepoznato";
            stanje_atoma.Text = "Sintetičan";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.kalifornij;
        }

        private void button124_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Einsteinij";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Einsteinium";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Einsteinio";
            atomski_broj.Text = "99";
            atomska_masa.Text = "252";
            radioaktivnost.Text = "Da";
            veličina_atoma.Text = "nepoznato";
            stanje_atoma.Text = "Sintetičan";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.einsteinij;
        }

        private void button125_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Fermij";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Fermium";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Fermio";
            atomski_broj.Text = "100";
            atomska_masa.Text = "257";
            radioaktivnost.Text = "Da";
            veličina_atoma.Text = "nepoznato";
            stanje_atoma.Text = "Sintetičan";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.fermij;
        }

        private void button111_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Mendelevij";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Mendelevium";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Mendelevio";
            atomski_broj.Text = "101";
            atomska_masa.Text = "258";
            radioaktivnost.Text = "Da";
            veličina_atoma.Text = "nepoznato";
            stanje_atoma.Text = "Sintetičan";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.mendelevij;
        }

        private void button112_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Nobelij";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Nobelium";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Nobelio";
            atomski_broj.Text = "102";
            atomska_masa.Text = "259";
            radioaktivnost.Text = "Da";
            veličina_atoma.Text = "nepoznato";
            stanje_atoma.Text = "Sintetičan";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.nobelij;
        }

        private void button127_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                naziv_elementa.Text = "Lawrencij";
            if (en_select.Checked == true)
                naziv_elementa.Text = "Lawrencium";
            if (it_select.Checked == true)
                naziv_elementa.Text = "Lawrencio";
            atomski_broj.Text = "103";
            atomska_masa.Text = "262";
            radioaktivnost.Text = "Da";
            veličina_atoma.Text = "nepoznato";
            stanje_atoma.Text = "Sintetičan";
            struktura_atoma.Image = Periodni_sustav_elemenata.Properties.Resources.lavrencij;
        }

        //
        //***KRAJ KODA ZA PRIKAZ INFORMACIJA O ELEMENTU***
        //

        //SPREMA INFORMACIJE O NEKOM ELEMENTU U TEKSTUALNU DATOTEKU OBLIKA <ime_elementa>.txt
        private void button130_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
            {
                if (lokacija.Text == "")
                    MessageBox.Show("Molimo odaberite lokaciju datoteke!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (naziv_elementa.Text == "")
                    MessageBox.Show("Molimo odaberite kemijski element!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (lokacija.Text != "" & naziv_elementa.Text != "")
                {
                    try
                    {
                        string lokacija_dat = lokacija.Text + @"\";
                        using (StreamWriter datoteka = File.CreateText(lokacija_dat.ToString() + naziv_elementa.Text + ".txt"))
                        {
                            datoteka.WriteLine("****************************************");
                            datoteka.WriteLine("INFORMACIJE O ELEMENTU: " + naziv_elementa.Text.ToUpper());
                            datoteka.WriteLine("****************************************");
                            datoteka.WriteLine("");
                            datoteka.WriteLine("IME ELEMENTA: " + naziv_elementa.Text);
                            datoteka.WriteLine("ATOMSKI BROJ: " + atomski_broj.Text);
                            datoteka.WriteLine("ATOMSKA MASA: " + atomska_masa.Text);
                            datoteka.WriteLine("STANJE PRI SOBNOJ TEMPERATURI: " + stanje_atoma.Text);
                            datoteka.WriteLine("VELIČINA ATOMA: " + veličina_atoma.Text);
                            datoteka.WriteLine("RADIOAKTIVNOST: " + radioaktivnost.Text);
                            datoteka.WriteLine("");
                            datoteka.WriteLine("****************************************");
                            datoteka.WriteLine("Periodni Sustav Elemenata 1.4");
                            datoteka.WriteLine("Mateo Velenik");
                        }
                        MessageBox.Show("Datoteka je uspješno kreirana", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Nije moguće kreirati datoteku", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            if (en_select.Checked == true)
            {
                if (lokacija.Text == "")
                    MessageBox.Show("Please choose the file location!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (naziv_elementa.Text == "")
                    MessageBox.Show("Please choose an element!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (lokacija.Text != "" & naziv_elementa.Text != "")
                {
                    try
                    {
                        string lokacija_dat = lokacija.Text + @"\";
                        using (StreamWriter datoteka = File.CreateText(lokacija_dat.ToString() + naziv_elementa.Text + ".txt"))
                        {
                            datoteka.WriteLine("****************************************");
                            datoteka.WriteLine("ELEMENT INFORMATION: " + naziv_elementa.Text.ToUpper());
                            datoteka.WriteLine("****************************************");
                            datoteka.WriteLine("");
                            datoteka.WriteLine("ELEMENT NAME: " + naziv_elementa.Text);
                            datoteka.WriteLine("ATOMIC NUMBER: " + atomski_broj.Text);
                            datoteka.WriteLine("ATOMIC WEIGHT: " + atomska_masa.Text);
                            datoteka.WriteLine("ELEMENT STATE: " + stanje_atoma.Text);
                            datoteka.WriteLine("ELEMENT SIZE: " + veličina_atoma.Text);
                            datoteka.WriteLine("RADIOACTIVE: " + radioaktivnost.Text);
                            datoteka.WriteLine("");
                            datoteka.WriteLine("****************************************");
                            datoteka.WriteLine("Periodni Sustav Elemenata 1.4");
                            datoteka.WriteLine("Mateo Velenik");
                        }
                        MessageBox.Show("File created successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Error during file creation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            if (it_select.Checked == true)
            {
                if (lokacija.Text == "")
                    MessageBox.Show("Selezionate la locazione del file!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (naziv_elementa.Text == "")
                    MessageBox.Show("Selezionate un elemento!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (lokacija.Text != "" & naziv_elementa.Text != "")
                {
                    try
                    {
                        string lokacija_dat = lokacija.Text + @"\";
                        using (StreamWriter datoteka = File.CreateText(lokacija_dat.ToString() + naziv_elementa.Text + ".txt"))
                        {
                            datoteka.WriteLine("****************************************");
                            datoteka.WriteLine("INFORMAZIONI DEL ELEMENTO: " + naziv_elementa.Text.ToUpper());
                            datoteka.WriteLine("****************************************");
                            datoteka.WriteLine("");
                            datoteka.WriteLine("NOME ELEMENTO: " + naziv_elementa.Text);
                            datoteka.WriteLine("NUMERO ATOMICO: " + atomski_broj.Text);
                            datoteka.WriteLine("PESO ATOMICO: " + atomska_masa.Text);
                            datoteka.WriteLine("STATO DEL ELEMENTO: " + stanje_atoma.Text);
                            datoteka.WriteLine("GRANDEZZA DEL ELEMENTO: " + veličina_atoma.Text);
                            datoteka.WriteLine("RADIOATTIVO: " + radioaktivnost.Text);
                            datoteka.WriteLine("");
                            datoteka.WriteLine("****************************************");
                            datoteka.WriteLine("Periodni Sustav Elemenata 1.4");
                            datoteka.WriteLine("Mateo Velenik");
                        }
                        MessageBox.Show("File creato corretamente", "Messagio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Errore durando la creazione del file", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void button130_MouseEnter(object sender, EventArgs e)
        {
            if(hr_select.Checked == true)
                status.Text = "Sprema informacije o odabranom elementu u tekstualnu datoteku.";
            if(en_select.Checked == true)
                status.Text = "Saves the informations of the selected element in a text file.";
            if(it_select.Checked == true)
                status.Text = "Salva le informazioni del elemento in un file testo.";
        }

        private void button130_MouseLeave(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
                status.Text = "Spreman";
            if (en_select.Checked == true)
                status.Text = "Ready";
            if (it_select.Checked == true)
                status.Text = "Pronto";
        }

        //SPREMA PODATKE IZ TEKSTUALNOG OKVIRA BILJEŠKE U .txt DATOTEKU
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter datoteka = File.CreateText(@"C:\biljeske.txt"))
                {
                    datoteka.WriteLine(textBox1.Text);
                }
            }
            catch
            {
                
            }
        }

        //PRI UČITAVANJU PROGRAMA, UČITAVAJU SE I PRIJAŠNJE BILJEŠKE
        private void PSE_Load(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader datoteka = File.OpenText(@"C:\biljeske.txt"))
                {
                    textBox1.Text = datoteka.ReadToEnd();
                }
            }
            catch
            {

            }
        }

        //POKREĆE KVIZ NAZIVA ELEMENATA PRITOM PRAZNEĆI PROZOR ZA INFORMACIJE
        private void kvizNazivaElemenataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
            {
                naziv_elementa.Text = "";
                atomska_masa.Text = "";
                atomski_broj.Text = "";
                radioaktivnost.Text = "";
                stanje_atoma.Text = "";
                veličina_atoma.Text = "";
                struktura_atoma.Image = null;
                //kviz_nazivi_HR p = new kviz_nazivi_HR();
                //p.ShowDialog();
            }
            if (en_select.Checked == true)
            {
                naziv_elementa.Text = "";
                atomska_masa.Text = "";
                atomski_broj.Text = "";
                radioaktivnost.Text = "";
                stanje_atoma.Text = "";
                veličina_atoma.Text = "";
                struktura_atoma.Image = null;
                kviz_nazivi_EN p = new kviz_nazivi_EN();
                p.ShowDialog();
            }
            if (it_select.Checked == true)
            {
                naziv_elementa.Text = "";
                atomska_masa.Text = "";
                atomski_broj.Text = "";
                radioaktivnost.Text = "";
                stanje_atoma.Text = "";
                veličina_atoma.Text = "";
                struktura_atoma.Image = null;
                kviz_nazivi_IT p = new kviz_nazivi_IT();
                p.ShowDialog();
            }
        }

        //POKREĆE KVIZ KEMIJSKIH SIMBOLA PRITOM PRAZNEĆI PROZOR ZA INFORMACIJE
        private void kvizKemijsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
            {
                naziv_elementa.Text = "";
                atomska_masa.Text = "";
                atomski_broj.Text = "";
                radioaktivnost.Text = "";
                stanje_atoma.Text = "";
                veličina_atoma.Text = "";
                struktura_atoma.Image = null;
                kviz_simboli_HR i = new kviz_simboli_HR();
                i.ShowDialog();
            }
            if (en_select.Checked == true)
            {
                naziv_elementa.Text = "";
                atomska_masa.Text = "";
                atomski_broj.Text = "";
                radioaktivnost.Text = "";
                stanje_atoma.Text = "";
                veličina_atoma.Text = "";
                struktura_atoma.Image = null;
                kviz_simboli_EN i = new kviz_simboli_EN();
                i.ShowDialog();
            }
            if (it_select.Checked == true)
            {
                naziv_elementa.Text = "";
                atomska_masa.Text = "";
                atomski_broj.Text = "";
                radioaktivnost.Text = "";
                stanje_atoma.Text = "";
                veličina_atoma.Text = "";
                struktura_atoma.Image = null;
                kviz_simboli_IT i = new kviz_simboli_IT();
                i.ShowDialog();
            }
        }

        //ZATVARA PROGRAM
        private void izlazToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //MIJENJA JEZIK U HRVATSKI
        private void hr_select_CheckedChanged(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
            {
                _ime.Text = "Ime elementa:";
                _atomski.Text = "Atomski broj:";
                _radioaktivnost.Text = "Radioaktivan:";
                _masa.Text = "Atomska masa:";
                _velicina.Text = "Veličina atoma:";
                _stanje.Text = "Stanje pri sobnoj temperaturi:";
                opcije.Text = "Opcije";
                legenda_vrste.Text = "Legenda";
                info_o_elementu.Text = "Informacije o elementu";
                struktura.Text = "Struktura atoma";
                bilješke.Text = "Bilješke";
                kvizToolStripMenuItem1.Text = "Kviz";
                oProgramuToolStripMenuItem.Text = "O programu";
                izlazToolStripMenuItem.Text = "Izlaz";
                _aktinidi.Text = "Aktinidi";
                _alkali.Text = "Alkali";
                _alkali_zemni.Text = "Alkali-zemni";
                _halogeni.Text = "Halogeni elementi";
                _lantanidi.Text = "Lantanidi";
                _metali.Text = "Metali";
                _metaloidi.Text = "Metaloidi";
                _nemetali.Text = "Nemetali";
                _plemeniti_plinovi.Text = "Plemeniti plinovi";
                _prijelazni_aktinidi.Text = "Prijelazni aktinidi";
                _prijelazni_metali.Text = "Prijelazni metali";
                naslov_hr.Visible = true;
                naslov_en.Visible = false;
                naslov_it.Visible = false;
                label18.Text = "Lokacija datoteke:";
                button130.Text = "Spremi datoteku";
                status.Text = "Spreman";
                naziv_elementa.Text = "";
                atomska_masa.Text = "";
                atomski_broj.Text = "";
                radioaktivnost.Text = "";
                stanje_atoma.Text = "";
                veličina_atoma.Text = "";
                struktura_atoma.Image = null;
                bilješkeradneToolStripMenuItem.Text = "Bilješke (radne)";
                //dodatne_info.Text = "Za osnovnoškolce";
                napredni_but.Text = "Napredni";
                osnovni_but.Text = "Osnovni";
                kviz_nazivi_ADV_but.Text = "Kviz naziva elemenata";
                kviz_nazivi_BAS_but.Text = "Kviz naziva elemenata";
                kviz_simboli_ADV_but.Text = "Kviz simbola elemenata";
                kviz_simboli_BAS_but.Text = "Kviz simbola elemenata";
                btnPregledaj.Text = "Pregledaj";
            }
        }
     
        //MIJENJA JEZIK U ENGLESKI
        private void en_select_CheckedChanged(object sender, EventArgs e)
        {
            if (en_select.Checked == true)
            {
                _ime.Text = "Name:";
                _atomski.Text = "Atomic number:";
                _masa.Text = "Atomic weight:";
                _stanje.Text = "Element state:";
                _velicina.Text = "Atomic size";
                _radioaktivnost.Text = "Radioactive:";
                opcije.Text = "Options";
                legenda_vrste.Text = "Legend";
                info_o_elementu.Text = "Informations";
                struktura.Text = "Atomic structure";
                bilješke.Text = "Notes";
                kvizToolStripMenuItem1.Text = "Quiz";
                oProgramuToolStripMenuItem.Text = "About";
                izlazToolStripMenuItem.Text = "Exit";
                _aktinidi.Text = "Actinides";
                _alkali.Text = "Alkali metals";
                _alkali_zemni.Text = "Alkali earth metals";
                _halogeni.Text = "Halogens";
                _lantanidi.Text = "Lanthanides";
                _metali.Text = "Metals";
                _metaloidi.Text = "Metaloids";
                _nemetali.Text = "Non-metals";
                _plemeniti_plinovi.Text = "Noble gases";
                _prijelazni_aktinidi.Text = "Transactinides";
                _prijelazni_metali.Text = "Transition metals";
                naslov_hr.Visible = false;
                naslov_en.Visible = true;
                naslov_it.Visible = false;
                label18.Text = "File location:";
                button130.Text = "Save file";
                status.Text = "Ready";
                naziv_elementa.Text = "";
                atomska_masa.Text = "";
                atomski_broj.Text = "";
                radioaktivnost.Text = "";
                stanje_atoma.Text = "";
                veličina_atoma.Text = "";
                struktura_atoma.Image = null;
                bilješkeradneToolStripMenuItem.Text = "Footnotes";
                //dodatne_info.Text = "For elementary school";
                napredni_but.Text = "Advanced";
                osnovni_but.Text = "Basic";
                kviz_nazivi_ADV_but.Text = "Quiz - element names";
                kviz_nazivi_BAS_but.Text = "Quiz - element names";
                kviz_simboli_ADV_but.Text = "Quiz - element simbols";
                kviz_simboli_BAS_but.Text = "Quiz - element simbols";
                btnPregledaj.Text = "Browse";
            }
        }

        //MIJENJA JEZIK U TALIJANSKI
        private void it_select_CheckedChanged(object sender, EventArgs e)
        {
            if (it_select.Checked == true)
            {
                _ime.Text = "Nome:";
                _atomski.Text = "Numero atomico:";
                _masa.Text = "Peso atomico:";
                _stanje.Text = "Stato del elemento:";
                _velicina.Text = "Grandezza del elemento";
                _radioaktivnost.Text = "Radioattivo:";
                opcije.Text = "Opzioni";
                legenda_vrste.Text = "Leggenda";
                info_o_elementu.Text = "Informazioni";
                struktura.Text = "Struttura atomica";
                bilješke.Text = "Note";
                kvizToolStripMenuItem1.Text = "Quiz";
                oProgramuToolStripMenuItem.Text = "Informazioni";
                izlazToolStripMenuItem.Text = "Uscita";
                _aktinidi.Text = "Attinidi";
                _alkali.Text = "Alcalini";
                _alkali_zemni.Text = "Alcalini-terrosi";
                _halogeni.Text = "Alogeni";
                _lantanidi.Text = "Lantanidi";
                _metali.Text = "Metalli";
                _metaloidi.Text = "Metaloidi";
                _nemetali.Text = "Non-metali";
                _plemeniti_plinovi.Text = "Gas nobili";
                _prijelazni_aktinidi.Text = "Attinidi in transizione";
                _prijelazni_metali.Text = "Metalli in transizione";
                naslov_hr.Visible = false;
                naslov_en.Visible = false;
                naslov_it.Visible = true;
                label18.Text = "Locazione file:";
                button130.Text = "Salva file";
                status.Text = "Pronto";
                naziv_elementa.Text = "";
                atomska_masa.Text = "";
                atomski_broj.Text = "";
                radioaktivnost.Text = "";
                stanje_atoma.Text = "";
                veličina_atoma.Text = "";
                struktura_atoma.Image = null;
                bilješkeradneToolStripMenuItem.Text = "Note da lavoro";
                //dodatne_info.Text = "Per scuola elementare";
                napredni_but.Text = "Avanzato";
                osnovni_but.Text = "Base";
                kviz_nazivi_ADV_but.Text = "Quiz - nomi degli elementi";
                kviz_nazivi_BAS_but.Text = "Quiz - nomi degli elementi";
                kviz_simboli_ADV_but.Text = "Quiz - simboli degli elementi";
                kviz_simboli_BAS_but.Text = "Quiz - simboli degli elementi";
                btnPregledaj.Text = "Cerca";
            }
        }

        //
        //BLOK KODA ZA DINAMIČNU PROMJENU JEZIKA
        //
        private void radioaktivnost_TextChanged(object sender, EventArgs e)
        {
            if (en_select.Checked == true)
            {
                if (radioaktivnost.Text == "Ne")
                    radioaktivnost.Text = "No";
                
                if (radioaktivnost.Text == "Da")
                    radioaktivnost.Text = "Yes";
            }
            if (hr_select.Checked == true)
            {
                if (radioaktivnost.Text == "Ne")
                    radioaktivnost.Text = "Ne";

                if (radioaktivnost.Text == "Da")
                    radioaktivnost.Text = "Da";
            }
            if (it_select.Checked == true)
            {
                if (radioaktivnost.Text == "Ne")
                    radioaktivnost.Text = "No";

                if (radioaktivnost.Text == "Da")
                    radioaktivnost.Text = "Si";
            }
        }

        private void stanje_atoma_TextChanged(object sender, EventArgs e)
        {
            if (en_select.Checked == true)
            {
                if (stanje_atoma.Text == "Krutina")
                    stanje_atoma.Text = "Solid";
                if (stanje_atoma.Text == "Plin")
                    stanje_atoma.Text = "Gas";
                if (stanje_atoma.Text == "Tekućina")
                    stanje_atoma.Text = "Liquid";
                if (stanje_atoma.Text == "Sintetičan")
                    stanje_atoma.Text = "Sintetic";
            }
            if (hr_select.Checked == true)
            {
                if (stanje_atoma.Text == "Krutina")
                    stanje_atoma.Text = "Krutina";
                if (stanje_atoma.Text == "Plin")
                    stanje_atoma.Text = "Plin";
                if (stanje_atoma.Text == "Tekućina")
                    stanje_atoma.Text = "Tekućina";
                if (stanje_atoma.Text == "Sintetičan")
                    stanje_atoma.Text = "Sintetičan";
            }
            if (it_select.Checked == true)
            {
                if (stanje_atoma.Text == "Krutina")
                    stanje_atoma.Text = "Solido";
                if (stanje_atoma.Text == "Plin")
                    stanje_atoma.Text = "Gas";
                if (stanje_atoma.Text == "Tekućina")
                    stanje_atoma.Text = "Liquido";
                if (stanje_atoma.Text == "Sintetičan")
                    stanje_atoma.Text = "Artificiale";
            }
        }

        private void atomska_masa_TextChanged(object sender, EventArgs e)
        {
            if (en_select.Checked == true)
            {
                if (atomska_masa.Text == "nepoznato")
                    atomska_masa.Text = "unknown";
            }
            if (it_select.Checked == true)
            {
                if (atomska_masa.Text == "nepoznato")
                    atomska_masa.Text = "N/A";
            }
            if (hr_select.Checked == true)
            {
                if (atomska_masa.Text == "nepoznato")
                    atomska_masa.Text = "nepoznato";
            }
        }

        private void veličina_atoma_TextChanged(object sender, EventArgs e)
        {
            if (en_select.Checked == true)
            {
                if (veličina_atoma.Text == "nepoznato")
                    veličina_atoma.Text = "unknown";
            }
            if (it_select.Checked == true)
            {
                if (veličina_atoma.Text == "nepoznato")
                    veličina_atoma.Text = "N/A";
            }
            if (hr_select.Checked == true)
            {
                if (veličina_atoma.Text == "nepoznato")
                    veličina_atoma.Text = "nepoznato";
            }
        }
        //
        //BLOK KODA ZA SERIJSKU PROMJENU JEZIKA
        //

        //BRIŠE INFORMACIJE O ELEMENTU
        private void button129_Click(object sender, EventArgs e)
        {
            naziv_elementa.Text = "";
            atomska_masa.Text = "";
            atomski_broj.Text = "";
            radioaktivnost.Text = "";
            stanje_atoma.Text = "";
            veličina_atoma.Text = "";
            struktura_atoma.Image = null;
        }

        private void biljeske_radne_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (hr_select.Checked == true)
            {
                biljeske_radne_HR p = new biljeske_radne_HR();
                p.Show();
            }
            if (en_select.Checked == true)
            {
                biljeske_radne_EN p = new biljeske_radne_EN();
                p.Show();
            }
            if (it_select.Checked == true)
            {
                biljeske_radne_IT p = new biljeske_radne_IT();
                p.Show();
            }
        }

        private void dodatne_info_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
            {
                //dod_informacije_HR p = new dod_informacije_HR();
                //p.ShowDialog();

                MessageBox.Show("Ovaj dio programa još nije dovršen", "Dio programa", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            if (en_select.Checked == true)
            {
                MessageBox.Show("This program feature isn't avaiable at the moment.", "Program features", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (it_select.Checked == true)
            {
                MessageBox.Show("Questa parte del programma non è raggiungibile in questo momento", "Parte del programma", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        private void kviz_nazivi_BAS_but_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
            {
                naziv_elementa.Text = "";
                atomska_masa.Text = "";
                atomski_broj.Text = "";
                radioaktivnost.Text = "";
                stanje_atoma.Text = "";
                veličina_atoma.Text = "";
                struktura_atoma.Image = null;
                kviz_dodatni_nazivi_HR p = new kviz_dodatni_nazivi_HR();
                p.ShowDialog();
            }
            if (en_select.Checked == true)
            {
                naziv_elementa.Text = "";
                atomska_masa.Text = "";
                atomski_broj.Text = "";
                radioaktivnost.Text = "";
                stanje_atoma.Text = "";
                veličina_atoma.Text = "";
                struktura_atoma.Image = null;
                kviz_dodatni_nazivi_EN p = new kviz_dodatni_nazivi_EN();
                p.ShowDialog();
            }
            if (it_select.Checked == true)
            {
                naziv_elementa.Text = "";
                atomska_masa.Text = "";
                atomski_broj.Text = "";
                radioaktivnost.Text = "";
                stanje_atoma.Text = "";
                veličina_atoma.Text = "";
                struktura_atoma.Image = null;
                kviz_dodatni_nazivi_IT p = new kviz_dodatni_nazivi_IT();
                p.ShowDialog();
            }
        }
        
        private void kviz_simboli_BAS_but_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
            {
                naziv_elementa.Text = "";
                atomska_masa.Text = "";
                atomski_broj.Text = "";
                radioaktivnost.Text = "";
                stanje_atoma.Text = "";
                veličina_atoma.Text = "";
                struktura_atoma.Image = null;
                kviz_dodatni_simboli_HR p = new kviz_dodatni_simboli_HR();
                p.ShowDialog();
            }
            if (en_select.Checked == true)
            {
                naziv_elementa.Text = "";
                atomska_masa.Text = "";
                atomski_broj.Text = "";
                radioaktivnost.Text = "";
                stanje_atoma.Text = "";
                veličina_atoma.Text = "";
                struktura_atoma.Image = null;
                kviz_dodatni_simboli_EN p = new kviz_dodatni_simboli_EN();
                p.ShowDialog();
            }
            if (it_select.Checked == true)
            {
                naziv_elementa.Text = "";
                atomska_masa.Text = "";
                atomski_broj.Text = "";
                radioaktivnost.Text = "";
                stanje_atoma.Text = "";
                veličina_atoma.Text = "";
                struktura_atoma.Image = null;
                kviz_dodatni_simboli_IT p = new kviz_dodatni_simboli_IT();
                p.ShowDialog();
            }
        }

        private void kviz_nazivi_ADV_but_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
            {
                naziv_elementa.Text = "";
                atomska_masa.Text = "";
                atomski_broj.Text = "";
                radioaktivnost.Text = "";
                stanje_atoma.Text = "";
                veličina_atoma.Text = "";
                struktura_atoma.Image = null;
                kviz_nazivi_HR p = new kviz_nazivi_HR();
                p.ShowDialog();
            }
            if (en_select.Checked == true)
            {
                naziv_elementa.Text = "";
                atomska_masa.Text = "";
                atomski_broj.Text = "";
                radioaktivnost.Text = "";
                stanje_atoma.Text = "";
                veličina_atoma.Text = "";
                struktura_atoma.Image = null;
                kviz_nazivi_EN p = new kviz_nazivi_EN();
                p.ShowDialog();
            }
            if (it_select.Checked == true)
            {
                naziv_elementa.Text = "";
                atomska_masa.Text = "";
                atomski_broj.Text = "";
                radioaktivnost.Text = "";
                stanje_atoma.Text = "";
                veličina_atoma.Text = "";
                struktura_atoma.Image = null;
                kviz_nazivi_IT p = new kviz_nazivi_IT();
                p.ShowDialog();
            }
        }       

        private void kviz_simboli_ADV_but_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
            {
                naziv_elementa.Text = "";
                atomska_masa.Text = "";
                atomski_broj.Text = "";
                radioaktivnost.Text = "";
                stanje_atoma.Text = "";
                veličina_atoma.Text = "";
                struktura_atoma.Image = null;
                kviz_simboli_HR p = new kviz_simboli_HR();
                p.ShowDialog();
            }
            if (en_select.Checked == true)
            {
                naziv_elementa.Text = "";
                atomska_masa.Text = "";
                atomski_broj.Text = "";
                radioaktivnost.Text = "";
                stanje_atoma.Text = "";
                veličina_atoma.Text = "";
                struktura_atoma.Image = null;
                kviz_simboli_EN p = new kviz_simboli_EN();
                p.ShowDialog();
            }
            if (it_select.Checked == true)
            {
                naziv_elementa.Text = "";
                atomska_masa.Text = "";
                atomski_broj.Text = "";
                radioaktivnost.Text = "";
                stanje_atoma.Text = "";
                veličina_atoma.Text = "";
                struktura_atoma.Image = null;
                kviz_simboli_IT p = new kviz_simboli_IT();
                p.ShowDialog();
            }
        }

        private void bilješkeradneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
            {
                biljeske_radne_HR p = new biljeske_radne_HR();
                p.Show();
            }
            if (en_select.Checked == true)
            {
                biljeske_radne_EN p = new biljeske_radne_EN();
                p.Show();
            }
            if (it_select.Checked == true)
            {
                biljeske_radne_IT p = new biljeske_radne_IT();
                p.Show();
            }
        }

        private void btnPregledaj_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            lokacija.Text = folderBrowserDialog1.SelectedPath;
        }

        private void oProgramuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (hr_select.Checked == true)
            {
                o_programu_HR a = new o_programu_HR();
                a.ShowDialog();
            }
            if (en_select.Checked == true)
            {
                o_programu_EN a = new o_programu_EN();
                a.ShowDialog();
            }
            if (it_select.Checked == true)
            {
                o_programu_IT a = new o_programu_IT();
                a.ShowDialog();
            }
        }
    }
}