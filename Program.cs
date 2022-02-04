using System;

namespace ConsoleApp1
{
    public class ArrayReverse
    {
        public static void Main(string[] args)
        {
            int[] numbers = GenerateNumbers();
            ReverseArray(numbers);
            PrintNumbers(numbers);
        }

        public static int[] GenerateNumbers()
        {
            Random _random = new Random(10);
            int[] num = new int[10];
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = _random.Next();

                Console.WriteLine(_random.Next());
            }
            return num;
        }

        public static void ReverseArray(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = numbers.Length - 1; j >= 0; j--)
                {
                    int temp = i;
                    i = j;
                    j = temp;
                }
            }
        }

        public static void PrintNumbers(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }

        
}