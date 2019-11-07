using System; //importing namespaces

namespace HelloWorld //name space name
{
    class Program //class name
    {
        static void Main(string[] args) //method declaration
        {
            string hello = "Hello ";
            Console.Write("{0}", hello);
            funcWorld();
            
        }

        static void funcWorld() //extra method (NOT MAIN)
            {
            Console.WriteLine("World!");
            }
    }
}
