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
    public partial class InventoryForm : Form
    {
        InventoryService s;
        DataAccess da;
        public InventoryForm()
        {
            InitializeComponent();
            s = new InventoryService();
            da = new DataAccess();
            inventoryComboBox.DataSource = s.GetInventoryName();
            dataGridView1.DataSource = s.GetInventoryData();
        }

        private void InventoryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        int id;
        string month;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            iNameTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            iAmountTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            month = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            priceTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void newInventoryButton_Click(object sender, EventArgs e)
        {
            da = new DataAccess();
            string sql = "SELECT InventoryName FROM Inventories";
            SqlDataReader reader = da.GetData(sql);
            Inventory i = new Inventory();
            while(reader.Read())
            {
                i.InventoryName = reader["InventoryName"].ToString();
            }
            if(iNameTextBox.Text!=i.InventoryName && !string.IsNullOrEmpty(iNameTextBox.Text))
            {
                if(!string.IsNullOrEmpty(priceTextBox.Text))
                {
                    int result = s.AddInventory(iNameTextBox.Text, Convert.ToInt32(iAmountTextBox.Text), DateTime.Now.Month.ToString(), Convert.ToInt32(priceTextBox.Text));
                    if(result==1)
                    {
                        MessageBox.Show("Inventory Successfully Added!");
                        s = new InventoryService();
                        dataGridView1.DataSource = s.GetInventoryData();
                        inventoryComboBox.DataSource = s.GetInventoryName();
                        iNameTextBox.Clear();
                        iAmountTextBox.Clear();
                        priceTextBox.Clear();
                    }
                    else
                    {
                        MessageBox.Show("ERROR!");
                    }
                }
                else
                {
                    MessageBox.Show("Please fill the price field!");
                }
            }
            else
            {
                MessageBox.Show("Same inventory name.\nOr,\nYou didn't fill the Inventory name field!");
            }
        }

        private void editInventoryButton_Click(object sender, EventArgs e)
        {
            int result = s.EditInventory(id, iNameTextBox.Text, Convert.ToInt32(iAmountTextBox.Text), month, Convert.ToInt32(priceTextBox.Text));
            s = new InventoryService();
            dataGridView1.DataSource = s.GetInventoryData();
            inventoryComboBox.DataSource = s.GetInventoryName();
            MessageBox.Show("Inventory details successfully saved!");
            iNameTextBox.Clear();
            iAmountTextBox.Clear();
            priceTextBox.Clear();
        }

        private void deleteInventoryButton_Click(object sender, EventArgs e)
        {
            int result = s.DeleteInventory(Convert.ToInt32(dInventoryTextBox.Text));
            if(result==1)
            {
                MessageBox.Show("Inventory successfully deleted!");
                s = new InventoryService();
                dataGridView1.DataSource = s.GetInventoryData();
                inventoryComboBox.DataSource = s.GetInventoryName();
                dInventoryTextBox.Clear();
            }
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            da = new DataAccess();
            string sql = "SELECT Amount,InventoryId FROM Inventories WHERE InventoryName='" + inventoryComboBox.SelectedItem.ToString() + "'";
            SqlDataReader reader = da.GetData(sql);
            Inventory i = new Inventory();
            while(reader.Read())
            {
                i.InventoryId = (int)reader["InventoryId"];
                i.Amount = (int)reader["Amount"];
            }
            int cal = i.Amount - Convert.ToInt32(amountTextBox.Text);
            if(cal>0)
            {
                if(cal<=5)
                {
                    GlobalVriables.inventory = i.InventoryId;
                    GlobalVriables.x=cal;
                    int result = s.SubInventory(i.InventoryId, cal);
                    s = new InventoryService();
                    dataGridView1.DataSource = s.GetInventoryData();
                    MessageBox.Show("Amount subtracted!");
                    inventoryComboBox.SelectedItem = null;
                    amountTextBox.Clear();
                }
                else
                {
                    int result = s.SubInventory(i.InventoryId, cal);
                    s = new InventoryService();
                    dataGridView1.DataSource = s.GetInventoryData();
                    MessageBox.Show("Amount subtracted!");
                    inventoryComboBox.SelectedItem = null;
                    amountTextBox.Clear();
                }
            }
            else
            {
                MessageBox.Show("Insufficient Amount!");
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            da = new DataAccess();
            string sql = "SELECT Amount,InventoryId,Price FROM Inventories WHERE InventoryName='" + inventoryComboBox.SelectedItem.ToString() + "'";
            SqlDataReader reader = da.GetData(sql);
            Inventory i = new Inventory();
            while (reader.Read())
            {
                i.InventoryId = (int)reader["InventoryId"];
                i.Amount = (int)reader["Amount"];
                i.Price = (int)reader["Price"];
            }
            int cal = i.Amount + Convert.ToInt32(amountTextBox.Text);
            int p = ((i.Price / i.Amount) * Convert.ToInt32(amountTextBox.Text))+i.Price;
            int result = s.AdInventory(i.InventoryId, cal,p);
            s = new InventoryService();
            dataGridView1.DataSource = s.GetInventoryData();
            MessageBox.Show("Amount added!");
            inventoryComboBox.SelectedItem = null;
            amountTextBox.Clear();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home h = new Home();
            h.Show();
        }

        private void InventoryForm_Load(object sender, EventArgs e)
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
                addButton.Show();
                groupBox1.Show();
                label3.Show();
                deleteInventoryButton.Show();
                dInventoryTextBox.Show();
            }
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
            label6.BackColor = Color.Transparent;
            groupBox1.BackColor = Color.Transparent;
            groupBox2.BackColor = Color.Transparent;
        }
    }
}
