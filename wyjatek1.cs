using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab05
{
    public class wyjatek1: System.Exception
    {
        public wyjatek1(): base() { }
        public wyjatek1(string message): base(message) { }
        public wyjatek1(string message, System.Exception inner) :
            base(message, inner) { }
    }
}
