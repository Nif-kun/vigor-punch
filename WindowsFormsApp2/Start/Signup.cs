using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Exercises.Types;
using WindowsFormsApp2.Localdb;

namespace WindowsFormsApp2.Start
{
    public partial class Signup : Form
    {
        //tmp list
        //this only stays in intro, login, signup, and options(exercise).
        public List<User> users = new List<User>();

        public Signup()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Intro intro = new Intro();
            intro.users = users;
            intro.Show();
            Hide();
        }

        private void viewChoosePass_Click(object sender, EventArgs e)
        {
            choosePassTxBox.UseSystemPasswordChar = !choosePassTxBox.UseSystemPasswordChar;
        }

        private void viewConfirmPass_Click(object sender, EventArgs e)
        {
            confirmPassTxBox.UseSystemPasswordChar = !confirmPassTxBox.UseSystemPasswordChar;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            int verified = 0;
            if (choosePassTxBox.Text.Equals(confirmPassTxBox.Text)) {
                verified++;
                passNotif.Hide();
            } else {
                passNotif.Show();
            }

            if (usernameTxBox.Text.Length == 0 || emailTxBox.Text.Length == 0 || choosePassTxBox.Text.Length == 0 || confirmPassTxBox.Text.Length == 0) {
                emptyNotif.Show();
            } else {
                verified++;
                emptyNotif.Hide(); 
            }

            foreach (User user in users)
            {
                if (user.username.Equals(usernameTxBox.Text)) {
                    verified = 0;
                    usernameNotif.Show();
                    break;
                } else if (usernameNotif.Visible) {
                    usernameNotif.Hide();
                }
            }

            if (verified == 2) 
            {
                users.Add(new User(usernameTxBox.Text, emailTxBox.Text, choosePassTxBox.Text));
                OptionsWindow optionsWindow = new OptionsWindow();
                optionsWindow.users = users;
                optionsWindow.Show();
                Hide();
            }
        }

    }
}
