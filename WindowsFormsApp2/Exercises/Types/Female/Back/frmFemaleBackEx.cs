﻿using System;
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
    }
}
