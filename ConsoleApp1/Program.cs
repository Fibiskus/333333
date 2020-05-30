using System;

namespace ConsoleApp10
{
    class Program
    {
        public static void Main(String[] args)
        {
            string file = "Hi is , driving a red car";
            string number = file.Split(',')[0].Trim();
            Console.WriteLine(number.Replace("red", "").Replace("  ", " "));
        }
    }
}