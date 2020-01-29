using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using GYM.Klase;
using System.Text.RegularExpressions;

namespace GYM
{
    public partial class radnici : UserControl
    {
       
        public radnici()
        {
            InitializeComponent();
           
            popuniTabelu();
        }

        private void popuniTabelu()
        {
            var radnici = Bazaa.vratiPodatkeRadnici();

            List<string> zaPrikaz = new List<string>();
            foreach (var r in radnici)
            {
                zaPrikaz.Add(r.ToString());
            }
            radniciBox.DataSource = zaPrikaz;
        }
       /* private void zabranikarakter()
        {
            string karakeri = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            if (!(txtLozinka.Text.ToString().Contains(karakeri)))
            {
                MessageBox.Show("Nisu dozvoljeni specijalni karakteri za lozinku!");
            }
            
        }*/

        private void btnDodaj_Click(object sender, EventArgs e)
        { 
            korisnik k = new korisnik();
            k.KorisnickoIme = tbKorisnickoIme.Text;
            string allowedchar = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            k.sifra = txtLozinka.Text;

            if (tbIme.Text == "" || tbPrezime.Text == "" || tbbrTel.Text == "" || tbadresa.Text == "" || tbemail.Text == "" || tbJMBG.Text == "" || tbKorisnickoIme.Text == "" || txtLozinka.Text == "")
            {
                MessageBox.Show("Morate popuniti sva polja!");
            }
            else if (k.proveraKorisnika())
            {
                MessageBox.Show("Korisnicko ime vec postoji.");
            }
            else if (!txtLozinka.Text.All(allowedchar.Contains))
            {
                MessageBox.Show("Proverite lozinku.Uneli ste zabranjene karaktere.");
            }
            else if (!tbKorisnickoIme.Text.All(allowedchar.Contains))
            {
                MessageBox.Show("Proverite korisnicko ime.Uneli ste zabranjene karaktere.");
            }


            else
            {
                string res = "";
                if (cbM.Checked)
                    res = "M";
                else
                    res = "Ž";
                try
                {
                    Bazaa.dodavanjeRadnika(tbIme.Text, tbPrezime.Text, tbbrTel.Text, tbadresa.Text, tbemail.Text, tbJMBG.Text, res, txtLozinka.Text, tbKorisnickoIme.Text);
                    MessageBox.Show("Uspešno");
                }
                catch 
                {
                    MessageBox.Show("Radnik već postoji!");
                }
            }
        }      
        private void btnObrisi_Click(object sender, EventArgs e)
        {
            DialogResult Izlaz;
            Izlaz = MessageBox.Show("Da li želite da izbrišete člana?", "Izlaz", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (Izlaz == DialogResult.Yes)
            {
                try
                {
                    Bazaa.brisanjeRadnika(tbJMBG.Text, tbIme.Text, tbPrezime.Text);
                    MessageBox.Show("Uspešno");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    
        private void btnAzuriranje_Click(object sender, EventArgs e)
        {
            if (tbbrTel.Text == "" || tbadresa.Text == "" || tbemail.Text == "" || tbJMBG.Text == "")
            {
                MessageBox.Show("Morate uneti broj telefona, adresu i email.");
            }
            else
            {
                try
                {
                   Bazaa.azuriranjeRadnika(tbbrTel.Text, tbadresa.Text,tbemail.Text, tbJMBG.Text);
                   MessageBox.Show("Uspešno");
                }
                 catch (Exception ex)
                 {
                      MessageBox.Show(ex.Message);
                 }
           } 
        }

        private void radniciBox_Click(object sender, EventArgs e)
        {
            osoba o = new osoba();
            DataTable dt = Bazaa.radniciBox(o);
            if (dt.Rows.Count > 0)
            {
                tbIme.Text = dt.Rows[0][0].ToString();
                tbPrezime.Text = dt.Rows[0][1].ToString();
                tbbrTel.Text = dt.Rows[0][2].ToString();
                tbadresa.Text = dt.Rows[0][3].ToString();
                tbemail.Text = dt.Rows[0][4].ToString();
                tbJMBG.Text = dt.Rows[0][6].ToString();

            }
            else
            {
                MessageBox.Show("Proverite JMBG");
            }
        }

        private void radniciBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           var izabran = radniciBox.SelectedItem.ToString();
            string[] unosi = izabran.Split(' ');
            var jmbg = unosi[0];
           var ime = unosi[1];
            var prezime = unosi[2];
            var email = unosi[3];
            var pol = unosi[4];
            var adresa1 = unosi[5];
            var adresa2 = unosi[6];
            var brojt = unosi[7];
            var adresa = adresa1 + " " + adresa2;

            tbIme.Text = ime;
            tbPrezime.Text = prezime;
            tbemail.Text = email;
            tbbrTel.Text = brojt;
            tbadresa.Text = adresa;
            tbJMBG.Text = jmbg; 
        }

        private void btnocisti_Click(object sender, EventArgs e)
        {     
            tbIme.Text = "";
            tbPrezime.Text = "";
            tbKorisnickoIme.Text = "";
            tbJMBG.Text = "";
            tbemail.Text = "";
            tbbrTel.Text = "";
            tbadresa.Text = "";
        }

        private void txtLozinka_KeyPress(object sender, KeyPressEventArgs e)
        {
         
          //  e.Handled = !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar);
        
    }

       
    }
}
