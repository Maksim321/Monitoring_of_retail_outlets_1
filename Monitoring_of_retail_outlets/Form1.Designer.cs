namespace Monitoring_of_retail_outlets
{
    partial class Form1
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
            this.List_Of_Outlets_LB = new System.Windows.Forms.ListBox();
            this.Delete_Outlets_Button = new System.Windows.Forms.Button();
            this.Information_Outlets_DGV = new System.Windows.Forms.DataGridView();
            this.Product_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price_Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number_Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Add_Outlets_Button = new System.Windows.Forms.Button();
            this.Product_Name_TB = new System.Windows.Forms.TextBox();
            this.Product_Price_TB = new System.Windows.Forms.TextBox();
            this.Product_Count_TB = new System.Windows.Forms.TextBox();
            this.Add_Product_Button = new System.Windows.Forms.Button();
            this.Enter_Prod_Name_Label = new System.Windows.Forms.Label();
            this.Enter_Prod_Price_Label = new System.Windows.Forms.Label();
            this.Enter_Prod_Count_Label = new System.Windows.Forms.Label();
            this.Name_Label = new System.Windows.Forms.Label();
            this.Adress_Label = new System.Windows.Forms.Label();
            this.Manager_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Information_Outlets_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // List_Of_Outlets_LB
            // 
            this.List_Of_Outlets_LB.FormattingEnabled = true;
            this.List_Of_Outlets_LB.Location = new System.Drawing.Point(13, 13);
            this.List_Of_Outlets_LB.Name = "List_Of_Outlets_LB";
            this.List_Of_Outlets_LB.Size = new System.Drawing.Size(126, 290);
            this.List_Of_Outlets_LB.TabIndex = 0;
            this.List_Of_Outlets_LB.SelectedIndexChanged += new System.EventHandler(this.List_Of_Outlets_LB_SelectedIndexChanged);
            // 
            // Delete_Outlets_Button
            // 
            this.Delete_Outlets_Button.Location = new System.Drawing.Point(465, 307);
            this.Delete_Outlets_Button.Name = "Delete_Outlets_Button";
            this.Delete_Outlets_Button.Size = new System.Drawing.Size(94, 23);
            this.Delete_Outlets_Button.TabIndex = 1;
            this.Delete_Outlets_Button.Text = "Удалить";
            this.Delete_Outlets_Button.UseVisualStyleBackColor = true;
            this.Delete_Outlets_Button.Click += new System.EventHandler(this.Delete_Outlets_Button_Click);
            // 
            // Information_Outlets_DGV
            // 
            this.Information_Outlets_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Information_Outlets_DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product_Name,
            this.Price_Product,
            this.Number_Product});
            this.Information_Outlets_DGV.Location = new System.Drawing.Point(145, 45);
            this.Information_Outlets_DGV.Name = "Information_Outlets_DGV";
            this.Information_Outlets_DGV.Size = new System.Drawing.Size(414, 258);
            this.Information_Outlets_DGV.TabIndex = 2;
            // 
            // Product_Name
            // 
            this.Product_Name.HeaderText = "Товар";
            this.Product_Name.Name = "Product_Name";
            this.Product_Name.ReadOnly = true;
            this.Product_Name.Width = 120;
            // 
            // Price_Product
            // 
            this.Price_Product.HeaderText = "Ціна";
            this.Price_Product.Name = "Price_Product";
            this.Price_Product.ReadOnly = true;
            this.Price_Product.Width = 120;
            // 
            // Number_Product
            // 
            this.Number_Product.HeaderText = "Кількість";
            this.Number_Product.Name = "Number_Product";
            this.Number_Product.ReadOnly = true;
            this.Number_Product.Width = 120;
            // 
            // Add_Outlets_Button
            // 
            this.Add_Outlets_Button.Location = new System.Drawing.Point(12, 310);
            this.Add_Outlets_Button.Name = "Add_Outlets_Button";
            this.Add_Outlets_Button.Size = new System.Drawing.Size(127, 23);
            this.Add_Outlets_Button.TabIndex = 4;
            this.Add_Outlets_Button.Text = "Добавить магазин";
            this.Add_Outlets_Button.UseVisualStyleBackColor = true;
            this.Add_Outlets_Button.Click += new System.EventHandler(this.Add_Outlets_Button_Click);
            // 
            // Product_Name_TB
            // 
            this.Product_Name_TB.Location = new System.Drawing.Point(638, 159);
            this.Product_Name_TB.Name = "Product_Name_TB";
            this.Product_Name_TB.Size = new System.Drawing.Size(184, 20);
            this.Product_Name_TB.TabIndex = 5;
            // 
            // Product_Price_TB
            // 
            this.Product_Price_TB.Location = new System.Drawing.Point(638, 184);
            this.Product_Price_TB.Name = "Product_Price_TB";
            this.Product_Price_TB.Size = new System.Drawing.Size(184, 20);
            this.Product_Price_TB.TabIndex = 6;
            // 
            // Product_Count_TB
            // 
            this.Product_Count_TB.Location = new System.Drawing.Point(638, 210);
            this.Product_Count_TB.Name = "Product_Count_TB";
            this.Product_Count_TB.Size = new System.Drawing.Size(184, 20);
            this.Product_Count_TB.TabIndex = 7;
            // 
            // Add_Product_Button
            // 
            this.Add_Product_Button.Location = new System.Drawing.Point(702, 236);
            this.Add_Product_Button.Name = "Add_Product_Button";
            this.Add_Product_Button.Size = new System.Drawing.Size(120, 23);
            this.Add_Product_Button.TabIndex = 8;
            this.Add_Product_Button.Text = "Добавить";
            this.Add_Product_Button.UseVisualStyleBackColor = true;
            this.Add_Product_Button.Click += new System.EventHandler(this.Add_Product_Button_Click);
            // 
            // Enter_Prod_Name_Label
            // 
            this.Enter_Prod_Name_Label.AutoSize = true;
            this.Enter_Prod_Name_Label.Location = new System.Drawing.Point(565, 166);
            this.Enter_Prod_Name_Label.Name = "Enter_Prod_Name_Label";
            this.Enter_Prod_Name_Label.Size = new System.Drawing.Size(38, 13);
            this.Enter_Prod_Name_Label.TabIndex = 9;
            this.Enter_Prod_Name_Label.Text = "Товар";
            // 
            // Enter_Prod_Price_Label
            // 
            this.Enter_Prod_Price_Label.AutoSize = true;
            this.Enter_Prod_Price_Label.Location = new System.Drawing.Point(565, 192);
            this.Enter_Prod_Price_Label.Name = "Enter_Prod_Price_Label";
            this.Enter_Prod_Price_Label.Size = new System.Drawing.Size(33, 13);
            this.Enter_Prod_Price_Label.TabIndex = 10;
            this.Enter_Prod_Price_Label.Text = "Цена";
            // 
            // Enter_Prod_Count_Label
            // 
            this.Enter_Prod_Count_Label.AutoSize = true;
            this.Enter_Prod_Count_Label.Location = new System.Drawing.Point(566, 217);
            this.Enter_Prod_Count_Label.Name = "Enter_Prod_Count_Label";
            this.Enter_Prod_Count_Label.Size = new System.Drawing.Size(66, 13);
            this.Enter_Prod_Count_Label.TabIndex = 11;
            this.Enter_Prod_Count_Label.Text = "Количество";
            // 
            // Name_Label
            // 
            this.Name_Label.AutoSize = true;
            this.Name_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.Name_Label.Location = new System.Drawing.Point(145, 13);
            this.Name_Label.Name = "Name_Label";
            this.Name_Label.Size = new System.Drawing.Size(0, 29);
            this.Name_Label.TabIndex = 12;
            // 
            // Adress_Label
            // 
            this.Adress_Label.AutoSize = true;
            this.Adress_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Adress_Label.Location = new System.Drawing.Point(566, 63);
            this.Adress_Label.Name = "Adress_Label";
            this.Adress_Label.Size = new System.Drawing.Size(54, 18);
            this.Adress_Label.TabIndex = 13;
            this.Adress_Label.Text = "Адрес:";
            // 
            // Manager_Label
            // 
            this.Manager_Label.AutoSize = true;
            this.Manager_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Manager_Label.Location = new System.Drawing.Point(566, 45);
            this.Manager_Label.Name = "Manager_Label";
            this.Manager_Label.Size = new System.Drawing.Size(109, 18);
            this.Manager_Label.TabIndex = 14;
            this.Manager_Label.Text = "Управляющий:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 342);
            this.Controls.Add(this.Manager_Label);
            this.Controls.Add(this.Adress_Label);
            this.Controls.Add(this.Name_Label);
            this.Controls.Add(this.Enter_Prod_Count_Label);
            this.Controls.Add(this.Enter_Prod_Price_Label);
            this.Controls.Add(this.Enter_Prod_Name_Label);
            this.Controls.Add(this.Add_Product_Button);
            this.Controls.Add(this.Product_Count_TB);
            this.Controls.Add(this.Product_Price_TB);
            this.Controls.Add(this.Product_Name_TB);
            this.Controls.Add(this.Add_Outlets_Button);
            this.Controls.Add(this.Information_Outlets_DGV);
            this.Controls.Add(this.Delete_Outlets_Button);
            this.Controls.Add(this.List_Of_Outlets_LB);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Information_Outlets_DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox List_Of_Outlets_LB;
        private System.Windows.Forms.Button Delete_Outlets_Button;
        private System.Windows.Forms.DataGridView Information_Outlets_DGV;
        private System.Windows.Forms.Button Add_Outlets_Button;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price_Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number_Product;
        private System.Windows.Forms.TextBox Product_Name_TB;
        private System.Windows.Forms.TextBox Product_Price_TB;
        private System.Windows.Forms.TextBox Product_Count_TB;
        private System.Windows.Forms.Button Add_Product_Button;
        private System.Windows.Forms.Label Enter_Prod_Name_Label;
        private System.Windows.Forms.Label Enter_Prod_Price_Label;
        private System.Windows.Forms.Label Enter_Prod_Count_Label;
        public System.Windows.Forms.Label Name_Label;
        public System.Windows.Forms.Label Adress_Label;
        public System.Windows.Forms.Label Manager_Label;
    }
}

