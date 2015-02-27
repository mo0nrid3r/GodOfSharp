using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GodOfSharp.AutoProperty
{
    /// <summary>
    /// Example how to work override keyword for base/dervied instance
    /// </summary>
    public class OverrideAutoProperty
    {
        public class BaseClass
        {
            public virtual int GoodFeeling { get; set; }
        }

        public class Foo : BaseClass
        {
            public override int GoodFeeling { get { return 1; }  }
        }

        public static void Process()
        {
            var baseFoo = new BaseClass() { GoodFeeling = 5 };
            Helper.PrintResult("Base class value", baseFoo.GoodFeeling);

            var derivedFoo = new Foo() { GoodFeeling = 5 };
            Helper.PrintResult("Dervied class value", derivedFoo.GoodFeeling);

            BaseClass baseInstanceFoo = new Foo() { GoodFeeling = 5 };
            Helper.PrintResult("Set dervied object to base type variable value", baseInstanceFoo.GoodFeeling);

            BaseClass castedFoo = (BaseClass)derivedFoo;
            Helper.PrintResult("Cast dervied object to base value", castedFoo.GoodFeeling);
        }

    }
}
