using System;
using System.Windows.Forms;

namespace PizzaStorePOS
{
    partial class CombosMasterForm
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
            this.CombosData = new System.Windows.Forms.DataGridView();
            this.ComboNameM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComboPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComboInputP = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ComboSizePriceT = new System.Windows.Forms.TextBox();
            this.ComboSizePrice = new System.Windows.Forms.TextBox();
            this.ComboPriceT = new System.Windows.Forms.TextBox();
            this.PriceT = new System.Windows.Forms.TextBox();
            this.SidesT = new System.Windows.Forms.TextBox();
            this.ComboName = new System.Windows.Forms.TextBox();
            this.ComboNameT = new System.Windows.Forms.TextBox();
            this.PizzaSizeGroupBox = new System.Windows.Forms.GroupBox();
            this.SmallPizzaC = new System.Windows.Forms.CheckBox();
            this.MedPizzaC = new System.Windows.Forms.CheckBox();
            this.LargePizzaC = new System.Windows.Forms.CheckBox();
            this.XLPizzaC = new System.Windows.Forms.CheckBox();
            this.PizzaQuantityGroupBox = new System.Windows.Forms.GroupBox();
            this.Pizza3C = new System.Windows.Forms.CheckBox();
            this.Pizza2C = new System.Windows.Forms.CheckBox();
            this.Pizza1C = new System.Windows.Forms.CheckBox();
            this.PopsGroupBox = new System.Windows.Forms.GroupBox();
            this.NoPopC = new System.Windows.Forms.CheckBox();
            this.Pop4C = new System.Windows.Forms.CheckBox();
            this.Pop1C = new System.Windows.Forms.CheckBox();
            this.Pop2C = new System.Windows.Forms.CheckBox();
            this.DipsGroupBox = new System.Windows.Forms.GroupBox();
            this.NoDipC = new System.Windows.Forms.CheckBox();
            this.Dip1C = new System.Windows.Forms.CheckBox();
            this.Dip2C = new System.Windows.Forms.CheckBox();
            this.SaveB = new System.Windows.Forms.Button();
            this.EditB = new System.Windows.Forms.Button();
            this.CloseB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CombosData)).BeginInit();
            this.ComboInputP.SuspendLayout();
            this.PizzaSizeGroupBox.SuspendLayout();
            this.PizzaQuantityGroupBox.SuspendLayout();
            this.PopsGroupBox.SuspendLayout();
            this.DipsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CombosData
            // 
            this.CombosData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CombosData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ComboNameM,
            this.ComboPrice});
            this.CombosData.Location = new System.Drawing.Point(12, 12);
            this.CombosData.Name = "CombosData";
            this.CombosData.RowHeadersVisible = false;
            this.CombosData.RowHeadersWidth = 82;
            this.CombosData.RowTemplate.Height = 33;
            this.CombosData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CombosData.Size = new System.Drawing.Size(619, 912);
            this.CombosData.TabIndex = 0;
            this.CombosData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CombosData_CellContentClick);
            // 
            // ComboNameM
            // 
            this.ComboNameM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ComboNameM.HeaderText = "Combo Name";
            this.ComboNameM.MinimumWidth = 10;
            this.ComboNameM.Name = "ComboNameM";
            this.ComboNameM.ReadOnly = true;
            // 
            // ComboPrice
            // 
            this.ComboPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ComboPrice.HeaderText = "Combo Price";
            this.ComboPrice.MinimumWidth = 10;
            this.ComboPrice.Name = "ComboPrice";
            this.ComboPrice.ReadOnly = true;
            // 
            // ComboInputP
            // 
            this.ComboInputP.Controls.Add(this.textBox2);
            this.ComboInputP.Controls.Add(this.ComboSizePriceT);
            this.ComboInputP.Controls.Add(this.ComboSizePrice);
            this.ComboInputP.Controls.Add(this.ComboPriceT);
            this.ComboInputP.Controls.Add(this.PriceT);
            this.ComboInputP.Controls.Add(this.SidesT);
            this.ComboInputP.Controls.Add(this.ComboName);
            this.ComboInputP.Controls.Add(this.ComboNameT);
            this.ComboInputP.Controls.Add(this.PizzaSizeGroupBox);
            this.ComboInputP.Controls.Add(this.PizzaQuantityGroupBox);
            this.ComboInputP.Controls.Add(this.PopsGroupBox);
            this.ComboInputP.Controls.Add(this.DipsGroupBox);
            this.ComboInputP.Location = new System.Drawing.Point(638, 12);
            this.ComboInputP.Name = "ComboInputP";
            this.ComboInputP.Size = new System.Drawing.Size(854, 691);
            this.ComboInputP.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(246, 246);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(597, 49);
            this.textBox2.TabIndex = 20;
            // 
            // ComboSizePriceT
            // 
            this.ComboSizePriceT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboSizePriceT.Location = new System.Drawing.Point(246, 624);
            this.ComboSizePriceT.Name = "ComboSizePriceT";
            this.ComboSizePriceT.Size = new System.Drawing.Size(597, 49);
            this.ComboSizePriceT.TabIndex = 19;
            this.ComboSizePriceT.TextChanged += new System.EventHandler(this.ComboSizePriceT_TextChanged);
            this.ComboSizePriceT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboPriceT_KeyPress);
            // 
            // ComboSizePrice
            // 
            this.ComboSizePrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ComboSizePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboSizePrice.Location = new System.Drawing.Point(3, 627);
            this.ComboSizePrice.Name = "ComboSizePrice";
            this.ComboSizePrice.ReadOnly = true;
            this.ComboSizePrice.Size = new System.Drawing.Size(219, 42);
            this.ComboSizePrice.TabIndex = 18;
            this.ComboSizePrice.Text = "Size Price";
            // 
            // ComboPriceT
            // 
            this.ComboPriceT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboPriceT.Location = new System.Drawing.Point(246, 545);
            this.ComboPriceT.Name = "ComboPriceT";
            this.ComboPriceT.Size = new System.Drawing.Size(597, 49);
            this.ComboPriceT.TabIndex = 17;
            this.ComboPriceT.TextChanged += new System.EventHandler(this.ComboPriceT_TextChanged);
            this.ComboPriceT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboPriceT_KeyPress);
            // 
            // PriceT
            // 
            this.PriceT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PriceT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceT.Location = new System.Drawing.Point(3, 548);
            this.PriceT.Name = "PriceT";
            this.PriceT.ReadOnly = true;
            this.PriceT.Size = new System.Drawing.Size(219, 42);
            this.PriceT.TabIndex = 16;
            this.PriceT.Text = "Combo Price";
            // 
            // SidesT
            // 
            this.SidesT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SidesT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SidesT.Location = new System.Drawing.Point(67, 253);
            this.SidesT.Name = "SidesT";
            this.SidesT.ReadOnly = true;
            this.SidesT.Size = new System.Drawing.Size(122, 42);
            this.SidesT.TabIndex = 12;
            this.SidesT.Text = "Sides";
            // 
            // ComboName
            // 
            this.ComboName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboName.Location = new System.Drawing.Point(246, 3);
            this.ComboName.Name = "ComboName";
            this.ComboName.Size = new System.Drawing.Size(597, 49);
            this.ComboName.TabIndex = 1;
            this.ComboName.Text = " ";
            // 
            // ComboNameT
            // 
            this.ComboNameT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ComboNameT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboNameT.Location = new System.Drawing.Point(3, 3);
            this.ComboNameT.Name = "ComboNameT";
            this.ComboNameT.ReadOnly = true;
            this.ComboNameT.Size = new System.Drawing.Size(237, 42);
            this.ComboNameT.TabIndex = 0;
            this.ComboNameT.Text = "Combo Name";
            // 
            // PizzaSizeGroupBox
            // 
            this.PizzaSizeGroupBox.Controls.Add(this.SmallPizzaC);
            this.PizzaSizeGroupBox.Controls.Add(this.MedPizzaC);
            this.PizzaSizeGroupBox.Controls.Add(this.LargePizzaC);
            this.PizzaSizeGroupBox.Controls.Add(this.XLPizzaC);
            this.PizzaSizeGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PizzaSizeGroupBox.Location = new System.Drawing.Point(3, 70);
            this.PizzaSizeGroupBox.Name = "PizzaSizeGroupBox";
            this.PizzaSizeGroupBox.Size = new System.Drawing.Size(848, 63);
            this.PizzaSizeGroupBox.TabIndex = 26;
            this.PizzaSizeGroupBox.TabStop = false;
            this.PizzaSizeGroupBox.Text = "Pizza Sizes";
            // 
            // SmallPizzaC
            // 
            this.SmallPizzaC.Appearance = System.Windows.Forms.Appearance.Button;
            this.SmallPizzaC.AutoSize = true;
            this.SmallPizzaC.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SmallPizzaC.Location = new System.Drawing.Point(218, 0);
            this.SmallPizzaC.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.SmallPizzaC.Name = "SmallPizzaC";
            this.SmallPizzaC.Size = new System.Drawing.Size(120, 52);
            this.SmallPizzaC.TabIndex = 3;
            this.SmallPizzaC.Text = "Small";
            this.SmallPizzaC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SmallPizzaC.UseVisualStyleBackColor = true;
            // 
            // MedPizzaC
            // 
            this.MedPizzaC.Appearance = System.Windows.Forms.Appearance.Button;
            this.MedPizzaC.AutoSize = true;
            this.MedPizzaC.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedPizzaC.Location = new System.Drawing.Point(358, 0);
            this.MedPizzaC.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.MedPizzaC.Name = "MedPizzaC";
            this.MedPizzaC.Size = new System.Drawing.Size(160, 52);
            this.MedPizzaC.TabIndex = 4;
            this.MedPizzaC.Text = "Medium";
            this.MedPizzaC.UseVisualStyleBackColor = true;
            // 
            // LargePizzaC
            // 
            this.LargePizzaC.Appearance = System.Windows.Forms.Appearance.Button;
            this.LargePizzaC.AutoSize = true;
            this.LargePizzaC.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LargePizzaC.Location = new System.Drawing.Point(538, 0);
            this.LargePizzaC.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.LargePizzaC.Name = "LargePizzaC";
            this.LargePizzaC.Size = new System.Drawing.Size(124, 52);
            this.LargePizzaC.TabIndex = 6;
            this.LargePizzaC.Text = "Large";
            this.LargePizzaC.UseVisualStyleBackColor = true;
            // 
            // XLPizzaC
            // 
            this.XLPizzaC.Appearance = System.Windows.Forms.Appearance.Button;
            this.XLPizzaC.AutoSize = true;
            this.XLPizzaC.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XLPizzaC.Location = new System.Drawing.Point(682, 0);
            this.XLPizzaC.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.XLPizzaC.Name = "XLPizzaC";
            this.XLPizzaC.Size = new System.Drawing.Size(161, 52);
            this.XLPizzaC.TabIndex = 5;
            this.XLPizzaC.Text = "X-Large";
            this.XLPizzaC.UseVisualStyleBackColor = true;
            // 
            // PizzaQuantityGroupBox
            // 
            this.PizzaQuantityGroupBox.Controls.Add(this.Pizza3C);
            this.PizzaQuantityGroupBox.Controls.Add(this.Pizza2C);
            this.PizzaQuantityGroupBox.Controls.Add(this.Pizza1C);
            this.PizzaQuantityGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PizzaQuantityGroupBox.Location = new System.Drawing.Point(3, 156);
            this.PizzaQuantityGroupBox.Name = "PizzaQuantityGroupBox";
            this.PizzaQuantityGroupBox.Size = new System.Drawing.Size(802, 53);
            this.PizzaQuantityGroupBox.TabIndex = 27;
            this.PizzaQuantityGroupBox.TabStop = false;
            this.PizzaQuantityGroupBox.Text = "Pizza Quantity";
            // 
            // Pizza3C
            // 
            this.Pizza3C.Appearance = System.Windows.Forms.Appearance.Button;
            this.Pizza3C.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pizza3C.Location = new System.Drawing.Point(617, -7);
            this.Pizza3C.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.Pizza3C.Name = "Pizza3C";
            this.Pizza3C.Size = new System.Drawing.Size(151, 60);
            this.Pizza3C.TabIndex = 10;
            this.Pizza3C.Tag = "3";
            this.Pizza3C.Text = "3";
            this.Pizza3C.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Pizza3C.UseVisualStyleBackColor = true;
            this.Pizza3C.CheckedChanged += new System.EventHandler(this.Pizza3C_CheckedChanged);
            // 
            // Pizza2C
            // 
            this.Pizza2C.Appearance = System.Windows.Forms.Appearance.Button;
            this.Pizza2C.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pizza2C.Location = new System.Drawing.Point(437, -7);
            this.Pizza2C.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.Pizza2C.Name = "Pizza2C";
            this.Pizza2C.Size = new System.Drawing.Size(151, 60);
            this.Pizza2C.TabIndex = 9;
            this.Pizza2C.Tag = "2";
            this.Pizza2C.Text = "2";
            this.Pizza2C.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Pizza2C.UseVisualStyleBackColor = true;
            this.Pizza2C.CheckedChanged += new System.EventHandler(this.Pizza2C_CheckedChanged);
            // 
            // Pizza1C
            // 
            this.Pizza1C.Appearance = System.Windows.Forms.Appearance.Button;
            this.Pizza1C.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pizza1C.Location = new System.Drawing.Point(266, -7);
            this.Pizza1C.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.Pizza1C.Name = "Pizza1C";
            this.Pizza1C.Size = new System.Drawing.Size(151, 60);
            this.Pizza1C.TabIndex = 8;
            this.Pizza1C.Tag = "1";
            this.Pizza1C.Text = "1";
            this.Pizza1C.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Pizza1C.UseVisualStyleBackColor = true;
            this.Pizza1C.CheckedChanged += new System.EventHandler(this.Pizza1C_CheckedChanged);
            // 
            // PopsGroupBox
            // 
            this.PopsGroupBox.Controls.Add(this.NoPopC);
            this.PopsGroupBox.Controls.Add(this.Pop4C);
            this.PopsGroupBox.Controls.Add(this.Pop1C);
            this.PopsGroupBox.Controls.Add(this.Pop2C);
            this.PopsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PopsGroupBox.Location = new System.Drawing.Point(67, 344);
            this.PopsGroupBox.Name = "PopsGroupBox";
            this.PopsGroupBox.Size = new System.Drawing.Size(719, 52);
            this.PopsGroupBox.TabIndex = 28;
            this.PopsGroupBox.TabStop = false;
            this.PopsGroupBox.Text = "Pop(s)";
            // 
            // NoPopC
            // 
            this.NoPopC.Appearance = System.Windows.Forms.Appearance.Button;
            this.NoPopC.AutoSize = true;
            this.NoPopC.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoPopC.Location = new System.Drawing.Point(154, 0);
            this.NoPopC.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.NoPopC.Name = "NoPopC";
            this.NoPopC.Size = new System.Drawing.Size(126, 52);
            this.NoPopC.TabIndex = 24;
            this.NoPopC.Tag = "0";
            this.NoPopC.Text = "0 Pop";
            this.NoPopC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NoPopC.UseVisualStyleBackColor = true;
            this.NoPopC.CheckedChanged += new System.EventHandler(this.NoPopC_CheckedChanged);
            // 
            // Pop4C
            // 
            this.Pop4C.Appearance = System.Windows.Forms.Appearance.Button;
            this.Pop4C.AutoSize = true;
            this.Pop4C.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pop4C.Location = new System.Drawing.Point(592, 0);
            this.Pop4C.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.Pop4C.Name = "Pop4C";
            this.Pop4C.Size = new System.Drawing.Size(126, 52);
            this.Pop4C.TabIndex = 23;
            this.Pop4C.Tag = "4";
            this.Pop4C.Text = "4 Pop";
            this.Pop4C.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Pop4C.UseVisualStyleBackColor = true;
            this.Pop4C.CheckedChanged += new System.EventHandler(this.Pop4C_CheckedChanged);
            // 
            // Pop1C
            // 
            this.Pop1C.Appearance = System.Windows.Forms.Appearance.Button;
            this.Pop1C.AutoSize = true;
            this.Pop1C.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pop1C.Location = new System.Drawing.Point(300, 0);
            this.Pop1C.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.Pop1C.Name = "Pop1C";
            this.Pop1C.Size = new System.Drawing.Size(126, 52);
            this.Pop1C.TabIndex = 21;
            this.Pop1C.Tag = "1";
            this.Pop1C.Text = "1 Pop";
            this.Pop1C.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Pop1C.UseVisualStyleBackColor = true;
            this.Pop1C.CheckedChanged += new System.EventHandler(this.Pop1C_CheckedChanged);
            // 
            // Pop2C
            // 
            this.Pop2C.Appearance = System.Windows.Forms.Appearance.Button;
            this.Pop2C.AutoSize = true;
            this.Pop2C.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pop2C.Location = new System.Drawing.Point(446, 0);
            this.Pop2C.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.Pop2C.Name = "Pop2C";
            this.Pop2C.Size = new System.Drawing.Size(126, 52);
            this.Pop2C.TabIndex = 22;
            this.Pop2C.Tag = "2";
            this.Pop2C.Text = "2 Pop";
            this.Pop2C.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Pop2C.UseVisualStyleBackColor = true;
            this.Pop2C.CheckedChanged += new System.EventHandler(this.Pop2C_CheckedChanged);
            // 
            // DipsGroupBox
            // 
            this.DipsGroupBox.Controls.Add(this.NoDipC);
            this.DipsGroupBox.Controls.Add(this.Dip1C);
            this.DipsGroupBox.Controls.Add(this.Dip2C);
            this.DipsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DipsGroupBox.Location = new System.Drawing.Point(67, 448);
            this.DipsGroupBox.Name = "DipsGroupBox";
            this.DipsGroupBox.Size = new System.Drawing.Size(738, 63);
            this.DipsGroupBox.TabIndex = 29;
            this.DipsGroupBox.TabStop = false;
            this.DipsGroupBox.Text = "Dip(s)";
            // 
            // NoDipC
            // 
            this.NoDipC.Appearance = System.Windows.Forms.Appearance.Button;
            this.NoDipC.AutoSize = true;
            this.NoDipC.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoDipC.Location = new System.Drawing.Point(154, 5);
            this.NoDipC.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.NoDipC.Name = "NoDipC";
            this.NoDipC.Size = new System.Drawing.Size(115, 52);
            this.NoDipC.TabIndex = 25;
            this.NoDipC.Tag = "0";
            this.NoDipC.Text = "0 Dip";
            this.NoDipC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NoDipC.UseVisualStyleBackColor = true;
            this.NoDipC.CheckedChanged += new System.EventHandler(this.NoDipC_CheckedChanged);
            // 
            // Dip1C
            // 
            this.Dip1C.Appearance = System.Windows.Forms.Appearance.Button;
            this.Dip1C.AutoSize = true;
            this.Dip1C.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dip1C.Location = new System.Drawing.Point(300, 5);
            this.Dip1C.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.Dip1C.Name = "Dip1C";
            this.Dip1C.Size = new System.Drawing.Size(115, 52);
            this.Dip1C.TabIndex = 14;
            this.Dip1C.Tag = "1";
            this.Dip1C.Text = "1 Dip";
            this.Dip1C.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Dip1C.UseVisualStyleBackColor = true;
            this.Dip1C.CheckedChanged += new System.EventHandler(this.Dip1C_CheckedChanged);
            // 
            // Dip2C
            // 
            this.Dip2C.Appearance = System.Windows.Forms.Appearance.Button;
            this.Dip2C.AutoSize = true;
            this.Dip2C.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dip2C.Location = new System.Drawing.Point(446, 5);
            this.Dip2C.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.Dip2C.Name = "Dip2C";
            this.Dip2C.Size = new System.Drawing.Size(134, 52);
            this.Dip2C.TabIndex = 15;
            this.Dip2C.Tag = "2";
            this.Dip2C.Text = "2 Dips";
            this.Dip2C.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Dip2C.UseVisualStyleBackColor = true;
            this.Dip2C.CheckedChanged += new System.EventHandler(this.Dip2C_CheckedChanged);
            // 
            // SaveB
            // 
            this.SaveB.Location = new System.Drawing.Point(1231, 724);
            this.SaveB.Name = "SaveB";
            this.SaveB.Size = new System.Drawing.Size(250, 200);
            this.SaveB.TabIndex = 2;
            this.SaveB.Text = "Save";
            this.SaveB.UseVisualStyleBackColor = true;
            this.SaveB.Click += new System.EventHandler(this.SaveB_Click);
            // 
            // EditB
            // 
            this.EditB.Location = new System.Drawing.Point(641, 724);
            this.EditB.Name = "EditB";
            this.EditB.Size = new System.Drawing.Size(250, 200);
            this.EditB.TabIndex = 3;
            this.EditB.Text = "Edit Combo";
            this.EditB.UseVisualStyleBackColor = true;
            this.EditB.Click += new System.EventHandler(this.EditB_Click);
            // 
            // CloseB
            // 
            this.CloseB.Location = new System.Drawing.Point(975, 724);
            this.CloseB.Name = "CloseB";
            this.CloseB.Size = new System.Drawing.Size(250, 200);
            this.CloseB.TabIndex = 4;
            this.CloseB.Text = "Close";
            this.CloseB.UseVisualStyleBackColor = true;
            this.CloseB.Click += new System.EventHandler(this.CloseB_Click);
            // 
            // CombosMasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1496, 936);
            this.Controls.Add(this.CloseB);
            this.Controls.Add(this.EditB);
            this.Controls.Add(this.SaveB);
            this.Controls.Add(this.ComboInputP);
            this.Controls.Add(this.CombosData);
            this.Name = "CombosMasterForm";
            this.Text = "CombosMasterForm";
            ((System.ComponentModel.ISupportInitialize)(this.CombosData)).EndInit();
            this.ComboInputP.ResumeLayout(false);
            this.ComboInputP.PerformLayout();
            this.PizzaSizeGroupBox.ResumeLayout(false);
            this.PizzaSizeGroupBox.PerformLayout();
            this.PizzaQuantityGroupBox.ResumeLayout(false);
            this.PopsGroupBox.ResumeLayout(false);
            this.PopsGroupBox.PerformLayout();
            this.DipsGroupBox.ResumeLayout(false);
            this.DipsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView CombosData;
        private System.Windows.Forms.Panel ComboInputP;
        private System.Windows.Forms.TextBox ComboName;
        private System.Windows.Forms.TextBox ComboNameT;
        private System.Windows.Forms.CheckBox Pizza3C;
        private System.Windows.Forms.CheckBox Pizza2C;
        private System.Windows.Forms.CheckBox Pizza1C;
        private System.Windows.Forms.CheckBox Pop4C;
        private System.Windows.Forms.CheckBox Pop2C;
        private System.Windows.Forms.CheckBox Pop1C;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox ComboSizePriceT;
        private System.Windows.Forms.TextBox ComboSizePrice;
        private System.Windows.Forms.TextBox ComboPriceT;
        private System.Windows.Forms.TextBox PriceT;
        private System.Windows.Forms.CheckBox Dip2C;
        private System.Windows.Forms.CheckBox Dip1C;
        private System.Windows.Forms.TextBox SidesT;
        private System.Windows.Forms.CheckBox NoDipC;
        private System.Windows.Forms.CheckBox NoPopC;
        private System.Windows.Forms.Button SaveB;
        private System.Windows.Forms.Button EditB;
        private System.Windows.Forms.Button CloseB;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComboNameM;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComboPrice;
        private System.Windows.Forms.CheckBox LargePizzaC;
        private System.Windows.Forms.CheckBox XLPizzaC;
        private System.Windows.Forms.CheckBox MedPizzaC;
        private System.Windows.Forms.CheckBox SmallPizzaC;
        private System.Windows.Forms.GroupBox PizzaSizeGroupBox;
        private System.Windows.Forms.GroupBox PizzaQuantityGroupBox;
        private System.Windows.Forms.GroupBox PopsGroupBox;
        private System.Windows.Forms.GroupBox DipsGroupBox;
    }
}