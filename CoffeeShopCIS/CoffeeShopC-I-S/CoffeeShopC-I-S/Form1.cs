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
            
            if (IsValidUser(usernameTB.Text, passwordTB.Text, roleComboBox.Text.ToString()))
            {
                this.Hide();
                MenuForm menu = new MenuForm();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Username, Password, or Role is Incorrect is incorrect please try again");
            }
        }
        private bool IsValidUser(string Username, string Password, string Role)
        {
            
                UsersDataContext usersdb = new UsersDataContext();
            
                

            var user = from s in usersdb.UsersTables
                       where s.Username == usernameTB.Text && s.Password == passwordTB.Text && s.Role == roleComboBox.Text.ToString()
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

        private void exitBtnLf_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'coffeeShopdbDataSet.UsersTable' table. You can move, or remove it, as needed.
            this.usersTableTableAdapter.Fill(this.coffeeShopdbDataSet.UsersTable);

        }
    }
}
