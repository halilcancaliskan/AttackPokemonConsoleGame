using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_efficom_c__11_22.Classes
{
    internal interface IFightTrait
    {
        string Name { get; set; }
        int Min { get; set; }
        int Max { get; set; }
        int Attack();
        
    }
}
