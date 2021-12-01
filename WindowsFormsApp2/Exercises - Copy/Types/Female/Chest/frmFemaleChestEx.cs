using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Exercises.Types.Female.Chest;
namespace WindowsFormsApp2
{
    public partial class WChestEx : Form
    {
        public WChestEx()
        {
            InitializeComponent();
        }

        private void groupBox10_Enter(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FemaleWorkout wmanWorkout = new FemaleWorkout();
            wmanWorkout.Closed += (s, args) => this.Close();
            wmanWorkout.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmDumbbellChestPress ChestPress = new frmDumbbellChestPress();
            ChestPress.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmPushUp Pushup = new frmPushUp();
            Pushup.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmStabilityBall StabilityBall = new frmStabilityBall();
            StabilityBall.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmMedicineBall MedicineBall = new frmMedicineBall();
            MedicineBall.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmDumbbelPullOver Pullover = new frmDumbbelPullOver();
            Pullover.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            frmCableCrossover Crossover = new frmCableCrossover();
            Crossover.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            frmButterflyMachine ButterflyMachine = new frmButterflyMachine();
            ButterflyMachine.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            frmInclineDumbbelChestPress inclinedumbchestpress = new frmInclineDumbbelChestPress();
            inclinedumbchestpress.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            frmBarbellbenchPress benchPress = new frmBarbellbenchPress();
            benchPress.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            frmCableObliqueTwist ObliqueTwist = new frmCableObliqueTwist();
            ObliqueTwist.Show();
        }
    }
}
