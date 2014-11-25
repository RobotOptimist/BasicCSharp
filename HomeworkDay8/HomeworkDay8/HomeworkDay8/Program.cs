using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkDay8
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection fconnect = new SqlConnection("Data Source = .\\SQLEXPRESS;Attachdbfilename=|DataDirectory|\\FifthColumn.mdf;Integrated Security = True;User Instance = True;");

            fconnect.Open();

            menuList();

            fconnect.Close();

            
        }

        private static void menuList()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1. Report Incidents By Country");
            Console.WriteLine("2. Report New Incident");
            Console.WriteLine("3. Exit");
            string userChoice = Console.ReadLine();
            int choice;
            Int32.TryParse(userChoice, out choice);

            switch (choice)
            {
                case 1:
                    Console.WriteLine("1");
                    break;
                case 2:
                    Console.WriteLine("2");
                    break;
                case 3:
                    Console.WriteLine("3");
                    break;
                default:
                    break;
            }
                
        }
    }
}
