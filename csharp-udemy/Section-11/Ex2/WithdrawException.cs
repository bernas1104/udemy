using System;
using System.Collections.Generic;
using System.Text;

namespace Section_11.Ex2
{
    class WithdrawException : ApplicationException
    {
        public WithdrawException(string err) : base(err)
        {

        }
    }
}
