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
    public partial class Search_Product_Form : Form
    {
        public Search_Product_Form()
        {
            InitializeComponent();
        }

        private void Search_Button_Click(object sender, EventArgs e)
        {
            search();
        }


        private void search()
        {
            int[,] products = search_name_f();
            Search_Tab_DGV.Rows.Clear();
            for (int i = 0; i < products.GetLength(0); i++)
            {
                Search_Tab_DGV.Rows.Add();
                Search_Tab_DGV.Rows[i].Cells[0].Value = getOutletsInfo.List_Outlets[products[i, 0]].s_nameOutlets;
                Search_Tab_DGV.Rows[i].Cells[1].Value = getOutletsInfo.List_Outlets[products[i, 0]].Return_Product(products[i, 1]).Name;
                Search_Tab_DGV.Rows[i].Cells[2].Value = getOutletsInfo.List_Outlets[products[i, 0]].Return_Product(products[i, 1]).Price;
                Search_Tab_DGV.Rows[i].Cells[3].Value = getOutletsInfo.List_Outlets[products[i, 0]].Return_Product(products[i, 1]).Number;
            }
        }
        private int[,] search_name_f()
        {
            int[,] products;
            List<int> List_Index_Outlets = new List<int>();
            List<int> List_Index_Prod = new List<int>();
            for (int j = 0; j < getOutletsInfo.List_Outlets.Count; j++)
            {
                for (int i = 0; i < getOutletsInfo.List_Outlets[j].products.Count; i++)
                {
                    if (getOutletsInfo.List_Outlets[j].Return_Product(i).Name == search_name.Text)
                    {
                        List_Index_Outlets.Add(j);
                        List_Index_Prod.Add(i);
                    }

                }
            }
            products = new int[List_Index_Outlets.Count, 2];
            for (int g = 0; g < List_Index_Outlets.Count; g++)
            {
                products[g, 0] = List_Index_Outlets[g];
                products[g, 1] = List_Index_Prod[g];
            }
            return products;
        }
    }
}
