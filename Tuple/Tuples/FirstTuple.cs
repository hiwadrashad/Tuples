using System;
using System.Collections.Generic;
using System.Text;
using Tuple.Methods;

namespace Tuple.Tuples
{
    public class FirstTuple : GenericMethods
    {
        public static void FirstTupleExecution(double first, double second)
        {
            var FirstTuple = GetRegularTuple(first,second);
            Console.WriteLine($"First value = {FirstTuple.Item1}, Second value = {FirstTuple.Item2}");
        }
    }
}
