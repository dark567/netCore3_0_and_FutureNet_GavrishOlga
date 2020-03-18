using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AsyncEnumerableNew
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await foreach (var dataPoint in FetchIODate())
            {
                Console.WriteLine(dataPoint);
            }
            Console.ReadLine();
        }

        private static async IAsyncEnumerable<int> FetchIODate()
        {
            for (int i = 0; i <= 10; i++)
            {
                await Task.Delay(1000);
                yield return i;
            }
        }
    }
}
