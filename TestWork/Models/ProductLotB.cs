using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWork.Models
{
    public class ProductLotB : AbstractProductLot
    {
        //private double industrialPower;

        public ProductLotB(double count) : base(count)
        {
            {
                for (int i = 0; i < count; i++)
                {
                    this.productList.Add(new ProductB());
                }
            }
        }
    }
}
