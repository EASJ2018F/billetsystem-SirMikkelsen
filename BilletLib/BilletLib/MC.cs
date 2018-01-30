using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLib
{
   public class MC
   {
       private string _nummerplade;
       private DateTime _dateTime;

       public string Nummerplade { get { return _nummerplade; } }
       public DateTime DateTime { get { return _dateTime; } }

       public int Pris()
       {
           return 125;
       }

       public string Køretøj()
       {
           return "MC";
       }
   }
}
