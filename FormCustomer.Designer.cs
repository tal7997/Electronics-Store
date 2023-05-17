
namespace WinFormsApp1
{
    partial class FormCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCustomer));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.label_customer = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_PowerStrip = new System.Windows.Forms.Button();
            this.btn_Oven = new System.Windows.Forms.Button();
            this.label_Elctric_Item = new System.Windows.Forms.Label();
            this.btn_Kettle = new System.Windows.Forms.Button();
            this.btn_Refrigerator = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxItems = new System.Windows.Forms.TextBox();
            this.comboBoxItems = new System.Windows.Forms.ComboBox();
            this.buttonAddItemToCart = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.comboBoxCart = new System.Windows.Forms.ComboBox();
            this.labelAmount = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.buttonBuy = new System.Windows.Forms.Button();
            this.labelItems = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Controls.Add(this.label_customer);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 517);
            this.panel1.TabIndex = 3;
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.White;
            this.btn_exit.Location = new System.Drawing.Point(74, 413);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(123, 29);
            this.btn_exit.TabIndex = 3;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // label_customer
            // 
            this.label_customer.AutoSize = true;
            this.label_customer.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_customer.Location = new System.Drawing.Point(26, 77);
            this.label_customer.Name = "label_customer";
            this.label_customer.Size = new System.Drawing.Size(209, 31);
            this.label_customer.TabIndex = 1;
            this.label_customer.Text = "CUSTOMER MEMU";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btn_PowerStrip);
            this.panel2.Controls.Add(this.btn_Oven);
            this.panel2.Controls.Add(this.label_Elctric_Item);
            this.panel2.Controls.Add(this.btn_Kettle);
            this.panel2.Controls.Add(this.btn_Refrigerator);
            this.panel2.Location = new System.Drawing.Point(258, -3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(131, 520);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(25, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 62);
            this.label1.TabIndex = 5;
            this.label1.Text = "SIDES\r\nITEMS\r\n";
            // 
            // btn_PowerStrip
            // 
            this.btn_PowerStrip.Location = new System.Drawing.Point(11, 412);
            this.btn_PowerStrip.Name = "btn_PowerStrip";
            this.btn_PowerStrip.Size = new System.Drawing.Size(106, 29);
            this.btn_PowerStrip.TabIndex = 4;
            this.btn_PowerStrip.Text = "PowerStrip";
            this.btn_PowerStrip.UseVisualStyleBackColor = true;
            this.btn_PowerStrip.Click += new System.EventHandler(this.btn_PowerStrip_Click);
            // 
            // btn_Oven
            // 
            this.btn_Oven.Location = new System.Drawing.Point(11, 275);
            this.btn_Oven.Name = "btn_Oven";
            this.btn_Oven.Size = new System.Drawing.Size(106, 29);
            this.btn_Oven.TabIndex = 3;
            this.btn_Oven.Text = "Oven";
            this.btn_Oven.UseVisualStyleBackColor = true;
            this.btn_Oven.Click += new System.EventHandler(this.btn_Oven_Click);
            // 
            // label_Elctric_Item
            // 
            this.label_Elctric_Item.AutoSize = true;
            this.label_Elctric_Item.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Elctric_Item.Location = new System.Drawing.Point(13, 81);
            this.label_Elctric_Item.Name = "label_Elctric_Item";
            this.label_Elctric_Item.Size = new System.Drawing.Size(111, 62);
            this.label_Elctric_Item.TabIndex = 2;
            this.label_Elctric_Item.Text = "ELECTRIC\r\n  ITEMS\r\n";
            // 
            // btn_Kettle
            // 
            this.btn_Kettle.Location = new System.Drawing.Point(11, 224);
            this.btn_Kettle.Name = "btn_Kettle";
            this.btn_Kettle.Size = new System.Drawing.Size(106, 29);
            this.btn_Kettle.TabIndex = 1;
            this.btn_Kettle.Text = "Kettle";
            this.btn_Kettle.UseVisualStyleBackColor = true;
            this.btn_Kettle.Click += new System.EventHandler(this.btn_Kettle_Click);
            // 
            // btn_Refrigerator
            // 
            this.btn_Refrigerator.Location = new System.Drawing.Point(11, 171);
            this.btn_Refrigerator.Name = "btn_Refrigerator";
            this.btn_Refrigerator.Size = new System.Drawing.Size(106, 29);
            this.btn_Refrigerator.TabIndex = 0;
            this.btn_Refrigerator.Text = "Refrigerators";
            this.btn_Refrigerator.UseVisualStyleBackColor = true;
            this.btn_Refrigerator.Click += new System.EventHandler(this.btn_Refrigerator_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Tan;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(389, -3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(902, 75);
            this.panel3.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(55, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(397, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "HOME PAGE";
            // 
            // textBoxItems
            // 
            this.textBoxItems.Location = new System.Drawing.Point(389, 115);
            this.textBoxItems.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxItems.Multiline = true;
            this.textBoxItems.Name = "textBoxItems";
            this.textBoxItems.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxItems.Size = new System.Drawing.Size(901, 279);
            this.textBoxItems.TabIndex = 6;
            // 
            // comboBoxItems
            // 
            this.comboBoxItems.FormattingEnabled = true;
            this.comboBoxItems.Location = new System.Drawing.Point(529, 79);
            this.comboBoxItems.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxItems.Name = "comboBoxItems";
            this.comboBoxItems.Size = new System.Drawing.Size(747, 28);
            this.comboBoxItems.TabIndex = 7;
            this.comboBoxItems.Visible = false;
            // 
            // buttonAddItemToCart
            // 
            this.buttonAddItemToCart.Location = new System.Drawing.Point(397, 79);
            this.buttonAddItemToCart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAddItemToCart.Name = "buttonAddItemToCart";
            this.buttonAddItemToCart.Size = new System.Drawing.Size(126, 31);
            this.buttonAddItemToCart.TabIndex = 8;
            this.buttonAddItemToCart.Text = "Add Item";
            this.buttonAddItemToCart.UseVisualStyleBackColor = true;
            this.buttonAddItemToCart.Click += new System.EventHandler(this.buttonAddItemToCart_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(397, 403);
            this.buttonRemove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(126, 31);
            this.buttonRemove.TabIndex = 10;
            this.buttonRemove.Text = "Remove Item";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // comboBoxCart
            // 
            this.comboBoxCart.FormattingEnabled = true;
            this.comboBoxCart.Location = new System.Drawing.Point(529, 403);
            this.comboBoxCart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxCart.Name = "comboBoxCart";
            this.comboBoxCart.Size = new System.Drawing.Size(747, 28);
            this.comboBoxCart.TabIndex = 9;
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAmount.Location = new System.Drawing.Point(397, 437);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(154, 31);
            this.labelAmount.TabIndex = 11;
            this.labelAmount.Text = "Total Amount\n";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPrice.Location = new System.Drawing.Point(550, 437);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(27, 31);
            this.labelPrice.TabIndex = 12;
            this.labelPrice.Text = "0";
            // 
            // buttonBuy
            // 
            this.buttonBuy.Location = new System.Drawing.Point(626, 464);
            this.buttonBuy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(126, 31);
            this.buttonBuy.TabIndex = 13;
            this.buttonBuy.Text = "Buy Items";
            this.buttonBuy.UseVisualStyleBackColor = true;
            this.buttonBuy.Click += new System.EventHandler(this.buttonBuy_Click);
            // 
            // labelItems
            // 
            this.labelItems.AutoSize = true;
            this.labelItems.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelItems.Location = new System.Drawing.Point(550, 471);
            this.labelItems.Name = "labelItems";
            this.labelItems.Size = new System.Drawing.Size(27, 31);
            this.labelItems.TabIndex = 15;
            this.labelItems.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(397, 471);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 31);
            this.label4.TabIndex = 14;
            this.label4.Text = "Items\n";
            // 
            // FormCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1290, 517);
            this.ControlBox = false;
            this.Controls.Add(this.labelItems);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonBuy);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.comboBoxCart);
            this.Controls.Add(this.buttonAddItemToCart);
            this.Controls.Add(this.comboBoxItems);
            this.Controls.Add(this.textBoxItems);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCustomer";
            this.Text = "FormCustomer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label label_customer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_Elctric_Item;
        private System.Windows.Forms.Button btn_Kettle;
        private System.Windows.Forms.Button btn_Refrigerator;
        private System.Windows.Forms.Button btn_PowerStrip;
        private System.Windows.Forms.Button btn_Oven;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxItems;
        private System.Windows.Forms.ComboBox comboBoxItems;
        private System.Windows.Forms.Button buttonAddItemToCart;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.ComboBox comboBoxCart;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Button buttonBuy;
        private System.Windows.Forms.Label labelItems;
        private System.Windows.Forms.Label label4;
    }
}