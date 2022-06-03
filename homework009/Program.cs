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
            Random random = new Random();
            int number = random.Next(0, 101);
            Console.WriteLine("Полученное число: " + number);
            for (int i = 0; i < number; i++)
            {
                if (i % variable1 == 0 || i % variable2 == 0)
                    sumOfNumbers += i;
            }
            Console.WriteLine("Сумма всех чисел меньше " + number + " и кратные 3м и 5: " +  sumOfNumbers);
        }
    }
}
