using System;

namespace studA
{
    class Program
    {
        static public int b = 0; 
        static void Main(string[] args)
        {
            Console.WriteLine("Введите изначальное число: ");
            int FirstA = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введите конечно число: ");
            int LastA = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введите алгоритм: ");
            double Alg = Convert.ToDouble(Console.ReadLine());
            while (b <= 10000)
            {
                int A = FirstA;
                char[] AlgArr = Alg.ToString().ToCharArray();
                foreach (var command in AlgArr)
                {
                    if (command.ToString().Equals("1")) A = FirstCommand(A);
                    if (command.ToString().Equals("2")) A = SecondCommand(A);
                }
                if (A == LastA)
                {
                    Console.WriteLine("b = " + b);
                    break;
                }
                Console.WriteLine(b + "   "+ A);
                b += 1;
            }
        }

        static int FirstCommand(int A)
        {
            return Convert.ToInt16(Math.Pow(A,2));
        }

        static int SecondCommand(int A)
        {
            return A + b;
        }

    }
}
