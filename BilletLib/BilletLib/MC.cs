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
       private DateTime _dato;

       public string Nummerplade { get { return _nummerplade; } }
       public DateTime Dato { get { return _dato; } }

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
