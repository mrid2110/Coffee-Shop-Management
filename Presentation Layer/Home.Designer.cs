namespace CoffeeShop.Presentation_Layer
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.orderButton = new System.Windows.Forms.Button();
            this.inventoryButton = new System.Windows.Forms.Button();
            this.employeesButton = new System.Windows.Forms.Button();
            this.menuButton = new System.Windows.Forms.Button();
            this.cancelOrderButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.notificationTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.profitTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Hometown Personal Use", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(675, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Coffee Shop Management System";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 170);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(566, 357);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // orderButton
            // 
            this.orderButton.Location = new System.Drawing.Point(646, 170);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(146, 37);
            this.orderButton.TabIndex = 2;
            this.orderButton.Text = "Place an order";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // inventoryButton
            // 
            this.inventoryButton.Location = new System.Drawing.Point(646, 284);
            this.inventoryButton.Name = "inventoryButton";
            this.inventoryButton.Size = new System.Drawing.Size(146, 37);
            this.inventoryButton.TabIndex = 3;
            this.inventoryButton.Text = "Inventory";
            this.inventoryButton.UseVisualStyleBackColor = true;
            this.inventoryButton.Click += new System.EventHandler(this.inventoryButton_Click);
            // 
            // employeesButton
            // 
            this.employeesButton.Location = new System.Drawing.Point(646, 342);
            this.employeesButton.Name = "employeesButton";
            this.employeesButton.Size = new System.Drawing.Size(146, 37);
            this.employeesButton.TabIndex = 4;
            this.employeesButton.Text = "Employees";
            this.employeesButton.UseVisualStyleBackColor = true;
            this.employeesButton.Visible = false;
            this.employeesButton.Click += new System.EventHandler(this.employeesButton_Click);
            // 
            // menuButton
            // 
            this.menuButton.Location = new System.Drawing.Point(646, 404);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(146, 37);
            this.menuButton.TabIndex = 5;
            this.menuButton.Text = "Menu";
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Visible = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // cancelOrderButton
            // 
            this.cancelOrderButton.Location = new System.Drawing.Point(646, 227);
            this.cancelOrderButton.Name = "cancelOrderButton";
            this.cancelOrderButton.Size = new System.Drawing.Size(146, 37);
            this.cancelOrderButton.TabIndex = 6;
            this.cancelOrderButton.Text = "Cancel";
            this.cancelOrderButton.UseVisualStyleBackColor = true;
            this.cancelOrderButton.Click += new System.EventHandler(this.cancelOrderButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(646, 490);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(146, 37);
            this.logoutButton.TabIndex = 7;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // notificationTextBox
            // 
            this.notificationTextBox.Location = new System.Drawing.Point(31, 112);
            this.notificationTextBox.Multiline = true;
            this.notificationTextBox.Name = "notificationTextBox";
            this.notificationTextBox.ReadOnly = true;
            this.notificationTextBox.Size = new System.Drawing.Size(272, 49);
            this.notificationTextBox.TabIndex = 8;
            this.notificationTextBox.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Notification:";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "This Month Profit:";
            this.label3.Visible = false;
            // 
            // profitTextBox
            // 
            this.profitTextBox.Location = new System.Drawing.Point(325, 112);
            this.profitTextBox.Multiline = true;
            this.profitTextBox.Name = "profitTextBox";
            this.profitTextBox.ReadOnly = true;
            this.profitTextBox.Size = new System.Drawing.Size(272, 49);
            this.profitTextBox.TabIndex = 10;
            this.profitTextBox.Visible = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(830, 548);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.profitTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.notificationTextBox);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.cancelOrderButton);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.employeesButton);
            this.Controls.Add(this.inventoryButton);
            this.Controls.Add(this.orderButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Home";
            this.Text = "Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.Button inventoryButton;
        private System.Windows.Forms.Button employeesButton;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.Button cancelOrderButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.TextBox notificationTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox profitTextBox;
    }
}