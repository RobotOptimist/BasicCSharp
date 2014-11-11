using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkDay2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader myReader = new StreamReader("DecodeThis.txt");
            StreamWriter myWriter = new StreamWriter("Decoded.txt");
            string line = "";

            while (line != null)
            {
                line = myReader.ReadLine();
                if (line != null) 
                {
                    line = reverseString(line);
                    Console.WriteLine(line);
                    myWriter.WriteLine(line);
                }
            }
                      
            Console.ReadLine();
            myReader.Dispose();
            myWriter.Dispose();
        }

        private static string reverseString (string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray); 
        }
    
    
    }
}
