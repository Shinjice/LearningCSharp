using System;

namespace DataTypes
{
    class Datatypes
    {
        static void Main(string[] args)
        {
            /*    
            Different kind of data types;

            byte    8 - bit unsigned integer  0 to 255
            sbyte   8 - bit signed integer    -128 to 127
            short   16 - bit signed integer   -32,768 to 32,767
            ushort  16 - bit unsigned integer 0 to 65,535
            int     32 - bit signed integer   -2,147,483,648 to 2,147,483,647
            uint    32 - bit unsigned integer 0 to 4,294,967,295  u
            long    64 - bit signed integer   -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807   l
            ulong   64 - bit unsigned integer 0 to 18,446,744,073,709,551,615 ul
            float   32 - bit Single - precision floating point type - 3.402823e38 to 3.402823e38 f
            double  64 - bit double-precision floating point type - 1.79769313486232e308 to 1.79769313486232e308   d
            decimal 128 - bit decimal type for financial and monetary calculations(+or -)1.0 x 10e-28 to 7.9 x 10e28 m
            char    16 - bit single Unicode character Any valid character, e.g.a, *, \x0058(hex), or\u0058(Unicode)
            bool    8 - bit logical true / false value  True or False
            object  Base type of all other types.
            string  A sequence of Unicode characters
            DateTime Represents date and time 0:00:00am 1/1/01 to 11:59:59pm 12/31/9999
            */

            /*
            Value Suffix
            
            uint ui = 100u;
            float fl = 10.2f;
            long l = 45755452222222l;
            ulong ul = 45755452222222ul;
            double d = 11452222.555d;
            decimal mon = 1000.15m;

            float num = 3; is assigned as float, compiler will see it as int (implicit conversion), can cause loss in precision
            float num = 3.0; compiler will see it as double
            float num = 3.0f: compiler will handle 3.0 as float
            float num = (float)3.0; explicit cast
            */


            /*
            Alias vs .NET Type

            byte	        System.Byte	struct
            sbyte	        System.SByte	struct
            int	            System.Int32	struct (so int is same is Int32)
            uint	        System.UInt32	struct
            short	        System.Int16	struct
            ushort	        System.UInt16	struct
            long	        System.Int64	struct
            ulong	        System.UInt64	struct
            float	        System.Single	struct
            double	        System.Double	struct
            char	        System.Char	    struct
            bool	        System.Boolean	struct
            object	        System.Object	Class
            string	        System.String	Class
            decimal	        System.Decimal	struct
            DateTime	    System.DateTime	struct
            */

            /*
            Default Value

            int i = default(int); // 0
            float f = default(float);// 0
            decimal d = default(decimal);// 0
            bool b = default(bool);// false
            char c = default(char);// '\0'
            
            // C# 7.1 onwards
            int i = default; // 0
            float f = default;// 0
            decimal d = default;// 0
            bool b = default;// false
            char c = default;// '\0'    
            */

            int i = 345;
            float f = i; //implicit conversion; will convert because its predifined
            uint u = (uint) i; //explicit converon; not predifened so you have to assign type of data

            Console.WriteLine("Type of i is {0}", i.GetType().ToString());
            Console.WriteLine("Type of i is {0}", f.GetType().ToString());
            Console.WriteLine("Type of i is {0}", u.GetType().ToString());

            /*
             
            Implicit Conversion From	To
            sbyte	                    short, int, long, float, double, decimal
            byte	                    short, ushort, int, uint, long, ulong, float, double, decimal
            short	                    int, long, float, double, or decimal
            ushort	                    int, uint, long, ulong, float, double, or decimal
            int	                        long, float, double, or decimal.
            uint	                    long, ulong, float, double, or decimal
            long	                    float, double, or decimal
            ulong	                    float, double, or decimal
            char	                    ushort, int, uint, long, ulong, float, double, or decimal
            float	                    Double

            */


        }
    }
}
