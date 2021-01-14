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
        public DescriptorString(string desc, Tag tag)
        {
            Descriptor = desc;
            Tag = tag;
        }

        public string Descriptor { get; private set; }

        public Tag Tag { get; private set; }
    }
}
