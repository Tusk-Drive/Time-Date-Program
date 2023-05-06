using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATE_TIME_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            #this is a comment;
            DateTime today = DateTime.Now;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("DATE-TIME Calculator");
            Console.WriteLine(String.Format("Short date: {0:d}", today));
            Console.WriteLine(String.Format("Long date: {0:D}", today));
            Console.WriteLine(String.Format("Short time: {0:t}", today));
            Console.WriteLine(String.Format("Long time: {0:T}", today));
            Console.WriteLine(String.Format("Month: {0:M}", today));
            Console.WriteLine(String.Format("Year: {0:Y}", today));
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
