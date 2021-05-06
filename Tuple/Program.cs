using System;
using Tuple.Methods;
using Tuple.Tuples;

namespace Tuple
{
    class Program : FifthTuple
    {
        static void Main(string[] args)
        {
            FirstTupleExecution(1, 2);

            SecondTupleExecution(10, 20);

            ThirdTupleExecution(20, 30);

            FourthTupleExecution(30, 40);

            FifthTupleExecution("40","50");

            Console.ReadLine();
        }
    }
}
