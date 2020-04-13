using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionLivre_BahamadImane
{
    class SaisieException : Exception
    {
        public SaisieException(string message): base(message)
        {
            
        }
    }
}
