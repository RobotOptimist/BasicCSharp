using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxManager;

namespace HomeworkDay10
{
    class Program
    {
        static void Main(string[] args)
        {
            Day10Entities1 salesDB = new Day10Entities1();
            Sale sale = new Sale();          

            Console.WriteLine("What is the day of the sale?");
            String day = Console.ReadLine();

            DateTime dayParsed;
            if (DateTime.TryParse(day, out dayParsed))
            {
                sale.SalesDate = dayParsed;
                Console.WriteLine(dayParsed.ToShortDateString());
            }
            else
            {
                Console.WriteLine("Not a Valid Day!");                
            }

            Console.WriteLine("What is the amount of the sale?");
            String amount = Console.ReadLine();

            int amountParsed;
            if (int.TryParse(amount, out amountParsed))
            {
                sale.SalesAmount = amountParsed;
                Console.WriteLine(amountParsed.ToString());
            }
            else
            {
                Console.WriteLine("Not a Valid Amount!");
            }

            double taxAmount = Tax.Analyzer(amountParsed);

            sale.TaxAmount = (decimal)taxAmount;                        

            salesDB.Sales.Add(sale);
            salesDB.SaveChanges();

            var sales = from s in salesDB.Sales
                        select s;

            foreach (var slisted in sales)
            {
                Console.WriteLine("Date of Sale {0:C}; Amount of Sale {1}; Tax of Sale {2:C}", slisted.SalesAmount.ToString(), slisted.SalesDate.ToShortDateString(), slisted.TaxAmount.ToString());                    
            }

            Console.ReadLine(); 
        }
    }
}
