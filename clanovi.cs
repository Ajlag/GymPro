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

namespace GYM
{
    public partial class clanovi : UserControl
    {
        GymNEntities1 vezasaBazom;
        public clanovi()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            vezasaBazom = new GymNEntities1();
            popuniTabelu();

        }

        private void popuniTabelu()
        {

            var clanovi = new List<string>();
          LBoxPrikazi.DataSource = Bazaa.popunitabeluClanovi();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (tbIme.Text == "" || tbPrezime.Text == "" || tbbrTelefona.Text == "" || tbAdresa.Text == "" || tbemail.Text == "" || tbJMBG.Text == "")
            {
                MessageBox.Show("Morate popuniti sva polja!");
            }
            else
            {                             
                    string res = "";
                    if (rbM.Checked)
                        res = "M";
                    else
                        res = "Ž";
                try
                {
                    var datumRodj = dtpdatumrodj.Value.ToString("dd/MM/yyyy");
                    var datumUpisa = dtpdatumup.Value.ToString("dd/MM/yyyy");
                    Bazaa.dodavanjeClanova(tbIme.Text, tbPrezime.Text, tbbrTelefona.Text, tbAdresa.Text, tbemail.Text, tbJMBG.Text, res, datumRodj, datumUpisa);
                    MessageBox.Show("Uspešno");

                }
                catch
                {
                    MessageBox.Show("Član već postoji!");
                }

            }
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            try
            {
                Bazaa.azuriranjeClanova(tbbrTelefona.Text, tbAdresa.Text, tbemail.Text, tbJMBG.Text, dtpdatumup.Text);
                MessageBox.Show("Uspešno");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                    Bazaa.brisanjeClanova(tbJMBG.Text, tbIme.Text, tbPrezime.Text);
                    MessageBox.Show("Uspešno");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbPretraga.Text == "")
                {
                    MessageBox.Show("Unesite ime i prezime za pretragu");

                }
                else
                {
                    var imee = "";
                    var prezimee = "";
                    var uneto = "";
                    var uneseno = tbPretraga.Text;
                    try
                    {
                        string[] unosi = uneseno.Split(' ');
                        imee = unosi[0];
                        prezimee = unosi[1];
                    }
                    catch
                    {
                        uneto = tbPretraga.Text;
                    }
                    var osobe = vezasaBazom.osobas.ToList();
                    var clanovi = vezasaBazom.clans.ToList();
                    var lista = new List<string>();
                    var trazena = " ";
                    foreach (var osoba in osobe)
                    {
                        foreach (var clan in clanovi)
                        {
                            if ((osoba.Ime == uneto && osoba.JMBG == clan.IDClana) || (osoba.Prezime == uneto && osoba.JMBG == clan.IDClana) || (osoba.Ime == imee && osoba.Prezime == prezimee && osoba.JMBG == clan.IDClana))
                            {
                                trazena = osoba.Ime + " " + osoba.Prezime + " " + osoba.brTelefona + " " + osoba.adresa + " " + osoba.email + " " + osoba.pol + " " + clan.datumRodj + " " + clan.datumUpisa + " " + osoba.JMBG;
                                lista.Add(trazena);
                            }
                            
                        }
                    }
                    LBoxPrikazi.DataSource = lista;
                }          
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void LBoxPrikazi_Click(object sender, EventArgs e)
        {
            osoba o = new osoba();
            DataTable dt = Bazaa.radniciBox(o);
            if (dt.Rows.Count > 0)
            {
                tbIme.Text = dt.Rows[0][0].ToString();
                tbPrezime.Text = dt.Rows[0][1].ToString();
                tbbrTelefona.Text = dt.Rows[0][2].ToString();
                tbAdresa.Text = dt.Rows[0][3].ToString();
                tbemail.Text = dt.Rows[0][4].ToString();
                tbJMBG.Text = dt.Rows[0][6].ToString();

            }
            else
            {
                MessageBox.Show("Proverite JMBG");
            }         
        }

        private void LBoxPrikazi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LBoxPrikazi.SelectedItem == null)
            {
                return;
            }
            else
            {
                var izabran = LBoxPrikazi.SelectedItem.ToString();
                string[] unosi = izabran.Split(' ');
                var ime = unosi[0];
                var prezime = unosi[1];
                var brojt = unosi[2];
                var adresa1 = unosi[3];
                var adresa2 = unosi[4];
                var email = unosi[5];
                var pol = unosi[6];
                var jmbg = unosi[9];
                var adresa = adresa1 + " " + adresa2;


                tbIme.Text = ime;
                tbPrezime.Text = prezime;
                tbemail.Text = email;
                tbbrTelefona.Text = brojt;
                tbAdresa.Text = adresa;
                tbJMBG.Text = jmbg;
            }
        }
        private void brnocisti_Click(object sender, EventArgs e)
        {
            tbIme.Text = "";
            tbPrezime.Text = "";
            tbJMBG.Text = "";
            tbemail.Text = "";
            tbbrTelefona.Text = "";
            tbAdresa.Text = "";
        }

       
    }
}
