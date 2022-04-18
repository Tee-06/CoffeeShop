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
// UsersTable Database, and products made by Tyler Petersen
//Date:4/14/22

namespace CoffeeShopC_I_S
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        // checks method isValidUser using If statement-Tyler
        // If valid user returns true, then it will hide form 1 and go to menu form -Tyler
        private void signInBtn_Click(object sender, EventArgs e)
        {
            
            if (IsValidUser(usernameTB.Text, passwordTB.Text, roleComboBox.Text.ToString()))
            {
                MenuForm menu = new MenuForm();
                this.Hide();
                menu.ShowDialog();
                this.Show();
            }
            else
            {
                // If wrong information is provided, User is prompted to correct it. -Tyler
                MessageBox.Show("Username, Password, or Role is Incorrect is incorrect please try again");
            }
        }
        //Bool for is valid user -Tyler
        private bool IsValidUser(string Username, string Password, string Role)
        {
            
                UsersDataContext usersdb = new UsersDataContext();

                //! Creates variable User and variable s -Tyler
                //! pulls from database and checks for if whats in the database matches whats been put into the textboxes and combo box -Tyler

            var user = from s in usersdb.UsersTables
                       where s.Username == usernameTB.Text && s.Password == passwordTB.Text && s.Role == roleComboBox.Text.ToString()
                           select s;
                if (user.Any())
                {
                    return true;
                    
                    //! I have an extention called better comments, this is just better for me for organization -Tyler
                    //! if this causes an issue for you when viewing, either install the extention and then restart visual studio, or remove whatever is after the initial -Tyler
                    //xthis.Hide();
                    //xMenuForm menu = new MenuForm();
                   //xmenu.Show();
               }
                else
               {
                return false;
                }
        }

        //Exit button -Tyler
        private void exitBtnLf_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        //! On Load fills userstable, and sets the username and password textbox to say username and password -Tyler
        private void LoginForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'coffeeShopdbDataSet.UsersTable' table. You can move, or remove it, as needed.
            this.usersTableTableAdapter.Fill(this.coffeeShopdbDataSet.UsersTable);

            usernameTB.Text = "Username";
            passwordTB.Text = "Password";

        }
        // watermark placeholder for username and password textboxes on Enter and on Leave -Tyler
        private void usernameTB_Enter(object sender, EventArgs e)
        {
            if(usernameTB.Text == "Username")
            {
                usernameTB.Text = "";
                usernameTB.ForeColor = Color.Black;
            }
        }

        // when they click or tab out of the textbox, if nothing is typed in it it shows the watermark for what it's supposed to be - Tyler
        private void usernameTB_Leave(object sender, EventArgs e)
        {
            if (usernameTB.Text == "")
            {
                usernameTB.Text = "Username";
                usernameTB.ForeColor = Color.Silver;
            }
        }
        // Same for password on enter and leave -Tyler
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
