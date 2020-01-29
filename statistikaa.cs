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
    public partial class statistikaa : UserControl
    {
        public int visina_old, tezina_old, ruke_old, noge_old, struk_old, tezina_ova_int_grafik, struk_ova_int_grafik, visina_ova_int_grafik, ruke_ova_int_grafik, noge_ova_int_grafik, i;
        public int visina_epic, tezina_epic, ruke_epic, noge_epic, struk_epic;
        public string vremeUnosa_old_string;
        public string vremeUnosa_new;
        public string visina_temp, tezina_temp, ruke_temp, noge_temp, struk_temp, jmbg_temp;

        public string vremeUnosa_epic_string;
        string vr_old = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss ");

        public statistikaa()
        {
            InitializeComponent();
            popuniTabelu1();
            vremeUnosa.Text = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss ");
            i = 0;
        }

        private void popuniTabelu1()
        {
            var clanovi = new List<string>();
            comboBox1.DataSource = Bazaa.popunitabeluStatistiku();
        }
        private void button1_Click(object sender, EventArgs e)
        {
         
            SqlConnection con = new SqlConnection("data source=DESKTOP-L1JRQG0;initial catalog=GymN;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot;");
            SqlDataAdapter sda = new SqlDataAdapter("Select * From rezultati where ime='" + comboBox1.Text + "' ;", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                visina.Text = dt.Rows[0][0].ToString();
                tezina.Text = dt.Rows[0][1].ToString();
                ruke.Text = dt.Rows[0][2].ToString();
                noge.Text = dt.Rows[0][3].ToString();
                struk.Text = dt.Rows[0][4].ToString();
                jmbg.Text = dt.Rows[0][5].ToString();
                vremeUnosa_old_string = dt.Rows[0][11].ToString();



                //ove koristiti za grafik
                visina_epic = int.Parse(dt.Rows[0][6].ToString());
                tezina_epic = int.Parse(dt.Rows[0][7].ToString());
                ruke_epic = int.Parse(dt.Rows[0][8].ToString());
                noge_epic = int.Parse(dt.Rows[0][9].ToString());
                struk_epic = int.Parse(dt.Rows[0][10].ToString());
                vremeUnosa_epic_string = dt.Rows[0][12].ToString();
            }
            else
            {
                MessageBox.Show("Proverite JMBG");
            }

            //ove koristiti za grafik
            visina_old = int.Parse(visina.Text);
            tezina_old = int.Parse(tezina.Text);
            ruke_old = int.Parse(ruke.Text);
            noge_old = int.Parse(noge.Text);
            struk_old = int.Parse(struk.Text);

            try
            {
                con.Open();
                SqlCommand sdaa = new SqlCommand("Update rezultati set visina_epic ='" + visina.Text + "', tezina_epic ='" + tezina.Text + "', ruke_epic='" + ruke.Text + "', noge_epic ='" + noge.Text + "', struk_epic='" + struk.Text + "',vremeUnosa_epic='" + vremeUnosa_old_string + "' where JMBG1='" + jmbg.Text + "';", con);
                sdaa.ExecuteNonQuery();
                MessageBox.Show("Uspesno");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string visina_new, tezina_new, ruke_new, noge_new, struk_new;

            SqlConnection con = new SqlConnection("data source=DESKTOP-L1JRQG0;initial catalog=GymN;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot;");
            SqlDataAdapter sda = new SqlDataAdapter("Select * From rezultati where ime='" + comboBox1.Text + "' ;", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                visina_temp = dt.Rows[0][0].ToString();
                tezina_temp = dt.Rows[0][1].ToString();
                ruke_temp = dt.Rows[0][2].ToString();
                noge_temp = dt.Rows[0][3].ToString();
                struk_temp = dt.Rows[0][4].ToString();
                jmbg_temp = dt.Rows[0][5].ToString();
                vremeUnosa_old_string = dt.Rows[0][11].ToString();

                //ove koristiti za grafik
                visina_epic = int.Parse(dt.Rows[0][6].ToString());
                tezina_epic = int.Parse(dt.Rows[0][7].ToString());
                ruke_epic = int.Parse(dt.Rows[0][8].ToString());
                noge_epic = int.Parse(dt.Rows[0][9].ToString());
                struk_epic = int.Parse(dt.Rows[0][10].ToString());
                vremeUnosa_epic_string = dt.Rows[0][12].ToString();
            }
            else
            {
                MessageBox.Show("Proverite JMBG");
            }

            //ove koristiti za grafik
            visina_old = int.Parse(visina_temp);
            tezina_old = int.Parse(tezina_temp);
            ruke_old = int.Parse(ruke_temp);
            noge_old = int.Parse(noge_temp);
            struk_old = int.Parse(struk_temp);

            try
            {
                con.Open();
                SqlCommand sdaa = new SqlCommand("Update rezultati set visina_epic ='" + visina_temp + "', tezina_epic ='" + tezina_temp + "', ruke_epic='" + ruke_temp + "', noge_epic ='" + noge_temp + "', struk_epic='" + struk_temp + "',vremeUnosa_epic='" + vremeUnosa_old_string + "' where JMBG1='" + jmbg_temp + "';", con);
                sdaa.ExecuteNonQuery();
                MessageBox.Show("Uspesno");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            visina_new = visina.Text;
            tezina_new = tezina.Text;
            ruke_new = ruke.Text;
            noge_new = noge.Text;
            struk_new = struk.Text;

            try
            {
                con.Open();
                String vr_new = DateTime.Now.ToString("MM/dd/yyyy  HH:mm:ss");
                vr_old = vr_new;
                SqlCommand sdae = new SqlCommand("Update rezultati set visina ='" + visina_new + "', tezina='" + tezina_new + "', ruke='" + ruke_new + "', noge='" + noge_new + "', struk='" + struk_new + "',vremeUnosa='" + vr_new + "' where JMBG1='" + jmbg.Text + "';", con);
                sdae.ExecuteNonQuery();

                MessageBox.Show("Uspesno");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            int visina_new_int, tezina_new_int, ruke_new_int, noge_new_int, struk_new_int;
            double visina_diff, tezina_diff, ruke_diff, noge_diff, struk_diff;
            vremeUnosa_new = DateTime.Now.ToString("MM/dd/yyyy  HH:mm:ss");



            //ovo koristiit u grafiku
            visina_new_int = int.Parse(visina.Text);
            tezina_new_int = int.Parse(tezina.Text);
            ruke_new_int = int.Parse(ruke.Text);
            noge_new_int = int.Parse(noge.Text);
            struk_new_int = int.Parse(struk.Text);

            tezina_ova_int_grafik = tezina_new_int;
            struk_ova_int_grafik = struk_new_int;
            visina_ova_int_grafik = visina_new_int;
            ruke_ova_int_grafik = ruke_new_int;
            noge_ova_int_grafik = noge_new_int;

            visina_diff = (visina_new_int - visina_old);
            visina_diff = (double)visina_diff / visina_old;
            visina_diff = visina_diff * 100;

            tezina_diff = (tezina_new_int - tezina_old);
            tezina_diff = (double)tezina_diff / tezina_old;
            tezina_diff = tezina_diff * 100;

            ruke_diff = (ruke_new_int - ruke_old);
            ruke_diff = (double)ruke_diff / ruke_old;
            ruke_diff = ruke_diff * 100;

            noge_diff = (noge_new_int - noge_old);
            noge_diff = (double)noge_diff / noge_old;
            noge_diff = noge_diff * 100;

            struk_diff = (struk_new_int - struk_old);
            struk_diff = (double)struk_diff / struk_old;
            struk_diff = struk_diff * 100;



            //ove varijable smo samo prebrisali s novim vrednostima jer nam je bilo mucno da pravimo nove sa novim imenima
            //njihova imena nemaju neko posebno znacenje!
            visina_new_int = (int)visina_diff;       //da odbacimo iza zareza
            visina_new = visina_new_int.ToString();
            label8.Text = visina_new + "%";

            tezina_new_int = (int)tezina_diff;       //da odbacimo iza zareza
            tezina_new = tezina_new_int.ToString();
            label10.Text = tezina_new + "%";

            ruke_new_int = (int)ruke_diff;       //da odbacimo iza zareza
            ruke_new = ruke_new_int.ToString();
            label11.Text = ruke_new + "%";

            noge_new_int = (int)noge_diff;       //da odbacimo iza zareza
            noge_new = noge_new_int.ToString();
            label12.Text = noge_new + "%";

            struk_new_int = (int)struk_diff;       //da odbacimo iza zareza
            struk_new = struk_new_int.ToString();
            label13.Text = struk_new + "%";

            // vremeUnosa_epic_string = vremeUnosa_epic_string.Substring(0, 10);
            //  vremeUnosa_epic_string = vremeUnosa_epic_string + "    ";
            //   vremeUnosa_old_string = vremeUnosa_old_string.Substring(0, 10);
            //   vremeUnosa_new = vremeUnosa_new.Substring(0, 10);

            if (i > 0)
            {
                chart1.Series.Clear();

                this.chart1.Series.Add("Visina");
                this.chart1.Series.Add("Tezina");
                this.chart1.Series.Add("Ruke");
                this.chart1.Series.Add("Noge");
                this.chart1.Series.Add("Struk");
            }

            if (visina_epic == 0 && tezina_epic == 0 && ruke_epic == 0 && noge_epic == 0 && struk_epic == 0)
            {

                this.chart1.Series["Visina"].Points.AddXY(vremeUnosa_old_string, visina_old);
                this.chart1.Series["Visina"].Points.AddXY(vremeUnosa_new, visina_ova_int_grafik);


                this.chart1.Series["Tezina"].Points.AddXY(vremeUnosa_old_string, tezina_old);
                this.chart1.Series["Tezina"].Points.AddXY(vremeUnosa_new, tezina_ova_int_grafik);


                this.chart1.Series["Ruke"].Points.AddXY(vremeUnosa_old_string, ruke_old);
                this.chart1.Series["Ruke"].Points.AddXY(vremeUnosa_new, ruke_ova_int_grafik);


                this.chart1.Series["Noge"].Points.AddXY(vremeUnosa_old_string, noge_old);
                this.chart1.Series["Noge"].Points.AddXY(vremeUnosa_new, noge_ova_int_grafik);


                this.chart1.Series["Struk"].Points.AddXY(vremeUnosa_old_string, struk_old);
                this.chart1.Series["Struk"].Points.AddXY(vremeUnosa_new, struk_ova_int_grafik);
            }
            else
            {
                this.chart1.Series["Visina"].Points.AddXY(vremeUnosa_epic_string, visina_epic);
                this.chart1.Series["Visina"].Points.AddXY(vremeUnosa_old_string, visina_old);
                this.chart1.Series["Visina"].Points.AddXY(vremeUnosa_new, visina_ova_int_grafik);


                this.chart1.Series["Tezina"].Points.AddXY(vremeUnosa_epic_string, tezina_epic);
                this.chart1.Series["Tezina"].Points.AddXY(vremeUnosa_old_string, tezina_old);
                this.chart1.Series["Tezina"].Points.AddXY(vremeUnosa_new, tezina_ova_int_grafik);

                this.chart1.Series["Ruke"].Points.AddXY(vremeUnosa_epic_string, ruke_epic);
                this.chart1.Series["Ruke"].Points.AddXY(vremeUnosa_old_string, ruke_old);
                this.chart1.Series["Ruke"].Points.AddXY(vremeUnosa_new, ruke_ova_int_grafik);

                this.chart1.Series["Noge"].Points.AddXY(vremeUnosa_epic_string, noge_epic);
                this.chart1.Series["Noge"].Points.AddXY(vremeUnosa_old_string, noge_old);
                this.chart1.Series["Noge"].Points.AddXY(vremeUnosa_new, noge_ova_int_grafik);


                this.chart1.Series["Struk"].Points.AddXY(vremeUnosa_epic_string, struk_epic);
                this.chart1.Series["Struk"].Points.AddXY(vremeUnosa_old_string, struk_old);
                this.chart1.Series["Struk"].Points.AddXY(vremeUnosa_new, struk_ova_int_grafik);
            }
            i++;


        }
    }
}