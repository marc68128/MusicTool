using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicTool.Core.Model
{
    public enum Alteration
    { 
        None = 0,
        Sharp = 1, 
        Flat = -1,
        DoubleSharp = 2, 
        DoubleFlat = -2
    }
}
