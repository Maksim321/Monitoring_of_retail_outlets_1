using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
            Add_Outlets_Form a = new Add_Outlets_Form();
            a.Owner = this;
            a.Show();
            a.Select();
        }
        private void Add_Product_Button_Click(object sender, EventArgs e)
        {
            double price;
            int count;
            try
            {
                price = Convert.ToDouble(Product_Price_TB.Text);
            }
            catch (FormatException exception)
            {
                MessageBox.Show("Цена введена некоректно!");
                return;
            }
            try
            {
                count = Convert.ToInt32(Product_Count_TB.Text);
            }
            catch (FormatException exception)
            {
                MessageBox.Show("Количество введено некоректно!");
                return;
            }
            getOutletsInfo.List_Outlets[List_Of_Outlets_LB.SelectedIndex].addProduct(Product_Name_TB.Text, price,
                count, Information_Outlets_DGV.RowCount - 1);
            Update_Information_DGV();
        }
        private void List_Of_Outlets_LB_SelectedIndexChanged(object sender, EventArgs e)
        {
            Update_Information_DGV();
            Name_Label.Text = getOutletsInfo.List_Outlets[List_Of_Outlets_LB.SelectedIndex].s_nameOutlets;
            Manager_Label.Text = "Управляющий: " + getOutletsInfo.List_Outlets[List_Of_Outlets_LB.SelectedIndex].s_nameManager;
            Adress_Label.Text = "Адрес: " + getOutletsInfo.List_Outlets[List_Of_Outlets_LB.SelectedIndex].s_adress;
        }
        private void Update_Information_DGV()
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
        private void Delete_Outlets_Button_Click(object sender, EventArgs e)
        {
            //getOutletsInfo.List_Outlets[List_Of_Outlets_LB.SelectedIndex].Del_product(Information_Outlets_DGV.CurrentRow.Index);
            //Information_Outlets_DGV.Rows.RemoveAt(Information_Outlets_DGV.CurrentRow.Index);
            Search_Product_Form a = new Search_Product_Form();
            a.Owner = this;
            a.Show();
            a.Select();
        }
        private void ReadFile(string path)
        {
            Encoding enc = Encoding.GetEncoding(1251);
            StreamReader streamReader;
            DirectoryInfo dir = new DirectoryInfo(path);
            string s_nameOutlets, s_nameManager, s_adress;
            foreach (var item in dir.GetFiles())
            {
                streamReader = new StreamReader(path + "\\" + item.Name);
                s_nameOutlets = streamReader.ReadLine();
                s_nameManager = streamReader.ReadLine();
                s_adress = streamReader.ReadLine();
                getOutletsInfo.List_Outlets.Add(new COutlets(s_nameOutlets, s_nameManager, s_adress));
                List_Of_Outlets_LB.Items.Add(s_nameOutlets);
                while (true)
                {
                    string[] prod;
                    prod = streamReader.ReadLine().Split(' ');
                    if (prod[0] != "*")
                        getOutletsInfo.List_Outlets[getOutletsInfo.List_Outlets.Count - 1].addProduct(prod[0],
                                                    Convert.ToDouble(prod[1]),
                                                    Convert.ToInt32(prod[2]), Information_Outlets_DGV.RowCount - 1);
                    else
                        break;
                }
                streamReader.Close();            
            }
        }

        private static void saveResult(string path)
        {
            StreamWriter save;
            for (int i = 0; i < getOutletsInfo.List_Outlets.Count; i++)
            {
                save = new StreamWriter(path + "\\" + getOutletsInfo.List_Outlets[i].s_nameOutlets + ".txt");
                save.WriteLine(getOutletsInfo.List_Outlets[i].s_nameOutlets);
                save.WriteLine(getOutletsInfo.List_Outlets[i].s_nameManager);
                save.WriteLine(getOutletsInfo.List_Outlets[i].s_adress);
                for (int j = 0; j < getOutletsInfo.List_Outlets[i].products.Count; j++)
                    save.WriteLine(getOutletsInfo.List_Outlets[i].products[j].Name + " " +
                        Convert.ToString(getOutletsInfo.List_Outlets[i].products[j].Price) + " " +
                        Convert.ToString(getOutletsInfo.List_Outlets[i].products[j].Number));
                save.WriteLine("*");
                save.Close();
            }
        }

        private void Load_Outlets_BT_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            string path = folderBrowserDialog1.SelectedPath;
            ReadFile(path);
        }

        private void Save_Outlets_BT_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            string path = folderBrowserDialog1.SelectedPath;
            saveResult(path);
        }  
    }
}
