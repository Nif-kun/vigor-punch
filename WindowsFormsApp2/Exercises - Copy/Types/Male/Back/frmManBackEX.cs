using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Exercises.Types.Male.Back;
<<<<<<< HEAD
=======

>>>>>>> 8fc5d549398b9f81b3dfd707bad19c97092fde0d
namespace WindowsFormsApp2
{
    public partial class frmManBackEX : Form
    {
        public frmManBackEX()
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

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            frmLatPulldown LatPulldown = new frmLatPulldown();
            LatPulldown.Show();

=======
            frmLatPulldown latPulldown = new frmLatPulldown();
            latPulldown.Show();
>>>>>>> 8fc5d549398b9f81b3dfd707bad19c97092fde0d
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmPullUps pullUps = new frmPullUps();
            pullUps.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            frmSeatedCable SeatedCable = new frmSeatedCable();
            SeatedCable.Show();
=======
            frmSeatedCable seatedCable = new frmSeatedCable();
            seatedCable.Show();
>>>>>>> 8fc5d549398b9f81b3dfd707bad19c97092fde0d
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            frmBentOver BentOver = new frmBentOver();
            BentOver.Show();
=======
            frmBentOver bentOver = new frmBentOver();
            bentOver.Show();
>>>>>>> 8fc5d549398b9f81b3dfd707bad19c97092fde0d
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            frmMachineRow MachineRow = new frmMachineRow();
            MachineRow.Show();
=======
            frmMachineRow machineRow = new frmMachineRow();
            machineRow.Show();
>>>>>>> 8fc5d549398b9f81b3dfd707bad19c97092fde0d
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            frmSingleArmDumbell SingleArmDumbell = new frmSingleArmDumbell();
            SingleArmDumbell.Show();
=======
            frmSingleArmDumbell singleArmDumbell = new frmSingleArmDumbell();
            singleArmDumbell.Show();
>>>>>>> 8fc5d549398b9f81b3dfd707bad19c97092fde0d
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
    }
}
