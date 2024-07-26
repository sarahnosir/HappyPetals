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

namespace HappyPetals
{
    public partial class DeliveredOrders : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-67FO074;Initial Catalog=flower_shop;Integrated Security=True");
        SqlDataAdapter Da;
        DataTable Dt = new DataTable();
        SqlCommandBuilder cmdb;
        public DeliveredOrders()
        {
            InitializeComponent();
            Da = new SqlDataAdapter("select orderId,orderStatus from Orders where orderStatus='Delivered' ", con);
            Da.Fill(Dt);
            dataGridView1.DataSource = Dt;
        }

        private void DeliveredOrders_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
