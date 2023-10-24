using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PizzaStorePOS.PizzaControl;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Data.SqlClient;
using System.Xml;

namespace PizzaStorePOS
{
    public partial class PizzaStorePOS : Form
    {
        //PizzaControl pizzaControl = new PizzaControl();
        
        public PizzaStorePOS()
        {

            InitializeComponent();
            Combos1.Click += NewOrder1_Click;
        }

        private void PickUpDelivery_CheckedChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["DataComboName"].Value != null && row.Cells["DataPrice"].Value != null)
                {
                    string name = row.Cells["DataComboName"].Value.ToString();
                    decimal price = decimal.Parse(row.Cells["DataPrice"].Value.ToString());

                    if (PickUpDelivery.Checked)
                    {
                        // Update the price for delivery orders
                        price += 2.00m;
                        PickUpDelivery.Text = "Delivery";
                    }
                    else
                    {
                        // Update the price for pick orders
                        price -= 2.00m;
                        PickUpDelivery.Text = "Pick Up";
                    }

                    // Update the DataGridView with the new price
                    row.Cells["DataPrice"].Value = price.ToString();
                }
            }


        }

        public void AddRow(string size,decimal price)
        {
            dataGridView1.Rows.Add(size,"Select Toppings" ,price);
        }

        private void NewOrder1_Click(object sender, EventArgs e)
        {
            //dataGridView1.RowCount = 13;
            OrderPanel1.Visible = true;
            AddressPanel.Visible = true;
            CheckoutPanel.Visible = true;
            //Creates new form
            Form2 newOrderF = new Form2(this);
            newOrderF.StartPosition = FormStartPosition.Manual; // Set start position manually
            newOrderF.Location = new Point(15, 50); // Set location
            newOrderF.Size = new Size(820, 550); // Set the size of the new form.
            //newOrderF.Show(); // Show the new form
            newOrderF.SetDataGridView(this.dataGridView1);
            newOrderF.ShowDialog();
        }



        private void OrderPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Cancel1_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Are you sure you want to clear the order?",
    "Confirm Clear Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                OrderPanel1.Visible = false;
                AddressPanel.Visible = false;
                CheckoutPanel.Visible = false;
                dataGridView1.Rows.Clear(); // Clear all rows in the DataGridView
            }
            
            //dataGridView1.Refresh(); // Refresh the DataGridView to reflect the changes
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Each Pizza will have a size value, and topping value. Size value, s=1, m=2, l=3, Xl=4.Toppings will be value 1 per topping.
            //Example Medium Pizza, 4 toppings = 6.
            //Make into combo, will check the current the above pizza value of 6, and compare to any combos that are close to 6. 
            //Medium Pizza, 3 toppings = 5. Medium Pizza, 5 toppings = 7. Will suggest to either those 2 combos. With the combo selected
            //it will auto update the order sheet, to show the selected combo with all the selected combos.
            //Example Medium Pizza, 4 toppings = 6 || wings will have a value of 50 per lb. DO I have wing values much larger to insure no mixed results?
            //Medium Pizza, 4 toppings, 1lb wings = 56
            //XL + 5 toppings = 9. would show up for a medium 4 topping + 1lb wings. 
        }


        private void CancelOrder1_Click(object sender, EventArgs e)
        {
 
        }

        private void DeleteCombo1_Click(object sender, EventArgs e)
        {
            // Check if there are any rows selected
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    // Loop through each selected row
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        // Check if the row is committed
                        if (!row.IsNewRow)
                        {
                            // Remove the row from the DataGridView
                            dataGridView1.Rows.Remove(row);
                        }
                    }
                }
        }

        private void masterToppingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToppingMaster toppingMaster = new ToppingMaster();
            toppingMaster.Size = new Size(675, 465);
            toppingMaster.Show();
        }

        private void Toppings1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void combosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CombosMasterForm combosMasterForm= new CombosMasterForm();
            combosMasterForm.Size = new Size(770, 525);
            combosMasterForm.Show();
        }

        private void MakeCombo1_Click(object sender, EventArgs e)
        {
            //Check Combo Item Values.
        }

        private void PizzaStorePOS_Load(object sender, EventArgs e)
        {

        }
    }
}
