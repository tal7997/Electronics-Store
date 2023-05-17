
namespace WinFormsApp1
{
    partial class FormManager
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_return = new System.Windows.Forms.Button();
            this.btn_showStock = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.managerLable = new System.Windows.Forms.Label();
            this.comboBoxSockets = new System.Windows.Forms.ComboBox();
            this.labelNumOfSockets = new System.Windows.Forms.Label();
            this.comboBoxMaxHeight = new System.Windows.Forms.ComboBox();
            this.labelMaxHigh = new System.Windows.Forms.Label();
            this.lb_id = new System.Windows.Forms.Label();
            this.tb_return_id = new System.Windows.Forms.TextBox();
            this.comboBoxDoors = new System.Windows.Forms.ComboBox();
            this.labelDoor = new System.Windows.Forms.Label();
            this.comboBoxYear = new System.Windows.Forms.ComboBox();
            this.comboBoxLitters = new System.Windows.Forms.ComboBox();
            this.labelLitter = new System.Windows.Forms.Label();
            this.comboBoxColors = new System.Windows.Forms.ComboBox();
            this.lb_price = new System.Windows.Forms.Label();
            this.tb_return_price = new System.Windows.Forms.TextBox();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelColor = new System.Windows.Forms.Label();
            this.comboBoxItems = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxData = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Controls.Add(this.btn_return);
            this.panel1.Controls.Add(this.btn_showStock);
            this.panel1.Controls.Add(this.btn_remove);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 524);
            this.panel1.TabIndex = 3;
            // 
            // btn_return
            // 
            this.btn_return.BackColor = System.Drawing.Color.White;
            this.btn_return.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_return.Location = new System.Drawing.Point(58, 347);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(146, 29);
            this.btn_return.TabIndex = 4;
            this.btn_return.Text = "Return to menu";
            this.btn_return.UseVisualStyleBackColor = false;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // btn_showStock
            // 
            this.btn_showStock.BackColor = System.Drawing.Color.White;
            this.btn_showStock.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_showStock.Location = new System.Drawing.Point(58, 287);
            this.btn_showStock.Name = "btn_showStock";
            this.btn_showStock.Size = new System.Drawing.Size(146, 29);
            this.btn_showStock.TabIndex = 3;
            this.btn_showStock.Text = "Show the stock";
            this.btn_showStock.UseVisualStyleBackColor = false;
            this.btn_showStock.Click += new System.EventHandler(this.btn_showStock_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.BackColor = System.Drawing.Color.White;
            this.btn_remove.Location = new System.Drawing.Point(58, 205);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(146, 76);
            this.btn_remove.TabIndex = 2;
            this.btn_remove.Text = "Remove item from stock";
            this.btn_remove.UseVisualStyleBackColor = false;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(49, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "ADMIN MENU";
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.White;
            this.btn_add.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_add.Location = new System.Drawing.Point(58, 152);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(146, 29);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Add item to stock";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // managerLable
            // 
            this.managerLable.AutoSize = true;
            this.managerLable.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.managerLable.Location = new System.Drawing.Point(594, 20);
            this.managerLable.Name = "managerLable";
            this.managerLable.Size = new System.Drawing.Size(268, 45);
            this.managerLable.TabIndex = 4;
            this.managerLable.Text = "ELECTRIC STORE";
            // 
            // comboBoxSockets
            // 
            this.comboBoxSockets.DisplayMember = "2 3 4 5 6 7 8";
            this.comboBoxSockets.FormattingEnabled = true;
            this.comboBoxSockets.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.comboBoxSockets.Location = new System.Drawing.Point(474, 193);
            this.comboBoxSockets.Name = "comboBoxSockets";
            this.comboBoxSockets.Size = new System.Drawing.Size(151, 28);
            this.comboBoxSockets.Sorted = true;
            this.comboBoxSockets.TabIndex = 36;
            this.comboBoxSockets.Text = "select socket";
            // 
            // labelNumOfSockets
            // 
            this.labelNumOfSockets.AutoSize = true;
            this.labelNumOfSockets.Location = new System.Drawing.Point(274, 193);
            this.labelNumOfSockets.Name = "labelNumOfSockets";
            this.labelNumOfSockets.Size = new System.Drawing.Size(139, 20);
            this.labelNumOfSockets.TabIndex = 35;
            this.labelNumOfSockets.Text = "Numbers of sockets";
            // 
            // comboBoxMaxHeight
            // 
            this.comboBoxMaxHeight.FormattingEnabled = true;
            this.comboBoxMaxHeight.Items.AddRange(new object[] {
            "200",
            "300"});
            this.comboBoxMaxHeight.Location = new System.Drawing.Point(475, 376);
            this.comboBoxMaxHeight.Name = "comboBoxMaxHeight";
            this.comboBoxMaxHeight.Size = new System.Drawing.Size(151, 28);
            this.comboBoxMaxHeight.Sorted = true;
            this.comboBoxMaxHeight.TabIndex = 34;
            this.comboBoxMaxHeight.Text = "select max high";
            // 
            // labelMaxHigh
            // 
            this.labelMaxHigh.AutoSize = true;
            this.labelMaxHigh.Location = new System.Drawing.Point(277, 376);
            this.labelMaxHigh.Name = "labelMaxHigh";
            this.labelMaxHigh.Size = new System.Drawing.Size(70, 20);
            this.labelMaxHigh.TabIndex = 33;
            this.labelMaxHigh.Text = "Max high";
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Location = new System.Drawing.Point(277, 429);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(24, 20);
            this.lb_id.TabIndex = 32;
            this.lb_id.Text = "ID";
            // 
            // tb_return_id
            // 
            this.tb_return_id.Location = new System.Drawing.Point(475, 421);
            this.tb_return_id.Name = "tb_return_id";
            this.tb_return_id.ReadOnly = true;
            this.tb_return_id.Size = new System.Drawing.Size(151, 27);
            this.tb_return_id.TabIndex = 31;
            this.tb_return_id.TextChanged += new System.EventHandler(this.tb_return_id_TextChanged);
            // 
            // comboBoxDoors
            // 
            this.comboBoxDoors.FormattingEnabled = true;
            this.comboBoxDoors.Items.AddRange(new object[] {
            "2",
            "4"});
            this.comboBoxDoors.Location = new System.Drawing.Point(475, 325);
            this.comboBoxDoors.Name = "comboBoxDoors";
            this.comboBoxDoors.Size = new System.Drawing.Size(151, 28);
            this.comboBoxDoors.Sorted = true;
            this.comboBoxDoors.TabIndex = 30;
            this.comboBoxDoors.Text = "select doors";
            // 
            // labelDoor
            // 
            this.labelDoor.AutoSize = true;
            this.labelDoor.Location = new System.Drawing.Point(277, 328);
            this.labelDoor.Name = "labelDoor";
            this.labelDoor.Size = new System.Drawing.Size(49, 20);
            this.labelDoor.TabIndex = 29;
            this.labelDoor.Text = "Doors";
            // 
            // comboBoxYear
            // 
            this.comboBoxYear.FormattingEnabled = true;
            this.comboBoxYear.Items.AddRange(new object[] {
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022"});
            this.comboBoxYear.Location = new System.Drawing.Point(474, 235);
            this.comboBoxYear.Name = "comboBoxYear";
            this.comboBoxYear.Size = new System.Drawing.Size(151, 28);
            this.comboBoxYear.Sorted = true;
            this.comboBoxYear.TabIndex = 28;
            this.comboBoxYear.Text = "select year";
            // 
            // comboBoxLitters
            // 
            this.comboBoxLitters.FormattingEnabled = true;
            this.comboBoxLitters.Location = new System.Drawing.Point(475, 280);
            this.comboBoxLitters.Name = "comboBoxLitters";
            this.comboBoxLitters.Size = new System.Drawing.Size(151, 28);
            this.comboBoxLitters.Sorted = true;
            this.comboBoxLitters.TabIndex = 27;
            this.comboBoxLitters.Text = "select litter";
            // 
            // labelLitter
            // 
            this.labelLitter.AutoSize = true;
            this.labelLitter.Location = new System.Drawing.Point(277, 283);
            this.labelLitter.Name = "labelLitter";
            this.labelLitter.Size = new System.Drawing.Size(49, 20);
            this.labelLitter.TabIndex = 26;
            this.labelLitter.Text = "Litters";
            // 
            // comboBoxColors
            // 
            this.comboBoxColors.AccessibleName = "";
            this.comboBoxColors.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboBoxColors.FormattingEnabled = true;
            this.comboBoxColors.Items.AddRange(new object[] {
            "Black",
            "Grey",
            "White"});
            this.comboBoxColors.Location = new System.Drawing.Point(474, 155);
            this.comboBoxColors.Name = "comboBoxColors";
            this.comboBoxColors.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxColors.Size = new System.Drawing.Size(151, 28);
            this.comboBoxColors.Sorted = true;
            this.comboBoxColors.TabIndex = 25;
            this.comboBoxColors.Text = "select color";
            this.comboBoxColors.SelectedIndexChanged += new System.EventHandler(this.comboBoxColors_SelectedIndexChanged);
            // 
            // lb_price
            // 
            this.lb_price.AutoSize = true;
            this.lb_price.Location = new System.Drawing.Point(274, 473);
            this.lb_price.Name = "lb_price";
            this.lb_price.Size = new System.Drawing.Size(41, 20);
            this.lb_price.TabIndex = 24;
            this.lb_price.Text = "Price";
            // 
            // tb_return_price
            // 
            this.tb_return_price.Location = new System.Drawing.Point(474, 467);
            this.tb_return_price.Name = "tb_return_price";
            this.tb_return_price.ReadOnly = true;
            this.tb_return_price.Size = new System.Drawing.Size(151, 27);
            this.tb_return_price.TabIndex = 23;
            this.tb_return_price.TextChanged += new System.EventHandler(this.tb_return_price_TextChanged);
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(274, 235);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(124, 20);
            this.labelYear.TabIndex = 22;
            this.labelYear.Text = "year of prodction";
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Location = new System.Drawing.Point(274, 155);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(43, 20);
            this.labelColor.TabIndex = 21;
            this.labelColor.Text = "color";
            // 
            // comboBoxItems
            // 
            this.comboBoxItems.ForeColor = System.Drawing.Color.Black;
            this.comboBoxItems.FormattingEnabled = true;
            this.comboBoxItems.Items.AddRange(new object[] {
            "Kettle",
            "Oven",
            "PowerStrip",
            "Refrigerator"});
            this.comboBoxItems.Location = new System.Drawing.Point(410, 108);
            this.comboBoxItems.Name = "comboBoxItems";
            this.comboBoxItems.Size = new System.Drawing.Size(151, 28);
            this.comboBoxItems.Sorted = true;
            this.comboBoxItems.TabIndex = 20;
            this.comboBoxItems.Text = "select item";
            this.comboBoxItems.SelectedIndexChanged += new System.EventHandler(this.cmb_items_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "Choose item:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(433, 20);
            this.label3.TabIndex = 38;
            this.label3.Text = "Please Select Item from the list and choose one the next actions:";
            // 
            // textBoxData
            // 
            this.textBoxData.Location = new System.Drawing.Point(655, 92);
            this.textBoxData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxData.Multiline = true;
            this.textBoxData.Name = "textBoxData";
            this.textBoxData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxData.Size = new System.Drawing.Size(623, 405);
            this.textBoxData.TabIndex = 41;
            // 
            // FormManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1290, 511);
            this.ControlBox = false;
            this.Controls.Add(this.textBoxData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSockets);
            this.Controls.Add(this.labelNumOfSockets);
            this.Controls.Add(this.comboBoxMaxHeight);
            this.Controls.Add(this.labelMaxHigh);
            this.Controls.Add(this.lb_id);
            this.Controls.Add(this.tb_return_id);
            this.Controls.Add(this.comboBoxDoors);
            this.Controls.Add(this.labelDoor);
            this.Controls.Add(this.comboBoxYear);
            this.Controls.Add(this.comboBoxLitters);
            this.Controls.Add(this.labelLitter);
            this.Controls.Add(this.comboBoxColors);
            this.Controls.Add(this.lb_price);
            this.Controls.Add(this.tb_return_price);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.labelColor);
            this.Controls.Add(this.comboBoxItems);
            this.Controls.Add(this.managerLable);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormManager";
            this.Text = "formMangger";
            this.Load += new System.EventHandler(this.FormManager_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label managerLable;
        private System.Windows.Forms.Button btn_showStock;
        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.ComboBox comboBoxSockets;
        private System.Windows.Forms.Label labelNumOfSockets;
        private System.Windows.Forms.ComboBox comboBoxMaxHeight;
        private System.Windows.Forms.Label labelMaxHigh;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.TextBox tb_return_id;
        private System.Windows.Forms.ComboBox comboBoxDoors;
        private System.Windows.Forms.Label labelDoor;
        private System.Windows.Forms.ComboBox comboBoxYear;
        private System.Windows.Forms.ComboBox comboBoxLitters;
        private System.Windows.Forms.Label labelLitter;
        private System.Windows.Forms.ComboBox comboBoxColors;
        private System.Windows.Forms.Label lb_price;
        private System.Windows.Forms.TextBox tb_return_price;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.ComboBox comboBoxItems;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxData;
    }
}