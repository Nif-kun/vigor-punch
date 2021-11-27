using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Form3 form3 = new Form3();
                form3.Show();    
            }
            else if (checkBox2.Checked)
            {
                Form4 form4 = new Form4();
                form4.Show();
            }
            else if (checkBox3.Checked)
            {
                Form5 form5 = new Form5();
                form5.Show();
            }
            else if (checkBox4.Checked)
            {
                Form6 form6 = new Form6();
                form6.Show();
            }
            else if (checkBox5.Checked)
            {
                Form7 form7 = new Form7();
                form7.Show();
            }
            else if (checkBox6.Checked) 
            {
                Form8 form8 = new Form8();
                form8.Show();
            }
            else
            {
                MessageBox.Show("Please Choose a type of Workout");
            }
        }
        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
