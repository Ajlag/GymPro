using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GYM
{
    public partial class promenaLozinke : Form
    {
       
        public promenaLozinke()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txbKorisnickoIme.Text == "" || txbLozinka.Text == "" || txbNovaLozinka.Text == "" || txbPotvrdaLozinke.Text == "")
                {
                    MessageBox.Show("Morate popuniti sva polja");
                }
                else
                {
                    korisnik k = new korisnik();
                    k.KorisnickoIme = txbKorisnickoIme.Text;
                    k.sifra = txbLozinka.Text;
                 string allowedchar = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                    if (txbNovaLozinka.Text.Equals(txbPotvrdaLozinke.Text))
                    {
                      
                       
                         if (!txbNovaLozinka.Text.All(allowedchar.Contains))
                        {
                            MessageBox.Show("Proverite lozinku");
                        }

                  else if (k.promenaLozinke(txbNovaLozinka.Text))
                            {

                                MessageBox.Show("Lozinka je uspešno promenjena");
                            }
                        
                        else MessageBox.Show("Neuspešna promena lozinke");


                    }
                    else MessageBox.Show("Nepravilno potvrđena lozinka");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnPPonisti_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Form1();
            f.Show();
        }

        private void cbLozinka_CheckedChanged(object sender, EventArgs e)
        {
            txbLozinka.PasswordChar = cbLozinka.Checked ? '\0' : '*';

            txbNovaLozinka.PasswordChar = cbLozinka.Checked ? '\0' : '*';

            txbPotvrdaLozinke.PasswordChar = cbLozinka.Checked ? '\0' : '*';
        }

      
    }
}
