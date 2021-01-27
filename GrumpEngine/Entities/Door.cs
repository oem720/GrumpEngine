using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrumpEngine
{
    [Serializable]
    public class Door : IEntity
    {
        //implement the required properties for IEntity
        public float Weight { get; private set; } = 0.0f;
        public string Identifier { get; private set; } = "Door";
        public bool IsGrabbable { get; set; } = false;

        //Member Auto-Props
        public string FilePath { get; set; }
        public bool IsInteractible { get; set; }
        public GridPoint DestinationCoord { get; set; }
        public string InspectionString { get; private set; }

        public Door(string filepath, bool initinteract, GridPoint dest, string inspect)
        {
            FilePath = filepath;
            IsInteractible = initinteract;
            DestinationCoord = dest;
            InspectionString = inspect;
        }

        public void Interact()
        {
            EventCoordinator.RaiseEvent(this, EventHandle.On_Entity_Interact);
            MapInterpreter.TransitionLevel(FilePath, DestinationCoord);
        }
    }
}
