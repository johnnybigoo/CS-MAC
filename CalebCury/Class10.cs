using System;

// 10 - Value Types and Reference Types


namespace CalebCury //a namespace - used for organization
{
    public class Class4 //a class - has members (such as a method)
    {
        static void Main(string[] args) //a method - contain a block of code
        {
            int a = -5;
            int b = a;
            // Both will assign as a value -5
            Console.WriteLine(a);
            Console.WriteLine(b);

            int[] c = { -5 };
            int[] d = c;
            Test(c);

            //d[0] = 10;
            // both will assign the value 10 (Because in an array it accepts modifying)
            Console.WriteLine(c[0]);
            //Console.WriteLine(d[0]);
        }

        static void Test(int[] c)
        {
            c[0] = 100;
        }
    }
}


