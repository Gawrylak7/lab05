using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab05
{
    public class wyjatek3 : Exception
    {
        public wyjatek3() : base()
        {
        }

        public wyjatek3(string message) : base(message)
        {
        }

        public wyjatek3(string message, Exception inner) : base(message, inner)
        {
        }
    }
}