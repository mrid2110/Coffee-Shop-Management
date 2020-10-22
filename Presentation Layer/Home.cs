using CoffeeShop.Business_Logic_Layer;
using CoffeeShop.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop.Presentation_Layer
{
    public partial class Home : Form
    {
        DataAccess da;
        OrderService os;
        public Home()
        {
            InitializeComponent();
            da = new DataAccess();
            os = new OrderService();
            dataGridView1.DataSource = os.GetOrderData();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            da = new DataAccess();
            string sql = "SELECT Designation FROM Employees WHERE EId='" + GlobalVriables.id + "'";
            SqlDataReader reader = da.GetData(sql);
            Employee em = new Employee();
            while (reader.Read())
            {
                em.Designation = reader["Designation"].ToString();
            }
            if (em.Designation == "Admin")
            {
                if (GlobalVriables.x <= 5 && GlobalVriables.x > 0)
                {
                    da = new DataAccess();
                    string query = "SELECT InventoryName FROM Inventories WHERE Amount='" + GlobalVriables.x + "'";
                    SqlDataReader sdr = da.GetData(query);
                    Inventory inv = new Inventory();
                    while (sdr.Read())
                    {
                        inv.InventoryName = sdr["InventoryName"].ToString();
                    }
                    string Text = inv.InventoryName + " is about to finish. There only " + GlobalVriables.x + " packets left.";
                    notificationTextBox.AppendText(Text);
                    notificationTextBox.AppendText(Environment.NewLine);
                }
                else
                {
                    notificationTextBox.Text = "There is no notification.";
                }


                da = new DataAccess();
                string s = "SELECT SUM(Price) as Price FROM Inventories";
                SqlDataReader r = da.GetData(s);
                Inventory inventory = new Inventory();
                while (r.Read())
                {
                    inventory.Price = (int)r["Price"];
                }

                da = new DataAccess();
                string s1 = "SELECT SUM(Total) as Total FROM OrderList";
                SqlDataReader r1 = da.GetData(s1);
                Order order = new Order();
                while(r1.Read())
                {
                    order.Total = (int)r1["Total"];
                }

                int profit = order.Total - inventory.Price;
                if(profit<=0)
                {
                    profitTextBox.Text = "There is still no profit on this month!";
                }
                else
                {
                    profitTextBox.Text = "Month profit till now: "+profit;
                }
                employeesButton.Show();
                menuButton.Show();
                notificationTextBox.Show();
                profitTextBox.Show();
                label2.Show();
                label3.Show();
            }
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
        }


        private void orderButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderForm of = new OrderForm();
            of.Show();
        }

        private void cancelOrderButton_Click(object sender, EventArgs e)
        {
            da = new DataAccess();
            os = new OrderService();
            int result = os.DeleteOrder(oid);
            if(result==1)
            {
                MessageBox.Show("Order Cancelled!");
                os = new OrderService();
                dataGridView1.DataSource = os.GetOrderData();
            }
        }


        private void menuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuForm mf = new MenuForm();
            mf.Show();
        }


        int oid, eid, tamount;
        string ename,month;

        private void inventoryButton_Click(object sender, EventArgs e)
        {
            da = new DataAccess();
            this.Hide();
            InventoryForm i = new InventoryForm();
            i.Show();
        }

        private void employeesButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeesForm ef = new EmployeesForm();
            ef.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            oid = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            ename = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            eid = (int)dataGridView1.Rows[e.RowIndex].Cells[2].Value;
            tamount = (int)dataGridView1.Rows[e.RowIndex].Cells[3].Value;
            month = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
