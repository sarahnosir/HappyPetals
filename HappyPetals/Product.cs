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
    public partial class Product : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-67FO074;Initial Catalog=flower_shop;Integrated Security=True");
        SqlDataAdapter Da;
        DataTable Dt = new DataTable();
        SqlCommandBuilder cmdb;
        public Product()
        {
            InitializeComponent();
            
            Da = new SqlDataAdapter("select * from Product ", con);
            Da.Fill(Dt);
            dataGridView1.DataSource = Dt;
        }

        private void Product_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'flower_shopDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.flower_shopDataSet.Product);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmdb = new SqlCommandBuilder(Da);
            Da.Update(Dt);
            MessageBox.Show("Upadated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
