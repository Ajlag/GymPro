using GYM.Klase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GYM
{
    public partial class Form1 : Form
    {

       

        public Form1()
        {
            InitializeComponent();

        }



        private void button3_Click_1(object sender, EventArgs e)
        {

        
        korisnik k = new korisnik();
            k.KorisnickoIme = textBox1.Text;
            k.sifra = textBox2.Text;
            DataTable dt = Bazaa.UlogujRadnika(k);
            string allowedchar = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            try
            {
                if (textBox1.Text == "" || textBox2.Text == "")
                {
                    MessageBox.Show("Morate popuniti sva polja");
                }
                else if (!textBox2.Text.All(allowedchar.Contains))
                {
                    MessageBox.Show("Proverite lozinku");
                }
                else
                {
                    if (k.proveraKorisnika())
                    {
                        if (dt.Rows.Count == 1)

                        {
                            this.Hide();
                            Radnik f = new Radnik();
                            f.Show();



                        }
                        else
                        {
                            MessageBox.Show("Neispravno ste uneli lozinku.");
                        }



                    }
                    else
                    {
                        MessageBox.Show("Ne postoji korisnik sa unesenim korisničkim imenom");
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void button2_Click_1(object sender, EventArgs e)
        {      

        korisnik k = new korisnik();
            k.KorisnickoIme = textBox1.Text;
            k.sifra = textBox2.Text;
            DataTable dt = Bazaa.UlogujNadleznog(k);
            string allowedchar = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            try {
                if (textBox1.Text == "" || textBox2.Text == "")
                {
                    MessageBox.Show("Morate popuniti sva polja");
                }
                else if(!textBox2.Text.All(allowedchar.Contains))
                        {
                    MessageBox.Show("Proverite lozinku");
                }
                else
                { if (k.proveraKorisnika())
                    {
                        if (dt.Rows.Count == 1)

                        {
                            this.Hide();
                            Nadlezni f = new Nadlezni();
                            f.Show();
                        }
                        else
                        {
                            MessageBox.Show("Neispravno ste uneli  lozinku.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ne postoji korisnik sa unesenim korisničkim imenom");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void promenaLozinke_Click(object sender, EventArgs e)
        {
            promenaLozinke pl = new promenaLozinke();
            pl.ShowDialog();
        }

        private void izadji_Click(object sender, EventArgs e)
        {
            this.Close();
        }     

        private void cbPrikaziLozinku_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = cbPrikaziLozinku.Checked ? '\0' : '*';
        }

      
    }
}

