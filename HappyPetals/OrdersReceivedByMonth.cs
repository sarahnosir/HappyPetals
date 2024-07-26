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
    public partial class OrdersReceivedByMonth : Form
    {
        public OrdersReceivedByMonth()
        {
            InitializeComponent();
        }

        private void OrdersReceivedByMonth_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'flower_shopDataSet.Orders2' table. You can move, or remove it, as needed.
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Orders2TableAdapter.Fill(this.flower_shopDataSet.Orders2,int.Parse(textBox1.Text));

            this.reportViewer1.RefreshReport();
        }
    }
}
