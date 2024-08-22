using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public class ListItem
    {
        public string Name { get; set; }
        public int Count { get; set; }

        public override string ToString()
        {
            return $"{Name} ({Count})";
        }
    }
}
