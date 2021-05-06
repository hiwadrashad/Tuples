using System;
using System.Collections.Generic;
using System.Text;

namespace Tuple.Tuples
{
    public class FourthTuple : ThirdTuple
    {
        public static void FourthTupleExecution(double first, double second)
        {
            var (f, s) = SecondNotationTuple<double>(first, second);
            Console.WriteLine($"First value = {f}, Second value = {s}");
        }

    }
}
