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
<<<<<<< HEAD
=======

>>>>>>> 8fc5d549398b9f81b3dfd707bad19c97092fde0d
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
<<<<<<< HEAD
            InclineDumbellSkullCrusher inclineDumbellSkullCrusher = new InclineDumbellSkullCrusher();
=======
            frmInclineDumbellSkullCrusher inclineDumbellSkullCrusher = new frmInclineDumbellSkullCrusher();
>>>>>>> 8fc5d549398b9f81b3dfd707bad19c97092fde0d
            inclineDumbellSkullCrusher.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            ReverseGripPushUps ReverseGripPushup = new ReverseGripPushUps();
            ReverseGripPushup.Show();

=======
            frmReverseGripPushUps reverseGripPushUps = new frmReverseGripPushUps();
            reverseGripPushUps.Show();
>>>>>>> 8fc5d549398b9f81b3dfd707bad19c97092fde0d
        }

        private void button3_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            frmCableTricepPushDown CableTricepPushdown = new frmCableTricepPushDown();
            CableTricepPushdown.Show();
=======
            frmCableTricepPushDown cableTricepPushDown = new frmCableTricepPushDown();
            cableTricepPushDown.Show();
>>>>>>> 8fc5d549398b9f81b3dfd707bad19c97092fde0d
        }

        private void button4_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            frmPreacherCurls PreacherCurls = new frmPreacherCurls();
            PreacherCurls.Show();
=======
            frmPreacherCurls preacherCurls = new frmPreacherCurls();
            preacherCurls.Show();
>>>>>>> 8fc5d549398b9f81b3dfd707bad19c97092fde0d
        }

        private void button5_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            frmBarbellCurls BarbellCurls = new frmBarbellCurls();
            BarbellCurls.Show();
=======
            frmBarbellCurls barbellCurls = new frmBarbellCurls();
            barbellCurls.Show();
>>>>>>> 8fc5d549398b9f81b3dfd707bad19c97092fde0d
        }

        private void button6_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            frmZottmanCurls ZottmanCurls = new frmZottmanCurls();
            ZottmanCurls.Show();
=======
            frmZottmanCurls zottmanCurls = new frmZottmanCurls();
            zottmanCurls.Show();
>>>>>>> 8fc5d549398b9f81b3dfd707bad19c97092fde0d
        }
    }
}
