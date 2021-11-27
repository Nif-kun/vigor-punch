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
    public partial class frmManBackEX : Form
    {
        public frmManBackEX()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmManWorkout manWorkout = new frmManWorkout();
            manWorkout.Closed += (s, args) => this.Close();
            manWorkout.Show();
        }
    }
}
