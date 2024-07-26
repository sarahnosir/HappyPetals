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
    public partial class NonDeliveredOrders : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-67FO074;Initial Catalog=flower_shop;Integrated Security=True");
        SqlDataAdapter Da;
        DataTable Dt = new DataTable();
        SqlCommandBuilder cmdb;
        public NonDeliveredOrders()
        {
            InitializeComponent();
            Da = new SqlDataAdapter("select orderId,orderStatus from Orders where orderStatus='Not_D' ", con);
            Da.Fill(Dt);
            dataGridView1.DataSource = Dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void NonDeliveredOrders_Load(object sender, EventArgs e)
        {

        }
    }
}
