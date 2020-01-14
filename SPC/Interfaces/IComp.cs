using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPC.Interfaces
{
    public interface IComp
    {
        string getName
        {
            get;
        }
        
        string getSymbol
        {
            get;
        }

        string getBeschreibung
        {
            get;
        }
    }
}
