using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2.Exercises.Types.Male.Legs
{
    public partial class frmManLeg : Form
    {
        public frmManLeg()
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

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            frmExplosiveSquat ExplosiveSquat = new frmExplosiveSquat();
            ExplosiveSquat.Show();
=======
            frmExplosiveSquat explosiveSquat = new frmExplosiveSquat();
            explosiveSquat.Show();
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

        private void button5_Click(object sender, EventArgs e)
        {
            frmLunges lunges = new frmLunges();
            lunges.Show();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            frmBulgarianSplitsSquats BulgarianSplitSquats = new frmBulgarianSplitsSquats();
            BulgarianSplitSquats.Show();
=======
            frmBulgarianSplitsSquats bulgarianSplitsSquats = new frmBulgarianSplitsSquats();
            bulgarianSplitsSquats.Show();
>>>>>>> 8fc5d549398b9f81b3dfd707bad19c97092fde0d
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            frmOneLegSquats OnelegSquats = new frmOneLegSquats();
            OnelegSquats.Show();
=======
            frmOneLegSquats oneLegSquats = new frmOneLegSquats();
            oneLegSquats.Show();
>>>>>>> 8fc5d549398b9f81b3dfd707bad19c97092fde0d
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            frmSlowSquats SlowSquats = new frmSlowSquats();
            SlowSquats.Show();
=======
            frmSlowSquats slowSquats = new frmSlowSquats();
            slowSquats.Show();
>>>>>>> 8fc5d549398b9f81b3dfd707bad19c97092fde0d
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
