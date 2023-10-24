namespace PyramidPOS
{
    partial class ToppingMaster
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
            this.components = new System.ComponentModel.Container();
            this.ToppingNameT = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.DisaplayNameT = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.ToppingAmountT = new System.Windows.Forms.TextBox();
            this.ToppingData = new System.Windows.Forms.DataGridView();
            this.ToppingName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToppingDisplayName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToppingAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToppingCancel = new System.Windows.Forms.Button();
            this.ToppingAdd = new System.Windows.Forms.Button();
            this.ToppingRemove = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataSet1 = new System.Data.DataSet();
            this.ClearB = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ToppingData)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // ToppingNameT
            // 
            this.ToppingNameT.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToppingNameT.Location = new System.Drawing.Point(277, 127);
            this.ToppingNameT.Name = "ToppingNameT";
            this.ToppingNameT.Size = new System.Drawing.Size(599, 56);
            this.ToppingNameT.TabIndex = 0;
            this.ToppingNameT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ToppingNameT_KeyDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(75, 28);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(74, 24);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(34, 49);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(304, 62);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Topping Input";
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(34, 134);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 20, 3, 20);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(128, 49);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "Name";
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(34, 223);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 20, 3, 20);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(237, 42);
            this.textBox4.TabIndex = 3;
            this.textBox4.Text = "Display Name";
            // 
            // DisaplayNameT
            // 
            this.DisaplayNameT.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisaplayNameT.Location = new System.Drawing.Point(277, 216);
            this.DisaplayNameT.Name = "DisaplayNameT";
            this.DisaplayNameT.Size = new System.Drawing.Size(294, 56);
            this.DisaplayNameT.TabIndex = 4;
            this.DisaplayNameT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DisplayName_KeyDown);
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(34, 312);
            this.textBox6.Margin = new System.Windows.Forms.Padding(3, 20, 3, 20);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(237, 37);
            this.textBox6.TabIndex = 5;
            this.textBox6.Text = "Topping Amount";
            // 
            // ToppingAmountT
            // 
            this.ToppingAmountT.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToppingAmountT.Location = new System.Drawing.Point(277, 312);
            this.ToppingAmountT.Name = "ToppingAmountT";
            this.ToppingAmountT.Size = new System.Drawing.Size(294, 56);
            this.ToppingAmountT.TabIndex = 6;
            this.ToppingAmountT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox7_KeyPress);
            // 
            // ToppingData
            // 
            this.ToppingData.AllowUserToResizeColumns = false;
            this.ToppingData.AllowUserToResizeRows = false;
            this.ToppingData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ToppingData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ToppingName,
            this.ToppingDisplayName,
            this.ToppingAmount});
            this.ToppingData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToppingData.Location = new System.Drawing.Point(0, 0);
            this.ToppingData.Name = "ToppingData";
            this.ToppingData.RowHeadersVisible = false;
            this.ToppingData.RowHeadersWidth = 82;
            this.ToppingData.RowTemplate.Height = 33;
            this.ToppingData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ToppingData.Size = new System.Drawing.Size(721, 600);
            this.ToppingData.TabIndex = 7;
            this.ToppingData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ToppingData_CellContentClick);
            // 
            // ToppingName
            // 
            this.ToppingName.HeaderText = "Topping";
            this.ToppingName.MinimumWidth = 10;
            this.ToppingName.Name = "ToppingName";
            this.ToppingName.ReadOnly = true;
            this.ToppingName.Width = 200;
            // 
            // ToppingDisplayName
            // 
            this.ToppingDisplayName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ToppingDisplayName.HeaderText = "Display Name";
            this.ToppingDisplayName.MinimumWidth = 100;
            this.ToppingDisplayName.Name = "ToppingDisplayName";
            this.ToppingDisplayName.ReadOnly = true;
            // 
            // ToppingAmount
            // 
            this.ToppingAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ToppingAmount.HeaderText = "Topping Amount";
            this.ToppingAmount.MinimumWidth = 10;
            this.ToppingAmount.Name = "ToppingAmount";
            this.ToppingAmount.ReadOnly = true;
            // 
            // ToppingCancel
            // 
            this.ToppingCancel.Location = new System.Drawing.Point(12, 601);
            this.ToppingCancel.Name = "ToppingCancel";
            this.ToppingCancel.Size = new System.Drawing.Size(250, 200);
            this.ToppingCancel.TabIndex = 8;
            this.ToppingCancel.Text = "Cancel";
            this.ToppingCancel.UseVisualStyleBackColor = true;
            this.ToppingCancel.Click += new System.EventHandler(this.ToppingCancel_Click);
            // 
            // ToppingAdd
            // 
            this.ToppingAdd.Location = new System.Drawing.Point(321, 395);
            this.ToppingAdd.Name = "ToppingAdd";
            this.ToppingAdd.Size = new System.Drawing.Size(250, 200);
            this.ToppingAdd.TabIndex = 9;
            this.ToppingAdd.Text = "Add Toppings";
            this.ToppingAdd.UseVisualStyleBackColor = true;
            this.ToppingAdd.Click += new System.EventHandler(this.ToppingAdd_Click);
            // 
            // ToppingRemove
            // 
            this.ToppingRemove.Location = new System.Drawing.Point(321, 600);
            this.ToppingRemove.Name = "ToppingRemove";
            this.ToppingRemove.Size = new System.Drawing.Size(250, 200);
            this.ToppingRemove.TabIndex = 10;
            this.ToppingRemove.Text = "Remove Toppings";
            this.ToppingRemove.UseVisualStyleBackColor = true;
            this.ToppingRemove.Click += new System.EventHandler(this.ToppingRemove_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ToppingData);
            this.panel1.Location = new System.Drawing.Point(577, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(721, 600);
            this.panel1.TabIndex = 11;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // ClearB
            // 
            this.ClearB.Location = new System.Drawing.Point(12, 395);
            this.ClearB.Name = "ClearB";
            this.ClearB.Size = new System.Drawing.Size(250, 200);
            this.ClearB.TabIndex = 12;
            this.ClearB.Text = "Clear";
            this.ClearB.UseVisualStyleBackColor = true;
            this.ClearB.Click += new System.EventHandler(this.ClearB_Click);
            // 
            // ToppingMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 813);
            this.Controls.Add(this.ClearB);
            this.Controls.Add(this.ToppingRemove);
            this.Controls.Add(this.ToppingAdd);
            this.Controls.Add(this.ToppingCancel);
            this.Controls.Add(this.ToppingAmountT);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.DisaplayNameT);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.ToppingNameT);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ToppingMaster";
            this.Text = "ToppingMaster";
            this.Load += new System.EventHandler(this.ToppingMaster_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ToppingData)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ToppingNameT;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox DisaplayNameT;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox ToppingAmountT;
        private System.Windows.Forms.DataGridView ToppingData;
        private System.Windows.Forms.Button ToppingCancel;
        private System.Windows.Forms.Button ToppingAdd;
        private System.Windows.Forms.Button ToppingRemove;
        private System.Windows.Forms.Panel panel1;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToppingName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToppingDisplayName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToppingAmount;
        private System.Windows.Forms.Button ClearB;
    }
}