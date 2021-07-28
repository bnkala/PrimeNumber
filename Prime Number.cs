using System;

namespace PrimeNumber
{
    class PrimeNumber
    {
        static string InputNumber()
        {
            Console.Write("Enter a number: ");
            return Console.ReadLine();
        }

        static bool IsInputValid(string input)
        {
            int num = 0;
            if (!int.TryParse(input, out num)){
                Console.WriteLine("Input Invalid! There should only be numbers");
                return false;
            }
            return true;
        }

        static void NumberIsPrimeOrNot(int count, int num)
        {
            if (count == num)
                Console.WriteLine(num + " is a Prime number");
            else 
                Console.WriteLine(num + " is not a Prime number");
        }

        static void Main(string[] args)
        {
            string input;
            do{
                input = InputNumber();
            } while(!IsInputValid(input));

            int num = int.Parse(input);
            int count = 2;

            do {
                count++;
            } while(num % count != 0);
            NumberIsPrimeOrNot(count, num);
        }
    }
}
