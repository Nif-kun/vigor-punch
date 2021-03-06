using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Exercises.Types.Male.Arms;



namespace WindowsFormsApp2.Exercises.Types.Male.Arms
{
    public partial class frmManArmsEx : Form
    {
        public frmManArmsEx()
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

        private void button1_Click(object sender, EventArgs e)
        {

            frmInclineDumbellSkullCrusher inclineDumbellSkullCrusher = new frmInclineDumbellSkullCrusher();

            inclineDumbellSkullCrusher.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            frmReverseGripPushUps ReverseGripPushup = new frmReverseGripPushUps();
            ReverseGripPushup.Show();


            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmCableTricepPushDown CableTricepPushdown = new frmCableTricepPushDown();
            CableTricepPushdown.Show();

            
                
        }

        private void button4_Click(object sender, EventArgs e)
        {

            frmPreacherCurls PreacherCurls = new frmPreacherCurls();
            PreacherCurls.Show();

           

        }

        private void button5_Click(object sender, EventArgs e)
        {

            frmBarbellCurls BarbellCurls = new frmBarbellCurls();
            BarbellCurls.Show();

            
        }

        private void button6_Click(object sender, EventArgs e)
        {

            frmZottmanCurls ZottmanCurls = new frmZottmanCurls();
            ZottmanCurls.Show();

            

        }
    }
}
