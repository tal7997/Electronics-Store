using System;
using System.Windows.Forms;
using WinFormsApp1.DataStoarge;
using WinFormsApp1.NewFolder;
using System.Collections.Generic;
using System.IO;

namespace WinFormsApp1
{
    public partial class FormManager : Form
    {
        public FormManager()
        {
            InitializeComponent();

        }
        private void refreshForItem()
        {
            comboBoxLitters.Visible = false;
            comboBoxDoors.Visible = false;
            comboBoxColors.Visible = false;
            comboBoxYear.Visible = false;
            comboBoxMaxHeight.Visible = false;
            comboBoxSockets.Visible = false;
            labelLitter.Visible = false;
            labelDoor.Visible = false;
            labelColor.Visible = false;
            labelYear.Visible = false;
            labelMaxHigh.Visible = false;
            labelNumOfSockets.Visible = false;

            comboBoxLitters.Items.Clear();

        }

        private void visibleKettle()
        {
            labelLitter.Visible = true;
            comboBoxLitters.Visible = true;
            labelColor.Visible = true;
            comboBoxColors.Visible = true;
            labelYear.Visible = true;
            comboBoxYear.Visible = true;

            comboBoxLitters.Items.Add("1.7");
            comboBoxLitters.Items.Add("2.1");
        }
        private void visibleOven()
        {
            labelLitter.Visible = true;
            comboBoxLitters.Visible = true;
            labelColor.Visible = true;
            comboBoxColors.Visible = true;
            labelYear.Visible = true;
            comboBoxYear.Visible = true;
            labelMaxHigh.Visible = true;
            comboBoxMaxHeight.Visible = true;

            comboBoxLitters.Items.Add("60");
            comboBoxLitters.Items.Add("90");
        }
        private void visiblePowerStrip()
        {
            labelNumOfSockets.Visible = true;
            comboBoxSockets.Visible = true;
        }
        private void visibleRefrigerator()
        {
            labelLitter.Visible = true;
            comboBoxLitters.Visible = true;
            labelDoor.Visible = true;
            comboBoxDoors.Visible = true;
            labelColor.Visible = true;
            comboBoxColors.Visible = true;
            labelYear.Visible = true;
            comboBoxYear.Visible = true;

            comboBoxLitters.Items.Add("450");
            comboBoxLitters.Items.Add("550");
            comboBoxLitters.Items.Add("650");
            comboBoxLitters.Items.Add("750");
        }

        private void refresh_comboBox()
        {
            comboBoxColors.Text = "select color";
            comboBoxYear.Text = "select year";
            comboBoxDoors.Text = "select door";
            comboBoxLitters.Text = "select litter";
            comboBoxMaxHeight.Text = "select Max high";
            comboBoxSockets.Text = "select socket";
        }

        /*private void btn_add_Click(object sender, EventArgs e)
        {
            switch (comboBoxItems.SelectedItem.ToString())
            {
                case "Kettle":
                    Storage.Stock.Add(new Kettle(comboBoxColors.SelectedItem.ToString(),
                        Convert.ToInt32(comboBoxYear.SelectedItem),
                        Convert.ToDouble(comboBoxLitters.SelectedItem)));
                    break;
                case "Oven":
                    Storage.Stock.Add(new Oven(comboBoxColors.SelectedItem.ToString(),
                        Convert.ToInt32(comboBoxYear.SelectedItem),
                        Convert.ToInt32(comboBoxLitters.SelectedItem), Convert.ToInt32(comboBoxMaxHeight.SelectedItem)));
                    break;
                case "PowerStrip":
                    Storage.Stock.Add(new PowerStrip(Convert.ToInt32(comboBoxSockets.SelectedItem)));
                    break;
                case "Refrigerator":
                    Storage.Stock.Add(new Refrigerator(comboBoxColors.SelectedItem.ToString(),
                        Convert.ToInt32(comboBoxYear.SelectedItem),
                        Convert.ToInt32(comboBoxLitters.SelectedItem), Convert.ToInt32(comboBoxDoors.SelectedItem)));
                    break;

                default:
                    break;
            }

            showData();
            refresh_comboBox();
            Storage.SaveData();
            tb_return_id_TextChanged(sender, e);
            tb_return_price_TextChanged(sender, e);
        }*/

        private void btn_return_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmb_items_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshForItem();

            switch (comboBoxItems.SelectedItem.ToString())
            {
                case "Kettle":
                    visibleKettle();
                    break;
                case "Oven":
                    visibleOven();
                    break;
                case "PowerStrip":
                    visiblePowerStrip();
                    break;
                case "Refrigerator":
                    visibleRefrigerator();
                    break;

                default:
                    break;
            }
            refresh_comboBox();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            bool flag = false;
            switch (comboBoxItems.SelectedIndex)
            {
                case 0: // for Kettle
                    if (comboBoxColors.Text.Contains("select") || comboBoxYear.Text.Contains("select") || comboBoxLitters.Text.Contains("select"))
                        MessageBox.Show("Please finish fill the form");
                    else
                    {
                        Storage.Stock.Add(new Kettle(comboBoxColors.SelectedItem.ToString(),
                        Convert.ToInt32(comboBoxYear.SelectedItem),
                        Convert.ToDouble(comboBoxLitters.SelectedItem)));
                        flag = true;
                    }
                    break;
                case 1: // for Oven
                    if (comboBoxColors.Text.Contains("select") || comboBoxYear.Text.Contains("select") || comboBoxLitters.Text.Contains("select") || comboBoxMaxHeight.Text.Contains("select"))
                        MessageBox.Show("Please finish fill the form");
                    else
                    {
                        Storage.Stock.Add(new Oven(comboBoxColors.SelectedItem.ToString(),
                        Convert.ToInt32(comboBoxYear.SelectedItem),
                        Convert.ToInt32(comboBoxLitters.SelectedItem), Convert.ToInt32(comboBoxMaxHeight.SelectedItem)));
                        flag = true;
                    }
                    break;
                case 2: // for PowerStrip
                    if (comboBoxSockets.Text.Contains("select"))
                        MessageBox.Show("Please finish fill the form");
                    else
                    {
                        Storage.Stock.Add(new PowerStrip(Convert.ToInt32(comboBoxSockets.SelectedItem)));
                        flag = true;
                    }
                    break;
                case 3:  //for Refrigetor
                    if (comboBoxColors.Text.Contains("select") || comboBoxYear.Text.Contains("select") || comboBoxLitters.Text.Contains("select") || comboBoxDoors.Text.Contains("select"))
                        MessageBox.Show("Please finish fill the form");
                    else
                    {
                        Storage.Stock.Add(new Refrigerator(comboBoxColors.SelectedItem.ToString(),
                        Convert.ToInt32(comboBoxYear.SelectedItem),
                        Convert.ToInt32(comboBoxLitters.SelectedItem), Convert.ToInt32(comboBoxDoors.SelectedItem)));
                        flag = true;
                    }
                    break;
            }
            if (flag)
            {
                showData();
                refresh_comboBox();
                Storage.SaveData();
                tb_return_id_TextChanged(sender, e);
                tb_return_price_TextChanged(sender, e);
            }
        }

        private void FormManager_Load(object sender, EventArgs e)
        {
            refreshForItem();
            showData();
        }
        private void showData()
        {
            textBoxData.Text = "";
            if(Storage.Stock != null)
            {
                foreach (Item item in Storage.Stock)
                {
                    textBoxData.Text += item.ToString() + "\r\n";
                }
            }

        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            bool flag = false;
            Item item;
            switch (comboBoxItems.SelectedIndex)
            {
                case 0: // for Kettle
                    if (comboBoxColors.Text.Contains("select") || comboBoxYear.Text.Contains("select") || comboBoxLitters.Text.Contains("select"))
                        MessageBox.Show("Please finish fill the form");
                    else
                    {
                        item = new Kettle(comboBoxColors.SelectedItem.ToString(),
                        Convert.ToInt32(comboBoxYear.SelectedItem),
                        Convert.ToDouble(comboBoxLitters.SelectedItem));
                        foreach (Item item2 in Storage.Stock)
                        {
                            if (item.getId() == item2.getId())
                            {
                                Storage.Stock.Remove(item2);
                                flag = true;
                                tb_return_id.Text = item.getId().ToString();
                                tb_return_price.Text = item.getPrice().ToString();
                                break;
                            }

                        }

                        if (flag)
                        {
                            MessageBox.Show("The item deleted");
                        }
                        else
                        {
                            MessageBox.Show("Not exict this item in a stock");
                        }
                    }
                    break;
                case 1: // for Oven
                    if (comboBoxColors.Text.Contains("select") || comboBoxYear.Text.Contains("select") || comboBoxLitters.Text.Contains("select") || comboBoxMaxHeight.Text.Contains("select"))
                        MessageBox.Show("Please finish fill the form");
                    else
                    {
                        item = new Oven(comboBoxColors.SelectedItem.ToString(),
                        Convert.ToInt32(comboBoxYear.SelectedItem),
                        Convert.ToInt32(comboBoxLitters.SelectedItem), Convert.ToInt32(comboBoxMaxHeight.SelectedItem));
                        foreach (Item item2 in Storage.Stock)
                        {
                            if (item.getId() == item2.getId())
                            {
                                Storage.Stock.Remove(item2);
                                flag = true;
                                tb_return_id.Text = item.getId().ToString();
                                tb_return_price.Text = item.getPrice().ToString();
                                break;
                            }
                        }

                        if (flag)
                        {
                            MessageBox.Show("The item deleted");
                        }
                        else
                        {
                            MessageBox.Show("Not exict this item in a stock");
                        }
                    }
                    break;
                case 2: // for PowerStrip
                    if (comboBoxSockets.Text.Contains("select"))
                        MessageBox.Show("Please finish fill the form");
                    else
                    {
                        item = new PowerStrip(Convert.ToInt32(comboBoxSockets.SelectedItem));
                        foreach (Item item2 in Storage.Stock)
                        {
                            if(item.getId() == item2.getId())
                            {
                                Storage.Stock.Remove(item2);
                                flag = true;
                                tb_return_id.Text = item.getId().ToString();
                                tb_return_price.Text = item.getPrice().ToString();
                                break;
                            }
                        }

                        if (flag)
                        {
                            MessageBox.Show("The item deleted");
                        }
                        else
                            MessageBox.Show("Not exict this item in a stock");
                    }
                    break;
                case 3:  //for Refrigetor
                    if (comboBoxColors.Text.Contains("select") || comboBoxYear.Text.Contains("select") || comboBoxLitters.Text.Contains("select") || comboBoxDoors.Text.Contains("select"))
                        MessageBox.Show("Please finish fill the form");
                    else
                    {
                        item = new Refrigerator(comboBoxColors.SelectedItem.ToString(),
                        Convert.ToInt32(comboBoxYear.SelectedItem),
                        Convert.ToInt32(comboBoxLitters.SelectedItem), Convert.ToInt32(comboBoxDoors.SelectedItem));
                        foreach (Item item2 in Storage.Stock)
                        {
                            if (item.getId() == item2.getId())
                            {
                                Storage.Stock.Remove(item2);
                                flag = true;
                                tb_return_id.Text = item.getId().ToString();
                                tb_return_price.Text = item.getPrice().ToString();
                                break;
                            }
                        }

                        if (flag)
                        {
                            MessageBox.Show("The item deleted");
                        }
                        else
                        { 
                            MessageBox.Show("Not exict this item in a stock");
                        }
                    }
                    break;
            }
            if (flag)
            {
                showData();
                refresh_comboBox();
                Storage.SaveData();
            }
        }

        private void tb_return_id_TextChanged(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines("Temp_FILE.txt");
            if (lines != null)
            {
                int count = lines.Length - 1;
                string[] sublines = lines[count].Split(" ");
                tb_return_id.Text = sublines[4];
            }
        }

        private void tb_return_price_TextChanged(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines("Temp_FILE.txt");
            if (lines != null)
            {
                int count = lines.Length - 1;
                string[] sublines = lines[count].Split(" ");
                tb_return_price.Text = sublines[2];
            }
        }

        private void btn_showStock_Click(object sender, EventArgs e)
        {
            showData();
        }

        private void comboBoxColors_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}