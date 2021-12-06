using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TestWork.Models
{
    public  class GeneralStore
    {
        public event TruckInvoke truckInvoke;
        public delegate void TruckInvoke(AbstractProductLot product);
        //public delegate EventArgs Truck (IAbstractProduct product);
        public event StoreChanged storeChanged;
        public delegate void StoreChanged(AbstractProductLot product);


        public List<Product> ProductList
        {
            get
            {
                return productList;
            }
        }

        public double Capacity
        {
            get
            {
                return capacity;
            }
        }

        public GeneralStore(double capacity)
        {
            this.capacity = capacity;
        }

        public void AddProducts(AbstractProductLot productLot)
        {


            generalStore.Add(productLot);
            ProductLotA  pla= productLot as ProductLotA;
            if (pla != null)
            {
                this.productList.AddRange(pla.ProductList);
            }
            
            ProductLotB plb = productLot as ProductLotB;
            if (plb != null)
            {
                this.productList.AddRange(plb.ProductList);
            }
            ProductLotC plc = productLot as ProductLotC;
            if (plc != null)
            {
                this.productList.AddRange(plc.ProductList);
            }
                
            
            //this.productCount += productList.Count;
            storeChanged.Invoke(productLot);
            
            if (this.productList.Count >= this.capacity * 0.95)
            {
                truckInvoke.Invoke(productLot);
                
            }
        }
        

        private double capacity;
        private List<AbstractProductLot> generalStore = new List<AbstractProductLot>();


        internal void RemoveProducts(int productCount)
        {
            if (this.productList.Count > productCount)
            {
                //this.productCount -= productCount;
                this.productList.RemoveRange(0,productCount);
            }
            else
            {
                this.productList.Clear();
            }
        }
        private List<Product> productList= new List<Product>();
    }
}
