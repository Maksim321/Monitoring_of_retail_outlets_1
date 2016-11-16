namespace Monitoring_of_retail_outlets
{
    partial class Add_Outlets_Form
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
            this.Outlets_Name_TB = new System.Windows.Forms.TextBox();
            this.Outlets_Adress_TB = new System.Windows.Forms.TextBox();
            this.Outlets_Manager_TB = new System.Windows.Forms.TextBox();
            this.Add_New_Outlets_Button = new System.Windows.Forms.Button();
            this.Outlets_Name_Label = new System.Windows.Forms.Label();
            this.Outlets_Manager_Label = new System.Windows.Forms.Label();
            this.Outlets_Adress_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Outlets_Name_TB
            // 
            this.Outlets_Name_TB.Location = new System.Drawing.Point(130, 13);
            this.Outlets_Name_TB.Name = "Outlets_Name_TB";
            this.Outlets_Name_TB.Size = new System.Drawing.Size(196, 20);
            this.Outlets_Name_TB.TabIndex = 0;
            // 
            // Outlets_Adress_TB
            // 
            this.Outlets_Adress_TB.Location = new System.Drawing.Point(130, 42);
            this.Outlets_Adress_TB.Name = "Outlets_Adress_TB";
            this.Outlets_Adress_TB.Size = new System.Drawing.Size(196, 20);
            this.Outlets_Adress_TB.TabIndex = 1;
            // 
            // Outlets_Manager_TB
            // 
            this.Outlets_Manager_TB.Location = new System.Drawing.Point(130, 68);
            this.Outlets_Manager_TB.Name = "Outlets_Manager_TB";
            this.Outlets_Manager_TB.Size = new System.Drawing.Size(196, 20);
            this.Outlets_Manager_TB.TabIndex = 2;
            // 
            // Add_New_Outlets_Button
            // 
            this.Add_New_Outlets_Button.Location = new System.Drawing.Point(236, 91);
            this.Add_New_Outlets_Button.Name = "Add_New_Outlets_Button";
            this.Add_New_Outlets_Button.Size = new System.Drawing.Size(90, 23);
            this.Add_New_Outlets_Button.TabIndex = 4;
            this.Add_New_Outlets_Button.Text = "Добавить";
            this.Add_New_Outlets_Button.UseVisualStyleBackColor = true;
            this.Add_New_Outlets_Button.Click += new System.EventHandler(this.Add_New_Outlets_Button_Click);
            // 
            // Outlets_Name_Label
            // 
            this.Outlets_Name_Label.AutoSize = true;
            this.Outlets_Name_Label.Location = new System.Drawing.Point(12, 16);
            this.Outlets_Name_Label.Name = "Outlets_Name_Label";
            this.Outlets_Name_Label.Size = new System.Drawing.Size(57, 13);
            this.Outlets_Name_Label.TabIndex = 5;
            this.Outlets_Name_Label.Text = "Название";
            // 
            // Outlets_Manager_Label
            // 
            this.Outlets_Manager_Label.AutoSize = true;
            this.Outlets_Manager_Label.Location = new System.Drawing.Point(12, 42);
            this.Outlets_Manager_Label.Name = "Outlets_Manager_Label";
            this.Outlets_Manager_Label.Size = new System.Drawing.Size(38, 13);
            this.Outlets_Manager_Label.TabIndex = 6;
            this.Outlets_Manager_Label.Text = "Адрес";
            // 
            // Outlets_Adress_Label
            // 
            this.Outlets_Adress_Label.AutoSize = true;
            this.Outlets_Adress_Label.Location = new System.Drawing.Point(9, 68);
            this.Outlets_Adress_Label.Name = "Outlets_Adress_Label";
            this.Outlets_Adress_Label.Size = new System.Drawing.Size(115, 13);
            this.Outlets_Adress_Label.TabIndex = 7;
            this.Outlets_Adress_Label.Text = "ФИО Управляющего";
            // 
            // Add_Outlets_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 127);
            this.Controls.Add(this.Outlets_Adress_Label);
            this.Controls.Add(this.Outlets_Manager_Label);
            this.Controls.Add(this.Outlets_Name_Label);
            this.Controls.Add(this.Add_New_Outlets_Button);
            this.Controls.Add(this.Outlets_Manager_TB);
            this.Controls.Add(this.Outlets_Adress_TB);
            this.Controls.Add(this.Outlets_Name_TB);
            this.Name = "Add_Outlets_Form";
            this.Text = "Add_Outlets_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Outlets_Name_TB;
        private System.Windows.Forms.TextBox Outlets_Adress_TB;
        private System.Windows.Forms.TextBox Outlets_Manager_TB;
        private System.Windows.Forms.Button Add_New_Outlets_Button;
        private System.Windows.Forms.Label Outlets_Name_Label;
        private System.Windows.Forms.Label Outlets_Manager_Label;
        private System.Windows.Forms.Label Outlets_Adress_Label;
    }
}