﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Exercises.Types.Male.Legs;

namespace WindowsFormsApp2
{
    public partial class frmManWorkout : Form
    {
        public frmManWorkout()
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
    }
}
