using System;
using System.Collections.Generic;
using System.Text;

namespace Section_11.Ex1
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {

        }
    }
}
