﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrumpEngine
{
    [Serializable]
    public class EntityTemplate : IEntity
    {
        //TODO: add your code here.

        //Retuns the weight of the entity created.
        public float Weight { get; set; }
        public string Identifier { get; set; }
        public bool IsGrabbable { get; set; }
    }
}
