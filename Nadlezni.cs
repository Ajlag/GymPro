using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GYM
{
    public partial class Nadlezni : Form
    {
        public Nadlezni()
        {
            InitializeComponent();
        }

        private void Nadlezni_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("MM/dd/yyyy");
        }

        private void radniciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            radnici rad = new radnici();
            rad.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(rad);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult Izlaz;
            Izlaz = MessageBox.Show("Da li zelite da se odjavite?", "Izlaz", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (Izlaz == DialogResult.Yes)
            {
                this.Hide();
                Form1 frm1 = new Form1();
                frm1.ShowDialog();
            }
        }

        
    }
}
