using System;
namespace app1
{
    class Program
    {
        static void Main()
        {
            CheckYears();
            Console.WriteLine("");
            CheckEven();
        }

        static void CheckYears()
        {
            string years;

            Console.Write("Input your age: ");
            years = Console.ReadLine(); // input
            int yearsint = int.Parse(years); // string -> integer

            DateTime today = DateTime.Now; // today = today date
            DateTime future = DateTime.Today.AddYears(10); // future = today date + 10
            DateTime futureYear = future.AddYears(yearsint); // futureYear = future + age
            int predict = futureYear.Year - today.Year; // futureYear - today = age + 10
            Console.WriteLine("Your age 10 years from now will be: " + predict);
            
        }
         static void CheckEven()
        {
            string number;
            int x;
            Console.Write("Input a number to check if it is even: ");
            number = Console.ReadLine();
            x = int.Parse(number) % 2;
            Console.WriteLine(x == 0 ? "The number is even" : "The number is not even");
        }
    }
}
