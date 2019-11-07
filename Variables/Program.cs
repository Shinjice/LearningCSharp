using System;

namespace Variables
{
    class Variables
    {
        private static string helloClass = "Hello class";
        static void Main(string[] args)
        {
            var num = 2; //VS will MOSTLY know the type
            Console.WriteLine("var type is: {0}", num.GetType()); //how to get type of var

            string name; 
            name = "Shinjce"; //value can be assigned after declaration
            string lastname = "Johnson"; //var declared and initialized
            Console.WriteLine("name of string: {0} {1}", name, lastname);

            int a = 6, b = 8, c = 2, d = 0; //multi declaration, VAR cannot do this
            int tam, 
                tri, 
                mai;    //can be on more lines till semicolon
            tam = 9;
            Console.WriteLine(tam + a);

            int num1, num2;

            Console.WriteLine("Pls enter a number"); //var types got to be the same. so assign string to int is not possible
            num1 = int.Parse(Console.ReadLine()); //Parse converts string to int

            Console.WriteLine("Pls enter another number");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("adding these two numbers: {0}", (num1 + num2));


            Console.WriteLine(helloClass); //data from first method
            string hello = "Hello Local string"; 
            Console.WriteLine(hello); //data from local function
            ExtraHello(); //data from extra method

            int i = 100; //var assigned
            int j = i; 
            Console.WriteLine(j);

            /*
            int k;      //not possible because var is unasigned
            int l = int k;
            Console.WriteLine(k);
            */

            int u = 100; //explicitly
            var k = 100; //implicitly

            //samples how var mostly will automaticly be determined
            var z = 10;
            Console.WriteLine("type of z is {0}", z.GetType().ToString());
            var x = "helloWorld";
            Console.WriteLine("type of x is {0}", x.GetType().ToString());
            var n = 10.10;
            Console.WriteLine("type of n is {0}", n.GetType().ToString());
            var v = true;
            Console.WriteLine("type of v is {0}", v.GetType().ToString());


            /* Notes
             *var can not be used in function parameters, field type at the class level
             *  Var can be used in;
             *      Local variable in a function
             *      foreach loop
             *      using statement
             *      as anoymous type
             *      in a LINQ query expression
             *      
             *      Not valid;
             *      var i; i=10;
             *      var i += 10;
             *      var i =10, j=10;
             */


        }

        static void ExtraHello()
        {
            Console.WriteLine("Extra hello from function: {0}", helloClass); //takes data first method
        }
    }

}
