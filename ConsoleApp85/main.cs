using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshFactory

{
    internal partial class main
    {
        static void Main(string[] args)
        {
            int key;
            do
            {
                Console.WriteLine(@"
Welcome to Fresh-Factory:
**************************************************************************************
#)Enter 1 to create new Item and add it to the storage.

#)Enter 2 to Sell a product/Products. 

#)Enter 3 to check items count in storage.

#)Enter 4 to Check Product with max Value.

#)Enter 5 to Check Product with min Value.

#)Enter 6 to create new Item and add it to the storage. 

#)Enter 7 to Check Factory Revenue/company NetWorth/sales Income expenses. 

#)Enter 0 to Exit Program. 
**************************************************************************************
");
                 key = int.Parse(Console.ReadLine());

                switch (key)
                {
                    case 0:
                        Console.WriteLine("Thanks for using our program have a nice day!");
                        break;
                    case 1:
                        Console.WriteLine("create new Item and add it to the storage :");
                        break;

                    case 2:
                        Console.WriteLine("Sell existing Item :");
                        break;

                    case 3:
                        Console.WriteLine("items count check :");
                        break;

                    case 4:
                        Console.WriteLine("item with the max value:");
                        break;

                    case 5:
                        Console.WriteLine("item with the min value :");
                        break;

                    case 6:
                        Console.WriteLine("money in store :");
                        break;

                    case 7:
                        Console.WriteLine("");
                        break;
                    default:
                        Console.WriteLine("Error ,NonValid input ,try again!");
                        break;
                }

            }while (key!=0);

        }
    }
}
