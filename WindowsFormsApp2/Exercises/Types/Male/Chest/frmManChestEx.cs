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
<<<<<<< HEAD
            frmPushUps Pushup = new frmPushUps();
            Pushup.Show();
=======
            frmPushUps pushUps = new frmPushUps();
            pushUps.Show();
>>>>>>> 8fc5d549398b9f81b3dfd707bad19c97092fde0d
        }

        private void button4_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            frmSuspendedPushUps SuspendedPushup = new frmSuspendedPushUps();
            SuspendedPushup.Show();
=======
            frmSuspendedPushUps suspendedPushUps = new frmSuspendedPushUps();
            suspendedPushUps.Show();
>>>>>>> 8fc5d549398b9f81b3dfd707bad19c97092fde0d
        }

        private void button6_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            frmInclineDumbell InclineDumbell = new frmInclineDumbell();
            InclineDumbell.Show();
=======
            frmInclineDumbell inclineDumbell = new frmInclineDumbell();
            inclineDumbell.Show();
>>>>>>> 8fc5d549398b9f81b3dfd707bad19c97092fde0d
        }

        private void button8_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            frmBarbellBench BarbellBench = new frmBarbellBench();
            BarbellBench.Show();
=======
            frmBarbellBench barbellBench = new frmBarbellBench();
            barbellBench.Show();
>>>>>>> 8fc5d549398b9f81b3dfd707bad19c97092fde0d
        }

        private void button10_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            frmCloseGrip closegrip = new frmCloseGrip();
            closegrip.Show();
=======
            frmCloseGrip closeGrip = new frmCloseGrip();
            closeGrip.Show();
>>>>>>> 8fc5d549398b9f81b3dfd707bad19c97092fde0d
        }

        private void button12_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            frmDips Dips = new frmDips();
            Dips.Show();
=======
            frmDips dips = new frmDips();
            dips.Show();
>>>>>>> 8fc5d549398b9f81b3dfd707bad19c97092fde0d
        }

        private void button14_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            frmSeatedPec SeatedPec = new frmSeatedPec();
            SeatedPec.Show();
=======
            frmSeatedPec seatedPec = new frmSeatedPec();
            seatedPec.Show();
>>>>>>> 8fc5d549398b9f81b3dfd707bad19c97092fde0d
        }

        private void button16_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            frmPlatePressOut PlatePressout = new frmPlatePressOut();
            PlatePressout.Show();
=======
            frmPlatePressOut platePressOut = new frmPlatePressOut();
            platePressOut.Show();
>>>>>>> 8fc5d549398b9f81b3dfd707bad19c97092fde0d
        }

        private void button18_Click(object sender, EventArgs e)
        {
            frmResistanceBandPull resistanceBandPull = new frmResistanceBandPull();
            resistanceBandPull.Show();
        }
    }
}
