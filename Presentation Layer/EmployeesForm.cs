using CoffeeShop.Business_Logic_Layer;
using CoffeeShop.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop.Presentation_Layer
{
    public partial class EmployeesForm : Form
    {
        EmployeeDataAccess eda;
        EmployeeService es;
        public EmployeesForm()
        {
            InitializeComponent();
            eda = new EmployeeDataAccess();
            es = new EmployeeService();
            dataGridView1.DataSource = eda.GetEmployeeData();
        }

        private void EmployeesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            es = new EmployeeService();
            int result = es.EditEmployee(id, nameTextBox.Text, dobTextBox.Text, addressTextBox.Text, phoneTextBox.Text, bgComboBox.SelectedItem.ToString(), passwordTextBox.Text);
            eda = new EmployeeDataAccess();
            dataGridView1.DataSource = eda.GetEmployeeData();
            MessageBox.Show("Information saved!");
            nameTextBox.Clear();
            dobTextBox.Clear();
            addressTextBox.Clear();
            phoneTextBox.Clear();
            bgComboBox.SelectedItem = null;
            passwordTextBox.Clear();
            pictureBox1.Image = null;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            es = new EmployeeService();
            int result = es.DeleteEmployee(Convert.ToInt32(deleteTextBox.Text));
            if (result == 1)
            {
                MessageBox.Show("Employee information deleted from menu successfully!");
                eda = new EmployeeDataAccess();
                dataGridView1.DataSource = eda.GetEmployeeData();
                deleteTextBox.Clear();
            }
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(nameTextBox.Text))
            {
                pictureBox1.Image = new Bitmap(ofd.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                string path = Application.StartupPath + "\\EmployeePictures\\" + nameTextBox.Text + ".jpg";
                File.Copy(ofd.FileName, path, true);
            }
            else
            {
                MessageBox.Show("Please first enter your name!");
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home h = new Home();
            h.Show();
        }

        int id;
        string designation;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            nameTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            passwordTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            dobTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            addressTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            phoneTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            bgComboBox.SelectedItem = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            designation = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            string path = Application.StartupPath + "\\EmployeePictures\\" + nameTextBox.Text + ".jpg";
            if (File.Exists(path))
            {
                pictureBox1.Image = Image.FromFile(path);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                pictureBox1.Image = null;
            }
        }

        private void EmployeesForm_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
            label6.BackColor = Color.Transparent;
            label7.BackColor = Color.Transparent;
            groupBox1.BackColor = Color.Transparent;
            groupBox2.BackColor = Color.Transparent;
        }
    }
}
