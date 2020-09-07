using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotationConverter
{
    interface INotation
    {
        N2 ToN2();
        N8 ToN8();
        N10 ToN10();
        N16 ToN16();
    }
}
