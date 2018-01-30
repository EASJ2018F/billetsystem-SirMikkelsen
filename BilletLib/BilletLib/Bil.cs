using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLib
{
    public class Bil : Kørertøj
    {
        private string _nummerplade;
        private DateTime _dato;

        public String NummerPlade { get { return _nummerplade; } }
        
        public DateTime Dato { get { return _dato; } }


        public override string Køretøj()
        {
            return "Bil";
        }

        public override int Pris()
        {
                 return 240;
        }
    }
}
