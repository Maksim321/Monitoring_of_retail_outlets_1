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
            int[,] products = get_index_array();
            Search_Tab_DGV.Rows.Clear();
            if (search_name.Text != "")
                products = search_name_f(products);

            if (search_price.Text != "")
                products = search_price_f(products);

            if (search_number.Text != "")
                products = search_number_f(products);


            for (int i = 0; i < products.GetLength(0); i++)
            {
                Search_Tab_DGV.Rows.Add();
                Search_Tab_DGV.Rows[i].Cells[0].Value = getOutletsInfo.List_Outlets[products[i, 0]].s_nameOutlets;
                Search_Tab_DGV.Rows[i].Cells[1].Value = getOutletsInfo.List_Outlets[products[i, 0]].Return_Product(products[i, 1]).Name;
                Search_Tab_DGV.Rows[i].Cells[2].Value = getOutletsInfo.List_Outlets[products[i, 0]].Return_Product(products[i, 1]).Price;
                Search_Tab_DGV.Rows[i].Cells[3].Value = getOutletsInfo.List_Outlets[products[i, 0]].Return_Product(products[i, 1]).Number;
            }
        }
        private int[,] search_name_f(int[,] products)
        {
            int[,] products_name;
            List<int> List_Index_Outlets = new List<int>();
            List<int> List_Index_Prod = new List<int>();
            for (int j = 0; j < products.GetLength(0); j++)
            {
                if (getOutletsInfo.List_Outlets[products[j, 0]].Return_Product(products[j, 1]).Name == search_name.Text)
                {
                    List_Index_Outlets.Add(products[j, 0]);
                    List_Index_Prod.Add(products[j, 1]);
                }
            }
            products_name = new int[List_Index_Outlets.Count, 2];
            for (int g = 0; g < List_Index_Outlets.Count; g++)
            {
                products_name[g, 0] = List_Index_Outlets[g];
                products_name[g, 1] = List_Index_Prod[g];
            }
            return products_name;
        }
        private int[,] search_price_f(int[,] products)
        {
            int[,] products_price;
            List<int> List_Index_Outlets = new List<int>();
            List<int> List_Index_Prod = new List<int>();
            for (int j = 0; j < products.GetLength(0); j++)
            {
                if (search_price_compare(getOutletsInfo.List_Outlets[products[j, 0]].Return_Product(products[j, 1]).Price, Convert.ToDouble(search_price.Text)))
                {
                    List_Index_Outlets.Add(products[j, 0]);
                    List_Index_Prod.Add(products[j, 1]);
                }
            }
            products_price = new int[List_Index_Outlets.Count, 2];
            for (int g = 0; g < List_Index_Outlets.Count; g++)
            {
                products_price[g, 0] = List_Index_Outlets[g];
                products_price[g, 1] = List_Index_Prod[g];
            }
            return products_price;
        }
        private int[,] search_number_f(int[,] products)
        {
            int[,] products_price;
            List<int> List_Index_Outlets = new List<int>();
            List<int> List_Index_Prod = new List<int>();
            for (int j = 0; j < products.GetLength(0); j++)
            {
                if (search_number_compare(getOutletsInfo.List_Outlets[products[j, 0]].Return_Product(products[j, 1]).Number, Convert.ToInt32(search_number.Text))) 
                {
                    List_Index_Outlets.Add(products[j, 0]);
                    List_Index_Prod.Add(products[j, 1]);
                }
            }
            products_price = new int[List_Index_Outlets.Count, 2];
            for (int g = 0; g < List_Index_Outlets.Count; g++)
            {
                products_price[g, 0] = List_Index_Outlets[g];
                products_price[g, 1] = List_Index_Prod[g];
            }
            return products_price;
        }
        private int[,] get_index_array()
        {
            int[,] indexArray;
            List<int> List_Index_Outlets = new List<int>();
            List<int> List_Index_Prod = new List<int>();
            for (int j = 0; j < getOutletsInfo.List_Outlets.Count; j++)
            {
                for (int i = 0; i < getOutletsInfo.List_Outlets[j].products.Count; i++)
                {
                    List_Index_Outlets.Add(j);
                    List_Index_Prod.Add(i);
                }
            }
            indexArray= new int[List_Index_Outlets.Count, 2];
            for (int g = 0; g < List_Index_Outlets.Count; g++)
            {
                indexArray[g, 0] = List_Index_Outlets[g];
                indexArray[g, 1] = List_Index_Prod[g];
            }
            return indexArray;
        }

        private bool search_price_compare(double x1, double x2)
        {
            string g = comboBox1.Text;
            switch(g)
            {
                case "<":
                    return x1 < x2;
                case ">":
                    return x1 > x2;
                case "=":
                    return x1 == x2;
                case "<=":
                    return x1 <= x2;
                case ">=":
                    return x1 >= x2;
                default:
                    return x1 == x2;
            }
        }
        private bool search_number_compare(int x1, int x2)
        {
            string g = comboBox2.Text;
            switch (g)
            {
                case "<":
                    return x1 < x2;
                case ">":
                    return x1 > x2;
                case "=":
                    return x1 == x2;
                case "<=":
                    return x1 <= x2;
                case ">=":
                    return x1 >= x2;
                default:
                    return x1 == x2;
            }
        }
    }
}
