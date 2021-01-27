using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrumpEngine
{
    public static class MapInterpreter
    {
        private static Map _focusmap;

        public static void TransitionLevel(string filepath, GridPoint transitionpoint)
        {


            EventCoordinator.RaiseEvent(_focusmap, EventHandle.On_Map_Load);
        }
    }
}
