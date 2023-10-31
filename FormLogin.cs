using InvoiceManagement.DAO.LoginDAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InvoiceManagement.Models;

namespace InvoiceManagement
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string userName = UserTxt.Text.Trim();
                string password = PasswordTxt.Text.Trim();
                ILoginDAO dao = new LoginDAOImpl();
                if (dao.UserExists(new User(userName, password))) {
                    FormMain formMain = new FormMain(userName, password);
                    this.Hide();
                    formMain.ShowDialog();
                } else
                {
                    MessageBox.Show("Wrong");
                }
            } catch (Exception ex)
            {
                MessageBox.Show("General error: " +  ex.Message);
            }

        }
    }
}
