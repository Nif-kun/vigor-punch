using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Exercises.Types.Female.Abdominal;

namespace WindowsFormsApp2.Exercises.Types.Male.Abdominal
{
    public partial class WAbdominalEx : Form
    {
        public WAbdominalEx()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FemaleWorkout manWorkout = new FemaleWorkout();
            manWorkout.Closed += (s, args) => this.Close();
            manWorkout.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PlankCrawlout PlankCrawlout = new PlankCrawlout();
            PlankCrawlout.Show();
  
        }
    }
}
