﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace GrumpEngine.Serializer
{
    public class MapSerializer
    {
        public void Serialize(FileStream bw, Map map)
        {
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(bw, map);
        }
    }
}
