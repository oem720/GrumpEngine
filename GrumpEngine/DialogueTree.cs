using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrumpEngine
{
    [Serializable]
    public class DialogueTree
    {
        private List<DescriptorString> _dialogue;

        public DialogueTree()
        {
            _dialogue = new List<DescriptorString>();
        }

        /// <summary>
        /// Attempts to add a descriptor string to the tree. If the string's tag is incorrect, it refuses to add and returns a false value
        /// </summary>
        /// <param name="ds"></param>
        /// <returns></returns>
        public bool AddString(DescriptorString ds)
        {
            if(ds.Tag != Tag.Dialogue_Tree_Choice && ds.Tag != Tag.Dialogue_Tree_End && ds.Tag != Tag.Dialogue_Tree_Response)
                return false;

            _dialogue.Add(ds);
            return true;
        }

        /// <summary>
        /// Attempts to remove a value at the point index. If such a point is above or below the limits of the list, it returns a false value.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool RemoveString(int index)
        {
            if (index > _dialogue.Count - 1 || index < 0)
                return false;

            _dialogue.RemoveAt(index);
            return true;
        }

        /// <summary>
        /// Requests a string from the given index and returns an Array containing that string. If the string is part of a Dialogue Tree Choice,
        /// the assumption will be that it is the first item in that Choice Tree, and will fill the array with dialogue tree choices until it no longer
        /// finds any, at which point it returns the value.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public DescriptorString[] RequestString(int index)
        {
            List<DescriptorString> temp = new List<DescriptorString>();

            if(_dialogue[index].Tag == Tag.Dialogue_Tree_Choice)
                for(int i = index; i < _dialogue.Count; i++)
                {
                    if (_dialogue[index].Tag != Tag.Dialogue_Tree_Choice)
                        break;
                    temp.Add(_dialogue[index]);
                }

            return temp.ToArray();
        }
    }
}
