using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAMK.IT;

namespace ConsoleApplication1
{
    public class Tyre
    {
    public string Branch { get; set; }    
    public string Size { get; set; }
        
            public override string ToString()
                {
                return "Valmistaja: " + Branch + "koko: " + Size;
            }
        }
    }
}
