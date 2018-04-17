using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Fibonachi
    {
        public static IEnumerable<int> FibonachiNumbers(int num)
        {
            int prev = 0;
            int result = 1;
            for (int i = 0; i < num - 1; i++)
            {
                yield return result;
                int temp = prev;
                prev = result;
                result = temp + result;
            }
        }
    }
}
