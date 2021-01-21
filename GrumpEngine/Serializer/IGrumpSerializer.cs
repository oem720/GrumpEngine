using System;
using System.Collections.Generic;
using System.Text;

namespace GrumpEngine.Serializer
{
    public interface IGrumpSerializer
    {
        string Serialize(object obj);
    }
}
