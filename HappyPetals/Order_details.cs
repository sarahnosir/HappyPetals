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
    public partial class Order_details : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-67FO074;Initial Catalog=flower_shop;Integrated Security=True");
        SqlDataAdapter Da;
        DataTable Dt = new DataTable();
        SqlCommandBuilder cmdb;
        public Order_details()
        {
            InitializeComponent();
            Da = new SqlDataAdapter("select * from OrderDetails ", con);
            Da.Fill(Dt);
            dataGridView1.DataSource = Dt;
        }

        private void Order_details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'flower_shopDataSet.OrderDetails' table. You can move, or remove it, as needed.
            this.orderDetailsTableAdapter.Fill(this.flower_shopDataSet.OrderDetails);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cmdb = new SqlCommandBuilder(Da);
            Da.Update(Dt);
            MessageBox.Show("Upadated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
