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

        private void button2_Click(object sender, EventArgs e)
        {
            frmSidePlank SPlank = new frmSidePlank();
                SPlank.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmReverseCrunch RCrunch = new frmReverseCrunch();
            RCrunch.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmBoatPose BPose = new frmBoatPose();
                BPose.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmBicycleCrunches BCrunches = new frmBicycleCrunches();
            BCrunches.Show();
        }
    }
}
