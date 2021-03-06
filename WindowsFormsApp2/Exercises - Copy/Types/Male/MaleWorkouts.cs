using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Exercises.Types;
using WindowsFormsApp2.Exercises.Types.Male.Abdominal;
using WindowsFormsApp2.Exercises.Types.Male.Arms;
using WindowsFormsApp2.Exercises.Types.Male.Legs;
using WindowsFormsApp2.Exercises.Types.Male.Shoulder;

namespace WindowsFormsApp2
{
    public partial class MaleWorkout : Form
    {
        public MaleWorkout()
        {
            InitializeComponent();
        }

        private void btnManChestStart_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            frmManChestEx chestEx = new frmManChestEx();
            chestEx.Closed += (s, args) => this.Close();
            chestEx.Show();

        }

        private void btnManBackStart_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmManBackEX backEx = new frmManBackEX();
            backEx.Closed += (s, args) => this.Close();
            backEx.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmManLeg legEx = new frmManLeg();
            legEx.Closed += (s, args) => this.Close();
            legEx.Show();
             
        }

        private void btnManArmStart_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmManArmsEx armEx = new frmManArmsEx();
            armEx.Closed += (s, args) => this.Close();
            armEx.Show();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmManShoulderEx shoulderEx = new frmManShoulderEx();
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            OptionsWindow options = new OptionsWindow();
            options.Closed += (s, args) => this.Close();
            options.Show();
        }
    }
}
