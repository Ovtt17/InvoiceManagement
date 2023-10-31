using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;



namespace InvoiceManagement
{
    public partial class FormMain : Form
    {
        private readonly string userName;
        private readonly string password;

        public FormMain()
        {
            InitializeComponent();
        }

        public FormMain(string userName, string password)
        {
            InitializeComponent();
            this.userName = userName;
            this.password = password;
            UserStatusLabel.Text = $"{UserStatusLabel.Text} {userName}";
        }

        private void InvoiceToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ShowForm(new FormInvoice());
        }

        private void CatalogToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ShowForm(new FormCatalogProducts());
        }

        private void ChangePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new FormChangePassword(userName, password));
        }
        public void ShowForm(Form childForm)
        {
            // Set the child form as a child of the parent form
            childForm.MdiParent = this;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            // Add the child form to the panel
            this.panel1.Controls.Add(childForm);

            // Bring the child form to the front
            this.panel1.Controls.SetChildIndex(childForm, 0);

            // Show the child form
            childForm.Show();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
