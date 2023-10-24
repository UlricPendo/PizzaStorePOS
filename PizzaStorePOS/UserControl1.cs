using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaStorePOS
{
    public partial class ComboItemsPanel : UserControl
    {
        public ComboItemsPanel()
        {

            InitializeComponent();
        }

        private void ComboItemsPanel_Load(object sender, EventArgs e)
        {

        }

        private void ComboItemP_Paint(object sender, PaintEventArgs e)
        {

        }
        //Pulls information from other forms.
        public event EventHandler CancelButtonClicked;
        private void Cancel1_Click(object sender, EventArgs e)
        {
            CancelButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void Pizzas1_Click(object sender, EventArgs e)
        {
            PizzaControl pizzaControl = new PizzaControl(this);
            pizzaControl.Dock = DockStyle.Fill;
            ComboItemP.Controls.Add(pizzaControl);
            // Set the size of the UserControl to match the size of the Panel
            pizzaControl.Size = ComboItemP.Size;
            Pizzas1.BackColor = Color.DarkSeaGreen;
            Cancel1.BackColor = SystemColors.Window;
            Combos1.BackColor = SystemColors.Window;
            Pops1.BackColor = SystemColors.Window;
            Sides1.BackColor = SystemColors.Window;
        }

        private void Combos1_Click(object sender, EventArgs e)
        {
            Pizzas1.BackColor = SystemColors.Window;
            Cancel1.BackColor = SystemColors.Window;
            Combos1.BackColor = Color.DarkSeaGreen;
            Pops1.BackColor = SystemColors.Window;
            Sides1.BackColor = SystemColors.Window;
        }

        private void Pops1_Click(object sender, EventArgs e)
        {
            Pizzas1.BackColor = SystemColors.Window;
            Cancel1.BackColor = SystemColors.Window;
            Combos1.BackColor = SystemColors.Window;
            Pops1.BackColor = Color.DarkSeaGreen;
            Sides1.BackColor = SystemColors.Window;
        }

        private void Sides1_Click(object sender, EventArgs e)
        {
            Pizzas1.BackColor = SystemColors.Window;
            Cancel1.BackColor = SystemColors.Window;
            Combos1.BackColor = SystemColors.Window;
            Pops1.BackColor = SystemColors.Window;
            Sides1.BackColor = Color.DarkSeaGreen;
        }
    }
}
