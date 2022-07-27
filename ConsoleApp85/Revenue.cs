using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshFactory
{
     class Revenue
    {
        private double companyNetWorth;
        private double salesIncome;
        private double expenses;

        public Revenue()
        {
            this.companyNetWorth = 1000000;
        }

        public double CalcSalesIncome()
        {
            //add sold items income
            return salesIncome;
        }
        public double CalcFactoryExpenses()
        {
            //add sold factory expenses
            return expenses;
        }


        public override string ToString()
        {
            return $"Company NetWorth : {this.companyNetWorth}\nsales income :{CalcSalesIncome()}\nExpenses:{CalcFactoryExpenses()}";
        }

    }
}
