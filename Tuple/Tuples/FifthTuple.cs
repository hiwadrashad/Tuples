using System;
using System.Collections.Generic;
using System.Text;

namespace Tuple.Tuples
{
    public class FifthTuple : FourthTuple
    {
        public static void FifthTupleExecution(string first, string second)
        {
            var FifthTuple = (First: first, Second: second);
            Console.WriteLine($"First value = {FifthTuple.First}, Second value = {FifthTuple.Second}");
        }
    }
}
