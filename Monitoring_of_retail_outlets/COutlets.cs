using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monitoring_of_retail_outlets
{
    class COutlets
    {
        public string s_nameOutlets;
        public List<СProduct> products;

        public COutlets()
        {
            products = new List<СProduct>();
        }
        public COutlets(string name)
        {
            s_nameOutlets = name;
            products = new List<СProduct>();
        }

        public void addProduct(string s_nameProd, double d_priceProd, int i_numberProd, int i_indexProd)
        {
           products.Add(new СProduct(s_nameProd, d_priceProd, i_numberProd, i_indexProd));
        }
        public СProduct this[int index]
        {
            get
            {
                foreach (СProduct product in products)
                    if (product.index == index)
                        return product;
                return new СProduct();
            }
        }
        public void Del_product(СProduct del_product)
        {
            products.Remove(del_product);
        }
        public СProduct Return_Product(int index)
        {
            if (index <= products.Count && index >= 0)
            {
                return products[index];
            }
            else return new СProduct();
        }
    }
}
