using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Exercises.Types.Male.Abdominal;

namespace WindowsFormsApp2.Exercises.Types.Male.Abdominal
{
    public partial class frmManAbdominalEx : Form
    {
        public frmManAbdominalEx()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MaleWorkout manWorkout = new MaleWorkout();
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
            frmHangingKnee hangingKnee = new frmHangingKnee();
            hangingKnee.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmPushUpsToJackKnife PushuptoJackKnife = new frmPushUpsToJackKnife();
                PushuptoJackKnife.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmKeepOnPlanking KeepOnPlanking = new frmKeepOnPlanking();
            KeepOnPlanking.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmABRollOut AbRollout = new frmABRollOut();
            AbRollout.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmObliqueCrunch obliqueCrunch = new frmObliqueCrunch();
            obliqueCrunch.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            frmKeepOnPlanking KeeponPlanking = new frmKeepOnPlanking();
            KeeponPlanking.Show();
        }
    }
}
