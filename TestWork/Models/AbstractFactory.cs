using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TestWork.Models
{
    public abstract class AbstractFactory
    {

        public AbstractProductLot NewProduct
        {
            get
            {
                return newProduct;
            }
        }

        //private void BeginProductionCycle(this.)
        //{

        //    while (true)
        //    {

        //        Thread.Sleep(Convert.ToInt32(n / (3.6)));
        //        this.newProduct = CreateProduct();
        //        this.newProductChanged.Invoke(this, EventArgs.Empty);
        //    }
        //}

        //IAbstractProduct CreateProduct();

        //IAbstractProductB CreateProductB();

        //IAbstractProductC CreateProductC();

        public AbstractProductLot newProduct;
    }
}
