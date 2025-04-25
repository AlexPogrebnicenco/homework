using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkProject.Exceptions
{
    public class NoSessionApprovedException : Exception
    {
        public NoSessionApprovedException(string message) : base (message) { }
    }
}
