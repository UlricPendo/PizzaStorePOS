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
    public partial class SidesF : Form
    {

        private List<Sides> sides = new List<Sides>();
        public SidesF()
        {
            InitializeComponent();
        }

        public class Sides
        {
            public string SideName { get; set; }
            public int Dips { get; set; }
            public int Price { get; set; }
        }

        private void SidesF_Load(object sender, EventArgs e)
        {

        }

        private void SideCancelB_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void SideAddB_Click(object sender, EventArgs e)
        {

        }

        private void SidesData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DipsT_TextChanged(object sender, EventArgs e)
        {


        }

        private void PriceT_TextChanged(object sender, EventArgs e)
        {

        }

        private void DipsT_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
