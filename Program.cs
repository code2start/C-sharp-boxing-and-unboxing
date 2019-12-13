using System;
using System.Collections.Generic;

namespace BoxingAndUnBoxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 20;//value type
            Object o1 = i;//Boxing
            int i1 = (int)o1;//Unboxing
            Console.WriteLine(i1);
            Console.WriteLine(string.Concat("Mohamed fathy", 330, 4.5, true));
            var items = new List<object>();
            items.Add(10);
            items.Add("Mohamed");
            items.Add(true);

            string name = (string)items[1];
            Console.WriteLine(name);
        }
    }
}
