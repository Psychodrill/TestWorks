using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWork.Models
{
    public class TruckOne
    {
        public List<Product> ForStatisticList
        {
            get
            {
                return this.forStatisticList;
            }
        }

        private List<Product> forStatisticList = new List<Product>();

        internal void Delivering(List<Product> productList)
        {
            this.forStatisticList.AddRange(productList);
            Task.Delay(200);//имитация процесса доставки
        }
    }
}
