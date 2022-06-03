using System;

namespace homework009
{
    class Program
    {
        static void Main(string[] args)
        {
            int variable1 = 3;
            int variable2 = 5;
            int sumOfNumbers = 0;
            int minValue = 0;
            int maxValue = 101;

            Random random = new Random();

            int number = random.Next(minValue, maxValue);
            Console.WriteLine("Полученное число: " + number);

            for (int i = 0; i < number; i++)
            {
                if (i % variable1 == 0 || i % variable2 == 0)
                    sumOfNumbers += i;
            }
            Console.WriteLine("Сумма всех чисел меньше " + number + " и кратные " + variable1 + " и " + variable2 +  sumOfNumbers);
        }
    }
}
