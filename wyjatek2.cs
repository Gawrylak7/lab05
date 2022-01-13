using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab05
{
    public class wyjatek2 : System.Exception
    {
        public wyjatek2() : base() { }
        public wyjatek2(string message) : base(message) { }
        public wyjatek2(string message, System.Exception inner) :
            base(message, inner)
        { }
    }
}
