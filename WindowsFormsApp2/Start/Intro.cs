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

namespace WindowsFormsApp2.Start
{
    public partial class Intro : Form
    {
        //tmp list
        //this only stays in intro, login, signup, and options(exercise).
        public List<User> users = new List<User>();

        public Intro()
        {
            InitializeComponent();
        }

        private void signupBtn_Click(object sender, EventArgs e)
        {
            Signup signup = new Signup();
            signup.users = users;
            signup.Show();
            Hide();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.users = users;
            login.Show();
            Hide();
        }
    }
}
