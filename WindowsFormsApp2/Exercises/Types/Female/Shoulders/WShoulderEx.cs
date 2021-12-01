using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Exercises.Types.Female.Shoulders;
namespace WindowsFormsApp2.Exercises.Types.Male.Shoulder
{
    public partial class WShoulderEx : Form
    {
        public WShoulderEx()
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

        private void button1_Click(object sender, EventArgs e)
        {
            frmElbowSide ElbowSide = new frmElbowSide();
            ElbowSide.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmShoulderRotation ShoulderRotation = new frmShoulderRotation();
            ShoulderRotation.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmBackSqueeze backSqueeze = new frmBackSqueeze();
            backSqueeze.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmArmsRaise ArmsRaise = new frmArmsRaise();
                ArmsRaise.Show();
        }
    }
}
