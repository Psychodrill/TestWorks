using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWork.Models
{
    public class ProductLotA : AbstractProductLot
    {
        //private double industrialPower;
        //public List<ProductA>ProductList
        //{
        //    get
        //    {
        //        return this.productList;
        //    }
        //}
        public ProductLotA(double count) : base(count)
        {
            for(int i=0; i<count; i++)
            {
                this.productList.Add(new ProductA());
            }
        }

        //public double Count
        //{
        //    get
        //    {
        //        return industrialPower;
        //    }
        //} 
        //private List<ProductA> productList= new List<ProductA>();
    }
}
