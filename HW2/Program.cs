using System;

namespace HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(10819 % 10818);
            Console.WriteLine(10819 % 10819);
            Console.WriteLine(10819 % 19);
            Console.WriteLine(10819 % 10818);
            Console.WriteLine(10819 % 10);


            Console.WriteLine("Put your number !");
            string str = Console.ReadLine();
            for (char ch = '9'; ch >= '0'; ch--)
                {
                if (str.IndexOf(ch) != -1)
                {
                    Console.WriteLine("Самая большая цифра: {0}", ch);
                    break;
                }
            }
            Console.ReadKey();

            int max = 0;
            int min = 0;

            for (int ch = 0; ch < str.Length; ch++)
            {
                if (max < str[ch])
                {
                    max = str[ch];
                }
            }
            Console.WriteLine(max);

        }
    }
}
