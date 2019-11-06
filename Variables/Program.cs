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

            int a = 6, b = 8, c = 2, d = 0; //multi declaration, can 
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

        }

        static void ExtraHello()
        {
            Console.WriteLine("Extra hello from function: {0}", helloClass); //takes data first method
        }
    }

}
