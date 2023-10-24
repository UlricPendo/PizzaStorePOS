namespace PizzaStorePOS
{
    partial class PizzaStorePOS
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dailyAuditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.driverCashoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cashRegisterItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userAccountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toppingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterToppingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toppingValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.specialtyPizzasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.combosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instructionsMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeliveryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deliveryAddressessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deliveryChargesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.driversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeClockInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.driverCashoutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.onlineOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onlineOrderTimesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onlineOrderHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onlineOrderDailyAuditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onlineOrderSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.NewOrder1 = new System.Windows.Forms.Button();
            this.ModifyOrder1 = new System.Windows.Forms.Button();
            this.CancelOrder1 = new System.Windows.Forms.Button();
            this.Driver1 = new System.Windows.Forms.Button();
            this.CashRegister = new System.Windows.Forms.Button();
            this.AddressPanel = new System.Windows.Forms.Panel();
            this.ChangeAddress1 = new System.Windows.Forms.Button();
            this.BuzzNum1 = new System.Windows.Forms.TextBox();
            this.BuzzNum = new System.Windows.Forms.TextBox();
            this.ApptNum1 = new System.Windows.Forms.TextBox();
            this.ApptNum = new System.Windows.Forms.TextBox();
            this.StreetName1 = new System.Windows.Forms.TextBox();
            this.StreetName = new System.Windows.Forms.TextBox();
            this.AddressNumber1 = new System.Windows.Forms.TextBox();
            this.AddressNumber = new System.Windows.Forms.TextBox();
            this.PhoneNumber1 = new System.Windows.Forms.TextBox();
            this.PhoneNumber = new System.Windows.Forms.TextBox();
            this.PickUpDelivery = new System.Windows.Forms.CheckBox();
            this.OrderPanel1 = new System.Windows.Forms.Panel();
            this.MakeCombo1 = new System.Windows.Forms.Button();
            this.Cancel1 = new System.Windows.Forms.Button();
            this.DeleteCombo1 = new System.Windows.Forms.Button();
            this.Instructions1 = new System.Windows.Forms.Button();
            this.DippingSauce1 = new System.Windows.Forms.Button();
            this.ChangeSize1 = new System.Windows.Forms.Button();
            this.Toppings1 = new System.Windows.Forms.Button();
            this.Combos1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DataComboName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataToppings = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckoutPanel = new System.Windows.Forms.Panel();
            this.PrevOrder1 = new System.Windows.Forms.Button();
            this.Checkout1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.AddressPanel.SuspendLayout();
            this.OrderPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.CheckoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.toppingsToolStripMenuItem,
            this.DeliveryToolStripMenuItem,
            this.driversToolStripMenuItem,
            this.onlineOrderToolStripMenuItem,
            this.toolStripTextBox1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 0, 0, 8);
            this.menuStrip1.Size = new System.Drawing.Size(1443, 37);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dailyAuditToolStripMenuItem,
            this.driverCashoutToolStripMenuItem,
            this.paymentOptionsToolStripMenuItem,
            this.cashRegisterItemsToolStripMenuItem,
            this.userAccountsToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(81, 29);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // dailyAuditToolStripMenuItem
            // 
            this.dailyAuditToolStripMenuItem.Name = "dailyAuditToolStripMenuItem";
            this.dailyAuditToolStripMenuItem.Size = new System.Drawing.Size(287, 34);
            this.dailyAuditToolStripMenuItem.Text = "Daily Audit";
            // 
            // driverCashoutToolStripMenuItem
            // 
            this.driverCashoutToolStripMenuItem.Name = "driverCashoutToolStripMenuItem";
            this.driverCashoutToolStripMenuItem.Size = new System.Drawing.Size(287, 34);
            this.driverCashoutToolStripMenuItem.Text = "Employee Attendance";
            // 
            // paymentOptionsToolStripMenuItem
            // 
            this.paymentOptionsToolStripMenuItem.Name = "paymentOptionsToolStripMenuItem";
            this.paymentOptionsToolStripMenuItem.Size = new System.Drawing.Size(287, 34);
            this.paymentOptionsToolStripMenuItem.Text = "Payment Options";
            // 
            // cashRegisterItemsToolStripMenuItem
            // 
            this.cashRegisterItemsToolStripMenuItem.Name = "cashRegisterItemsToolStripMenuItem";
            this.cashRegisterItemsToolStripMenuItem.Size = new System.Drawing.Size(287, 34);
            this.cashRegisterItemsToolStripMenuItem.Text = "Cash Register Items";
            // 
            // userAccountsToolStripMenuItem
            // 
            this.userAccountsToolStripMenuItem.Name = "userAccountsToolStripMenuItem";
            this.userAccountsToolStripMenuItem.Size = new System.Drawing.Size(287, 34);
            this.userAccountsToolStripMenuItem.Text = "User Accounts";
            // 
            // toppingsToolStripMenuItem
            // 
            this.toppingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterToppingsToolStripMenuItem,
            this.toppingValueToolStripMenuItem,
            this.specialtyPizzasToolStripMenuItem,
            this.menuItemsToolStripMenuItem,
            this.combosToolStripMenuItem,
            this.instructionsMasterToolStripMenuItem});
            this.toppingsToolStripMenuItem.Name = "toppingsToolStripMenuItem";
            this.toppingsToolStripMenuItem.Size = new System.Drawing.Size(126, 29);
            this.toppingsToolStripMenuItem.Text = "Pizza Master";
            // 
            // masterToppingsToolStripMenuItem
            // 
            this.masterToppingsToolStripMenuItem.Name = "masterToppingsToolStripMenuItem";
            this.masterToppingsToolStripMenuItem.Size = new System.Drawing.Size(265, 34);
            this.masterToppingsToolStripMenuItem.Text = "Master Toppings";
            this.masterToppingsToolStripMenuItem.Click += new System.EventHandler(this.masterToppingsToolStripMenuItem_Click);
            // 
            // toppingValueToolStripMenuItem
            // 
            this.toppingValueToolStripMenuItem.Name = "toppingValueToolStripMenuItem";
            this.toppingValueToolStripMenuItem.Size = new System.Drawing.Size(265, 34);
            this.toppingValueToolStripMenuItem.Text = "Topping Value";
            // 
            // specialtyPizzasToolStripMenuItem
            // 
            this.specialtyPizzasToolStripMenuItem.Name = "specialtyPizzasToolStripMenuItem";
            this.specialtyPizzasToolStripMenuItem.Size = new System.Drawing.Size(265, 34);
            this.specialtyPizzasToolStripMenuItem.Text = "Specialty Pizzas";
            // 
            // menuItemsToolStripMenuItem
            // 
            this.menuItemsToolStripMenuItem.Name = "menuItemsToolStripMenuItem";
            this.menuItemsToolStripMenuItem.Size = new System.Drawing.Size(265, 34);
            this.menuItemsToolStripMenuItem.Text = "Menu Items";
            // 
            // combosToolStripMenuItem
            // 
            this.combosToolStripMenuItem.Name = "combosToolStripMenuItem";
            this.combosToolStripMenuItem.Size = new System.Drawing.Size(265, 34);
            this.combosToolStripMenuItem.Text = "Combos";
            this.combosToolStripMenuItem.Click += new System.EventHandler(this.combosToolStripMenuItem_Click);
            // 
            // instructionsMasterToolStripMenuItem
            // 
            this.instructionsMasterToolStripMenuItem.Name = "instructionsMasterToolStripMenuItem";
            this.instructionsMasterToolStripMenuItem.Size = new System.Drawing.Size(265, 34);
            this.instructionsMasterToolStripMenuItem.Text = "Instructions Master";
            // 
            // DeliveryToolStripMenuItem
            // 
            this.DeliveryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deliveryAddressessToolStripMenuItem,
            this.deliveryChargesToolStripMenuItem});
            this.DeliveryToolStripMenuItem.Name = "DeliveryToolStripMenuItem";
            this.DeliveryToolStripMenuItem.Size = new System.Drawing.Size(160, 29);
            this.DeliveryToolStripMenuItem.Text = "Delivery Options";
            // 
            // deliveryAddressessToolStripMenuItem
            // 
            this.deliveryAddressessToolStripMenuItem.Name = "deliveryAddressessToolStripMenuItem";
            this.deliveryAddressessToolStripMenuItem.Size = new System.Drawing.Size(246, 34);
            this.deliveryAddressessToolStripMenuItem.Text = "Street Locations";
            // 
            // deliveryChargesToolStripMenuItem
            // 
            this.deliveryChargesToolStripMenuItem.Name = "deliveryChargesToolStripMenuItem";
            this.deliveryChargesToolStripMenuItem.Size = new System.Drawing.Size(246, 34);
            this.deliveryChargesToolStripMenuItem.Text = "Delivery Charges";
            // 
            // driversToolStripMenuItem
            // 
            this.driversToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeClockInToolStripMenuItem,
            this.driverCashoutToolStripMenuItem1});
            this.driversToolStripMenuItem.Name = "driversToolStripMenuItem";
            this.driversToolStripMenuItem.Size = new System.Drawing.Size(106, 29);
            this.driversToolStripMenuItem.Text = "Employee";
            // 
            // employeeClockInToolStripMenuItem
            // 
            this.employeeClockInToolStripMenuItem.Name = "employeeClockInToolStripMenuItem";
            this.employeeClockInToolStripMenuItem.Size = new System.Drawing.Size(259, 34);
            this.employeeClockInToolStripMenuItem.Text = "Employee Clock in";
            // 
            // driverCashoutToolStripMenuItem1
            // 
            this.driverCashoutToolStripMenuItem1.Name = "driverCashoutToolStripMenuItem1";
            this.driverCashoutToolStripMenuItem1.Size = new System.Drawing.Size(259, 34);
            this.driverCashoutToolStripMenuItem1.Text = "Driver Cashout";
            // 
            // onlineOrderToolStripMenuItem
            // 
            this.onlineOrderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onlineOrderTimesToolStripMenuItem,
            this.onlineOrderHistoryToolStripMenuItem,
            this.onlineOrderDailyAuditToolStripMenuItem,
            this.onlineOrderSettingsToolStripMenuItem});
            this.onlineOrderToolStripMenuItem.Name = "onlineOrderToolStripMenuItem";
            this.onlineOrderToolStripMenuItem.Size = new System.Drawing.Size(130, 29);
            this.onlineOrderToolStripMenuItem.Text = "Online Order";
            // 
            // onlineOrderTimesToolStripMenuItem
            // 
            this.onlineOrderTimesToolStripMenuItem.Name = "onlineOrderTimesToolStripMenuItem";
            this.onlineOrderTimesToolStripMenuItem.Size = new System.Drawing.Size(308, 34);
            this.onlineOrderTimesToolStripMenuItem.Text = "Online Order Times";
            // 
            // onlineOrderHistoryToolStripMenuItem
            // 
            this.onlineOrderHistoryToolStripMenuItem.Name = "onlineOrderHistoryToolStripMenuItem";
            this.onlineOrderHistoryToolStripMenuItem.Size = new System.Drawing.Size(308, 34);
            this.onlineOrderHistoryToolStripMenuItem.Text = "Online Order History";
            // 
            // onlineOrderDailyAuditToolStripMenuItem
            // 
            this.onlineOrderDailyAuditToolStripMenuItem.Name = "onlineOrderDailyAuditToolStripMenuItem";
            this.onlineOrderDailyAuditToolStripMenuItem.Size = new System.Drawing.Size(308, 34);
            this.onlineOrderDailyAuditToolStripMenuItem.Text = "Online Order Daily Audit";
            // 
            // onlineOrderSettingsToolStripMenuItem
            // 
            this.onlineOrderSettingsToolStripMenuItem.Name = "onlineOrderSettingsToolStripMenuItem";
            this.onlineOrderSettingsToolStripMenuItem.Size = new System.Drawing.Size(308, 34);
            this.onlineOrderSettingsToolStripMenuItem.Text = "Online Order settings";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.ReadOnly = true;
            this.toolStripTextBox1.Size = new System.Drawing.Size(262, 29);
            this.toolStripTextBox1.Text = "Online Order Status: ";
            // 
            // NewOrder1
            // 
            this.NewOrder1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NewOrder1.Location = new System.Drawing.Point(10, 48);
            this.NewOrder1.Margin = new System.Windows.Forms.Padding(38, 40, 38, 40);
            this.NewOrder1.MaximumSize = new System.Drawing.Size(188, 160);
            this.NewOrder1.MinimumSize = new System.Drawing.Size(188, 160);
            this.NewOrder1.Name = "NewOrder1";
            this.NewOrder1.Padding = new System.Windows.Forms.Padding(15, 16, 15, 16);
            this.NewOrder1.Size = new System.Drawing.Size(188, 160);
            this.NewOrder1.TabIndex = 1;
            this.NewOrder1.Text = "New Order";
            this.NewOrder1.UseVisualStyleBackColor = true;
            this.NewOrder1.Click += new System.EventHandler(this.NewOrder1_Click);
            // 
            // ModifyOrder1
            // 
            this.ModifyOrder1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ModifyOrder1.Location = new System.Drawing.Point(206, 48);
            this.ModifyOrder1.Margin = new System.Windows.Forms.Padding(38, 40, 38, 40);
            this.ModifyOrder1.MaximumSize = new System.Drawing.Size(188, 160);
            this.ModifyOrder1.MinimumSize = new System.Drawing.Size(188, 160);
            this.ModifyOrder1.Name = "ModifyOrder1";
            this.ModifyOrder1.Padding = new System.Windows.Forms.Padding(15, 16, 15, 16);
            this.ModifyOrder1.Size = new System.Drawing.Size(188, 160);
            this.ModifyOrder1.TabIndex = 2;
            this.ModifyOrder1.Text = "Modify Order";
            this.ModifyOrder1.UseVisualStyleBackColor = true;
            // 
            // CancelOrder1
            // 
            this.CancelOrder1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelOrder1.Location = new System.Drawing.Point(400, 48);
            this.CancelOrder1.Margin = new System.Windows.Forms.Padding(38, 40, 38, 40);
            this.CancelOrder1.MaximumSize = new System.Drawing.Size(188, 160);
            this.CancelOrder1.MinimumSize = new System.Drawing.Size(188, 160);
            this.CancelOrder1.Name = "CancelOrder1";
            this.CancelOrder1.Padding = new System.Windows.Forms.Padding(15, 16, 15, 16);
            this.CancelOrder1.Size = new System.Drawing.Size(188, 160);
            this.CancelOrder1.TabIndex = 3;
            this.CancelOrder1.Text = "Cancel Order";
            this.CancelOrder1.UseVisualStyleBackColor = true;
            this.CancelOrder1.Click += new System.EventHandler(this.CancelOrder1_Click);
            // 
            // Driver1
            // 
            this.Driver1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Driver1.Location = new System.Drawing.Point(596, 48);
            this.Driver1.Margin = new System.Windows.Forms.Padding(38, 40, 38, 40);
            this.Driver1.MaximumSize = new System.Drawing.Size(188, 160);
            this.Driver1.MinimumSize = new System.Drawing.Size(188, 160);
            this.Driver1.Name = "Driver1";
            this.Driver1.Padding = new System.Windows.Forms.Padding(15, 16, 15, 16);
            this.Driver1.Size = new System.Drawing.Size(188, 160);
            this.Driver1.TabIndex = 4;
            this.Driver1.Text = "Drivers";
            this.Driver1.UseVisualStyleBackColor = true;
            // 
            // CashRegister
            // 
            this.CashRegister.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CashRegister.Location = new System.Drawing.Point(790, 48);
            this.CashRegister.Margin = new System.Windows.Forms.Padding(38, 40, 38, 40);
            this.CashRegister.MaximumSize = new System.Drawing.Size(188, 160);
            this.CashRegister.MinimumSize = new System.Drawing.Size(188, 160);
            this.CashRegister.Name = "CashRegister";
            this.CashRegister.Padding = new System.Windows.Forms.Padding(15, 16, 15, 16);
            this.CashRegister.Size = new System.Drawing.Size(188, 160);
            this.CashRegister.TabIndex = 5;
            this.CashRegister.Text = "Cash Register";
            this.CashRegister.UseVisualStyleBackColor = true;
            // 
            // AddressPanel
            // 
            this.AddressPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddressPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddressPanel.Controls.Add(this.ChangeAddress1);
            this.AddressPanel.Controls.Add(this.BuzzNum1);
            this.AddressPanel.Controls.Add(this.BuzzNum);
            this.AddressPanel.Controls.Add(this.ApptNum1);
            this.AddressPanel.Controls.Add(this.ApptNum);
            this.AddressPanel.Controls.Add(this.StreetName1);
            this.AddressPanel.Controls.Add(this.StreetName);
            this.AddressPanel.Controls.Add(this.AddressNumber1);
            this.AddressPanel.Controls.Add(this.AddressNumber);
            this.AddressPanel.Controls.Add(this.PhoneNumber1);
            this.AddressPanel.Controls.Add(this.PhoneNumber);
            this.AddressPanel.Location = new System.Drawing.Point(984, 58);
            this.AddressPanel.Margin = new System.Windows.Forms.Padding(2);
            this.AddressPanel.Name = "AddressPanel";
            this.AddressPanel.Size = new System.Drawing.Size(930, 158);
            this.AddressPanel.TabIndex = 6;
            this.AddressPanel.Visible = false;
            // 
            // ChangeAddress1
            // 
            this.ChangeAddress1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeAddress1.Location = new System.Drawing.Point(664, 2);
            this.ChangeAddress1.Margin = new System.Windows.Forms.Padding(2);
            this.ChangeAddress1.Name = "ChangeAddress1";
            this.ChangeAddress1.Size = new System.Drawing.Size(263, 139);
            this.ChangeAddress1.TabIndex = 12;
            this.ChangeAddress1.Text = "Customer Info";
            this.ChangeAddress1.UseVisualStyleBackColor = true;
            // 
            // BuzzNum1
            // 
            this.BuzzNum1.BackColor = System.Drawing.SystemColors.Window;
            this.BuzzNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuzzNum1.Location = new System.Drawing.Point(480, 51);
            this.BuzzNum1.Margin = new System.Windows.Forms.Padding(2);
            this.BuzzNum1.Name = "BuzzNum1";
            this.BuzzNum1.ReadOnly = true;
            this.BuzzNum1.Size = new System.Drawing.Size(181, 35);
            this.BuzzNum1.TabIndex = 9;
            // 
            // BuzzNum
            // 
            this.BuzzNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BuzzNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuzzNum.Location = new System.Drawing.Point(402, 57);
            this.BuzzNum.Margin = new System.Windows.Forms.Padding(2, 16, 2, 16);
            this.BuzzNum.Name = "BuzzNum";
            this.BuzzNum.ReadOnly = true;
            this.BuzzNum.Size = new System.Drawing.Size(80, 28);
            this.BuzzNum.TabIndex = 8;
            this.BuzzNum.Text = "Buzz #";
            // 
            // ApptNum1
            // 
            this.ApptNum1.BackColor = System.Drawing.SystemColors.Window;
            this.ApptNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApptNum1.Location = new System.Drawing.Point(473, 0);
            this.ApptNum1.Margin = new System.Windows.Forms.Padding(2);
            this.ApptNum1.Name = "ApptNum1";
            this.ApptNum1.ReadOnly = true;
            this.ApptNum1.Size = new System.Drawing.Size(188, 35);
            this.ApptNum1.TabIndex = 7;
            // 
            // ApptNum
            // 
            this.ApptNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ApptNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApptNum.Location = new System.Drawing.Point(387, 5);
            this.ApptNum.Margin = new System.Windows.Forms.Padding(2, 16, 2, 16);
            this.ApptNum.Name = "ApptNum";
            this.ApptNum.ReadOnly = true;
            this.ApptNum.Size = new System.Drawing.Size(89, 28);
            this.ApptNum.TabIndex = 6;
            this.ApptNum.Text = "Appt. #";
            // 
            // StreetName1
            // 
            this.StreetName1.BackColor = System.Drawing.SystemColors.Window;
            this.StreetName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StreetName1.Location = new System.Drawing.Point(144, 105);
            this.StreetName1.Margin = new System.Windows.Forms.Padding(2);
            this.StreetName1.Name = "StreetName1";
            this.StreetName1.ReadOnly = true;
            this.StreetName1.Size = new System.Drawing.Size(517, 35);
            this.StreetName1.TabIndex = 5;
            // 
            // StreetName
            // 
            this.StreetName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StreetName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StreetName.Location = new System.Drawing.Point(2, 112);
            this.StreetName.Margin = new System.Windows.Forms.Padding(2, 16, 2, 16);
            this.StreetName.Name = "StreetName";
            this.StreetName.ReadOnly = true;
            this.StreetName.Size = new System.Drawing.Size(137, 28);
            this.StreetName.TabIndex = 4;
            this.StreetName.Text = "Street Name";
            // 
            // AddressNumber1
            // 
            this.AddressNumber1.BackColor = System.Drawing.SystemColors.Window;
            this.AddressNumber1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressNumber1.Location = new System.Drawing.Point(211, 51);
            this.AddressNumber1.Margin = new System.Windows.Forms.Padding(2);
            this.AddressNumber1.Name = "AddressNumber1";
            this.AddressNumber1.ReadOnly = true;
            this.AddressNumber1.Size = new System.Drawing.Size(181, 35);
            this.AddressNumber1.TabIndex = 3;
            // 
            // AddressNumber
            // 
            this.AddressNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AddressNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressNumber.Location = new System.Drawing.Point(2, 57);
            this.AddressNumber.Margin = new System.Windows.Forms.Padding(2, 16, 2, 16);
            this.AddressNumber.Name = "AddressNumber";
            this.AddressNumber.ReadOnly = true;
            this.AddressNumber.Size = new System.Drawing.Size(204, 28);
            this.AddressNumber.TabIndex = 2;
            this.AddressNumber.Text = "Address Number #";
            // 
            // PhoneNumber1
            // 
            this.PhoneNumber1.BackColor = System.Drawing.SystemColors.Window;
            this.PhoneNumber1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumber1.Location = new System.Drawing.Point(195, 0);
            this.PhoneNumber1.Margin = new System.Windows.Forms.Padding(2);
            this.PhoneNumber1.Name = "PhoneNumber1";
            this.PhoneNumber1.ReadOnly = true;
            this.PhoneNumber1.Size = new System.Drawing.Size(188, 35);
            this.PhoneNumber1.TabIndex = 1;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumber.Location = new System.Drawing.Point(2, 5);
            this.PhoneNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 16);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
            this.PhoneNumber.Size = new System.Drawing.Size(195, 28);
            this.PhoneNumber.TabIndex = 0;
            this.PhoneNumber.Text = "Phone Number #";
            // 
            // PickUpDelivery
            // 
            this.PickUpDelivery.Appearance = System.Windows.Forms.Appearance.Button;
            this.PickUpDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PickUpDelivery.Location = new System.Drawing.Point(2, 2);
            this.PickUpDelivery.Margin = new System.Windows.Forms.Padding(2);
            this.PickUpDelivery.Name = "PickUpDelivery";
            this.PickUpDelivery.Size = new System.Drawing.Size(263, 139);
            this.PickUpDelivery.TabIndex = 11;
            this.PickUpDelivery.Text = "PickUp";
            this.PickUpDelivery.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PickUpDelivery.UseVisualStyleBackColor = true;
            this.PickUpDelivery.CheckedChanged += new System.EventHandler(this.PickUpDelivery_CheckedChanged);
            // 
            // OrderPanel1
            // 
            this.OrderPanel1.AutoSize = true;
            this.OrderPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.OrderPanel1.Controls.Add(this.MakeCombo1);
            this.OrderPanel1.Controls.Add(this.Cancel1);
            this.OrderPanel1.Controls.Add(this.DeleteCombo1);
            this.OrderPanel1.Controls.Add(this.Instructions1);
            this.OrderPanel1.Controls.Add(this.DippingSauce1);
            this.OrderPanel1.Controls.Add(this.ChangeSize1);
            this.OrderPanel1.Controls.Add(this.Toppings1);
            this.OrderPanel1.Controls.Add(this.Combos1);
            this.OrderPanel1.Controls.Add(this.dataGridView1);
            this.OrderPanel1.Location = new System.Drawing.Point(10, 226);
            this.OrderPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.OrderPanel1.Name = "OrderPanel1";
            this.OrderPanel1.Size = new System.Drawing.Size(1636, 811);
            this.OrderPanel1.TabIndex = 7;
            this.OrderPanel1.Visible = false;
            this.OrderPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.OrderPanel1_Paint);
            // 
            // MakeCombo1
            // 
            this.MakeCombo1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MakeCombo1.Location = new System.Drawing.Point(1155, 649);
            this.MakeCombo1.Margin = new System.Windows.Forms.Padding(2);
            this.MakeCombo1.MaximumSize = new System.Drawing.Size(188, 160);
            this.MakeCombo1.MinimumSize = new System.Drawing.Size(188, 160);
            this.MakeCombo1.Name = "MakeCombo1";
            this.MakeCombo1.Size = new System.Drawing.Size(188, 160);
            this.MakeCombo1.TabIndex = 8;
            this.MakeCombo1.Text = "Make Into Combo";
            this.MakeCombo1.UseVisualStyleBackColor = true;
            this.MakeCombo1.Click += new System.EventHandler(this.MakeCombo1_Click);
            // 
            // Cancel1
            // 
            this.Cancel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Cancel1.Location = new System.Drawing.Point(1444, 649);
            this.Cancel1.Margin = new System.Windows.Forms.Padding(2);
            this.Cancel1.MaximumSize = new System.Drawing.Size(188, 160);
            this.Cancel1.MinimumSize = new System.Drawing.Size(188, 160);
            this.Cancel1.Name = "Cancel1";
            this.Cancel1.Size = new System.Drawing.Size(188, 160);
            this.Cancel1.TabIndex = 7;
            this.Cancel1.Text = "Cancel";
            this.Cancel1.UseVisualStyleBackColor = true;
            this.Cancel1.Click += new System.EventHandler(this.Cancel1_Click);
            // 
            // DeleteCombo1
            // 
            this.DeleteCombo1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteCombo1.Location = new System.Drawing.Point(963, 649);
            this.DeleteCombo1.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteCombo1.MaximumSize = new System.Drawing.Size(188, 160);
            this.DeleteCombo1.MinimumSize = new System.Drawing.Size(188, 160);
            this.DeleteCombo1.Name = "DeleteCombo1";
            this.DeleteCombo1.Size = new System.Drawing.Size(188, 160);
            this.DeleteCombo1.TabIndex = 6;
            this.DeleteCombo1.Text = "Delete Combo";
            this.DeleteCombo1.UseVisualStyleBackColor = true;
            this.DeleteCombo1.Click += new System.EventHandler(this.DeleteCombo1_Click);
            // 
            // Instructions1
            // 
            this.Instructions1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Instructions1.Location = new System.Drawing.Point(771, 649);
            this.Instructions1.Margin = new System.Windows.Forms.Padding(2);
            this.Instructions1.MaximumSize = new System.Drawing.Size(188, 160);
            this.Instructions1.MinimumSize = new System.Drawing.Size(188, 160);
            this.Instructions1.Name = "Instructions1";
            this.Instructions1.Size = new System.Drawing.Size(188, 160);
            this.Instructions1.TabIndex = 5;
            this.Instructions1.Text = "Instructions";
            this.Instructions1.UseVisualStyleBackColor = true;
            // 
            // DippingSauce1
            // 
            this.DippingSauce1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DippingSauce1.Location = new System.Drawing.Point(579, 649);
            this.DippingSauce1.Margin = new System.Windows.Forms.Padding(2);
            this.DippingSauce1.MaximumSize = new System.Drawing.Size(188, 160);
            this.DippingSauce1.MinimumSize = new System.Drawing.Size(188, 160);
            this.DippingSauce1.Name = "DippingSauce1";
            this.DippingSauce1.Size = new System.Drawing.Size(188, 160);
            this.DippingSauce1.TabIndex = 4;
            this.DippingSauce1.Text = "Dipping Sauce";
            this.DippingSauce1.UseVisualStyleBackColor = true;
            // 
            // ChangeSize1
            // 
            this.ChangeSize1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangeSize1.Location = new System.Drawing.Point(386, 649);
            this.ChangeSize1.Margin = new System.Windows.Forms.Padding(2);
            this.ChangeSize1.MaximumSize = new System.Drawing.Size(188, 160);
            this.ChangeSize1.MinimumSize = new System.Drawing.Size(188, 160);
            this.ChangeSize1.Name = "ChangeSize1";
            this.ChangeSize1.Size = new System.Drawing.Size(188, 160);
            this.ChangeSize1.TabIndex = 3;
            this.ChangeSize1.Text = "Change Size";
            this.ChangeSize1.UseVisualStyleBackColor = true;
            // 
            // Toppings1
            // 
            this.Toppings1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Toppings1.Location = new System.Drawing.Point(194, 649);
            this.Toppings1.Margin = new System.Windows.Forms.Padding(2);
            this.Toppings1.MaximumSize = new System.Drawing.Size(188, 160);
            this.Toppings1.MinimumSize = new System.Drawing.Size(188, 160);
            this.Toppings1.Name = "Toppings1";
            this.Toppings1.Size = new System.Drawing.Size(188, 160);
            this.Toppings1.TabIndex = 2;
            this.Toppings1.Text = "Toppings";
            this.Toppings1.UseVisualStyleBackColor = true;
            this.Toppings1.Click += new System.EventHandler(this.Toppings1_Click);
            // 
            // Combos1
            // 
            this.Combos1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Combos1.Location = new System.Drawing.Point(2, 649);
            this.Combos1.Margin = new System.Windows.Forms.Padding(2);
            this.Combos1.MaximumSize = new System.Drawing.Size(188, 160);
            this.Combos1.MinimumSize = new System.Drawing.Size(188, 160);
            this.Combos1.Name = "Combos1";
            this.Combos1.Size = new System.Drawing.Size(188, 160);
            this.Combos1.TabIndex = 1;
            this.Combos1.Text = "Combos";
            this.Combos1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataComboName,
            this.DataToppings,
            this.DataPrice});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1634, 642);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // DataComboName
            // 
            this.DataComboName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DataComboName.HeaderText = "Name";
            this.DataComboName.MinimumWidth = 300;
            this.DataComboName.Name = "DataComboName";
            this.DataComboName.ReadOnly = true;
            this.DataComboName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DataComboName.Width = 300;
            // 
            // DataToppings
            // 
            this.DataToppings.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DataToppings.HeaderText = "Toppings";
            this.DataToppings.MinimumWidth = 650;
            this.DataToppings.Name = "DataToppings";
            this.DataToppings.ReadOnly = true;
            this.DataToppings.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DataToppings.Width = 650;
            // 
            // DataPrice
            // 
            this.DataPrice.HeaderText = "Price";
            this.DataPrice.MinimumWidth = 250;
            this.DataPrice.Name = "DataPrice";
            this.DataPrice.ReadOnly = true;
            this.DataPrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // CheckoutPanel
            // 
            this.CheckoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CheckoutPanel.Controls.Add(this.PrevOrder1);
            this.CheckoutPanel.Controls.Add(this.Checkout1);
            this.CheckoutPanel.Controls.Add(this.PickUpDelivery);
            this.CheckoutPanel.Location = new System.Drawing.Point(1646, 226);
            this.CheckoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.CheckoutPanel.Name = "CheckoutPanel";
            this.CheckoutPanel.Size = new System.Drawing.Size(266, 883);
            this.CheckoutPanel.TabIndex = 8;
            this.CheckoutPanel.Visible = false;
            // 
            // PrevOrder1
            // 
            this.PrevOrder1.Location = new System.Drawing.Point(4, 482);
            this.PrevOrder1.Margin = new System.Windows.Forms.Padding(2);
            this.PrevOrder1.MaximumSize = new System.Drawing.Size(259, 160);
            this.PrevOrder1.MinimumSize = new System.Drawing.Size(259, 160);
            this.PrevOrder1.Name = "PrevOrder1";
            this.PrevOrder1.Size = new System.Drawing.Size(259, 160);
            this.PrevOrder1.TabIndex = 13;
            this.PrevOrder1.Text = "Last Order";
            this.PrevOrder1.UseVisualStyleBackColor = true;
            // 
            // Checkout1
            // 
            this.Checkout1.Location = new System.Drawing.Point(4, 649);
            this.Checkout1.Margin = new System.Windows.Forms.Padding(2);
            this.Checkout1.MaximumSize = new System.Drawing.Size(259, 160);
            this.Checkout1.MinimumSize = new System.Drawing.Size(259, 160);
            this.Checkout1.Name = "Checkout1";
            this.Checkout1.Size = new System.Drawing.Size(259, 160);
            this.Checkout1.TabIndex = 12;
            this.Checkout1.Text = "Checkout";
            this.Checkout1.UseVisualStyleBackColor = true;
            // 
            // PizzaStorePOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1443, 1046);
            this.Controls.Add(this.CheckoutPanel);
            this.Controls.Add(this.OrderPanel1);
            this.Controls.Add(this.AddressPanel);
            this.Controls.Add(this.CashRegister);
            this.Controls.Add(this.Driver1);
            this.Controls.Add(this.CancelOrder1);
            this.Controls.Add(this.ModifyOrder1);
            this.Controls.Add(this.NewOrder1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PizzaStorePOS";
            this.Text = "PizzaStorePOS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PizzaStorePOS_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.AddressPanel.ResumeLayout(false);
            this.AddressPanel.PerformLayout();
            this.OrderPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.CheckoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toppingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeliveryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem driversToolStripMenuItem;
        private System.Windows.Forms.Button NewOrder1;
        private System.Windows.Forms.Button ModifyOrder1;
        private System.Windows.Forms.Button CancelOrder1;
        private System.Windows.Forms.Button Driver1;
        private System.Windows.Forms.Button CashRegister;
        private System.Windows.Forms.Panel AddressPanel;
        private System.Windows.Forms.TextBox PhoneNumber;
        private System.Windows.Forms.CheckBox PickUpDelivery;
        private System.Windows.Forms.TextBox BuzzNum1;
        private System.Windows.Forms.TextBox BuzzNum;
        private System.Windows.Forms.TextBox ApptNum1;
        private System.Windows.Forms.TextBox ApptNum;
        private System.Windows.Forms.TextBox StreetName1;
        private System.Windows.Forms.TextBox StreetName;
        private System.Windows.Forms.TextBox AddressNumber1;
        private System.Windows.Forms.TextBox AddressNumber;
        private System.Windows.Forms.TextBox PhoneNumber1;
        private System.Windows.Forms.Button ChangeAddress1;
        private System.Windows.Forms.Panel OrderPanel1;
        private System.Windows.Forms.Panel CheckoutPanel;
        private System.Windows.Forms.Button Combos1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Toppings1;
        private System.Windows.Forms.Button DeleteCombo1;
        private System.Windows.Forms.Button Instructions1;
        private System.Windows.Forms.Button DippingSauce1;
        private System.Windows.Forms.Button ChangeSize1;
        private System.Windows.Forms.Button Cancel1;
        private System.Windows.Forms.Button Checkout1;
        private System.Windows.Forms.Button MakeCombo1;
        private System.Windows.Forms.ToolStripMenuItem onlineOrderToolStripMenuItem;
        private System.Windows.Forms.Button PrevOrder1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataComboName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataToppings;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataPrice;
        private System.Windows.Forms.ToolStripMenuItem masterToppingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toppingValueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem specialtyPizzasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem combosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deliveryAddressessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deliveryChargesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dailyAuditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem driverCashoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cashRegisterItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instructionsMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeClockInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem driverCashoutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem onlineOrderTimesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onlineOrderHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onlineOrderDailyAuditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onlineOrderSettingsToolStripMenuItem;
        public System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripMenuItem userAccountsToolStripMenuItem;
    }
}

