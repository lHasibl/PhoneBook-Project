using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phonebook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            register_data rd = new register_data();
            rd.MdiParent = this;
            rd.Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            search_data rd = new search_data();
            rd.MdiParent = this;
            rd.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            about_us rd = new about_us();
            rd.MdiParent = this;
            rd.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.process1.StartInfo.FileName = "C:\\Windows\\System32\\calc.exe";
            this.process1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.F1)
            {
                toolStripButton1_Click(sender, e);
                return;
            }
            if (e.KeyCode == Keys.F2)
            {
                toolStripButton2_Click(sender, e);
                return;
            }
            if (e.KeyCode == Keys.F3)
            {
                toolStripButton3_Click(sender, e);
                return;
            }
            if (e.KeyCode == Keys.F4)
            {
                toolStripButton4_Click(sender, e);
                return;
            }
            if (e.KeyCode == Keys.Escape)
            {
                toolStripButton5_Click(sender, e);
                return;
            }
            
        }
    }
}
