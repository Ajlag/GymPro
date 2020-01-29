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
using System.Drawing.Printing;
using GYM.Klase;

namespace GYM
{
    public partial class naplata : UserControl
    {
        public int id;
    
        public naplata()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
         
            popuniTabelu1();
        }
        private void popuniTabelu1()
        {
           

            var clanovi = new List<string>();
            
            comboBox1.DataSource = Bazaa.popunitabeluNaplata();
        }

        //  private void button1_Click(object sender, EventArgs e)
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            

            DataTable dt = Bazaa.naplata(comboBox1.Text);
            

            string vremeDolaska = dt.Rows[0][2].ToString();
            string tiptreninga = dt.Rows[0][3].ToString();

            MessageBox.Show("Cena po terminu" +"\n"+ tiptreninga);

            vremeDolaska = vremeDolaska.Substring(0, 2);

            int vrDolaska = int.Parse(vremeDolaska.ToString());
            int razlika; 

            DateTime vrOdlaska = DateTime.Now;

            string vremeOdlaska = vrOdlaska.ToString();      
        

            var o = vrOdlaska;
            var hmo = new DateTime(o.Year, o.Month, o.Day, o.Hour, o.Minute, 0);

            razlika = o.Hour - vrDolaska;

            if(razlika < 0)
            {
                razlika = razlika + 24;
            }

            MessageBox.Show("Vreme dolaska" + "\n" + razlika);

            switch (tiptreninga)
            {
                case "Individualni mesecni trening":
                    id = 2;
                    break;
                case "Grupni mesecni trening":
                    id = 1;
                    break;
                case "Grupni trening po terminu":
                    id = 3;
                    break;
                case "Individualni trening po terminu":
                    id = 4;
                    break;
            }

            DataTable df = Bazaa.naplata1(id);

            string cena = df.Rows[0][0].ToString();
                    int cenaInt = int.Parse(df.Rows[0][0].ToString());
                    string imeiprezime = comboBox1.Text;
                            
            try
            {
                SqlConnection con = new SqlConnection("data source=DESKTOP-L1JRQG0;initial catalog=GymN;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot;");

                con.Open();              
                SqlCommand sdae = new SqlCommand("Update termin set arhivirano='1' from termin where ImeiPrezime = '" + comboBox1.Text + "' ", con);
                sdae.ExecuteNonQuery();

                PrintDocument p = new PrintDocument();
                p.PrintPage += delegate (object sender1, PrintPageEventArgs e1)
                {
                    e1.Graphics.DrawString("Ime: " + imeiprezime + "\n" +"Tip treninga: " + tiptreninga + "\n" + " Cena: " + cena +"\n" + "Vreme dolaska:" + vrDolaska, new Font("Times New Roman", 12), new SolidBrush(Color.Black), new RectangleF(0, 0, p.DefaultPageSettings.PrintableArea.Width, p.DefaultPageSettings.PrintableArea.Height));
                };
                try
                {
                    p.Print();
                }
                catch (Exception ex)
                {
                    throw new Exception("Exception Occured While Printing", ex);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Exception Occured While Printing", ex);
            }         
        }

       

      //  }
    }
}
