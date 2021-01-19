using System;
using System.Collections.Generic;
using System.Text;
using System.IO

namespace GrumpSerializer
{
    public interface IGrumpDeserializer
    {
        void Deserialize(string filepath, StreamReader sr);
    }
}
