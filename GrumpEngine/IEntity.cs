using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrumpEngine
{
    public interface IEntity
    {
        float Weight { get; set; }
        string Identifier { get; set; }
    }
}
