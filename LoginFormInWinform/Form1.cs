using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginFormInWinform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user, password;
            user = textBox1.Text;
            password = textBox2.Text;
            if (user=="Maddineni"&& password=="sitecore")
            {
                //MessageBox.Show("successfully completed ");
                label3.Text = ("Login successfully completed ");
            }
            else
            {
                //MessageBox.Show("failed please Entered correct password");
                label3.Text = ("failed please Entered correct password");
            }
            
        }
    }
}
