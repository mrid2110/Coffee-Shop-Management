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
    public partial class OrderForm : Form
    {
        MenuService ms;
        DataAccess da;
        OrderService os;
        public OrderForm()
        {
            InitializeComponent();
            da = new DataAccess();
            os = new OrderService();
            ms = new MenuService();
            itemComboBox.DataSource = ms.GetMenuName();
        }


        int x;

        private void addButton_Click(object sender, EventArgs e)
        {
            if(itemComboBox.SelectedItem!=null)
            {
                if(quantityComboBox.SelectedItem!=null)
                {
                    if(!string.IsNullOrEmpty(cupsTextBox.Text))
                    {
                        da = new DataAccess();
                        string sql = "SELECT Price FROM Menu WHERE ItemName='" + itemComboBox.SelectedItem.ToString() + "' AND Quantity='" + quantityComboBox.SelectedItem.ToString() + "'";
                        SqlDataReader reader = da.GetData(sql);
                        ItemMenu im = new ItemMenu();
                        while (reader.Read())
                        {
                            im.Price = reader["Price"].ToString();
                        }
                        x = Convert.ToInt32(im.Price) * Convert.ToInt32(cupsTextBox.Text);
                        string text = itemComboBox.SelectedItem.ToString() + "    " + quantityComboBox.SelectedItem.ToString() + "    " + cupsTextBox.Text + "    " + x + "tk";
                        orderListBox.Items.Add(text);
                        itemComboBox.SelectedItem = null;
                        quantityComboBox.SelectedItem = null;
                        cupsTextBox.Clear();
                        GlobalVriables.total(x);
                    }
                    else
                    {
                        MessageBox.Show("How many cups?");
                    }
                }
                else
                {
                    MessageBox.Show("Please select quantity!");
                }
            }
            else
            {
                MessageBox.Show("Please select an item!");
            }
        }


        private void totalButton_Click(object sender, EventArgs e)
        {
            int m = 0;
            string text = "___________________________";
            string text2= "    Total      -       " + GlobalVriables.total(m)+"tk";
            orderListBox.Items.Add(text);
            orderListBox.Items.Add(text2);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            GlobalVriables.p = 0;
            orderListBox.Items.Clear();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if(orderListBox.SelectedIndex==-1)
            {
                MessageBox.Show("Please select the item!");
            }
            else
            {
                orderListBox.Items.RemoveAt(orderListBox.SelectedIndex);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            List<string> values = new List<string>();

            foreach (object o in orderListBox.Items)
                values.Add(o.ToString());

            string selectedItems = String.Join("\n", values);
            e.Graphics.DrawString("Thanks for enjoying your pastime with us\n\n\n"+selectedItems, new Font("Times New Romans", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 100));
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            int m = 0;
            da = new DataAccess();
            string sql = "SELECT EName FROM Employees WHERE EId='" + GlobalVriables.id + "'";
            SqlDataReader reader = da.GetData(sql);
            Employee em = new Employee();
            while (reader.Read())
            {
                em.EName = reader["EName"].ToString();
            }
            int result = os.AddOrder(em.EName, Convert.ToInt32(GlobalVriables.id), GlobalVriables.total(m), Convert.ToString(DateTime.Now.Month));
            if (result == 1)
            {
                printPreviewDialog1.Document = printDocument1;
                if(printPreviewDialog1.ShowDialog()==DialogResult.OK)
                {
                    printDocument1.Print();
                }
                orderListBox.Items.Clear();
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home h = new Home();
            h.Show();
        }

        private void OrderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
        }
    }
}
