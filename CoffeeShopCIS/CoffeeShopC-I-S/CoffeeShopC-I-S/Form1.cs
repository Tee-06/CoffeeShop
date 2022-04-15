using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Auth: Tyler Petersen
//Desc: Coffee Shop App
// UsersTable Database made by Tyler Petersen
//Date:4/14/22

namespace CoffeeShopC_I_S
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        // checks method isValidUser using If statement
        // If valid user returns true, then it will hide form 1 and go to menu form 
        private void signInBtn_Click(object sender, EventArgs e)
        {
            
            if (IsValidUser(usernameTB.Text, passwordTB.Text, roleComboBox.Text.ToString()))
            {
                this.Hide();
                MenuForm menu = new MenuForm();
                menu.ShowDialog();
            }
            else
            {
                // If wrong information is provided, User is prompted to correct it.
                MessageBox.Show("Username, Password, or Role is Incorrect is incorrect please try again");
            }
        }
        private bool IsValidUser(string Username, string Password, string Role)
        {
            
                UsersDataContext usersdb = new UsersDataContext();
            
                //! For some reason the combo box needs to be .Text instead of selectedvalue but it works.

                //! Creates variable User and variable s
                //! pulls from database and checks for if whats in the database matches whats been put into the textboxes and combo box

            var user = from s in usersdb.UsersTables
                       where s.Username == usernameTB.Text && s.Password == passwordTB.Text && s.Role == roleComboBox.Text.ToString()
                           select s;
                if (user.Any())
                {
                    return true;
                    
                    //! I have an extention called better comments, this is just better for me for organization -Tyler
                    //! if this causes an issue for you when viewing, either install the extention and then restart visual studio, or remove whatever is after the initial //
                    //xthis.Hide();
                    //xMenuForm menu = new MenuForm();
                   //xmenu.Show();
               }
                else
               {
                return false;
                }
        }

        //Exit button
        private void exitBtnLf_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'coffeeShopdbDataSet.UsersTable' table. You can move, or remove it, as needed.
            this.usersTableTableAdapter.Fill(this.coffeeShopdbDataSet.UsersTable);

            usernameTB.Text = "Username";
            passwordTB.Text = "Password";

        }
        // watermark placeholder for username and password textboxes on Enter and on Leave
        private void usernameTB_Enter(object sender, EventArgs e)
        {
            if(usernameTB.Text == "Username")
            {
                usernameTB.Text = "";
                usernameTB.ForeColor = Color.Black;
            }
        }

        private void usernameTB_Leave(object sender, EventArgs e)
        {
            if (usernameTB.Text == "")
            {
                usernameTB.Text = "Username";
                usernameTB.ForeColor = Color.Silver;
            }
        }

        private void passwordTB_Enter(object sender, EventArgs e)
        {
            if (passwordTB.Text == "Password")
            {
                passwordTB.Text = "";
                passwordTB.ForeColor = Color.Black;
            }
        }

        private void passwordTB_Leave(object sender, EventArgs e)
        {
            if (passwordTB.Text == "")
            {
                passwordTB.Text = "Password";
                passwordTB.ForeColor = Color.Silver;
            }
        }
    }
}
