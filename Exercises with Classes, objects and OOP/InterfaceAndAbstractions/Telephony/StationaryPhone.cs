﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
    public class StationaryPhone : ICallable
    {
        public StationaryPhone()
        {

        }
        public string Call(string number)
        {          
            return $"Dialing... {number}";           
        }
    }
}
