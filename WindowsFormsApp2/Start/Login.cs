using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Localdb;
using WindowsFormsApp2.Exercises.Types;

namespace WindowsFormsApp2.Start
{
    public partial class Login : Form
    {

        //tmp list
        //this only stays in intro, login, signup, and options(exercise).
        public List<User> users = new List<User>();

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //users.Add(new User("admin", "example@gmail.com", "admin"));
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Intro intro = new Intro();
            intro.users = users;
            intro.Show();
            Hide();
        }

        private void viewPass_Click(object sender, EventArgs e)
        {
            passTxBox.UseSystemPasswordChar = !passTxBox.UseSystemPasswordChar;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            //temp easy access
            if (users.Count == 0) {
                users.Add(new User("admin", "Admin@gmail.com", "admin"));
            }

            foreach (User user in users)
            {
                if ((usernameTxBox.Text.Equals(user.username) && passTxBox.Text.Equals(user.password)))
                {
                    OptionsWindow optionsWindow = new OptionsWindow();
                    optionsWindow.users = users;
                    optionsWindow.Show();
                    Hide();
                }
                else if(!credNotif.Visible)
                {
                    credNotif.Show();
                }
            }
        }

    }
}
