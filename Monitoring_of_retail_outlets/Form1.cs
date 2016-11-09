using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monitoring_of_retail_outlets
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Add_Outlets_Button_Click(object sender, EventArgs e)
        {
            getOutletsInfo.List_Outlets.Add(new COutlets(Outlets_Name_TB.Text));
            List_Of_Outlets_LB.Items.Add(Outlets_Name_TB.Text);
        }
        private void Config_Outlets_Button_Click(object sender, EventArgs e)
        {
            Add_Outlets_Form a = new Add_Outlets_Form();
            a.Owner = this;
            a.Show();
            a.Select();
        }

        private void Add_Product_Button_Click(object sender, EventArgs e)
        {
            getOutletsInfo.List_Outlets[List_Of_Outlets_LB.SelectedIndex].addProduct(Product_Name_TB.Text, Convert.ToDouble(Product_Price_TB.Text),
                Convert.ToInt32(Product_Count_TB.Text), List_Of_Outlets_LB.Items.Count-1);
        }

        private void List_Of_Outlets_LB_SelectedIndexChanged(object sender, EventArgs e)
        {
            Information_Outlets_DGV.Rows.Clear();
            for (int i = 0; i < getOutletsInfo.List_Outlets[List_Of_Outlets_LB.SelectedIndex].products.Count; i++)
            {
                Information_Outlets_DGV.Rows.Add();
                Information_Outlets_DGV.Rows[i].Cells[0].Value = getOutletsInfo.List_Outlets[List_Of_Outlets_LB.SelectedIndex].Return_Product(i).Name;
                Information_Outlets_DGV.Rows[i].Cells[1].Value = getOutletsInfo.List_Outlets[List_Of_Outlets_LB.SelectedIndex].Return_Product(i).Price;
                Information_Outlets_DGV.Rows[i].Cells[2].Value = getOutletsInfo.List_Outlets[List_Of_Outlets_LB.SelectedIndex].Return_Product(i).Number;
            }
        }
    }
}
