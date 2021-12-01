using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2.Exercises.Types.Male.Shoulder
{
    public partial class frmManShoulderEx : Form
    {
        public frmManShoulderEx()
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
            frmPikePushUps Pikepushup = new frmPikePushUps();
            Pikepushup.Show();
=======
            frmPikePushUps pikePushUps = new frmPikePushUps();
            pikePushUps.Show();
>>>>>>> 8fc5d549398b9f81b3dfd707bad19c97092fde0d
        }

        private void button2_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            frmPseudoPushUps pseudoPushups = new frmPseudoPushUps();
            pseudoPushups.Show();
=======
            frmPseudoPushUps pseudoPushUps = new frmPseudoPushUps();
            pseudoPushUps.Show();
>>>>>>> 8fc5d549398b9f81b3dfd707bad19c97092fde0d
        }

        private void button3_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            frmPlanchLean Planchlean = new frmPlanchLean();
            Planchlean.Show();
=======
            frmPlanchLean planchLean = new frmPlanchLean();
            planchLean.Show();
>>>>>>> 8fc5d549398b9f81b3dfd707bad19c97092fde0d
        }

        private void button4_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            frmShoulderTouch Shouldertouch = new frmShoulderTouch();
            Shouldertouch.Show();
=======
            frmShoulderTouch shoulderTouch = new frmShoulderTouch();
            shoulderTouch.Show();
>>>>>>> 8fc5d549398b9f81b3dfd707bad19c97092fde0d
        }
    }
}
