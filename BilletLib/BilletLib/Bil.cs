using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLib
{
    public class Bil
    {
        private string _nummerplade;
        private DateTime _dato;

        public String NummerPlade { get { return _nummerplade; } }
        
        public DateTime Dato { get { return _dato; } }

        public int Pris()
        {
            return 240;
        }

        public string køretøj()
        {
            return "Bil";
        }
    }
}
