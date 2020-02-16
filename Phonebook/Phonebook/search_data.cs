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
    public partial class search_data : Form
    {
        public search_data()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fn;
            if (this.textBox1.Text == "")
            {
                MessageBox.Show("Please Enter an Id!!!!");
                return;
            }
            fn = "F:\\STUDY\\C#\\Practice\\Section-28(phonebook project)\\save files\\";
            string p;
            string r;
            //-----------------First Name---------------------------------
            p = fn + this.textBox1.Text + "_firstname.txt";
            if (System.IO.File.Exists(p) == true)
            {
                r = System.IO.File.ReadAllText(p, Encoding.UTF8);
                this.fn_textBox2.Text = r;
            }
            //----------------last Name---------------------------------
            p = fn + this.textBox1.Text + "_lastname.txt";
            if (System.IO.File.Exists(p) == true)
            {
                r = System.IO.File.ReadAllText(p, Encoding.UTF8);
                this.ln_textBox7.Text = r;
            }
            //-----------------Telephone---------------------------------
            p = fn + this.textBox1.Text + "_Telephone.txt";
            if (System.IO.File.Exists(p) == true)
            {
                r = System.IO.File.ReadAllText(p, Encoding.UTF8);
                this.tp_textBox6.Text = r;
            }
            //-----------------Cellphone---------------------------------
            p = fn + this.textBox1.Text + "_cellphone.txt";
            if (System.IO.File.Exists(p) == true)
            {
                r = System.IO.File.ReadAllText(p, Encoding.UTF8);
                this.cn_textBox5.Text = r;
            }
            //-----------------Email---------------------------------
            p = fn + this.textBox1.Text + "_email.txt";
            if (System.IO.File.Exists(p) == true)
            {
                r = System.IO.File.ReadAllText(p, Encoding.UTF8);
                this.email_textBox3.Text = r;
            }
            //-----------------Adress---------------------------------
            p = fn + this.textBox1.Text + "_address.txt";
            if (System.IO.File.Exists(p) == true)
            {
                r = System.IO.File.ReadAllText(p, Encoding.UTF8);
                this.address_textBox4.Text = r;
            }
            //-----------------Comment---------------------------------
            p = fn + this.textBox1.Text + "_comment.txt";
            if (System.IO.File.Exists(p) == true)
            {
                r = System.IO.File.ReadAllText(p, Encoding.UTF8);
                this.comment_textBox8.Text = r;
            }
            this.id_textBox1.Text = this.textBox1.Text;
        }
    }
}
