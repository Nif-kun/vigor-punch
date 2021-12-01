using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Exercises.Types.Female.Arms;

namespace WindowsFormsApp2.Exercises.Types.Male.Arms
{
    public partial class WArmsEx : Form
    {
        public WArmsEx()
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
            frmPressUp PressUp = new frmPressUp();
            PressUp.Show();
        }

        private void WArmsEx_Load(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmOverHeadPress OverHeadPress = new frmOverHeadPress();
            OverHeadPress.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmTricepKickBack TricepKickBack = new frmTricepKickBack();
            TricepKickBack.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmFrontRaise FrontRaise = new frmFrontRaise();
            FrontRaise.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmChessFlye ChessFlye = new frmChessFlye();
            ChessFlye.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmUprightRow UprighrRow = new frmUprightRow();
            UprighrRow.Show();
        }
    }
}
