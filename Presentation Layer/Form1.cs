using CoffeeShop.Data_Access_Layer;
using CoffeeShop.Presentation_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["CoffeeShop"].ConnectionString);
            GlobalVriables.id = userIdTextBox.Text;
            string sql = "SELECT * FROM Employees WHERE EId='" + GlobalVriables.id + "' AND Password='" + passwordTextBox.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                this.Hide();
                Home h = new Home();
                h.Show();
            }
            else
            {
                MessageBox.Show("Wrong ID or, Password!");
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            EmployeeForm ef = new EmployeeForm();
            this.Hide();
            ef.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
        }
    }
}
