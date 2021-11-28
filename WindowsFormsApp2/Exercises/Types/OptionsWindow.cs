using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Start;
using WindowsFormsApp2.Localdb;

namespace WindowsFormsApp2.Exercises.Types
{
    public partial class OptionsWindow : Form
    {
        //tmp list
        //this only stays in intro, login, signup, and options(exercise).
        public List<User> users = new List<User>();

        public OptionsWindow()
        {
            InitializeComponent();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Intro intro = new Intro();
            intro.users = users;
            intro.Show();
            Hide();
        }

        private void mensBtn_Click(object sender, EventArgs e)
        {
            MaleWorkout maleWorkout = new MaleWorkout();
            maleWorkout.Show();
            Hide();
        }

        private void womensBtn_Click(object sender, EventArgs e)
        {
            FemaleWorkout femaleWorkout = new FemaleWorkout();
            femaleWorkout.Show();
            Hide();
        }
    }
}
