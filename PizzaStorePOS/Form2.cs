using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace PizzaStorePOS
{
    public partial class Form2 : Form
    {
        private DataGridView dataGridView1;
        private PizzaStorePOS parentForm;
        public Form2(PizzaStorePOS pForm)
        {
            InitializeComponent();
            parentForm = pForm;
            button1.Text = "↑";
            button2.Text = "↓";

        }

        public void SetDataGridView(DataGridView dataGridView)
        {
            this.dataGridView1 = dataGridView;
        }

        private void Pizzas1_Click(object sender, EventArgs e)
        {

            Pizzas1.BackColor = Color.DarkSeaGreen;
            Combos1.BackColor = SystemColors.Window;
            Pops1.BackColor = SystemColors.Window;
            Sides1.BackColor = SystemColors.Window;
            // Clear the FlowLayoutPanel's controls
            flowLayoutPanel1.Controls.Clear();



            // Get common properties from the existing button controls on the form
            Size buttonSize = Pizzas1.Size;
            Font buttonFont = Pizzas1.Font;

            Pizza[] pizzas = new Pizza[]
            {
             new Pizza("Small", 9.99m),
             new Pizza("Medium", 11.99m),
             new Pizza("Large", 13.99m)
            };

            // Define an array of button texts
            foreach (Pizza pizza in pizzas)
            {
                Button newButton = new Button();
                newButton.Text = $"{pizza.Size} - ${pizza.Price.ToString("F2")}";
                newButton.Size = buttonSize;
                newButton.Font = buttonFont;
                newButton.Click += new EventHandler((s, ev) => Button_Click(pizza));
                flowLayoutPanel1.Controls.Add(newButton);
            }
        }

        private void Button_Click(Pizza pizza)
        {

            // Get the quantity from the textbox
            int quantity = int.Parse(Quanty.Text);
            for (int i = 0; i < quantity; i++)
            {
                // Add new row to the DataGridView on Form1 with the selected pizza's size and price
                parentForm.AddRow(pizza.Size, pizza.Price);
            }
            // Close Form2
            this.Close();
        }

        private void smallPizza_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Small Pizza");
        }

        private void Combos1_Click(object sender, EventArgs e)
        {

            Pizzas1.BackColor = SystemColors.Window;
            Combos1.BackColor = Color.DarkSeaGreen;
            Pops1.BackColor = SystemColors.Window;
            Sides1.BackColor = SystemColors.Window;
            // Clear the FlowLayoutPanel's controls
            flowLayoutPanel1.Controls.Clear();

        }

        private class Pizza
        {
            public string Size { get; set; }
            public decimal Price { get; set; }

            public Pizza(string size, decimal price)
            {
                Size = size;
                Price = price;
            }
        }

        private void Sides1_Click(object sender, EventArgs e)
        {
            Pizzas1.BackColor = SystemColors.Window;
            Combos1.BackColor = SystemColors.Window;
            Pops1.BackColor = SystemColors.Window;
            Sides1.BackColor = Color.DarkSeaGreen;
            // Clear the FlowLayoutPanel's controls
            flowLayoutPanel1.Controls.Clear();

        }

        private void Pops1_Click(object sender, EventArgs e)
        {
            Pizzas1.BackColor = SystemColors.Window;
            Combos1.BackColor = SystemColors.Window;
            Pops1.BackColor = Color.DarkSeaGreen;
            Sides1.BackColor = SystemColors.Window;
            // Clear the FlowLayoutPanel's controls
            flowLayoutPanel1.Controls.Clear();

        }

        private void Cancel1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int currentValue = int.Parse(Quanty.Text);
            int newValue = currentValue + 1;
            Quanty.Text = newValue.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int currentValue = int.Parse(Quanty.Text);
            int newValue = currentValue - 1;

            if (newValue < 1)
            {
                newValue = 1;
            }

            Quanty.Text = newValue.ToString();
        }


        private void Quanty_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the key pressed is a digit or a control character
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
