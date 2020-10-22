using CoffeeShop.Business_Logic_Layer;
using CoffeeShop.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop.Presentation_Layer
{
    public partial class MenuForm : Form
    {
        MenuDataAccess mda;
        MenuService ms;
        public MenuForm()
        {
            InitializeComponent();
            mda = new MenuDataAccess();
            ms = new MenuService();
            dataGridView1.DataSource = mda.GetMenuData();
        }

        int id;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id= (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            itemNameTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            quantityComboBox.SelectedItem = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            priceTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(itemNameTextBox.Text))
            {
                if(!string.IsNullOrEmpty(quantityComboBox.SelectedIndex.ToString()))
                {
                    if(!string.IsNullOrEmpty(priceTextBox.Text))
                    {
                        int result = ms.AddMenu(itemNameTextBox.Text, quantityComboBox.SelectedItem.ToString(), priceTextBox.Text);
                        if(result==1)
                        {
                            MessageBox.Show("Item successfully added to menu!");
                            mda = new MenuDataAccess();
                            dataGridView1.DataSource = mda.GetMenuData();
                            itemNameTextBox.Clear();
                            quantityComboBox.SelectedItem = null;
                            priceTextBox.Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please give a price!");
                    }
                }
                else
                {
                    MessageBox.Show("Please select quantity!");
                }
            }
            else
            {
                MessageBox.Show("Please type an item name!");
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            int result = ms.EditMenu(id, itemNameTextBox.Text, quantityComboBox.SelectedItem.ToString(), priceTextBox.Text);
            mda = new MenuDataAccess();
            dataGridView1.DataSource = mda.GetMenuData();
            MessageBox.Show("Item details successfully saved!");
            itemNameTextBox.Clear();
            quantityComboBox.SelectedItem = null;
            priceTextBox.Clear();

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int result = ms.DeleteMenu(Convert.ToInt32(deleteTextBox.Text));
            if(result==1)
            {
                MessageBox.Show("Item is deleted from menu successfully!");
                mda = new MenuDataAccess();
                dataGridView1.DataSource = mda.GetMenuData();
                deleteTextBox.Clear();
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            itemNameTextBox.Clear();
            quantityComboBox.SelectedItem = null;
            priceTextBox.Clear();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home h = new Home();
            h.Show();
        }

        private void MenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
        }
    }
}
