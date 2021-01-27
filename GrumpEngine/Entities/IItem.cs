using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrumpEngine
{
    public interface IItem : IEntity
    {
        string ItemName { get; }
        string ItemDescription { get; }
    }
}
