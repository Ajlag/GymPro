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
    public partial class cenovnikk : UserControl
    {
        GymNEntities1 vezasaBazom;
        string vr_old = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss ");
        public cenovnikk()
        {
            InitializeComponent();
            vezasaBazom = new GymNEntities1();
            var sve = vezasaBazom.cenovniks.ToList();
            var napisi = sve.ElementAt(0).poslednjePromene;
            textBox5.Text = napisi;
        }
      
        private void cenovnikk_Load(object sender, EventArgs e)
        {
            DataTable dt = Bazaa.selectCene();
            if (dt.Rows.Count > 0)
            {
                textBox1.Text = dt.Rows[0][0].ToString();
                textBox2.Text = dt.Rows[1][0].ToString();
                textBox3.Text = dt.Rows[2][0].ToString();
                textBox4.Text = dt.Rows[3][0].ToString();
            }
            else
            {
                MessageBox.Show("Proverite");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
              
                String vr_new = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm");
                vr_old = vr_new;
                Bazaa.Promenicene(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text), int.Parse(textBox4.Text), vr_new);
                MessageBox.Show("Uspesno");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
