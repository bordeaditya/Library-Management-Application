using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LibraryApplication.SqlLayer;

namespace LibraryApplication
{
    public partial class Form1 : Form
    {
        private MainWindow mainMenu;
        public Form1()
        {
            InitializeComponent();
            errorLabel.Hide();
            mainMenu = new MainWindow();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (userName.Text.Trim() != string.Empty && password.Text.Trim() != string.Empty)
                {
                    #region Check details
                    DataLayer dataLayer = new DataLayer();
                    bool result = dataLayer.CheckUserDetails(userName.Text.Trim(), password.Text.Trim());

                    if (result)
                    {
                        userName.Text = string.Empty;
                        password.Text = string.Empty;
                        this.Hide();
                        mainMenu.ShowDialog();
                    }
                    else
                    {
                        errorLabel.Text = "Incorrect username or password";
                        errorLabel.Show();
                    }
                    #endregion
                }
                else
                {
                    #region No user details entered
                    errorLabel.Text = "Username or password should'nt be blank";
                    errorLabel.Show();
                    #endregion
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured :"+ ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void userName_TextChanged(object sender, EventArgs e)
        {
            errorLabel.Hide();
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            errorLabel.Hide();
        }

    }
}
