using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AsyncEnumerableOld
{
    class Program
    {
        static async Task Main(string[] args)
        {
            foreach (var dataPoint in await FetchIOTDate())
            {
                Console.WriteLine(dataPoint);
            }
            Console.ReadLine();
        }

        private static async Task<IEnumerable<int>> FetchIOTDate()
        {
            List<int> dataPoint = new List<int>();
            for (int i = 1; i <= 10; i++)
            {
                await Task.Delay(100);
                dataPoint.Add(i);
            }
            return dataPoint;
        }
    }
}
