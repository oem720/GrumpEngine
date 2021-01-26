using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;

namespace GrumpEngine.Serializer
{
    public static class MapDeserializer
    {
        public static Map Deserialize(FileStream fs)
        {
            BinaryFormatter bf = new BinaryFormatter();
            return (Map)bf.Deserialize(fs);
        }
    }
}
