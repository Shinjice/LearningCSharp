using System;

namespace DynamicType
{
    class Program
    {
        
        public class Student
        {
            public int StudentID { get; set; }
            public string StudentName { get; set; }
            public int Age { get; set; }
            public int StandardID { get; set; }

            public void DisplayStudentDetail()
            {
                Console.WriteLine("Name: {0}", this.StudentName);
                Console.WriteLine("Age: {0}", this.Age);
                Console.WriteLine("Standard: {0}", this.StandardID);
            }
        }

        static void PrintValue(dynamic val) //method can have dynamic type parameters so it can accept it at runtime
        {
            Console.WriteLine(val);
        }
        static void Main(string[] args)
        {
            
            dynamic dynamicVariable1 = 1; //makes it dynamic like a object
            Console.WriteLine(dynamicVariable1.GetType().ToString());

            //Dynamic type examples
            dynamic dynamicVariable = 100;
            Console.WriteLine("Dynamic variable value: {0}, Type: {1}", dynamicVariable, dynamicVariable.GetType().ToString());
            dynamicVariable = "Hello World!!";
            Console.WriteLine("Dynamic variable value: {0}, Type: {1}", dynamicVariable, dynamicVariable.GetType().ToString());
            dynamicVariable = true;
            Console.WriteLine("Dynamic variable value: {0}, Type: {1}", dynamicVariable, dynamicVariable.GetType().ToString());
            dynamicVariable = DateTime.Now;
            Console.WriteLine("Dynamic variable value: {0}, Type: {1}", dynamicVariable, dynamicVariable.GetType().ToString());

            dynamic dynamicStudent = new Student();

            dynamicStudent.FakeMethod(); //type wont be checked by compile time, but by run time, so programs runs, till tiss, error will be displayed in Visual Studio

            PrintValue("Hello World!!");
            PrintValue(100);
            PrintValue(100.50);
            PrintValue(true);
            PrintValue(DateTime.Now);
        }
    }
}
