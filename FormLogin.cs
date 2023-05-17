using System;
using System.Windows.Forms;
using WinFormsApp1.DataStoarge;

namespace WinFormsApp1
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Storage.SaveData();
            Close();
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            FormManager formManager = new FormManager();
            Hide();
            formManager.ShowDialog();
            Show();
        }

        private void btn_customer_Click(object sender, EventArgs e)
        {
            FormCustomer formCustomer = new FormCustomer();
            Hide();
            formCustomer.ShowDialog();
            Show();
        }




    }
}

