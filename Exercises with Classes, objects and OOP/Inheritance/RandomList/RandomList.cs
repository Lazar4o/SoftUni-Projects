using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        public string RandomString()
        {
            string randomElement = this.OrderBy(x => Guid.NewGuid()).FirstOrDefault();
            this.Remove(randomElement);
            return randomElement;

        }
    }
}
