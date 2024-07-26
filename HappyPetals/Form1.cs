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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Orders orders = new Orders();
            orders.Show();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer cust = new Customer();
            cust.Show();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.Show();
        }

        private void vendorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vendor ven = new Vendor();
            ven.Show();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Product prod = new Product();
            prod.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventory inv = new Inventory();
            inv.Show();
        }

        private void inventoryDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventory_Details inv_D = new Inventory_Details();
            inv_D.Show();
        }

        private void deliveriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Deliveries del = new Deliveries();
            del.Show();

        }

        private void orderDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Order_details od = new Order_details();
            od.Show();
        }

        private void customerOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerOrders co = new CustomerOrders();
            co.Show();
        }

        private void deliveredOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeliveredOrders deo = new DeliveredOrders();
            deo.Show();
        }

        private void nonDeliveredOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NonDeliveredOrders ndeo = new NonDeliveredOrders();
            ndeo.Show();
        }

        private void productQuantitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductQuantities poq = new ProductQuantities();
            poq.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reports R = new Reports();
            R.Show();
        }
    }
}
