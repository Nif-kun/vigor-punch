using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Exercises.Types.Female.Back;
namespace WindowsFormsApp2
{
    public partial class WomanBackEX : Form
    {
        public WomanBackEX()
        {
            InitializeComponent();
        }

        private void btnwBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FemaleWorkout wmanWorkout = new FemaleWorkout();
            wmanWorkout.Closed += (s, args) => this.Close();
            wmanWorkout.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmScapPullUp scapPullUp = new frmScapPullUp();
            scapPullUp.Show();
        }

        private void WomanBackEX_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmBandFacePull BandFacePull = new frmBandFacePull();
            BandFacePull.Show();
        }
    }
}
