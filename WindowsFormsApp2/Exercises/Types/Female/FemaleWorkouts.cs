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
using WindowsFormsApp2.Exercises.Types.Male.Arms;
using WindowsFormsApp2.Exercises.Types.Male.Legs;
using WindowsFormsApp2.Exercises.Types.Male.Shoulder;

namespace WindowsFormsApp2
{
    public partial class FemaleWorkout : Form
    {
        public FemaleWorkout()
        {
            InitializeComponent();
        }

        private void btnwManChestStart_Click(object sender, EventArgs e)
        {

            this.Hide();
            WChestEx chestEx = new WChestEx();
            chestEx.Closed += (s, args) => this.Close();
            chestEx.Show();

        }

        private void btnwManBackStart_Click(object sender, EventArgs e)
        {
            this.Hide();
            WomanBackEX backEx = new WomanBackEX();
            backEx.Closed += (s, args) => this.Close();
            backEx.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            WLeg legEx = new WLeg();
            legEx.Closed += (s, args) => this.Close();
            legEx.Show();

        }

        private void btnwManArmStart_Click(object sender, EventArgs e)
        {
            this.Hide();
            WArmsEx armEx = new WArmsEx();
            armEx.Closed += (s, args) => this.Close();
            armEx.Show();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            WShoulderEx shoulderEx = new WShoulderEx();
            shoulderEx.Closed += (s, args) => this.Close();
            shoulderEx.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmManAbdominalEx abdEx = new frmManAbdominalEx();
            abdEx.Closed += (s, args) => this.Close();
            abdEx.Show();
        }
    }
}
