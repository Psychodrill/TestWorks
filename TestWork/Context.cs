using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWork
{
    class Context:ApplicationContext
    {

        public Context()
        {
            ProductAccountingForm productAccountingForm = new ProductAccountingForm();
            productAccountingForm.FormClosing += ProductAccountingForm_FormClosing;
            this.MainForm = productAccountingForm;
            this.MainForm.Show();
        }

        private void ProductAccountingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();

        }
    }
}
