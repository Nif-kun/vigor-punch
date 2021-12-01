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

            frmPikePushUps Pikepushup = new frmPikePushUps();
            Pikepushup.Show();

            frmPikePushUps pikePushUps = new frmPikePushUps();
            pikePushUps.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            frmPseudoPushUps pseudoPushups = new frmPseudoPushUps();
            pseudoPushups.Show();

            frmPseudoPushUps pseudoPushUps = new frmPseudoPushUps();
            pseudoPushUps.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {

            frmPlanchLean Planchlean = new frmPlanchLean();
            Planchlean.Show();

            frmPlanchLean planchLean = new frmPlanchLean();
            planchLean.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {

            frmShoulderTouch Shouldertouch = new frmShoulderTouch();
            Shouldertouch.Show();

            frmShoulderTouch shoulderTouch = new frmShoulderTouch();
            shoulderTouch.Show();

        }
    }
}
