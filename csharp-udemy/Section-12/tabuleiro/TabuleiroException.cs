using System;
using System.Collections.Generic;
using System.Text;

namespace Section_12.tabuleiro
{
    class TabuleiroException : ApplicationException
    {
        public TabuleiroException(string err) : base(err) { }
    }
}
