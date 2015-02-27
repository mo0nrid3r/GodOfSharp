using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GodOfSharp.Inheritance
{
    public class Potato
    {
        public virtual void Say()
        {
            Console.WriteLine("I'm potato!");
        }
    }

    public class FriedPotato : Potato
    {
        public override void Say()
        {
            Console.WriteLine("I'm fried potato!");
        }
    }

    public class JacketPotato : Potato
    {
        public new void Say()
        {
            Console.WriteLine("I'm jacket potato!");
        }
    }

    /// <summary>
    /// Example how to work with virtual/override/new keyword
    /// </summary>
    public static class PotatoRun
    {
        /// <summary>
        /// Assign dervied types to base class variable
        /// </summary>
        public static void Process1()
        {
            var a = new Potato();
            Helper.PrintResult("Init base type variable", a.Say);
            a = new FriedPotato();
            Helper.PrintResult("Assign dervied type with override", a.Say);
            a = new JacketPotato();
            Helper.PrintResult("Assign dervied type with new", a.Say);
        }

        /// <summary>
        /// Init all types
        /// </summary>
        public static void Process2()
        {
            var a = new Potato();
            Helper.PrintResult("Base type variable", a.Say);
            var b = new FriedPotato();
            Helper.PrintResult("Dervied type with override", b.Say);
            var c = new JacketPotato();
            Helper.PrintResult("Dervied type with new", c.Say);
        }
    }

}
