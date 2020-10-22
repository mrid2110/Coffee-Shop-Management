using CoffeeShop.Business_Logic_Layer;
using CoffeeShop.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop.Presentation_Layer
{
    public partial class EmployeeForm : Form
    {
        EmployeeService es;
        DataAccess da;
        public EmployeeForm()
        {
            InitializeComponent();
            es = new EmployeeService();
            da = new DataAccess();
        }

        private void Employee_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void addPhoroButton_Click(object sender, EventArgs e)
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

        private void submitButton_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(nameTextBox.Text))
            {
                if(!string.IsNullOrEmpty(passwordTextBox.Text))
                {
                    if (dateTimePicker1.Value.Date != DateTime.Now.Date)
                    {
                        if (!string.IsNullOrEmpty(addressTextBox.Text))
                        {
                            if (!string.IsNullOrEmpty(phoneTextBox.Text))
                            {
                                if (!bgComboBox.SelectedItem.Equals(null))
                                {
                                    if (checkBox1.Checked)
                                    {
                                        if (pictureBox1.Image != null)
                                        {
                                            if (designationComboBox.SelectedItem.Equals("Admin"))
                                            {
                                                if (referenceTextBox.Text == "12345")
                                                {
                                                    int result = es.AddEmployee(nameTextBox.Text, passwordTextBox.Text, dateTimePicker1.Value.Date.ToString(), addressTextBox.Text, phoneTextBox.Text, bgComboBox.SelectedItem.ToString(), designationComboBox.SelectedItem.ToString());
                                                    if (result == 1)
                                                    {
                                                        string sql = "SELECT EId FROM Employees WHERE EName='" + nameTextBox.Text + "' AND DOB='" + dateTimePicker1.Value.Date.ToString() + "' AND Address='" + addressTextBox.Text + "' AND Phone='" + phoneTextBox.Text + "' AND BloodGroup='" + bgComboBox.SelectedItem.ToString() + "' AND Designation='" + designationComboBox.SelectedItem.ToString() + "'";
                                                        SqlDataReader reader = da.GetData(sql);
                                                        Employee em = new Employee();
                                                        while (reader.Read())
                                                        {
                                                            em.EId = (int)reader["EId"];
                                                        }
                                                        MessageBox.Show("Succeesfully registered!\nYour ID: "+em.EId);
                                                        //nda = new NotesDataAccess();
                                                        //dataGridView.DataSource = nda.GetNotes();
                                                        this.Hide();
                                                        Form1 f1 = new Form1();
                                                        f1.Show();
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Wrong reference!");
                                                }
                                            }
                                            else
                                            {
                                                int result = es.AddEmployee(nameTextBox.Text, passwordTextBox.Text, dateTimePicker1.Value.Date.ToString(), addressTextBox.Text, phoneTextBox.Text, bgComboBox.SelectedItem.ToString(), designationComboBox.SelectedItem.ToString());
                                                if (result == 1)
                                                {
                                                    string sql = "SELECT EId FROM EMPLOYEES WHERE EName='" + nameTextBox.Text + "' AND DOB='" + dateTimePicker1.Value.Date.ToString() + "' AND Address='" + addressTextBox.Text + "' AND Phone='" + phoneTextBox.Text + "'AND BloodGroup='" + bgComboBox.SelectedItem.ToString() + "' AND Designation='" + designationComboBox.SelectedItem.ToString() + "'";
                                                    SqlDataReader reader = da.GetData(sql);
                                                    Employee em = new Employee();
                                                    while (reader.Read())
                                                    {
                                                        em.EId = (int)reader["EId"];
                                                    }
                                                    MessageBox.Show("Succeesfully registered!\nYour ID: " + em.EId);
                                                    //nda = new NotesDataAccess();
                                                    //dataGridView.DataSource = nda.GetNotes();
                                                    this.Hide();
                                                    Form1 f1 = new Form1();
                                                    f1.Show();
                                                }
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Please add your picture!");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Please accept terms and conditions!");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Please your blood group!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Please give your contact number!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please give your address!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please give your date of birth!");
                    }
                }
                else
                {
                    MessageBox.Show("Please give a password!");
                }
            }
            else
            {
                MessageBox.Show("Please give your Full name!");
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void designationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(designationComboBox.SelectedItem.Equals("Admin"))
            {
                label8.Show();
                referenceTextBox.Show();
            }
            else
            {
                label8.Hide();
                referenceTextBox.Hide();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
            label6.BackColor = Color.Transparent;
            label7.BackColor = Color.Transparent;
            label8.BackColor = Color.Transparent;
            label9.BackColor = Color.Transparent;
            checkBox1.BackColor = Color.Transparent;
        }
    }
}
