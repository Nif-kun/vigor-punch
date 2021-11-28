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
    public partial class FemaleWorkout : Form
    {
        public FemaleWorkout()
        {
            InitializeComponent();
        }

        private void btnwManChestStart_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            WChestEx chestEx = new WChestEx();
            chestEx.Closed += (s, args) => this.Close();
            chestEx.Show();

        }

        private void btnwManBackStart_Click(object sender, EventArgs e)
        {
            this.Hide();
            WomanBackEX backEx = new WomanBackEX();
            backEx.Closed += (s, args) => this.Close();
            backEx.Show();

        }
    }
}
