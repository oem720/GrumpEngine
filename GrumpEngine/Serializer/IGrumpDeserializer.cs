using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace GrumpEngine.Serializer
{
    public interface IGrumpDeserializer
    {
        void Deserialize(string filepath, StreamReader sr);
    }
}
