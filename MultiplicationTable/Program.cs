using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("출력할 십오단을 입력하세요");

            string readString = Console.ReadLine();

            int number = int.Parse(readString);

            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine($"{number} X {i + 1} = {number * (i + 1)}");
            }
        }
    }
}
