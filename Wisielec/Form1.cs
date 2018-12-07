using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wisielec
{
    public partial class Form1 : Form
    {
        string slowo;
        int ile_blednych = 0;
        public Form1()
        {
            InitializeComponent();
            losuj_slowo();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ile_blednych < 7)
            {
                string litera = textBox1.Text;
                bool czy_trafiony = false;
                int gdzie_trafiony = 0;
                for (int i = 1; i < 6; i++)
                {
                    if (Convert.ToString(slowo[i]) == litera)
                    {
                        czy_trafiony = true;
                        gdzie_trafiony = i;
                        if (gdzie_trafiony == 1) { label2.Text = litera; }
                        if (gdzie_trafiony == 2) { label3.Text = litera; }
                        if (gdzie_trafiony == 3) { label4.Text = litera; }
                        if (gdzie_trafiony == 4) { label5.Text = litera; }
                        if (gdzie_trafiony == 5) { label6.Text = litera; }
                    }
                }
                if (czy_trafiony == false)
                {
                    ile_blednych = ile_blednych + 1;

                    if (ile_blednych == 1) { pictureBox1.Image = Wisielec.Properties.Resources._2; }
                    if (ile_blednych == 2) { pictureBox1.Image = Wisielec.Properties.Resources._3; }
                    if (ile_blednych == 3) { pictureBox1.Image = Wisielec.Properties.Resources._4; }
                    if (ile_blednych == 4) { pictureBox1.Image = Wisielec.Properties.Resources._5; }
                    if (ile_blednych == 5) { pictureBox1.Image = Wisielec.Properties.Resources._6; }
                    if (ile_blednych == 6) { pictureBox1.Image = Wisielec.Properties.Resources._7; }
                    if (ile_blednych == 7) { pictureBox1.Image = Wisielec.Properties.Resources._8; }
                    button2.Visible = true;
                }

                wygrana();
            }
            else 
            {
                
                pictureBox1.Image = Wisielec.Properties.Resources._10;
            }
            
        }

        private void losuj_slowo()
        {

            string[] slowa = { "adapter", "adopcja", "aerozol", "babiarz", "balejaż", "bariera", "chirurg", "choinka", "decyzja", "deltoid", "egzamin", "ekspert", "fabryka", "facjata", "fasolka", "kafelka", "kuchnia", "latarka", "schowek", "tablica", "walizka", "zagadka" };
            int ile_slow = slowa.Length;
            Random gen = new Random();
            int indeks_slowa = gen.Next(0, ile_slow);
            slowo = slowa[indeks_slowa];
            label1.Text = Convert.ToString(slowo[0]);
            label7.Text = Convert.ToString(slowo[6]);


        }

        private void wygrana()
        {
            if (label2.Text != "_")
            {
                if (label3.Text != "_")
                {
                    if (label4.Text != "_")
                    {
                        if (label5.Text != "_")
                        {
                            if (label6.Text != "_")
                            {
                                pictureBox1.Image = Wisielec.Properties.Resources._9;
                                button2.Visible = true;
                            }
                        }
                    }
                }
            }
        } 
            

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            losuj_slowo();
            label2.Text = "_";
            label3.Text = "_";
            label4.Text = "_";
            label5.Text = "_";
            label6.Text = "_";
            ile_blednych = 0;
            button2.Visible = false;
            pictureBox1.Image = pictureBox1.Image = Wisielec.Properties.Resources._1;

        }
    }
}
