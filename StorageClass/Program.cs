using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage_Class
{

    internal class Menu
    {
        static void Main(string[] args)
        {
            Product_Class[] products = new Product_Class[100];

            int proCount = 0;
            string input;
            bool flag = false;
            int id = 1000;
            while (true)
            {
                Product_Class a = new Product_Class();
                Console.WriteLine("Enter a command \nSyntax: \nADD(int,str,int,int) \nSELECT *: ");
                input = Console.ReadLine();
                if (input.Contains("ADD"))
                {
                    flag = a.ADD(input, id);
                    products[proCount] = new Product_Class(a);
                    if (flag == true)
                    {
                        proCount++;
                        id++;

                    }
                }
                if (input.Contains("SELECT *"))
                {
                    for (int i = 0; i < proCount; i++)
                    {
                        Console.WriteLine("------------------\nId: " + Convert.ToString(products[i].id) + "\nStorage Number: " + Convert.ToString(products[i].invenNum) + "\nName: " + products[i].name + "\nPrice: " + Convert.ToString(products[i].price) + "\nAmount: " + Convert.ToString(products[i].amount) + "\n-----------------------------------");

                    }

                }

            }
        }

    }

}
