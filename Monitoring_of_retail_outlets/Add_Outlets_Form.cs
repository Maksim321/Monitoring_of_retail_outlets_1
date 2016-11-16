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
    public partial class Add_Outlets_Form : Form
    {
        public Add_Outlets_Form()
        {
            InitializeComponent();
        }

        private void Add_New_Outlets_Button_Click(object sender, EventArgs e)
        {
            Add_Func();
        }

        private void Add_Func()
        {
            if (Outlets_Name_TB.Text == "")
                MessageBox.Show("Не все поля заполнены!");
            else
            {
                getOutletsInfo.List_Outlets.Add(new COutlets(Outlets_Name_TB.Text, Outlets_Manager_TB.Text, Outlets_Adress_TB.Text));
                Return_Form().List_Of_Outlets_LB.Items.Add(Outlets_Name_TB.Text);
               // Return_Form().Name_Label.Text = Outlets_Name_TB.Text;
                //Return_Form().Manager_Label.Text = Outlets_Manager_TB.Text;
                //Return_Form().Adress_Label.Text = Outlets_Adress_TB.Text;
            }
        }

        private Form1 Return_Form()
        {
            Form1 main = this.Owner as Form1;
            return main;
        }
    }
}
