using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HappyPetals
{
    public partial class proProfit : Form
    {
        public proProfit()
        {
            InitializeComponent();
        }

        private void proProfit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'flower_shopDataSet.Pro_profit' table. You can move, or remove it, as needed.
            this.Pro_profitTableAdapter.Fill(this.flower_shopDataSet.Pro_profit);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
