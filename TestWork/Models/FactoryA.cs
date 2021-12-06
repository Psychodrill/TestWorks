using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TestWork.Models
{
    public class FactoryA : AbstractFactory
    {
        public event EventHandler newProductChanged;

        public double  IndustrialPower
        {
            get
            {
                return industrialPower;
            }
        }
        public AbstractProductLot CreateProducts(double industrialPower) 
        {

            return new ProductLotA(industrialPower);
        }
        public FactoryA(double n)
        {
            this.industrialPower = n;
            Task.Factory.StartNew(() => BeginProductionCycle());

        }

        private void BeginProductionCycle()
        {

            while (true)
            {

                Thread.Sleep(500);//имитация процесса сборки
                this.newProduct = CreateProducts(this.industrialPower);
                this.newProductChanged.Invoke(this, EventArgs.Empty);
            }
        }
        //private IAbstractProduct newProduct;

        private double industrialPower; 

    }
}
