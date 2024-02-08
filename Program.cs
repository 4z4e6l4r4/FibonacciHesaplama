namespace FibonacciHesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 7;
            Console.WriteLine(fibonacciFuntion(n));
        }

        static long fibonacciFuntion(int number)
        {
            if (number <= 1)
            {
                return number;
            }
            else
            {
                return fibonacciFuntion(number - 1)+fibonacciFuntion(number-2);

            }

        }
    }

}