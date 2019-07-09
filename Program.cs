using System;
namespace app1
{
    class Program
    {
        static void Main(string[] args)
        {
            string years;

            years = Console.ReadLine(); // input
            int yearsint = int.Parse(years); // string -> integer

            DateTime today = DateTime.Now; // today = today date
            DateTime future = DateTime.Today.AddYears(10); // future = today date + 10
            DateTime futureYear = future.AddYears(yearsint); // futureYear = future + age
            int predict = futureYear.Year - today.Year; // futureYear - today = age + 10
            Console.WriteLine("Your age 10 years from now will be: " + predict);
        }

    }
}
