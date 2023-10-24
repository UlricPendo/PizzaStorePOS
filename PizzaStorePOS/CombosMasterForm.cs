using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace PizzaStorePOS
{
    public partial class CombosMasterForm : Form
    {

        private List<ComboList> comboLists= new List<ComboList>();
        public CombosMasterForm()
        {
            InitializeComponent();
        }

        public class ComboList
        {
            public ComboList(string comboName, string comboSizes, int comboQuantity, int comboPop, string comboPrice, string comboSizePrice)
            {
                ComboName = comboName;
                ComboSizes = comboSizes;
                ComboQuantity = comboQuantity;
                ComboPop = comboPop;
                ComboPrice1 = comboPrice;
                ComboSizePrice1 = comboSizePrice;
            }
            public string ComboSizes { get; set; }
            public int ComboQuantity { get; set; }
            public int ComboPop { get; set; }
            public string ComboName { get; }
            public string ComboPrice1 { get; }
            public string ComboSizePrice1 { get; }
        }

            private void ComboPriceT_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboSizePriceT_TextChanged(object sender, EventArgs e)
        {

        }

        private void CombosData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Pizza1C_CheckedChanged(object sender, EventArgs e)
        {
            Pizza2C.Checked = false;
            Pizza3C.Checked = false;
            Pizza1C.BackColor = Color.SeaGreen;
            Pizza2C.BackColor = SystemColors.Window;
            Pizza3C.BackColor = SystemColors.Window;
        }

        private void Pizza2C_CheckedChanged(object sender, EventArgs e)
        {
            Pizza3C.Checked = false;
            Pizza1C.Checked = false;
            Pizza1C.BackColor = SystemColors.Window;
            Pizza2C.BackColor = Color.SeaGreen;
            Pizza3C.BackColor = SystemColors.Window;
        }

        private void Pizza3C_CheckedChanged(object sender, EventArgs e)
        {
            Pizza1C.Checked = false;
            Pizza2C.Checked = false;
            Pizza1C.BackColor = SystemColors.Window;
            Pizza2C.BackColor = SystemColors.Window;
            Pizza3C.BackColor = Color.SeaGreen;
        }
        private void NoPopC_CheckedChanged(object sender, EventArgs e)
        {
            Pop1C.Checked = false;
            Pop2C.Checked = false;
            Pop4C.Checked = false;
            NoPopC.BackColor = Color.SeaGreen;
            Pop2C.BackColor = SystemColors.Window;
            Pop4C.BackColor = SystemColors.Window;
            Pop1C.BackColor = SystemColors.Window;

        }
        private void Pop1C_CheckedChanged(object sender, EventArgs e)
        {
            Pop2C.Checked = false;
            Pop4C.Checked = false;
            NoPopC.Checked = false;
            NoPopC.BackColor = SystemColors.Window;
            Pop2C.BackColor = SystemColors.Window;
            Pop4C.BackColor = SystemColors.Window;
            Pop1C.BackColor = Color.SeaGreen;
        }

        private void Pop2C_CheckedChanged(object sender, EventArgs e)
        {
            Pop1C.Checked = false;
            Pop4C.Checked = false;
            NoPopC.Checked = false;
            NoPopC.BackColor = SystemColors.Window;
            Pop1C.BackColor = SystemColors.Window;
            Pop4C.BackColor = SystemColors.Window;
            Pop2C.BackColor = Color.SeaGreen;

        }

        private void Pop4C_CheckedChanged(object sender, EventArgs e)
        {
            Pop2C.Checked = false;
            Pop1C.Checked = false;
            NoPopC.Checked = false;
            NoPopC.BackColor = SystemColors.Window;
            Pop2C.BackColor = SystemColors.Window;
            Pop1C.BackColor = SystemColors.Window;
            Pop4C.BackColor = Color.SeaGreen;

        }
        private void NoDipC_CheckedChanged(object sender, EventArgs e)
        {
            Dip1C.Checked = false;
            Dip2C.Checked = false;
            NoDipC.BackColor = Color.SeaGreen;
            Dip1C.BackColor = SystemColors.Window;
            Dip2C.BackColor = SystemColors.Window;
        }

        private void Dip1C_CheckedChanged(object sender, EventArgs e)
        {
            NoDipC.Checked = false;
            Dip2C.Checked = false;
            Dip1C.BackColor = Color.SeaGreen;
            NoDipC.BackColor = SystemColors.Window;
            Dip2C.BackColor = SystemColors.Window;

        }

        private void Dip2C_CheckedChanged(object sender, EventArgs e)
        {
            NoDipC.Checked = false;
            Dip1C.Checked = false;
            Dip2C.BackColor = Color.SeaGreen;
            Dip1C.BackColor = SystemColors.Window;
            NoDipC.BackColor = SystemColors.Window;

        }

        private void CloseB_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void SaveCombosToXml()
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlElement combosElement = xmlDoc.CreateElement("combos");
            xmlDoc.AppendChild(combosElement);


            // Load the XML document
            xmlDoc.Load("CombosDataMaster.xml");

            // Generate the unique ID
            string comboId = Guid.NewGuid().ToString();
            foreach (ComboList combo in comboLists)
            {
                // Check if the combo already exists
                XmlNode existingCombo = xmlDoc.SelectSingleNode("//combo[@name='" + combo.ComboName + "' and @sizes='" + combo.ComboSizes + "']");
                if (existingCombo != null)
                {
                    // Combo already exists, overwrite its attributes
                    existingCombo.Attributes["quantity"].Value = combo.ComboQuantity;
                    existingCombo.Attributes["pop"].Value = combo.comboPop;
                    existingCombo.Attributes["price"].Value = combo.ComboPrice1;
                    existingCombo.Attributes["sizePrice"].Value = comboSizePrice;
                }
                else
                {
                    // Combo does not exist, create a new combo element
                    XmlElement comboElement = xmlDoc.CreateElement("combo");
                    comboElement.SetAttribute("ID", comboId);
                    comboElement.SetAttribute("name", comboName);
                    comboElement.SetAttribute("sizes", comboSizes);
                    comboElement.SetAttribute("quantity", comboQuantity);
                    comboElement.SetAttribute("pop", comboPop);
                    comboElement.SetAttribute("price", comboPrice);
                    comboElement.SetAttribute("sizePrice", comboSizePrice);

                    // Add the new combo element to the combos element
                    XmlNode combosNode = xmlDoc.SelectSingleNode("//combos");
                    combosNode.AppendChild(comboElement);
                }
            }
            //foreach (ComboList combo in comboLists)
            //{
            //    XmlElement comboElement = xmlDoc.CreateElement("combo");

            //    XmlAttribute nameAttribute = xmlDoc.CreateAttribute("name");
            //    nameAttribute.Value = combo.ComboName;
            //    comboElement.Attributes.Append(nameAttribute);

            //    XmlAttribute sizesAttribute = xmlDoc.CreateAttribute("sizes");
            //    sizesAttribute.Value = combo.ComboSizes;
            //    comboElement.Attributes.Append(sizesAttribute);

            //    XmlAttribute quantityAttribute = xmlDoc.CreateAttribute("quantity");
            //    quantityAttribute.Value = combo.ComboQuantity.ToString();
            //    comboElement.Attributes.Append(quantityAttribute);

            //    XmlAttribute popAttribute = xmlDoc.CreateAttribute("pop");
            //    popAttribute.Value = combo.ComboPop.ToString();
            //    comboElement.Attributes.Append(popAttribute);

            //    XmlAttribute priceAttribute = xmlDoc.CreateAttribute("price");
            //    priceAttribute.Value = combo.ComboPrice.ToString();
            //    comboElement.Attributes.Append(priceAttribute);

            //    XmlAttribute sizePriceAttribute = xmlDoc.CreateAttribute("sizePrice");
            //    sizePriceAttribute.Value = combo.ComboSizePrice.ToString();
            //    comboElement.Attributes.Append(sizePriceAttribute);

            //    combosElement.AppendChild(comboElement);
            //}

            xmlDoc.Save("CombosDataMaster.xml");
        }
        private void SaveB_Click(object sender, EventArgs e)
        {
            string comboName = ComboName.Text;
            string comboSizes = "";
            int comboQuantity = 0;
            int comboPop = 0;
            string comboPrice = ComboPriceT.Text;
            string comboSizePrice = ComboSizePriceT.Text;
            //Pizza Sizes
            if (SmallPizzaC.Checked)
            {
                comboSizes += "Ssmall ";
            }
            if (MedPizzaC.Checked)
            {
                comboSizes += "Medium ";
            }
            if (LargePizzaC.Checked)
            {
                comboSizes += "Large ";
            }
            if (XLPizzaC.Checked)
            {
                comboSizes += "X-large ";
            }
            //Pizza Quantities
            if (Pizza1C.Checked)
            {
                comboQuantity = 1;
            }
            if (Pizza2C.Checked)
            {
                comboQuantity = 2;
            }
            if (Pizza3C.Checked)
            {
                comboQuantity = 3;
            }
            //Pop Quantity      
            if (Pop1C.Checked)
            {
                comboPop = 1;
            }
            if (Pop2C.Checked)
            {
                comboPop = 2;
            }
            if (Pop4C.Checked)
            {
                comboPop = 4;
            }


            ComboList combo = new ComboList(comboName, comboSizes, comboQuantity, comboPop, comboPrice, comboSizePrice);

            comboLists.Add(combo);
            SaveCombosToXml();
            ComboName.Clear();
            ComboPriceT.Clear();
            ComboSizePriceT.Clear();

        }

        private void EditB_Click(object sender, EventArgs e)
        {

        }

        private void ComboPriceT_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the key pressed is a digit, a period, or a control character
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}