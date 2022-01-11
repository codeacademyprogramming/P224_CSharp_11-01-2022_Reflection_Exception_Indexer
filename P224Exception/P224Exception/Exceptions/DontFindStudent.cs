using System;
using System.Collections.Generic;
using System.Text;

namespace P224Exception.Exceptions
{
    class DontFindStudent : Exception
    {
        public string message;
        public override string Message => message;
        public DontFindStudent(string msg)
        {
            message = msg;
        }
    }
}
