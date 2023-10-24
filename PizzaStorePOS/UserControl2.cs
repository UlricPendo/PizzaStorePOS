using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PizzaStorePOS
{


    public partial class PizzaControl : UserControl
    {

        string name = "";
        string toppings = "";
        double price = 1;
        Form form1;
        ComboItemsPanel comboItemsPanel;

        public PizzaStorePOS MainForm { get; set; }

        public PizzaControl(Form form)
        {
            InitializeComponent();
            this.form1=form;
        }
        public PizzaControl(ComboItemsPanel comboItemsPanel)
        {
            //InitializeComponent();
            this.comboItemsPanel = comboItemsPanel;
        }

        private void PizzaControl_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void SmallPizzaB_Click(object sender, EventArgs e)
        {
           
            name = "Small Pizza";
            toppings = "Select Toppings";
            price = 6.99;
            //form1.dataGridView1.Rows.Add(name, toppings, price);
            //MessageBox.Show("Added Small Pizza");
            // Create an instance of Form1
            //Form1 form1 = new Form1();

            // Call the AddDataToDataGridView method on Form1
            //form1.AddDataToDataGridView(name, toppings, price);
            ((Form)this.TopLevelControl).Close(); // Close the form that contains this UserControl

        }


        private void MediumPizzaB_Click(object sender, EventArgs e)
        {

        }

        private void LargePizzaB_Click(object sender, EventArgs e)
        {

        }

        private void XLPizzaB_Click(object sender, EventArgs e)
        {

        }
    }
}
