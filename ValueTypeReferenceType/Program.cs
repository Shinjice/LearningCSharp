using System;

namespace ValueTypeReferenceType

{
    public class Student
    {

        public string StudentName { get; set; }

    }

    public class Program

    {
        static void ChangeValue(int x)
        {
            x = 200;

            Console.WriteLine("a{0}", x);
        }
        public static void ChangeReferenceType(Student std2)
        {
            std2.StudentName = "Steve";
        }

        public static void Main()
        {
            int i = 100;
            Console.WriteLine("b{0}", i);
            ChangeValue(i);
            Console.WriteLine("c{0}", i);

            Student std1 = new Student();
            std1.StudentName = "Bill";
            Console.WriteLine(std1.StudentName);
            ChangeReferenceType(std1);
            Console.WriteLine(std1.StudentName); 
        }
    }
}

/*
The following data types are all of value type:

bool
byte
char
decimal
double
enum
float
int
long
sbyte
short
struct
uint
ulong
ushort

The following data types are of reference type:

String
All arrays, even if their elements are value types
Class
Delegates
*/
