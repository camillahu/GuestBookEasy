using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gjestebok
{
    internal class Guest
    {
        private string Name { get; set; }

        public Guest(string name)
        {
            Name = name;
        }

        public string GetName()
        {
            return Name;
        }
    }
}
