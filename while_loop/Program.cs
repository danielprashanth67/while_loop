using System;

namespace while_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            try
            {
                Console.WriteLine("Enter Experience");
                string years = Console.ReadLine();
                int year_of_exp = Int32.Parse(years);
                while(year_of_exp > 0)
                {
                    
                    Console.WriteLine("You have " + year_of_exp.ToString() + " years of Experience");
                    year_of_exp = year_of_exp - 1;
                }

            }
            catch(InvalidCastException)
            {
                Console.WriteLine("Enter Valid Years of Experience");
            }
        }
    }
}
