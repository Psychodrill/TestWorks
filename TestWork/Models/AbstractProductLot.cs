using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWork.Models
{
    public abstract class AbstractProductLot
    {
        public List<Product> ProductList
        {
            get
            {
                return productList;
            }
        }

        public AbstractProductLot(double count)
        {
            this.count = count;
        }
        public string Name
        {
            get
            {
                return (this.ToString()).Substring(16);
            }
        }

        public string Factory
        {
            get
            {
                return (this.ToString()).Substring(26);
            }
        }

        public double Count
        {
            get
            {
                //count =
                return count;
            }
        }
        public List<Product> productList = new List<Product>();
        private double count;
    }
}
