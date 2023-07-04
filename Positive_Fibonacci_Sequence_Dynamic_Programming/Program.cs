
/*Dynamic programming is a computer programming technique where an algorithmic 
problem is first broken down into sub-problems, the results are saved, and then the 
sub-problems are optimized to find the overall solution — which usually has 
to do with finding the maximum and minimum range of the algorithmic query.*/
class Program
{
    class PositiveFibonacciSequence
    {
        /// <summary>
        /// Прямой метод расчета чисел Фибоначчи
        /// </summary>
        /// <param name="len">количество чисел (первые два числа - единицы)</param>
        /// <returns>возвращает последнее число последовательности, при n = 0 возвращает 0</returns>
        static public int StraightMethod(int len)         //прямой метод 
        {
            // 1 1
            // 1 1 2
            // 1 1 2 3
            // 1 1 2 3 5
            // 1 1 2 3 5 8
            // etc

            if (len == 0) return 0;
            len = len < 2 ? 2 : len;
            int[] fibo = new int[len];
            fibo[0] = 1;
            fibo[1] = 1;

            for (int i = 2; i < len; i++)
            {
                fibo[i] = fibo[i - 2] + fibo[i - 1];
            }
            return fibo[len - 1];
        }
        /// <summary>
        /// Обратный метод расчета чисел Фибоначчи
        /// </summary>
        /// <param name="len">количество чисел (первые два числа - единицы)</param>
        /// <returns>возвращает последнее число последовательности, при n = 0 возвращает 0</returns>
        static public int ReverseMethod(int len)          //обратный метод
        {
            // 1
            // 1 1 1
            // 1 1 2 1
            // 1 1 2 3 2
            // 1 1 2 3 5 3
            // 1 1 2 3 5 8 5 
            // etc

            if (len == 0) return 0;
            len = len < 2 ? 2 : len;
            int[] fibo = new int[len];
            fibo[0] = 1;

            for (int i = 0; i < len - 2; i++)
            {
                fibo[i + 1] += fibo[i];
                fibo[i + 2] += fibo[i];
            }
            return fibo[len - 2] + fibo[len - 1];
        }
    }
    static void Main(string[] args)
    {
        //sequence: 1 1 2 3 5 8 13 21 34 55

        Console.WriteLine(PositiveFibonacciSequence.StraightMethod(0));      //0
        Console.WriteLine(PositiveFibonacciSequence.StraightMethod(1));      //1
        Console.WriteLine(PositiveFibonacciSequence.StraightMethod(2));      //1
        Console.WriteLine(PositiveFibonacciSequence.StraightMethod(10));     //55

        Console.WriteLine();

        Console.WriteLine(PositiveFibonacciSequence.ReverseMethod(0));       //0
        Console.WriteLine(PositiveFibonacciSequence.ReverseMethod(1));       //1
        Console.WriteLine(PositiveFibonacciSequence.ReverseMethod(2));       //1
        Console.WriteLine(PositiveFibonacciSequence.ReverseMethod(10));      //55
    }
}