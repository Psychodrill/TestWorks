using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWork.Models
{
    public class TruckTwo
    {
        public List<Product> ForStatisticList
        {
            get
            {
                return this.forStatisticList;
            }
        }

        internal void Delivering(List<Product> productList)
        {
            this.forStatisticList.AddRange(productList);
            Task.Delay(500);//имитация процесса доставки
        }

        private List<Product> forStatisticList = new List<Product>();
    }
}
