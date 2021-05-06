using System;
using System.Collections.Generic;
using System.Text;

namespace Tuple.Tuples
{
    public class ThirdTuple : SecondTuple
    {
        public static void ThirdTupleExecution(double first, double second)
        {

            var ThirdTuple = ValueTuple.Create(first, second);
            Console.WriteLine($"First value = {ThirdTuple.Item1}, Second value = {ThirdTuple.Item2}");
        }
    }
}
