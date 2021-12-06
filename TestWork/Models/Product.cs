using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWork.Models
{
    public abstract class Product
    {

        public string Name
        {
            get
            {
                return (this.ToString()).Substring(16);
            }
        }
    }
}
