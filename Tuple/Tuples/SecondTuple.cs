using System;
using System.Collections.Generic;
using System.Text;

namespace Tuple.Tuples
{
    public class SecondTuple : FirstTuple
    {
        public static void SecondTupleExecution(double first, double second)
        {
            var SecondTuple = SecondNotationTuple(first,second);
            Console.WriteLine($"First value = {SecondTuple.Item1}, Second value = {SecondTuple.Item2}");
            Console.WriteLine($"First value = {SecondTuple.FirstValue}, Second value = {SecondTuple.Secondvalue}");
        }
    }
}
