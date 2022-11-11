using System;

namespace PrimeNumberNS
{
    public class PrimeNumber
    {
        public string InputNumber()
        {
            Console.WriteLine("Enter number: ");
            return Console.ReadLine();
        }

        public bool IsNumberValid(string input)
        {
            int num = 0;
            if(input =="")
            {
                Console.WriteLine("Number input is empty");
                return false;
            }
            if (input == "1")
            {
                Console.WriteLine("1 is not a valid number for a prime number");
                return false;
            }
            if(input=="0")
            {
                Console.WriteLine("0 is not a valid number for a prime number");
                return false;
            }
            if (!int.TryParse(input, out num))
            {
                Console.WriteLine("Number must be numerical");
                return false;
            }
            
            return true;
        }


        public string PrimeOrNot(string input)
        {
            string prime;
            int num = int.Parse(input);
            int count = 2;

            do
            {
                count++;
            } while (num % count != 0);
            if (count==num)
            {
                prime = num + " is a prime number";

            } else
            {
                prime = num + " is not a prime number";
            }

            return prime;
        }

        public static void Main()
        {
            PrimeNumber prime = new PrimeNumber();
            string input;
            do
            {
                input = prime.InputNumber();
            } while (!prime.IsNumberValid(input));

            Console.WriteLine(prime.PrimeOrNot(input));
        }

    }
}
