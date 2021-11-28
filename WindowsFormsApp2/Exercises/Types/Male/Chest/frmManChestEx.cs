using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
