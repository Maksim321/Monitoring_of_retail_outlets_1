using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monitoring_of_retail_outlets
{
    class СProduct
    {
        private string product_name;
        private double price;
        public int number;
        public int index;

        public СProduct()
        {
            product_name = " ";
            price = 0.0;
            number = 0;
            index = 0;
        }

        public СProduct(string new_product_name, double new_price, int new_number, int new_index)
        {
            product_name = new_product_name;
            price = new_price;
            number = new_number;
            index = new_index;
        }
        public СProduct(СProduct prod_copy)
        {
            product_name = prod_copy.Name;
            price = prod_copy.Price;
            number = prod_copy.number;
            index = prod_copy.Index;
        }
        public string Name
        {
            get { return product_name; }
            set { product_name = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public int Number
        {
            get { return number; }
            set { number = value; }
        }
        public int Index
        {
            get { return index; }
            set { index = value; }
        }
        public virtual СProduct DeepCopy()
        {
            return new СProduct(this);
        }
    }
}
