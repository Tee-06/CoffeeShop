
namespace CoffeeShopC_I_S
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.roleComboBox = new System.Windows.Forms.ComboBox();
            this.usersTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coffeeShopdbDataSet = new CoffeeShopC_I_S.CoffeeShopdbDataSet();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.signInBtn = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.usernameTB = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.signInLbl = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.exitBtnLf = new System.Windows.Forms.Button();
            this.usersTableTableAdapter = new CoffeeShopC_I_S.CoffeeShopdbDataSetTableAdapters.UsersTableTableAdapter();
            this.panel1.SuspendLayout();
            this.panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeShopdbDataSet)).BeginInit();
            this.panel9.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel14.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel15);
            this.panel1.Controls.Add(this.signInBtn);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(39, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(398, 553);
            this.panel1.TabIndex = 0;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.Gainsboro;
            this.panel15.Controls.Add(this.roleComboBox);
            this.panel15.Controls.Add(this.panel16);
            this.panel15.Controls.Add(this.panel17);
            this.panel15.Controls.Add(this.panel18);
            this.panel15.Location = new System.Drawing.Point(36, 311);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(309, 69);
            this.panel15.TabIndex = 5;
            // 
            // roleComboBox
            // 
            this.roleComboBox.DataSource = this.usersTableBindingSource;
            this.roleComboBox.DisplayMember = "Role";
            this.roleComboBox.FormattingEnabled = true;
            this.roleComboBox.Location = new System.Drawing.Point(22, 26);
            this.roleComboBox.Name = "roleComboBox";
            this.roleComboBox.Size = new System.Drawing.Size(266, 21);
            this.roleComboBox.TabIndex = 3;
            // 
            // usersTableBindingSource
            // 
            this.usersTableBindingSource.DataMember = "UsersTable";
            this.usersTableBindingSource.DataSource = this.coffeeShopdbDataSet;
            // 
            // coffeeShopdbDataSet
            // 
            this.coffeeShopdbDataSet.DataSetName = "CoffeeShopdbDataSet";
            this.coffeeShopdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel16
            // 
            this.panel16.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel16.Location = new System.Drawing.Point(308, 0);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(1, 68);
            this.panel16.TabIndex = 2;
            // 
            // panel17
            // 
            this.panel17.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel17.Location = new System.Drawing.Point(0, 0);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(1, 68);
            this.panel17.TabIndex = 1;
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.White;
            this.panel18.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel18.Location = new System.Drawing.Point(0, 68);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(309, 1);
            this.panel18.TabIndex = 0;
            // 
            // signInBtn
            // 
            this.signInBtn.BackColor = System.Drawing.Color.Chocolate;
            this.signInBtn.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signInBtn.Location = new System.Drawing.Point(36, 386);
            this.signInBtn.Name = "signInBtn";
            this.signInBtn.Size = new System.Drawing.Size(309, 61);
            this.signInBtn.TabIndex = 4;
            this.signInBtn.Text = "Sign In";
            this.signInBtn.UseVisualStyleBackColor = false;
            this.signInBtn.Click += new System.EventHandler(this.signInBtn_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Gainsboro;
            this.panel9.Controls.Add(this.passwordTB);
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Controls.Add(this.panel11);
            this.panel9.Controls.Add(this.panel12);
            this.panel9.Location = new System.Drawing.Point(36, 233);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(309, 69);
            this.panel9.TabIndex = 3;
            // 
            // passwordTB
            // 
            this.passwordTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTB.Location = new System.Drawing.Point(19, 15);
            this.passwordTB.Multiline = true;
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(270, 38);
            this.passwordTB.TabIndex = 4;
            this.passwordTB.Enter += new System.EventHandler(this.passwordTB_Enter);
            this.passwordTB.Leave += new System.EventHandler(this.passwordTB_Leave);
            // 
            // panel10
            // 
            this.panel10.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel10.Location = new System.Drawing.Point(308, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1, 68);
            this.panel10.TabIndex = 2;
            // 
            // panel11
            // 
            this.panel11.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1, 68);
            this.panel11.TabIndex = 1;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.White;
            this.panel12.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel12.Location = new System.Drawing.Point(0, 68);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(309, 1);
            this.panel12.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gainsboro;
            this.panel5.Controls.Add(this.usernameTB);
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Location = new System.Drawing.Point(36, 140);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(309, 77);
            this.panel5.TabIndex = 2;
            // 
            // usernameTB
            // 
            this.usernameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.usernameTB.Location = new System.Drawing.Point(19, 19);
            this.usernameTB.Multiline = true;
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.Size = new System.Drawing.Size(270, 38);
            this.usernameTB.TabIndex = 5;
            this.usernameTB.Enter += new System.EventHandler(this.usernameTB_Enter);
            this.usernameTB.Leave += new System.EventHandler(this.usernameTB_Leave);
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(308, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1, 76);
            this.panel8.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1, 76);
            this.panel7.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 76);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(309, 1);
            this.panel6.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Chocolate;
            this.panel4.Location = new System.Drawing.Point(0, 43);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(26, 60);
            this.panel4.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(398, 103);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.signInLbl);
            this.panel3.Location = new System.Drawing.Point(0, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(395, 58);
            this.panel3.TabIndex = 1;
            // 
            // signInLbl
            // 
            this.signInLbl.AutoSize = true;
            this.signInLbl.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signInLbl.Location = new System.Drawing.Point(27, 21);
            this.signInLbl.Name = "signInLbl";
            this.signInLbl.Size = new System.Drawing.Size(112, 34);
            this.signInLbl.TabIndex = 0;
            this.signInLbl.Text = "Sign In";
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.Gainsboro;
            this.panel13.Controls.Add(this.panel14);
            this.panel13.Location = new System.Drawing.Point(39, 506);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(398, 100);
            this.panel13.TabIndex = 5;
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.exitBtnLf);
            this.panel14.Location = new System.Drawing.Point(0, 54);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(398, 46);
            this.panel14.TabIndex = 1;
            // 
            // exitBtnLf
            // 
            this.exitBtnLf.BackColor = System.Drawing.Color.Chocolate;
            this.exitBtnLf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtnLf.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtnLf.Location = new System.Drawing.Point(277, 0);
            this.exitBtnLf.Name = "exitBtnLf";
            this.exitBtnLf.Size = new System.Drawing.Size(121, 46);
            this.exitBtnLf.TabIndex = 6;
            this.exitBtnLf.Text = "Exit";
            this.exitBtnLf.UseVisualStyleBackColor = false;
            this.exitBtnLf.Click += new System.EventHandler(this.exitBtnLf_Click);
            // 
            // usersTableTableAdapter
            // 
            this.usersTableTableAdapter.ClearBeforeFill = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(477, 659);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Text = "Welcome Please Log In";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usersTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeShopdbDataSet)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label signInLbl;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button signInBtn;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.TextBox usernameTB;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Button exitBtnLf;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.ComboBox roleComboBox;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Panel panel18;
        private CoffeeShopdbDataSet coffeeShopdbDataSet;
        private System.Windows.Forms.BindingSource usersTableBindingSource;
        private CoffeeShopdbDataSetTableAdapters.UsersTableTableAdapter usersTableTableAdapter;
    }
}

