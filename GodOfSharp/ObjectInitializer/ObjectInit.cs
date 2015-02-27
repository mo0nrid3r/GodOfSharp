using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace GodOfSharp.ObjectInitializer
{
    public class ObjectInit
    {
        public class DuoProp
        {
            public int Uno { get; set; }
            public int Duo { get; set; }
        }

        public static void Process()
        {
            DuoProp duo = new DuoProp() { Uno = 2 };
            duo = new DuoProp()
            {
                Uno = 4,
                Duo = duo.Uno
            };

            Helper.PrintResult("Assign property in object from another property while init", duo.Duo);
        }
    }
}
