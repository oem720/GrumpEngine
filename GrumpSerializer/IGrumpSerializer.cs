using System;
using System.Collections.Generic;
using System.Text;

namespace GrumpSerializer
{
    public interface IGrumpSerializer
    {
        void Serialize(object obj);
    }
}
