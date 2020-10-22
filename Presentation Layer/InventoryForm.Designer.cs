namespace CoffeeShop.Presentation_Layer
{
    partial class InventoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.iNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.iAmountTextBox = new System.Windows.Forms.TextBox();
            this.newInventoryButton = new System.Windows.Forms.Button();
            this.editInventoryButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dInventoryTextBox = new System.Windows.Forms.TextBox();
            this.deleteInventoryButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.inventoryComboBox = new System.Windows.Forms.ComboBox();
            this.subtractButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(525, 448);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inventory Name:";
            // 
            // iNameTextBox
            // 
            this.iNameTextBox.Location = new System.Drawing.Point(136, 25);
            this.iNameTextBox.Name = "iNameTextBox";
            this.iNameTextBox.Size = new System.Drawing.Size(170, 22);
            this.iNameTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Amount:";
            // 
            // iAmountTextBox
            // 
            this.iAmountTextBox.Location = new System.Drawing.Point(136, 59);
            this.iAmountTextBox.Name = "iAmountTextBox";
            this.iAmountTextBox.Size = new System.Drawing.Size(170, 22);
            this.iAmountTextBox.TabIndex = 4;
            // 
            // newInventoryButton
            // 
            this.newInventoryButton.Location = new System.Drawing.Point(136, 134);
            this.newInventoryButton.Name = "newInventoryButton";
            this.newInventoryButton.Size = new System.Drawing.Size(170, 37);
            this.newInventoryButton.TabIndex = 5;
            this.newInventoryButton.Text = "New Inventory";
            this.newInventoryButton.UseVisualStyleBackColor = true;
            this.newInventoryButton.Click += new System.EventHandler(this.newInventoryButton_Click);
            // 
            // editInventoryButton
            // 
            this.editInventoryButton.Location = new System.Drawing.Point(136, 191);
            this.editInventoryButton.Name = "editInventoryButton";
            this.editInventoryButton.Size = new System.Drawing.Size(170, 37);
            this.editInventoryButton.TabIndex = 6;
            this.editInventoryButton.Text = "Edit Inventory";
            this.editInventoryButton.UseVisualStyleBackColor = true;
            this.editInventoryButton.Click += new System.EventHandler(this.editInventoryButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 499);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Type inventory ID to delete:";
            this.label3.Visible = false;
            // 
            // dInventoryTextBox
            // 
            this.dInventoryTextBox.Location = new System.Drawing.Point(219, 496);
            this.dInventoryTextBox.Name = "dInventoryTextBox";
            this.dInventoryTextBox.Size = new System.Drawing.Size(180, 22);
            this.dInventoryTextBox.TabIndex = 8;
            this.dInventoryTextBox.Visible = false;
            // 
            // deleteInventoryButton
            // 
            this.deleteInventoryButton.Location = new System.Drawing.Point(415, 489);
            this.deleteInventoryButton.Name = "deleteInventoryButton";
            this.deleteInventoryButton.Size = new System.Drawing.Size(132, 37);
            this.deleteInventoryButton.TabIndex = 9;
            this.deleteInventoryButton.Text = "Delete Inventory";
            this.deleteInventoryButton.UseVisualStyleBackColor = true;
            this.deleteInventoryButton.Visible = false;
            this.deleteInventoryButton.Click += new System.EventHandler(this.deleteInventoryButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.priceTextBox);
            this.groupBox1.Controls.Add(this.newInventoryButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.iNameTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.iAmountTextBox);
            this.groupBox1.Controls.Add(this.editInventoryButton);
            this.groupBox1.Location = new System.Drawing.Point(578, 244);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 239);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manage Inventory";
            this.groupBox1.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(86, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Price:";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(136, 95);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(170, 22);
            this.priceTextBox.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.inventoryComboBox);
            this.groupBox2.Controls.Add(this.subtractButton);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.amountTextBox);
            this.groupBox2.Controls.Add(this.addButton);
            this.groupBox2.Location = new System.Drawing.Point(578, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(322, 212);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Amount calculation of Inventory";
            // 
            // inventoryComboBox
            // 
            this.inventoryComboBox.FormattingEnabled = true;
            this.inventoryComboBox.Location = new System.Drawing.Point(136, 25);
            this.inventoryComboBox.Name = "inventoryComboBox";
            this.inventoryComboBox.Size = new System.Drawing.Size(170, 24);
            this.inventoryComboBox.TabIndex = 7;
            // 
            // subtractButton
            // 
            this.subtractButton.Location = new System.Drawing.Point(136, 105);
            this.subtractButton.Name = "subtractButton";
            this.subtractButton.Size = new System.Drawing.Size(170, 37);
            this.subtractButton.TabIndex = 5;
            this.subtractButton.Text = "Subtract";
            this.subtractButton.UseVisualStyleBackColor = true;
            this.subtractButton.Click += new System.EventHandler(this.subtractButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Inventory Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Used Amount:";
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(136, 59);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(170, 22);
            this.amountTextBox.TabIndex = 4;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(136, 162);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(170, 37);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Visible = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(578, 489);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(322, 37);
            this.backButton.TabIndex = 7;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(912, 550);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.deleteInventoryButton);
            this.Controls.Add(this.dInventoryTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Name = "InventoryForm";
            this.Text = "InventoryForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InventoryForm_FormClosing);
            this.Load += new System.EventHandler(this.InventoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox iNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox iAmountTextBox;
        private System.Windows.Forms.Button newInventoryButton;
        private System.Windows.Forms.Button editInventoryButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dInventoryTextBox;
        private System.Windows.Forms.Button deleteInventoryButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox inventoryComboBox;
        private System.Windows.Forms.Button subtractButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox priceTextBox;
    }
}