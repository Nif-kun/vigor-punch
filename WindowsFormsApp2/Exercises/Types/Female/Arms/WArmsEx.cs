﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2.Exercises.Types.Male.Arms
{
    public partial class WArmsEx : Form
    {
        public WArmsEx()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FemaleWorkout manWorkout = new FemaleWorkout();
            manWorkout.Closed += (s, args) => this.Close();
            manWorkout.Show();
        }
    }
}
