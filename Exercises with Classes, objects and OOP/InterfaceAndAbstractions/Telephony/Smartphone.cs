using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
    public class Smartphone : ICallable, IBrowsable
    {
        public Smartphone()
        {

        }
        public string Call(string number)
        {
            return $"Calling... {number}";
        }
        public string Browse(string pageLink)
        {
            return $"Browsing: {pageLink}!";
        }

    }
}
