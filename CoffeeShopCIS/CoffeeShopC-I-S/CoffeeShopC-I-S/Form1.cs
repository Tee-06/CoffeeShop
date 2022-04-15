using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopC_I_S
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void signInBtn_Click(object sender, EventArgs e)
        {
            if (IsValidUser(usernameTB.Text, passwordTB.Text))
            {
                this.Hide();
                MenuForm menu = new MenuForm();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Username or Password is incorrect please try again");
            }
        }
        private bool IsValidUser(string Username, string Password)
        {
            
                UsersDataContext usersdb = new UsersDataContext();

                var user = from s in usersdb.UsersTables
                           where s.Username == usernameTB.Text && s.Password == passwordTB.Text
                           select s;
                if (user.Any())
                {
                    return true;
                    //this.Hide();
                    //MenuForm menu = new MenuForm();
                    //menu.Show();
                }
                else
                {
                return false;
                }
        }
    }
}
