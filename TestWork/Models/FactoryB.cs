using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TestWork.Models
{
    public class FactoryB:AbstractFactory
    {
        public event EventHandler newProductChanged;
        //public IAbstractProduct NewProduct
        //{
        //    get
        //    {
        //        return newProduct;
        //    }
        //}
        public AbstractProductLot CreateProduct(double industrialPower)
        {
            return new ProductLotB(industrialPower);
        }
        public FactoryB(double n)
        {
            this.industrialPower = 1.1 * n;
            Task.Factory.StartNew(() => BeginProductionCycle());

        }

        private void BeginProductionCycle()
        {

            while (true)
            {

                Thread.Sleep(500);//имитация процесса сборки
                this.newProduct = CreateProduct(this.industrialPower);
                this.newProductChanged.Invoke(this, EventArgs.Empty);
            }
        }
        private double industrialPower;

    }
}
