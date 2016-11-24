namespace Monitoring_of_retail_outlets
{
    partial class Search_Product_Form
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
            this.Search_Tab_DGV = new System.Windows.Forms.DataGridView();
            this.search_name = new System.Windows.Forms.TextBox();
            this.search_price = new System.Windows.Forms.TextBox();
            this.search_number = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Search_Button = new System.Windows.Forms.Button();
            this.outlets_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Search_Tab_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // Search_Tab_DGV
            // 
            this.Search_Tab_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Search_Tab_DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.outlets_name,
            this.prod_name,
            this.price,
            this.number});
            this.Search_Tab_DGV.Location = new System.Drawing.Point(12, 119);
            this.Search_Tab_DGV.Name = "Search_Tab_DGV";
            this.Search_Tab_DGV.Size = new System.Drawing.Size(460, 230);
            this.Search_Tab_DGV.TabIndex = 0;
            // 
            // search_name
            // 
            this.search_name.Location = new System.Drawing.Point(123, 38);
            this.search_name.Name = "search_name";
            this.search_name.Size = new System.Drawing.Size(131, 20);
            this.search_name.TabIndex = 1;
            // 
            // search_price
            // 
            this.search_price.Location = new System.Drawing.Point(123, 64);
            this.search_price.Name = "search_price";
            this.search_price.Size = new System.Drawing.Size(131, 20);
            this.search_price.TabIndex = 2;
            // 
            // search_number
            // 
            this.search_number.Location = new System.Drawing.Point(123, 90);
            this.search_number.Name = "search_number";
            this.search_number.Size = new System.Drawing.Size(131, 20);
            this.search_number.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "=",
            "<",
            ">",
            ">=",
            "<="});
            this.comboBox1.Location = new System.Drawing.Point(261, 64);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(60, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "=",
            "<",
            ">",
            ">=",
            "<="});
            this.comboBox2.Location = new System.Drawing.Point(261, 90);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(60, 21);
            this.comboBox2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Название товара";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Цена товара";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Количество товара";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.Location = new System.Drawing.Point(44, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Критерии поиска";
            // 
            // Search_Button
            // 
            this.Search_Button.Location = new System.Drawing.Point(341, 71);
            this.Search_Button.Name = "Search_Button";
            this.Search_Button.Size = new System.Drawing.Size(131, 39);
            this.Search_Button.TabIndex = 10;
            this.Search_Button.Text = "Search_Button";
            this.Search_Button.UseVisualStyleBackColor = true;
            this.Search_Button.Click += new System.EventHandler(this.Search_Button_Click);
            // 
            // outlets_name
            // 
            this.outlets_name.HeaderText = "Магазин";
            this.outlets_name.Name = "outlets_name";
            this.outlets_name.ReadOnly = true;
            // 
            // prod_name
            // 
            this.prod_name.HeaderText = "Название";
            this.prod_name.Name = "prod_name";
            this.prod_name.ReadOnly = true;
            // 
            // price
            // 
            this.price.HeaderText = "Цена";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // number
            // 
            this.number.HeaderText = "Количество";
            this.number.Name = "number";
            this.number.ReadOnly = true;
            // 
            // Search_Product_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.Search_Button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.search_number);
            this.Controls.Add(this.search_price);
            this.Controls.Add(this.search_name);
            this.Controls.Add(this.Search_Tab_DGV);
            this.Name = "Search_Product_Form";
            this.Text = "Search_Product_Form";
            ((System.ComponentModel.ISupportInitialize)(this.Search_Tab_DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Search_Tab_DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn outlets_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.TextBox search_name;
        private System.Windows.Forms.TextBox search_price;
        private System.Windows.Forms.TextBox search_number;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Search_Button;
    }
}