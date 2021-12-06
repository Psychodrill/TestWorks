using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestWork.Models;

namespace TestWork
{
    public partial class ProductAccountingForm : System.Windows.Forms.Form
    {
        public double n;
        public double m;
        public TruckOne truckOne = new TruckOne();
        public TruckTwo truckTwo= new TruckTwo();
        private FactoryA factoryA;
        private FactoryB factoryB;
        private FactoryC factoryC;
        private GeneralStore generalStore;
        private List<AbstractProductLot> productLotList= new List<AbstractProductLot>();

        public ProductAccountingForm()
        {
            InitializeComponent();

            this.Load += ProductAccountingForm_Load;
            this.beginButton.Click += BeginButton_Click;
            this.refreshButton.Click += RefreshButton_Click;
            this.capacityTextBox.TextChanged += CapacityTextBox_TextChanged;
            this.multiplterTextBox.TextChanged += MultiplterTextBox_TextChanged;
            this.productBindingSource.DataSource = this.productLotList;

        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            //int productaCount = this.truckOne.ForStatisticList.cou
            List<Product> productAOneTruckList = this.truckOne.ForStatisticList.Where(x => x?.Name == "ProductA").ToList();
            List<Product> productBOneTruckList = this.truckOne.ForStatisticList.Where(x => x?.Name == "ProductB").ToList();
            List<Product> productCOneTruckList = this.truckOne.ForStatisticList.Where(x => x?.Name == "ProductC").ToList();
            List<Product> productATwoTruckList = this.truckTwo.ForStatisticList.Where(x => x?.Name == "ProductA").ToList();
            List<Product> productBTwoTruckList = this.truckTwo.ForStatisticList.Where(x => x?.Name == "ProductB").ToList();
            List<Product> productCTwoTruckList = this.truckTwo.ForStatisticList.Where(x => x?.Name == "ProductC").ToList();

            this.productAOneLabel.Text = productAOneTruckList.Count.ToString();
            this.productBOneLabel.Text = productBOneTruckList.Count.ToString();
            this.productCOneLabel.Text = productCOneTruckList.Count.ToString();
            this.productATwoLabel.Text = productATwoTruckList.Count.ToString();
            this.productBTwoLabel.Text = productBTwoTruckList.Count.ToString();
            this.productCTwoLabel.Text = productCTwoTruckList.Count.ToString();
        }

        private void MultiplterTextBox_TextChanged(object sender, EventArgs e)
        {
            this.m = Convert.ToDouble(this.multiplterTextBox.Text);
        }

        private void CapacityTextBox_TextChanged(object sender, EventArgs e)
        {
            this.n = Convert.ToDouble(this.capacityTextBox.Text);
        }

        private void BeginButton_Click(object sender, EventArgs e)
        {
            this.generalStore = new GeneralStore(this.m*3.3*n);
            generalStore.truckInvoke += GeneralStore_truckInvoke;
            generalStore.storeChanged += GeneralStore_storeChanged;

            this.factoryA =new FactoryA(n);
            factoryA.newProductChanged += FactoryA_newProductChanged;

            this.factoryB = new FactoryB(n);
            factoryB.newProductChanged += FactoryB_newProductChanged;

            this.factoryC = new FactoryC(n);
            factoryC.newProductChanged += FactoryC_newProductChanged;
        }

        private  void GeneralStore_storeChanged(AbstractProductLot productLot)
        {
            this.productLotList.Add(productLot);

                
            this.Invoke((Action)delegate
            {
                this.productBindingSource.CurrencyManager.Refresh();
                this.productBindingSource.ResetCurrentItem();
                this.productBindingSource.Position = this.productLotList.LastIndexOf(productLot);

            });
        }


        private void FactoryC_newProductChanged(object sender, EventArgs e)
        {
            this.generalStore.AddProducts(this.factoryC.NewProduct);
        }

        private void FactoryB_newProductChanged(object sender, EventArgs e)
        {
            this.generalStore.AddProducts(this.factoryB.NewProduct);
        }

        private void FactoryA_newProductChanged(object sender, EventArgs e)
        {
            this.generalStore.AddProducts(this.factoryA.NewProduct);
        }
        private void GeneralStore_truckInvoke(AbstractProductLot product)
        {

            while (this.generalStore.ProductList.Count > this.generalStore.Capacity * 0.1)
            {
                Task.Factory.StartNew(() => BeginDeliveryCycle());

            }

        }

        private void BeginDeliveryCycle()
        {
            if (this.generalStore.ProductList.Count > 300)
            {
                List<Product> loadingProducts = this.generalStore.ProductList.GetRange(0, 300);
                this.truckOne.Delivering(loadingProducts);
                //new TruckOne(loadingProducts);
                this.generalStore.RemoveProducts(300);


            }

            if (this.generalStore.ProductList.Count > 800)
            {
                List<Product> loadingProducts = this.generalStore.ProductList.GetRange(0, 800);
                this.truckTwo.Delivering(loadingProducts);
                this.generalStore.RemoveProducts(800);


            }

        }



        private void ProductAccountingForm_Load(object sender, EventArgs e)
        {

        }
    }
}
