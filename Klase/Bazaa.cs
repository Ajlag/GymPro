using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GYM.Klase
{
    class Bazaa
    {
        private static string connectionString = @"data source =DESKTOP-L1JRQG0; initial catalog = GymN; integrated security = True; MultipleActiveResultSets = True; App = EntityFramework & quot;";
        private static SqlConnection connect = new SqlConnection(connectionString);


        private static string hashLozinka(string lozinka)
        {
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                byte[] data = md5.ComputeHash(utf8.GetBytes(lozinka));
                return Convert.ToBase64String(data);
            }
        }


        public static bool ProveraKorisnika(korisnik k)
        {
            string sql = "SELECT KorisnickoIme FROM korisnik";
            SqlCommand cmd = new SqlCommand(sql, connect);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            connect.Open();
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i][0].ToString() == k.KorisnickoIme)
                {
                    connect.Close();
                    return true;
                }
            }
            connect.Close();
            return false;
        }

        public static DataTable UlogujNadleznog(korisnik k)
        {
            DataTable dt = new DataTable();
            string sql = "SELECT * FROM korisnik WHERE KorisnickoIme = @KorisnickoIme AND sifra = @sifra and tip='N'";
            SqlCommand cmd = new SqlCommand(sql, connect);
            cmd.Parameters.AddWithValue("@KorisnickoIme", k.KorisnickoIme);
            cmd.Parameters.AddWithValue("@sifra", k.sifra);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            connect.Open();
            adapter.Fill(dt);
            connect.Close();

            return dt;
        }
        public static DataTable UlogujRadnika(korisnik k)
        {
            DataTable dt = new DataTable();
            string sql = "SELECT * FROM korisnik WHERE KorisnickoIme = @KorisnickoIme AND sifra = @sifra and tip='R'";
            SqlCommand cmd = new SqlCommand(sql, connect);
            cmd.Parameters.AddWithValue("@KorisnickoIme", k.KorisnickoIme);
            cmd.Parameters.AddWithValue("@sifra", k.sifra);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            connect.Open();
            adapter.Fill(dt);
            connect.Close();

            return dt;
        }

        public static List<osoba> vratiPodatkeRadnici()
        {
            GymNEntities1 vezasaBazom = new GymNEntities1();
            var radnici = new List<osoba>();
            List<osoba> lista = vezasaBazom.osobas.ToList();
            List<korisnik> lista2 = vezasaBazom.korisniks.Where(t => t.tip == "R").ToList();

            foreach (var osoba in lista)
            {
                foreach (var kor in lista2)
                {
                    if (osoba.JMBG == kor.IDKorisnika)
                    {
                        radnici.Add(osoba);
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            return radnici;
        }

        public static void dodavanjeRadnika(string tbIme, string tbPrezime, string tbbrTel, string tbadresa, string tbemail, string tbJMBG, string res, string txtLozinka, string tbKorisnickoIme)
        {
            connect.Open();
            SqlCommand sda = new SqlCommand("Insert into osoba (Ime,Prezime,brTelefona,adresa,email,JMBG,pol) values('" + tbIme + "','" + tbPrezime + "','" + tbbrTel + "','" + tbadresa + "','" + tbemail + "','" + tbJMBG + "','" + res + "'); INSERT INTO korisnik( IDkorisnika,sifra,KorisnickoIme,tip) values('" + tbJMBG + "','" + txtLozinka + "','" + tbKorisnickoIme + "','R');", connect);
            sda.ExecuteNonQuery();
            connect.Close();
        }
        public static void brisanjeRadnika(string tbJMBG, string tbIme, string tbPrezime)
        {
            connect.Open();
            SqlCommand sda = new SqlCommand("DELETE FROM korisnik where IDKorisnika='" + tbJMBG + "';Delete from  osoba where Ime='" + tbIme + "' and Prezime='" + tbPrezime + "' and JMBG='" + tbJMBG + "'", connect);
            sda.ExecuteNonQuery();
            connect.Close();
        }

        public static void azuriranjeRadnika(string tbbrTel, string tbadresa, string tbemail, string tbJMBG)
        {
            connect.Open();
            SqlCommand sda = new SqlCommand("UPDATE osoba SET brTelefona='" + tbbrTel + "',adresa='" + tbadresa + "',email='" + tbemail + "' WHERE JMBG='" + tbJMBG + "';", connect);
            sda.ExecuteNonQuery();
            connect.Close();
        }

        public static DataTable radniciBox(osoba o)
        {
            connect.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select * From osoba;", connect);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            connect.Close();
            return dt;
        }

        public static void dodavanjeClanova(string tbIme, string tbPrezime, string tbbrTelefona, string tbAdresa, string tbemail, string tbJMBG, string res, string dtpdatumrodj, string dtpdatumup)
        {
            connect.Open();
            SqlCommand sda = new SqlCommand("Insert into osoba (Ime,Prezime,brTelefona,adresa,email,JMBG,pol) values('" + tbIme + "','" + tbPrezime + "','" + tbbrTelefona + "','" + tbAdresa + "','" + tbemail + "','" + tbJMBG + "','" + res + "'); INSERT INTO clan( IDclana,datumRodj,datumUpisa) values('" + tbJMBG + "','" + dtpdatumrodj + "','" + dtpdatumup + "');", connect);
            sda.ExecuteNonQuery();
            connect.Close();
        }
        public static void azuriranjeClanova(string tbbrTelefona, string tbAdresa, string tbemail, string tbJMBG, string dtpdatumup)
        {
            connect.Open();
            SqlCommand sda = new SqlCommand("UPDATE osoba SET  brTelefona='" + tbbrTelefona + "',adresa='" + tbAdresa + "',email='" + tbemail + "' WHERE JMBG='" + tbJMBG + "'; UPDATE clan SET  datumUpisa='" + dtpdatumup + "' WHERE IDClana='" + tbJMBG + "'", connect);
            sda.ExecuteNonQuery();
            connect.Close();
        }
        public static void brisanjeClanova(string tbJMBG, string tbIme, string tbPrezime)
        {
            connect.Open();
            SqlCommand sda = new SqlCommand("DELETE FROM rezultati where JMBG1='" + tbJMBG + "';DELETE FROM clan where IDClana='" + tbJMBG + "';Delete from  osoba where Ime='" + tbIme + "' and Prezime='" + tbPrezime + "' and JMBG='" + tbJMBG + "'", connect);
            sda.ExecuteNonQuery();
            connect.Close();
        }

        public static DataTable LBoxClanovi(osoba o)
        {
            connect.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select * From osoba;", connect);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            connect.Close();
            return dt;
        }
        public static void zauzmiTermin(string dateTimePicker1, string cbVreme, string cbTip, string comboBox1)
        {
            connect.Open();
            SqlCommand sda = new SqlCommand("INSERT INTO termin  (datum, vreme, Tiptreninga,ImeiPrezime,arhivirano) VALUES ('" + dateTimePicker1 + "', '" + cbVreme + "','" + cbTip + "', '" + comboBox1 + "', '0'); ", connect);
            sda.ExecuteNonQuery();
            connect.Close();
        }
        public static List<termin> popuniTabelutermin()
        {
            GymNEntities1 vezasaBazom = new GymNEntities1();
            List<termin> termini = vezasaBazom.termins.Where(t => t.arhivirano == 0).ToList();
            return termini;
        }
        public static List<termin> popuniTabeluarhiva()
        {
            GymNEntities1 vezasaBazom = new GymNEntities1();
            List<termin> termini = vezasaBazom.termins.Where(t => t.arhivirano == 1).ToList();
            return termini;
        }


        public static void dodavanjeRezultat(string tbIme, string tbvisina, string tbtezina, string tbruke, string tbnoge, string tbJMBG, string tbstruk, string vremeUnosa, float visina_epic, float tezina_epic, float ruke_epic, float noge_epic, float struk_epic, string vremeUnosa_epic)
        {
            connect.Open();
            SqlCommand sda = new SqlCommand("Insert into rezultati (ime,visina,tezina,ruke,noge,JMBG1,struk, vremeUnosa, visina_epic,tezina_epic, ruke_epic, noge_epic, struk_epic, vremeUnosa_epic) values('" + tbIme + "','" + tbvisina + "','" + tbtezina + "','" + tbruke + "','" + tbnoge + "','" + tbJMBG + "','" + tbstruk + "' , '" + vremeUnosa + "','" + visina_epic + "','" + tezina_epic + "','" + ruke_epic + "','" + noge_epic + "','" + struk_epic + "','" + vremeUnosa_epic + "') ;", connect);
            sda.ExecuteNonQuery();
            connect.Close();
        }

        public static DataTable listBox1(rezultati o)
        {
            connect.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select * From rezultati;", connect);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            connect.Close();
            return dt;
        }
        private static bool proveraKorisnikaZaReset(korisnik k)
        {
            connect.Open();
            string sql = "SELECT * FROM korisnik WHERE KorisnickoIme = @KorisnickoIme AND sifra = @sifra";
            SqlCommand cmd = new SqlCommand(sql, connect);
            cmd.Parameters.AddWithValue("@KorisnickoIme", k.KorisnickoIme);
            cmd.Parameters.AddWithValue("@sifra", k.sifra);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                connect.Close();
                return true;
            }
            else
            {
                connect.Close();
                return false;
            }
        }
        public static bool resetLozinku(korisnik k, string novasifra)
        {
            if (proveraKorisnikaZaReset(k))
            {
                string sql = "UPDATE korisnik SET [sifra] = @sifra WHERE [KorisnickoIme] = @KorisnickoIme";
                SqlCommand cmd = new SqlCommand(sql, connect);
                cmd.Parameters.Add("@sifra", SqlDbType.Char).Value = novasifra;
                cmd.Parameters.Add("@KorisnickoIme", SqlDbType.Char).Value = k.KorisnickoIme;

                connect.Open();

                int rows = cmd.ExecuteNonQuery();

                connect.Close();

                if (rows > 0)
                    return true;
                return false;
            }
            else return false;
        }
        public static DataTable naplata(termin t, string comboBox1)
        {
            connect.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select * From termin where ImeiPrezime =  '" + comboBox1 + "';", connect);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            connect.Close();
            return dt;
        }

        public static List<string> popunitabeluClanovi()
        {
            GymNEntities1 vezasaBazom = new GymNEntities1();
            string prikazati;
            List<osoba> lista = vezasaBazom.osobas.ToList();
            List<clan> lista2 = vezasaBazom.clans.ToList();
            List<string> zaPrikaz = new List<string>();

            foreach (var osoba in lista)
            {
                foreach (var cl in lista2)
                {
                    if (osoba.JMBG == cl.IDClana)
                    {
                        prikazati = osoba.Ime + " " + osoba.Prezime + " " + osoba.brTelefona + " " + osoba.adresa + " " + osoba.email + " " + osoba.pol + " " + cl.datumRodj + " " + cl.datumUpisa + " " + osoba.JMBG;

                        zaPrikaz.Add(prikazati);

                    }

                    else
                    {
                        continue;
                    }
                }
            }
            return zaPrikaz;
        }
        public static void Promenicene(int cena1, int cena2, int cena3, int cena4, string poslednjePromene)
        {

            connect.Open();
            SqlCommand sda = new SqlCommand("Update cenovnik set cena =" + cena1 + " where tip = 'MG';Update cenovnik set cena =" + cena2 + " where tip= 'MI';Update cenovnik set cena =" + cena3 + " where tip= 'GT'; Update cenovnik set cena =" + cena4 + " where tip= 'IT'; Update cenovnik set poslednjePromene='" + poslednjePromene + "';", connect);

            sda.ExecuteNonQuery();
            connect.Close();


        }
        public static DataTable selectCene()
        {
            connect.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select * From cenovnik ;", connect);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            connect.Close();
            return dt;
        }

        public static DataTable naplata(string comboBox1)
        {
            connect.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select * From termin where ImeiPrezime =  '" + comboBox1 + "';", connect);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            connect.Close();
            return dt;
        }
        public static DataTable naplata1(int id)
        {
            connect.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select * From cenovnik where IDcena = '" + id + "';", connect);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            connect.Close();
            return dt;
        }
        public static DataTable azuriranjeRezultata(string jmbg)
        {
            connect.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select * From rezultati where JMBG1='" + jmbg + "' ;", connect);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            connect.Close();
            return dt;
        }
        public static void azuriranjeRezultata1(string visina_old, string tezina_old, string ruke_old, string noge_old, string struk_old, string vremeUnosa_old_string, string jmbg)
        {
            connect.Open();
            SqlCommand sda = new SqlCommand("Update rezultati set visina_epic ='" + visina_old + "', tezina_epic ='" + tezina_old + "', ruke_epic='" + ruke_old + "', noge_epic ='" + noge_old + "', struk_epic='" + struk_old + "',vremeUnosa_epic='" + vremeUnosa_old_string + "' where JMBG1='" + jmbg + "';", connect);
            sda.ExecuteNonQuery();
            connect.Close();
        }
        public static void azuriranjeRezultata2(string tbImeiPrezime, string vr, string tbvisina, string txtTezina, string tbruke, string tbnoge, string tbstruk, string jmbg)
        {
            connect.Open();
            SqlCommand sda = new SqlCommand("Update rezultati set ime='" + tbImeiPrezime + "', vremeUnosa ='" + vr + "', visina='" + tbvisina + "', tezina='" + txtTezina + "', ruke='" + tbruke + "', noge='" + tbnoge + "', struk='" + tbstruk + "' WHERE JMBG1='" + jmbg + "'", connect);
            sda.ExecuteNonQuery();
            connect.Close();
        }
        public static List<string> popunitabeluNaplata()
        {
            GymNEntities1 vezasaBazom = new GymNEntities1();
            string prikazati;
            List<osoba> lista = vezasaBazom.osobas.ToList();
            List<clan> lista2 = vezasaBazom.clans.ToList();
            List<string> zaPrikaz = new List<string>();

            foreach (var osoba in lista)
            {
                foreach (var cl in lista2)
                {
                    if (osoba.JMBG == cl.IDClana)
                    {
                        prikazati = osoba.Ime + " " + osoba.Prezime;
                        zaPrikaz.Add(prikazati);
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            return zaPrikaz;
        }

        public static List<string> popunitabeluRezultati()
        {
            GymNEntities1 vezasaBazom = new GymNEntities1();
            string prikazati;
            List<rezultati> lista = vezasaBazom.rezultatis.ToList();
            List<string> zaPrikaz = new List<string>();
            foreach (var cl in lista)
            {

                prikazati = cl.ime + " " + cl.visina + " " + cl.tezina + " " + cl.ruke + " " + cl.noge + " " + cl.struk + " " + cl.JMBG1 + " " + cl.vremeUnosa;

                zaPrikaz.Add(prikazati);
            }
            return zaPrikaz;
        }
        public static List<string> popunitabeluStatistiku()
        {
            GymNEntities1 vezasaBazom = new GymNEntities1();
            string prikazati;
            List<osoba> lista = vezasaBazom.osobas.ToList();
            List<clan> lista2 = vezasaBazom.clans.ToList();
            List<string> zaPrikaz = new List<string>();

            foreach (var osoba in lista)
            {
                foreach (var cl in lista2)
                {
                    if (osoba.JMBG == cl.IDClana)
                    {
                        prikazati = osoba.Ime + " " + osoba.Prezime;
                        zaPrikaz.Add(prikazati);

                    }
                    else
                    {
                        continue;
                    }
                }
            }
            return zaPrikaz;
        }
        public static DataTable pretraziStatistika(string comboBox1)
        {
            connect.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select * From rezultati where ime='" + comboBox1 + "' ;", connect);
            DataTable dt = new DataTable();
            sda.Fill(dt); ;
            connect.Close();
            return dt;
        }
        public static void pretraziAzurStatistika(string visina, string tezina, string ruke, string noge, string struk, string vremeUnosa_old_string, string jmbg)
        {
            connect.Open();
            SqlCommand sdaa = new SqlCommand("Update rezultati set visina_epic ='" + visina + "', tezina_epic ='" + tezina + "', ruke_epic='" + ruke + "', noge_epic ='" + noge + "', struk_epic='" + struk + "',vremeUnosa_epic='" + vremeUnosa_old_string + "' where JMBG1='" + jmbg + "';", connect);
            sdaa.ExecuteNonQuery();
            connect.Open();
        }
        public static void azurirajStatistika(string visina_new, string tezina_new, string ruke_new, string noge_new, string struk_new, string vr_new, string jmbg)
        {
            connect.Open();
            SqlCommand sda = new SqlCommand("Update rezultati set visina ='" + visina_new + "', tezina='" + tezina_new + "', ruke='" + ruke_new + "', noge='" + noge_new + "', struk='" + struk_new + "',vremeUnosa='" + vr_new + "' where JMBG1='" + jmbg + "';", connect);
            sda.ExecuteNonQuery();
            connect.Close();
        }


     
        
    }
}


