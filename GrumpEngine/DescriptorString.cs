using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrumpEngine
{
    public class DescriptorString
    {
        public DescriptorString(string desc, Tag tag)
        {
            Descriptor = desc;
            Tag = tag;
        }

        public string Descriptor { get; private set; }

        public Tag Tag { get; private set; }
    }
}
