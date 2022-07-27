using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshFactory
{
    class Storage
    {
        private string name;
        private const int capastiy = 10000;
        private Product[] products;

        public Storage()
        {
           products = new Product[capastiy];
        }
        public string GetName()
        {
            return name;
        }
        public void SetName(string name)
        {
             this.name=name;
        }
    }
}
