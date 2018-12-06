using System;
using System.Collections.Generic;


namespace Prime
{
    public class PrimeNumbers
    {
        public static void Prime(List<int> list)
        {
            List<int> notPrime = new List<int>() {};

            for (int i = list.Count - 1; i > 0; i--)
            {
                if (i % 2 != 0 || i % 5 != 0)
                {
                    for (int j = Convert.ToInt32(Math.Sqrt(i)-1); j > 1; j--)
                    {
                        if (i % j == 0)
                        {
                            notPrime.Add(i);
                        }
                    }

                    if(!notPrime.Contains(i) && i != 1 && i != 2)
                    {
                        Console.WriteLine(i + " is a prime number.");
                    }
                }
            }
        }

        public static void Main()
        {
            List<int> totalNum = new List<int>() {};
            Console.WriteLine("Enter a number and generate all prime numbers between 0 and your number");
            int total = int.Parse(Console.ReadLine());
            for(int i = 0; i < total; i++)
            {
                totalNum.Add(i);
            }
            Prime(totalNum);
        }
    }

}