using System;
using System.Linq;

namespace GurufieldTask2
{
    class Program
    {
        static void Main()
        {
            var array = Enumerable.Range(1, 100000)
                .OrderBy(item => new Random().Next())
                .ToArray();
        }
    }
}