using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Exercises.Types.Male.Chest;

namespace WindowsFormsApp2
{
    public partial class frmManChestEx : Form
    {
        public frmManChestEx()
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
            MaleWorkout manWorkout = new MaleWorkout();
            manWorkout.Closed += (s, args) => this.Close();
            manWorkout.Show();
        }

        private void cablecrossBtn_Click(object sender, EventArgs e)
        {
            frmCableCrossOver cableCrossOver = new frmCableCrossOver();
            cableCrossOver.Show();
        }

        private void psuhupBtn_Click(object sender, EventArgs e)
        {

            frmPushUps Pushup = new frmPushUps();
            Pushup.Show();

            

        }

        private void button4_Click(object sender, EventArgs e)
        {

            frmSuspendedPushUps SuspendedPushup = new frmSuspendedPushUps();
            SuspendedPushup.Show();

            
        }

        private void button6_Click(object sender, EventArgs e)
        {

            frmInclineDumbell InclineDumbell = new frmInclineDumbell();
            InclineDumbell.Show();

            

        }

        private void button8_Click(object sender, EventArgs e)
        {

            frmBarbellBench BarbellBench = new frmBarbellBench();
            BarbellBench.Show();

           

        }

        private void button10_Click(object sender, EventArgs e)
        {

           

            frmCloseGrip closeGrip = new frmCloseGrip();
            closeGrip.Show();

        }

        private void button12_Click(object sender, EventArgs e)
        {

            frmDips Dips = new frmDips();
            Dips.Show();

           
        }

        private void button14_Click(object sender, EventArgs e)
        {

            frmSeatedPec SeatedPec = new frmSeatedPec();
            SeatedPec.Show();

           

        }

        private void button16_Click(object sender, EventArgs e)
        {

            frmPlatePressOut PlatePressout = new frmPlatePressOut();
            PlatePressout.Show();

           

        }

        private void button18_Click(object sender, EventArgs e)
        {
            frmResistanceBandPull resistanceBandPull = new frmResistanceBandPull();
            resistanceBandPull.Show();
        }
    }
}
