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
    public partial class ProductQuantities : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-67FO074;Initial Catalog=flower_shop;Integrated Security=True");
        SqlDataAdapter Da;
        DataTable Dt = new DataTable();
        SqlCommandBuilder cmdb;
        public ProductQuantities()
        {
            InitializeComponent(); 
            Da = new SqlDataAdapter("select Product.productName, V1.totalQuantity from V1 ,Product where Product.productCode=V1.productCode", con);
            Da.Fill(Dt);
            dataGridView1.DataSource = Dt;
        }

        private void ProductQuantities_Load(object sender, EventArgs e)
        {

        }
    }
}
