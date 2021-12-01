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
            frmHangingKnee hangingknee = new frmHangingKnee();
            hangingknee.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmPushuptojacKnife jackknife = new frmPushuptojacKnife();
            jackknife.Show();
        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            frmAbrollout abrollout = new frmAbrollout();
            abrollout.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmObliqueCrunch obliquecrunch = new frmObliqueCrunch();
            obliquecrunch.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            frmKeeponplanking keeponplanking = new frmKeeponplanking();
            keeponplanking.Show();
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
           // frmKeepOnPlanking keepOnPlanking = new frmKeepOnPlanking();
           // keepOnPlanking.Show();
        }

       

        
        private void button2_Click_1(object sender, EventArgs e)
        {
            frmPushuptojacKnife PJKnife = new frmPushuptojacKnife();
            PJKnife.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            frmAbrollout Abrollout = new frmAbrollout();
            Abrollout.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            frmObliqueCrunch ObliqueCrunch = new frmObliqueCrunch();
            ObliqueCrunch.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmPushUpsToJackKnife pushUpsToJackKnife = new frmPushUpsToJackKnife();
            pushUpsToJackKnife.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmKeepOnPlanking keepOnPlanking = new frmKeepOnPlanking();
            keepOnPlanking.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmABRollOut aBRollOut = new frmABRollOut();
            aBRollOut.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmObliqueCrunch obliqueCrunch = new frmObliqueCrunch();
            obliqueCrunch.Show();
        }
    }
}
