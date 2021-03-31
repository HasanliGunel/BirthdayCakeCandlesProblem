using System;

namespace Tapshiriq_6
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n = Convert.ToInt32(Console.ReadLine());
            int[] candles = new int[n];
            if (n >= 1 & n <= Math.Pow(10, 5))
            {
                int k = 0;
                
                for (int i = 0; i < n; i++)
                {
                    candles[i] = Convert.ToInt32(Console.ReadLine());
                }
                int max = candles[0];
                for (int i = 1; i < n; i++)
                {
                    if (max < candles[i])
                    {
                        max = candles[i];
                    }
                }
                for (int i = 0; i < n; i++)
                {
                    if (max == candles[i])
                        k++;
                }
               
                Console.WriteLine("max=" + max);
                Console.WriteLine("say=" + k);

            }
            Console.ReadLine();
        }
    }
}
