namespace PyramidPOS
{
    partial class PizzaControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SmallPizzaB = new System.Windows.Forms.Button();
            this.MediumPizzaB = new System.Windows.Forms.Button();
            this.LargePizzaB = new System.Windows.Forms.Button();
            this.XLPizzaB = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.SmallPizzaB);
            this.flowLayoutPanel1.Controls.Add(this.MediumPizzaB);
            this.flowLayoutPanel1.Controls.Add(this.LargePizzaB);
            this.flowLayoutPanel1.Controls.Add(this.XLPizzaB);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1618, 845);
            this.flowLayoutPanel1.TabIndex = 3;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // SmallPizzaB
            // 
            this.SmallPizzaB.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SmallPizzaB.Location = new System.Drawing.Point(15, 15);
            this.SmallPizzaB.Margin = new System.Windows.Forms.Padding(15);
            this.SmallPizzaB.MaximumSize = new System.Drawing.Size(250, 200);
            this.SmallPizzaB.MinimumSize = new System.Drawing.Size(250, 200);
            this.SmallPizzaB.Name = "SmallPizzaB";
            this.SmallPizzaB.Size = new System.Drawing.Size(250, 200);
            this.SmallPizzaB.TabIndex = 0;
            this.SmallPizzaB.Text = "Small Pizza";
            this.SmallPizzaB.UseVisualStyleBackColor = true;
            this.SmallPizzaB.Click += new System.EventHandler(this.SmallPizzaB_Click);
            // 
            // MediumPizzaB
            // 
            this.MediumPizzaB.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.MediumPizzaB.Location = new System.Drawing.Point(295, 15);
            this.MediumPizzaB.Margin = new System.Windows.Forms.Padding(15);
            this.MediumPizzaB.MaximumSize = new System.Drawing.Size(250, 200);
            this.MediumPizzaB.MinimumSize = new System.Drawing.Size(250, 200);
            this.MediumPizzaB.Name = "MediumPizzaB";
            this.MediumPizzaB.Size = new System.Drawing.Size(250, 200);
            this.MediumPizzaB.TabIndex = 1;
            this.MediumPizzaB.Text = "Medium Pizza";
            this.MediumPizzaB.UseVisualStyleBackColor = true;
            this.MediumPizzaB.Click += new System.EventHandler(this.MediumPizzaB_Click);
            // 
            // LargePizzaB
            // 
            this.LargePizzaB.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.LargePizzaB.Location = new System.Drawing.Point(575, 15);
            this.LargePizzaB.Margin = new System.Windows.Forms.Padding(15);
            this.LargePizzaB.MaximumSize = new System.Drawing.Size(250, 200);
            this.LargePizzaB.MinimumSize = new System.Drawing.Size(250, 200);
            this.LargePizzaB.Name = "LargePizzaB";
            this.LargePizzaB.Size = new System.Drawing.Size(250, 200);
            this.LargePizzaB.TabIndex = 2;
            this.LargePizzaB.Text = "Large Pizza";
            this.LargePizzaB.UseVisualStyleBackColor = true;
            this.LargePizzaB.Click += new System.EventHandler(this.LargePizzaB_Click);
            // 
            // XLPizzaB
            // 
            this.XLPizzaB.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.XLPizzaB.Location = new System.Drawing.Point(855, 15);
            this.XLPizzaB.Margin = new System.Windows.Forms.Padding(15);
            this.XLPizzaB.MaximumSize = new System.Drawing.Size(250, 200);
            this.XLPizzaB.MinimumSize = new System.Drawing.Size(250, 200);
            this.XLPizzaB.Name = "XLPizzaB";
            this.XLPizzaB.Size = new System.Drawing.Size(250, 200);
            this.XLPizzaB.TabIndex = 3;
            this.XLPizzaB.Text = "XL - Pizza";
            this.XLPizzaB.UseVisualStyleBackColor = true;
            this.XLPizzaB.Click += new System.EventHandler(this.XLPizzaB_Click);
            // 
            // PizzaControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "PizzaControl";
            this.Size = new System.Drawing.Size(1618, 845);
            this.Load += new System.EventHandler(this.PizzaControl_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button SmallPizzaB;
        private System.Windows.Forms.Button MediumPizzaB;
        private System.Windows.Forms.Button LargePizzaB;
        private System.Windows.Forms.Button XLPizzaB;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
