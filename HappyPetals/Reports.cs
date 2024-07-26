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
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportSalary RS = new ReportSalary();
            RS.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            proProfit pp = new proProfit();
            pp.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OrdersReservedByMonth o = new OrdersReservedByMonth();
            o.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OrdersReceivedByMonth or = new OrdersReceivedByMonth();
            or.Show();
        }
    }
}
