using System;
using System.Collections.Generic;
using System.Text;

namespace Tuple.Methods
{
    public class GenericMethods
    {
        public static Tuple<T, T> GetRegularTuple<T>(T first, T second)
        {
            var TupleValue = new Tuple<T, T>(first, second);
            return TupleValue;
        }

        public static (T FirstValue, T Secondvalue) SecondNotationTuple<T>(T first, T second)
        {
            return (first, second);
        }
    }
}
