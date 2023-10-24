namespace PizzaStorePOS
{
    partial class SidesF
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
            this.SidesData = new System.Windows.Forms.DataGridView();
            this.SideName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SidePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SidesNameD = new System.Windows.Forms.TextBox();
            this.SideNameT = new System.Windows.Forms.TextBox();
            this.DipsD = new System.Windows.Forms.TextBox();
            this.PriceD = new System.Windows.Forms.TextBox();
            this.PriceT = new System.Windows.Forms.TextBox();
            this.DipsT = new System.Windows.Forms.TextBox();
            this.SideAddB = new System.Windows.Forms.Button();
            this.SideCancelB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SidesData)).BeginInit();
            this.SuspendLayout();
            // 
            // SidesData
            // 
            this.SidesData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SidesData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SideName,
            this.SidePrice});
            this.SidesData.Location = new System.Drawing.Point(587, 12);
            this.SidesData.Name = "SidesData";
            this.SidesData.RowHeadersVisible = false;
            this.SidesData.RowHeadersWidth = 82;
            this.SidesData.RowTemplate.Height = 33;
            this.SidesData.Size = new System.Drawing.Size(615, 900);
            this.SidesData.TabIndex = 0;
            this.SidesData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SidesData_CellContentClick);
            // 
            // SideName
            // 
            this.SideName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SideName.HeaderText = " Name";
            this.SideName.MinimumWidth = 10;
            this.SideName.Name = "SideName";
            // 
            // SidePrice
            // 
            this.SidePrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SidePrice.HeaderText = "Price";
            this.SidePrice.MinimumWidth = 10;
            this.SidePrice.Name = "SidePrice";
            // 
            // SidesNameD
            // 
            this.SidesNameD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SidesNameD.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SidesNameD.Location = new System.Drawing.Point(12, 12);
            this.SidesNameD.Name = "SidesNameD";
            this.SidesNameD.ReadOnly = true;
            this.SidesNameD.Size = new System.Drawing.Size(248, 55);
            this.SidesNameD.TabIndex = 1;
            this.SidesNameD.Text = "Side Name";
            // 
            // SideNameT
            // 
            this.SideNameT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SideNameT.Location = new System.Drawing.Point(259, 20);
            this.SideNameT.Name = "SideNameT";
            this.SideNameT.Size = new System.Drawing.Size(305, 44);
            this.SideNameT.TabIndex = 2;
            // 
            // DipsD
            // 
            this.DipsD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DipsD.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DipsD.Location = new System.Drawing.Point(46, 125);
            this.DipsD.Name = "DipsD";
            this.DipsD.ReadOnly = true;
            this.DipsD.Size = new System.Drawing.Size(100, 55);
            this.DipsD.TabIndex = 3;
            this.DipsD.Text = "Dips";
            // 
            // PriceD
            // 
            this.PriceD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PriceD.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceD.Location = new System.Drawing.Point(46, 253);
            this.PriceD.Name = "PriceD";
            this.PriceD.ReadOnly = true;
            this.PriceD.Size = new System.Drawing.Size(130, 55);
            this.PriceD.TabIndex = 4;
            this.PriceD.Text = "Price";
            // 
            // PriceT
            // 
            this.PriceT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceT.Location = new System.Drawing.Point(259, 265);
            this.PriceT.Name = "PriceT";
            this.PriceT.Size = new System.Drawing.Size(305, 44);
            this.PriceT.TabIndex = 5;
            this.PriceT.TextChanged += new System.EventHandler(this.PriceT_TextChanged);
            // 
            // DipsT
            // 
            this.DipsT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DipsT.Location = new System.Drawing.Point(259, 136);
            this.DipsT.Name = "DipsT";
            this.DipsT.Size = new System.Drawing.Size(305, 44);
            this.DipsT.TabIndex = 6;
            this.DipsT.TextChanged += new System.EventHandler(this.DipsT_TextChanged);
            this.DipsT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DipsT_KeyPress);
            // 
            // SideAddB
            // 
            this.SideAddB.Location = new System.Drawing.Point(314, 712);
            this.SideAddB.Name = "SideAddB";
            this.SideAddB.Size = new System.Drawing.Size(250, 200);
            this.SideAddB.TabIndex = 7;
            this.SideAddB.Text = "Add Side";
            this.SideAddB.UseVisualStyleBackColor = true;
            this.SideAddB.Click += new System.EventHandler(this.SideAddB_Click);
            // 
            // SideCancelB
            // 
            this.SideCancelB.Location = new System.Drawing.Point(12, 712);
            this.SideCancelB.Name = "SideCancelB";
            this.SideCancelB.Size = new System.Drawing.Size(250, 200);
            this.SideCancelB.TabIndex = 8;
            this.SideCancelB.Text = "Cancel";
            this.SideCancelB.UseVisualStyleBackColor = true;
            this.SideCancelB.Click += new System.EventHandler(this.SideCancelB_Click);
            // 
            // SidesF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 924);
            this.Controls.Add(this.SideCancelB);
            this.Controls.Add(this.SideAddB);
            this.Controls.Add(this.DipsT);
            this.Controls.Add(this.PriceT);
            this.Controls.Add(this.PriceD);
            this.Controls.Add(this.DipsD);
            this.Controls.Add(this.SideNameT);
            this.Controls.Add(this.SidesNameD);
            this.Controls.Add(this.SidesData);
            this.Name = "SidesF";
            this.Text = "SidesF";
            this.Load += new System.EventHandler(this.SidesF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SidesData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView SidesData;
        private System.Windows.Forms.TextBox SidesNameD;
        private System.Windows.Forms.TextBox SideNameT;
        private System.Windows.Forms.TextBox DipsD;
        private System.Windows.Forms.TextBox PriceD;
        private System.Windows.Forms.TextBox PriceT;
        private System.Windows.Forms.TextBox DipsT;
        private System.Windows.Forms.Button SideAddB;
        private System.Windows.Forms.Button SideCancelB;
        private System.Windows.Forms.DataGridViewTextBoxColumn SideName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SidePrice;
    }
}