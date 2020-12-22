using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrumpEngine
{
    public enum Tag
    {
        Start_Of_Dialog_Tree = 100,
        Ordered_Dialog_Tree,
        End_Of_Dialog_Tree,
        Environmental_Description,
        Start_Of_Mid_Combat_Lines,
        Mid_Combat_Line,
        End_Of_Mid_Combat_Line,
        On_Tile_Enter,
        On_Tile_Exit,
        On_Entity_Interact
    }

    public class DescriptorString
    {
        string descriptor;
        Tag descriptorTag;

        public DescriptorString(string desc, Tag tag)
        {
            descriptor = desc;
            descriptorTag = tag;
        }

        public string Descriptor
        {
            get { return descriptor; }
            set { descriptor = value; }
        }

        public Tag DescriptorTag
        {
            get { return descriptorTag; }
            set { descriptorTag = value; }
        }

        public override string ToString()
        {
            return $"{descriptorTag} {descriptor}";
        }
    }
}
