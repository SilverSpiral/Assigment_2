using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
   public class CarStock
    {
        public string typeName = "CarX";
        public int price = 70000;
        public int totalInStock = 101;


        public void LoginSuccess()
        {
            Console.WriteLine("****** Here are your options ******\nPlease select action" +
                        "\n1. Show stock count\n2. Show total value of all cars in stock\n" +
                        "3. Register one car sold\n4. Get stock status veryLow, Low, Normal, Over");
            Console.WriteLine("___________________________________________________\n");
            WhenChoosing();
        }
        public void WhenChoosing()
        {
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                ShowStockCount();
                Console.WriteLine("___________________________________________________\n\n");
                LoginSuccess();
            }
            else if (choice == "2")
            {
                Console.WriteLine("The total value of all unsold cars is: $" +
                    ShowTotalValue(price, totalInStock));
                Console.WriteLine("___________________________________________________\n\n");
                LoginSuccess();
            }
            else if (choice == "3")
            {
                if (totalInStock != 0)
                {
                    Console.WriteLine("You have just sold one car!");
                    SoldOneCar();
                    Console.WriteLine("___________________________________________________\n\n");
                    LoginSuccess();
                }
                else
                    Console.WriteLine("Good job! All cars have been sold!\n (App will close now)");
            }
            else if (choice == "4")
            {
                StockStatus();
                Console.WriteLine("___________________________________________________\n\n");
                LoginSuccess();
            }
            else
            {
                Console.WriteLine("Does not compute. Please write either 1, 2, 3 or 4.");
                Console.WriteLine("___________________________________________________\n\n");
                LoginSuccess();
            }
        }
        public void ShowStockCount()
        {
            Console.WriteLine("The current number of " + typeName +
                " models left: " + totalInStock);
        }
        public int ShowTotalValue(int price, int totalInStock)
        {
            return price * totalInStock;
        }
        public int SoldOneCar()
        {
            return totalInStock -= 1;
        }
        public void StockStatus()
        {
            if (totalInStock > 100)
            {
                Console.WriteLine("Current status is Over.");
            }
            else if (totalInStock > 25)
            {
                Console.WriteLine("Current status is Normal.");
            }
            else if (totalInStock > 10 && totalInStock <= 25)
            {
                Console.WriteLine("Current status is Low.");
            }
            else if (totalInStock < 10)
            {
                Console.WriteLine("Current status is veryLow.");
            }
        }
    }
}

/*I had a lot of problems figuring out how for-loops and while-loops work without making infinite loops, so I ended up only using if-else statements, 
 * but by doing this it seemed very repetitive and I believe that there gotta be more efficient ways to do this assignment*/

    

