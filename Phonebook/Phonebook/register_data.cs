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
    public partial class register_data : Form
    {
        public register_data()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.save_Button2.Enabled = true;
            this.new_data_Button1.Enabled = false;
            this.info_groupBox1.Enabled = true;
            //-------clear--------------------
            this.id_textBox1.ResetText();
            this.fn_textBox2.ResetText();
            this.ln_textBox7.ResetText();
            this.tp_textBox6.ResetText();
            this.cn_textBox5.ResetText();
            this.address_textBox4.ResetText();
            this.comment_textBox8.ResetText();
            this.email_textBox3.ResetText();
            //---------------------------------
        }

        private void save_Button2_Click(object sender, EventArgs e)
        {
            if(this.id_textBox1.Text=="")
            {
                MessageBox.Show("Please Enter ur Valid Id!!!!!");
                return;
            }
            this.save_Button2.Enabled = false;
            this.new_data_Button1.Enabled = true;
            this.info_groupBox1.Enabled = false;
            string fn;
            fn = "F:\\STUDY\\C#\\Practice\\Section-28(phonebook project)\\save files\\";
            string p;
            //-----------------First Name---------------------------------
            p = fn + this.id_textBox1.Text + "_firstname.txt";
            System.IO.File.WriteAllText(p,this.fn_textBox2.Text, Encoding.UTF8);
            //--------------------Last name-------------------------------------
            p = fn + this.id_textBox1.Text + "_lastname.txt";
            System.IO.File.WriteAllText(p, this.ln_textBox7.Text, Encoding.UTF8);
            //--------------------Telephone-------------------------------------
            p = fn + this.id_textBox1.Text + "_Telephone.txt";
            System.IO.File.WriteAllText(p, this.tp_textBox6.Text, Encoding.UTF8);
            //--------------------cellphone-------------------------------------
            p = fn + this.id_textBox1.Text + "_cellphone.txt";
            System.IO.File.WriteAllText(p, this.cn_textBox5.Text, Encoding.UTF8);
            //--------------------Email-------------------------------------
            p = fn + this.id_textBox1.Text + "_email.txt";
            System.IO.File.WriteAllText(p, this.email_textBox3.Text, Encoding.UTF8);
            //--------------------Address-------------------------------------
            p = fn + this.id_textBox1.Text + "_address.txt";
            System.IO.File.WriteAllText(p, this.address_textBox4.Text, Encoding.UTF8);
            //--------------------Comment-------------------------------------
            p = fn + this.id_textBox1.Text + "_comment.txt";
            System.IO.File.WriteAllText(p, this.comment_textBox8.Text, Encoding.UTF8);
            //------------------------------------------------------------------------
            MessageBox.Show("Saved!!!!");
        }
    }
}
