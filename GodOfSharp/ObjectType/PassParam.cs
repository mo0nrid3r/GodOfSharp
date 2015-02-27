using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GodOfSharp.ObjectType
{
    /// <summary>
    /// Samples how to work with value/object type param 
    /// </summary>
    public class PassParam
    {
        private static void ChangeString(string what)
        {
            what = "change what?";
        }

        private static void ChangeString(ref string what)
        {
            what = "change what?";
        }

        public static void ProcessChangeString()
        {
            var a = "QQ";
            ChangeString(a);
            Helper.PrintResult("Try assign outer string variable into method", a);

            var b = "QQ";
            ChangeString(ref b);
            Helper.PrintResult("Try assign outer string variable into method passed by ref", b);
        }

        private static void IntMe(int a)
        {
            a = 5;
        }

        private static void IntMeRef(ref int a)
        {
            a = 5;
        }

        public static void ProcessChangeInt()
        {
            var a = 1;
            IntMe(a);
            Helper.PrintResult("Try assign outer int variable into method", a);
            
            var b = 1;
            IntMeRef(ref b);
            Helper.PrintResult("Try assign outer int variable into method passed by ref", b);
        }

        private class Foo
        {
            public int A;

            public Foo(int a)
            {
                A = a;
            }
        }

        private static void FooPropMe(Foo a)
        {
            a.A = 5;
        }

        private static void FooPropMeRef(ref Foo a)
        {
            a.A = 5;
        }

        private static void FooMe(Foo a)
        {
            a = new Foo(3);
        }

        private static void FooMeRef(ref Foo a)
        {
            a = new Foo(3);
        }

        public static void ProcessChangeFooProperty()
        {
            var a = new Foo(1);
            FooPropMe(a);
            Helper.PrintResult("Try assign outer object property into method", a.A);

            var b = new Foo(1);
            FooPropMeRef(ref b);
            Helper.PrintResult("Try assign outer object property into method passed by ref", b.A);
        }

        public static void ProcessChangeFoo()
        {
            var a = new Foo(1);
            FooMe(a);
            Helper.PrintResult("Try assign outer object into method to new object", a.A);

            var b = new Foo(1);
            FooMeRef(ref b);
            Helper.PrintResult("Try assign outer object into method passed by ref to new object", b.A);
        }
    }
}
