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
using System.Xml;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Xml.Linq;

namespace PizzaStorePOS
{
    public partial class ToppingMaster : Form
    {
        private List<Topping> toppings = new List<Topping>();
        public ToppingMaster()
        {
            InitializeComponent();
            LoadToppingsFromXml();
            ToppingData.CellClick += ToppingData_CellClick;
        }

        private void TextBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the key pressed is a digit or a control character
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        public class Topping
        {
            public string Name { get; set; }
            public string Display { get; set; }
            public int Amount { get; set; }

            public Topping(string name, string display, int amount)
            {
                Name = name;
                Display = display;
                Amount = amount;
            }
        }



        //private void ToppingAdd_Click(object sender, EventArgs e)
        //{
        //    string name = ToppingNameT.Text.Trim();
        //    string display = DisaplayNameT.Text.Trim();
        //    int amount = int.Parse(ToppingAmountT.Text.Trim());

        //    // Check if the topping already exists in the list
        //    Topping existingTopping = toppings.FirstOrDefault(t => t.Name == name);
        //    if (existingTopping != null)
        //    {
        //        // Prompt the user with a dialog box to confirm if they want to update the existing topping
        //        DialogResult result = MessageBox.Show($"The topping {name} already exists. Do you want to update it?", "Duplicate Topping", MessageBoxButtons.YesNo);
        //        if (result == DialogResult.Yes)
        //        {
        //            // Update the existing topping with the new settings
        //            existingTopping.Display = display;
        //            existingTopping.Amount = amount;
        //            // Refresh the DataGridView to reflect the changes
        //            ToppingData.Refresh();
        //        }
        //    }
        //    else
        //    {
        //        // Add the new topping to the list and the DataGridView
        //        Topping newTopping = new Topping(name, display, amount);
        //        toppings.Add(newTopping);
        //        ToppingData.Rows.Add(name, display, amount);
        //        ToppingData.Refresh();
        //    }

        //    SaveToppingsToXml();
        //    // Clear the textboxes
        //    ToppingNameT.Clear();
        //    DisaplayNameT.Clear();
        //    ToppingAmountT.Clear();
        //}

        private void ToppingAdd_Click(object sender, EventArgs e)
        {
            string name = ToppingNameT.Text.Trim();
            string display = DisaplayNameT.Text.Trim();
            int amount = int.Parse(ToppingAmountT.Text.Trim());

            // Check if the topping already exists in the list
            Topping existingTopping = toppings.FirstOrDefault(t => t.Name == name);
            if (existingTopping != null)
            {
                // Prompt the user with a dialog box to confirm if they want to update the existing topping
                DialogResult result = MessageBox.Show($"The topping {name} already exists. Do you want to update it?", "Duplicate Topping", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // Update the existing topping with the new settings
                    existingTopping.Display = display;
                    existingTopping.Amount = amount;

                    // Find the index of the row that contains the existing topping
                    int rowIndex = ToppingData.Rows
                        .Cast<DataGridViewRow>()
                        .Where(r => r.Cells["ToppingName"].Value.ToString().Equals(name))
                        .First()
                        .Index;

                    // Update the cells in the row with the new values
                    ToppingData.Rows[rowIndex].Cells["ToppingDisplayName"].Value = display;
                    ToppingData.Rows[rowIndex].Cells["ToppingAmount"].Value = amount;
                }
            }
            else
            {
                // Add the new topping to the list and the DataGridView
                Topping newTopping = new Topping(name, display, amount);
                toppings.Add(newTopping);
                ToppingData.Rows.Add(name, display, amount);
            }

            // Refresh the DataGridView to reflect the changes
            ToppingData.Refresh();

            SaveToppingsToXml();

            // Clear the textboxes
            ToppingNameT.Clear();
            DisaplayNameT.Clear();
            ToppingAmountT.Clear();
        }


        private void ToppingRemove_Click(object sender, EventArgs e)
        {
            if (ToppingData.Rows.Count == 0)
            {
                // DataGridView is empty, do nothing
                return;
            }

            // Get the selected row
            if (ToppingData.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = ToppingData.SelectedRows[0];

                // Ask the user for confirmation
                DialogResult result = MessageBox.Show("Are you sure you want to delete this topping?", "Confirm Deletion", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // Remove the selected row from the DataGridView
                    ToppingData.Rows.Remove(selectedRow);

                    // Remove the selected topping from the toppings list
                    string name = selectedRow.Cells[0].Value.ToString();
                    int index = toppings.FindIndex(t => t.Name == name);
                    if (index >= 0)
                    {
                        toppings.RemoveAt(index);
                    }
                    // Save the updated toppings list to the XML file
                    SaveToppingsToXml();
                }

            }
        }




        private void ToppingCancel_Click(object sender, EventArgs e)
        {
            // Clear the textboxes
            ToppingNameT.Text = "";
            DisaplayNameT.Text = "";
            ToppingAmountT.Text = "";

            // Deselect any selected rows in the DataGridView
            ToppingData.ClearSelection();
            this.Close();
        }

        private void ToppingData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = ToppingData.Rows[e.RowIndex];
                if (row.Cells["ToppingName"].Value != null && row.Cells["ToppingDisplayName"].Value != null && row.Cells["ToppingAmount"].Value != null)
                {
                    ToppingNameT.Text = row.Cells["ToppingName"].Value.ToString();
                    DisaplayNameT.Text = row.Cells["ToppingDisplayName"].Value.ToString();
                    ToppingAmountT.Text = row.Cells["ToppingAmount"].Value.ToString();
                }
            }
        }


        private void ToppingData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ToppingNameT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(ToppingNameT.Text))
                {
                    e.Handled = true;
                }
                else
                {
                    e.Handled = true;
                    DisaplayNameT.Focus();
                }
            }
        }
        private void DisplayName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(DisaplayNameT.Text))
                {
                    e.Handled = true;
                }
                else
                {
                    e.Handled = true;
                    ToppingAmountT.Focus();
                }
            }
        }

        private void ToppingMaster_Load(object sender, EventArgs e)
        {
            // Load the toppings data from the XML file
            LoadToppingsFromXml();
            

        }

        private void LoadToppingsFromXml()
        {
            toppings.Clear();
            ToppingData.Rows.Clear();

            if (!File.Exists("ToppingDataMaster.xml"))
            {
                return;
            }

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("ToppingDataMaster.xml");

            XmlNodeList toppingNodes = xmlDoc.GetElementsByTagName("Topping");
            if (toppingNodes.Count > 0)
            {
                foreach (XmlNode toppingNode in toppingNodes)
                {
                    string name = toppingNode.SelectSingleNode("ToppingName").InnerText;
                    string display = toppingNode.SelectSingleNode("DisplayName").InnerText;
                    int amount = int.Parse(toppingNode.SelectSingleNode("Amount").InnerText);

                    Topping topping = new Topping(name, display, amount);
                    toppings.Add(topping);
                    ToppingData.Rows.Add(name, display, amount);
                }
            }
        }



        private void SaveToppingsToXml()
        {
            // Create a new XmlDocument and the root element
            XmlDocument xmlDoc = new XmlDocument();
            XmlElement rootElement = xmlDoc.CreateElement("Toppings");
            xmlDoc.AppendChild(rootElement);

            // Loop through the toppings list and add each one as a child element to the root
            foreach (Topping topping in toppings)
            {
                XmlElement toppingElement = xmlDoc.CreateElement("Topping");
                rootElement.AppendChild(toppingElement);

                XmlElement nameElement = xmlDoc.CreateElement("ToppingName");
                nameElement.InnerText = topping.Name;
                toppingElement.AppendChild(nameElement);

                XmlElement displayNameElement = xmlDoc.CreateElement("DisplayName");
                displayNameElement.InnerText = topping.Display;
                toppingElement.AppendChild(displayNameElement);

                XmlElement amountElement = xmlDoc.CreateElement("Amount");
                amountElement.InnerText = topping.Amount.ToString();
                toppingElement.AppendChild(amountElement);
            }

            // Save the XmlDocument to the file
            xmlDoc.Save("ToppingDataMaster.xml");
        }

        private void ClearB_Click(object sender, EventArgs e)
        {
            ToppingNameT.Clear();
            DisaplayNameT.Clear();
            ToppingAmountT.Clear();
        }

    }
}
