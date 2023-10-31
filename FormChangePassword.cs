using InvoiceManagement.DAO.ChangePasswordDAO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceManagement
{
    public partial class FormChangePassword : Form
    {
        private readonly string userName;
        private string password;

        public FormChangePassword()
        {
            InitializeComponent();
        }

        public FormChangePassword(string userName, string password)
        {
            InitializeComponent();
            this.userName = userName;
            this.password = password;
        }

        private void ChangePasswordBtn_Click(object sender, EventArgs e)
        {
            string currentPass = CurrentPasswordTxt.Text.Trim();
            

            if (currentPass.Equals(this.password))
            {
                string newPass = NewPasswordTxt.Text.Trim();
                string confirmNewPass = ConfirmNewPasswordTxt.Text.Trim();
                if (newPass.Equals(confirmNewPass))
                {
                    try
                    {
                        IChangePasswordDAO dao = new ChangePassDAO();
                        dao.ChangePassword(this.userName, newPass);
                        this.password = newPass;
                        MessageBox.Show("Your password has been changed");
                        CleanFields();
                    } catch (MySqlException ex)
                    {
                        MessageBox.Show("SQL Error: " + ex.Message);
                        return;
                    } catch (Exception ex)
                    {
                        MessageBox.Show("General Error: " + ex.Message);
                        return;
                    }
                } else
                {
                    MessageBox.Show("The new password does not match.");
                    CleanFields();
                }
            } else
            {
                MessageBox.Show("Your current password does not match.");
                CleanFields();
            }


        }

        private void CleanFields()
        {
            CurrentPasswordTxt.Text = string.Empty;
            NewPasswordTxt.Text = string.Empty;
            ConfirmNewPasswordTxt.Text= string.Empty;
        }
    }
}
