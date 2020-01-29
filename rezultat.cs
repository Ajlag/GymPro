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
    public partial class rezultat : UserControl
    {
        string visina_old, tezina_old, ruke_old, noge_old, struk_old;
        string vremeUnosa_old_string;

     
        public rezultat()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            textBox1.Text = DateTime.Now.ToString("MM/dd/yyyy  HH:mm:ss");
            listBox1.DataSource = Bazaa.popunitabeluRezultati();
            popuniTabelu1();
        }

        private void popuniTabelu1()
        {
            var clanovi = new List<string>();
            tbImeiPrezime.DataSource = Bazaa.popunitabeluNaplata();
        }

        private void btnOcisti_Click(object sender, EventArgs e)
        {
            tbImeiPrezime.Text = "";
            tbnoge.Text = "";
            tbruke.Text = "";
            tbstruk.Text = "";
            tbvisina.Text = "";
            txtTezina.Text = "";
            jmbg.Text = "";
            textBox1.Text = "";
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            rezultati o = new rezultati();
            DataTable dt = Bazaa.listBox1(o);
            if (dt.Rows.Count > 0)
            {
                tbImeiPrezime.Text = dt.Rows[0][0].ToString();
                tbvisina.Text = dt.Rows[0][2].ToString();
                txtTezina.Text = dt.Rows[0][3].ToString();
                tbruke.Text = dt.Rows[0][4].ToString();
                tbnoge.Text = dt.Rows[0][6].ToString();
                tbstruk.Text = dt.Rows[0][7].ToString();
                jmbg.Text = dt.Rows[0][8].ToString();
                textBox1.Text = dt.Rows[0][9].ToString();

            }
            else
            {
                MessageBox.Show("Proverite JMBG");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {          
            try
            {

                String vr_new = DateTime.Now.ToString("dd MMMM yyyy HH:mm");
                Bazaa.dodavanjeRezultat(tbImeiPrezime.Text,tbvisina.Text, txtTezina.Text, tbruke.Text, tbnoge.Text, jmbg.Text, tbstruk.Text, vr_new, '0', '0', '0', '0', '0', "0");
                MessageBox.Show("Uspešno!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            rezultati r = new rezultati();
            DataTable dt = Bazaa.azuriranjeRezultata(jmbg.Text);

            if (dt.Rows.Count > 0)
            {
                visina_old = dt.Rows[0][0].ToString();
                tezina_old = dt.Rows[0][1].ToString();
                ruke_old = dt.Rows[0][2].ToString();
                noge_old = dt.Rows[0][3].ToString();
                struk_old = dt.Rows[0][4].ToString();
          
                vremeUnosa_old_string = dt.Rows[0][11].ToString();
            }
            else
            {
                MessageBox.Show("Proverite JMBG");
            }

            try
            {
                Bazaa.azuriranjeRezultata1(visina_old, tezina_old, ruke_old, noge_old, struk_old, vremeUnosa_old_string, jmbg.Text);

                MessageBox.Show("Uspesno");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                string vr = DateTime.Now.ToString("MM/dd/yyyy  HH:mm:ss");
                Bazaa.azuriranjeRezultata2(tbImeiPrezime.Text, vr, tbvisina.Text, txtTezina.Text, tbruke.Text, tbnoge.Text, tbstruk.Text, jmbg.Text);

                MessageBox.Show("Uspesno");
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var izabran = listBox1.SelectedItem.ToString();
            string[] unosi = izabran.Split(' ');
            var ime = unosi[0];
            var prezime = unosi[1];
            var imeiprezime = ime + " " + prezime;
            var visina = unosi[2];
            var tezina = unosi[3];
            var ruke = unosi[4];
            var noge = unosi[5];
            var struk = unosi[6];
            var jmbg11 = unosi[7];
            var vrUnosa1 = unosi[8];
        //   var vrUnosa2 = unosi[9];
            var vrUnosa = vrUnosa1 ;

            tbImeiPrezime.Text = imeiprezime;
            tbvisina.Text = visina;
            txtTezina.Text = tezina;
            tbruke.Text = ruke;
            tbnoge.Text = noge;
            tbstruk.Text = struk;
            jmbg.Text = jmbg11;
            textBox1.Text = vrUnosa;
        }     
    }
}
