using System;

namespace AnonymousType
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            
                var myAnonymousType = new
                {
                    firstProperty = "First",
                    secondProperty = 2,
                    thirdProperty = true,
                    anotherAnonymousType = new {nestedProperty = "Nested"}
                };

            Console.WriteLine(myAnonymousType.GetType().ToString());
            Console.WriteLine(myAnonymousType);
            Console.WriteLine(myAnonymousType.firstProperty);
            Console.WriteLine(myAnonymousType.anotherAnonymousType.GetType().ToString());
            Console.WriteLine(myAnonymousType.anotherAnonymousType.nestedProperty.ToString());
            Console.WriteLine(myAnonymousType.anotherAnonymousType.nestedProperty);

            DoSomethig(myAnonymousType);

        }
        static void DoSomethig(dynamic param)
        {
            Console.WriteLine(param.secondProperty);
        }
    }
}
