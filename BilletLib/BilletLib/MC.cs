using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLib
{
   public class MC : Kørertøj
   {
       private string _nummerplade;
       private DateTime _dato;

       public string Nummerplade { get {return _nummerplade;} }
       public DateTime Dato { get { return _dato; } }


        public MC(string nummerplade, DateTime dato)
        {
           if (nummerplade.Length > 7)
           {
               throw new ArgumentException("Nummerplade mmå have maks 7 tegn!");
            }
           _nummerplade = nummerplade;
           _dato = dato;    
       }

       public override string Køretøj()
       {
           return "MC";
       }

       public override int Pris()
       {
           return 125;
       }
   }
}
