using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WinFormsApp1.DataStoarge;
using WinFormsApp1.NewFolder;

namespace WinFormsApp1
{
    public partial class FormCustomer : Form
    {
        public FormCustomer()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            if(Storage.Cart.Count > 0)
            {
                foreach (Item item in Storage.Cart)
                {
                    Storage.Stock.Add(item);
                }
            }

            Storage.Cart = new List<Item>();
            Close();
        }

        private void btn_Refrigerator_Click(object sender, EventArgs e)
        {
            bindComboBox(new Refrigerator());
        }
        private void btn_Kettle_Click(object sender, EventArgs e)
        {
            bindComboBox(new Kettle());
        }
        private void btn_Oven_Click(object sender, EventArgs e)
        {
            bindComboBox(new Oven());
        }
        private void btn_PowerStrip_Click(object sender, EventArgs e)
        {
            bindComboBox(new PowerStrip());
        }
        private void bindComboBox(Item type)
        {
            comboBoxItems.Items.Clear();
            foreach (Item item in Storage.Stock)
            {
                if (item.GetType() == type.GetType())
                {
                    comboBoxItems.Items.Add(item);
                }
            }

            if (comboBoxItems.Items.Count > 0)
            {
                comboBoxItems.Visible = true;
                comboBoxItems.SelectedIndex = 0;
            }
            else comboBoxItems.Visible = false;
        }

        private void buttonAddItemToCart_Click(object sender, EventArgs e)
        {
            if (comboBoxItems.Visible == false) return;
            Storage.Cart.Add(comboBoxItems.SelectedItem as Item);
            Storage.Stock.Remove(comboBoxItems.SelectedItem as Item);
            comboBoxCart.Items.Add(comboBoxItems.SelectedItem as Item);

            textBoxItems.Text = "";
            foreach (Item item in Storage.Cart)
            {
                textBoxItems.Text += item.ToString() + "\r\n";
            }

            if(comboBoxItems.SelectedItem is Refrigerator)
            {
                bindComboBox(new Refrigerator());
            }
            if (comboBoxItems.SelectedItem is Kettle)
            {
                bindComboBox(new Kettle());
            }
            if (comboBoxItems.SelectedItem is Oven)
            {
                bindComboBox(new Oven());
            }
            if (comboBoxItems.SelectedItem is PowerStrip)
            {
                bindComboBox(new PowerStrip());
            }

            labelPrice.Text = getTotalAmount().ToString();
            labelItems.Text = Storage.Cart.Count.ToString();
        }
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (comboBoxCart.Text == "")
                return;
            for (int i = 0; i < Storage.Cart.Count; i++)
            {
                if (Storage.Cart[i].getId() == (comboBoxCart.SelectedItem as Item).getId())
                {
                    Storage.Stock.Add(Storage.Cart[i]);
                    comboBoxCart.Items.Remove(Storage.Cart[i]);
                    comboBoxCart.Text = "";
                    Storage.Cart.Remove(Storage.Cart[i]);
                    break;
                }
            }

            textBoxItems.Text = "";
            foreach (Item item in Storage.Cart)
            {
                textBoxItems.Text += item.ToString() + "\r\n";
            }

            labelPrice.Text = getTotalAmount().ToString();
            labelItems.Text = Storage.Cart.Count.ToString();
        }


        private double getTotalAmount()
        {
            double sum = 0;
            foreach (Item item in Storage.Cart)
            {
                sum += item.getPrice();
            }
            return sum;
        }
        private void buttonBuy_Click(object sender, EventArgs e)
        {
            if (Storage.Cart.Count != 0)
            {
                Storage.Cart = new List<Item>();
                labelPrice.Text = "0";
                labelItems.Text = "0";
                comboBoxCart.Items.Clear();
                comboBoxCart.ResetText();
                textBoxItems.Text = "";
                MessageBox.Show("Thanks for buying in tal's and amit's shop !! :)");
            }
            else
                MessageBox.Show("your cart is empty  :(");
        }

    }
}
