using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GYM
{
    public partial class Radnik : Form
    {
       
        public Radnik()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
         
        }

        private void clanoviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clanovi cl = new clanovi();
            cl.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(cl);
        }

     

        private void cenovnikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cenovnikk cn = new cenovnikk();
            cn.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(cn);
        }

        private void terminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            terminn tr = new terminn();
            tr.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(tr);
        }

        private void rezultatiToolStripMenuItem_Click(object sender, EventArgs e)
        {

            rezultat rz = new rezultat();
            rz.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(rz);
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
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

        private void naplataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            naplata npl = new naplata();     
            npl.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(npl);
        }

        private void statistikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statistikaa st = new statistikaa();
            st.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(st);
        }

        private void arhivaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            arhiva ar = new arhiva();
            ar.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(ar);
        }
    }
}
