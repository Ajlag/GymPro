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
    public partial class terminn : UserControl
    {
      
        public terminn()
        {
            InitializeComponent();
            popuniTabelu();
            this.Dock = DockStyle.Fill;
            popuniTabelu1();
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
           

            dateTimePicker1.CustomFormat = "yyyy MM dd";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            cbVreme.Items.Add(cbVreme);
            cbTip.Items.Add(cbTip);
          
            try
            {
                    Bazaa.zauzmiTermin(dateTimePicker1.Text, cbVreme.Text, cbTip.Text, comboBox1.Text);
                    MessageBox.Show("Uspešno");
                
                  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void popuniTabelu()
        {
            var termini = Bazaa.popuniTabelutermin();
            dtgwPrikazTermina.DataSource = null;
            dtgwPrikazTermina.DataSource = termini;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = DateTime.Today;
        }
        private void popuniTabelu1()
        {     
            var clanovi = new List<string>();
            comboBox1.DataSource = Bazaa.popunitabeluNaplata(); 
        }
    }
}
