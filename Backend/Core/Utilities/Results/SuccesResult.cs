using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class SuccesResult : Result
    {
        //succes true dir.
        public SuccesResult(string message) : base(true, message)
        {

        }

        public SuccesResult(bool success) : base(true)
        {

        }
    }
}
