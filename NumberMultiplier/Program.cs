using System;

namespace NumberMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a list of numbers separated by a comma");
            var v1 = Console.ReadLine();
            Console.WriteLine("Do you want to (1) Multiply these numbers together or (2) Square each number in the list?");
            var v2 = Console.ReadLine();
            var seperatedNumbers = v1.Split(',');

            // User wants numbers multiplied
            if (v2 == "1") {

                var multipliedNumbers = 1;
                foreach (var myNum in seperatedNumbers)
                {
                    multipliedNumbers = multipliedNumbers * int.Parse(myNum);
                }
                Console.WriteLine($"When multiplied, your product is {multipliedNumbers}");
                // User wants each number squared
            } else if (v2 == "2") {
                string squaredNums = "";
                foreach (var myNum in seperatedNumbers)
                {
                    squaredNums += int.Parse(myNum) * int.Parse(myNum);
                    squaredNums += ",";
                }

                squaredNums = squaredNums.TrimEnd(',');
                Console.WriteLine($"Here you go: {squaredNums}");

             // User wants the best of both worlds
            } else if (v2 == "3") {
                var multipliedNumbers = 1;
                foreach (var myNum in seperatedNumbers)
                {
                    multipliedNumbers = multipliedNumbers * int.Parse(myNum);
                }
                multipliedNumbers = multipliedNumbers * multipliedNumbers;
                Console.WriteLine($"Multiplied together and squared: Your product is {multipliedNumbers}");
            }
            // User has chosen a non existant fourth option
            else
            {
                Console.WriteLine($"{v2} was not an option.");
            }


            Console.WriteLine("Press Enter to Exit");
            Console.ReadLine();
        }
    }
}