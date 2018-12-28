using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core101.Helpers
{
    public static class MathHelper
    {
        public static int ArraySum(int[] numbers)
        {
            int sum = 0;
            foreach (var t in numbers)
            {
                sum += t;
            }

            return sum;
        }
    }
}
