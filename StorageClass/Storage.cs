using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage_Class
{
    internal class Product_Class
    {
        public int id;
        public int invenNum;
        public bool inStore = false;
        public float price;
        public int amount;
        public string name;

        public Product_Class() { }
        public Product_Class(Product_Class a)
        {
            id = a.id;
            invenNum = a.invenNum;
            inStore = a.inStore;
            price = a.price;
            amount = a.amount;
            name = a.name;
        }
        Product_Class(int invenNu, string nam, float pric, int amoun)
        {
            invenNum = invenNu;
            name = nam;
            price = pric;
            amount = amoun;


        }
        public bool ADD(string inp, int id)
        {
            int switching = 0;
            char letter;
            char[] input = inp.ToCharArray();
            bool flag = false;

            int storNum = 0;
            string name = "";
            int price = 0;
            int amount = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (i <= 3)
                {
                    ///Console.WriteLine("ADD:");

                }
                else if (input[i] >= '0' && input[i] <= '9' && switching == 0)
                {
                    storNum = storNum * 10 + Convert.ToInt32(input[i] - '0');
                    //Console.WriteLine("Switch " + Convert.ToString( switching)+" "+ Convert.ToString(storNum));
                    if (i == 9)
                    {
                        switching++;
                        i++;
                    }

                }
                else if (switching == 1)
                {
                    if (inp[i] == ',')
                    {
                        switching++;
                    }
                    else if ((input[i] >= 'a' && input[i] <= 'z') || (input[i] >= 'A' && input[i] <= 'Z'))
                    {

                        letter = (char)input[i];
                        name = name + letter;
                    }
                    else
                    {
                        switching = 5;
                    }
                    //Console.WriteLine("Switch " + Convert.ToString( switching)+" "+ name);

                }
                else if (switching == 2)
                {
                    if (input[i] == ',')
                    {
                        switching++;

                    }
                    else if (input[i] >= '0' || input[i] <= '9')
                    {
                        price = price * 10 + Convert.ToInt32(input[i] - '0');
                    }
                    else
                    {
                        switching = 5;
                    }
                    //Console.WriteLine("Switch " + Convert.ToString( switching)+" "+ Convert.ToString(price));


                }
                else if (switching == 3)
                {
                    if (input[i] == ')')
                    {
                        flag = true;
                        switching++;
                    }
                    else if (input[i] >= '0' || input[i] <= '9')
                    {
                        amount = amount * 10 + Convert.ToInt32(input[i] - '0');
                    }
                    else
                    {
                        switching = 5;
                    }
                    //Console.WriteLine("Switch " + Convert.ToString( switching)+" "+ Convert.ToString(amount));
                }

                else
                {
                    Console.WriteLine("Input Error, wrong line");
                    return flag;

                }

            }
            if (flag == true)
            {
                this.id = id;
                this.invenNum = storNum;
                this.name = name;
                this.price = price;
                this.amount = amount;



            }
            return flag;

        }
    }
}
