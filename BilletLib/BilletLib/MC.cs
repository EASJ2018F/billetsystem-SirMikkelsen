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
       private bool _brobizz;
       private bool _øresund;


       public bool Øresund { get { return _øresund; } }
       public string Nummerplade { get {return _nummerplade;} }
       public DateTime Dato { get { return _dato; } }

       public bool Brobizz { get { return _brobizz; } }

        public MC(string nummerplade, DateTime dato, bool brobizz, bool øresund)
        {
           if (nummerplade.Length > 7)
           {
               throw new ArgumentException("Nummerplade mmå have maks 7 tegn!");
            }
           _nummerplade = nummerplade;
           _dato = dato;
            _brobizz = brobizz;
            _øresund = øresund;
        }

       public override string Køretøj()
       {
           if (_øresund == true)
           {
               return "Øresund MC";
           }
           return "MC";
       }


       public override int Pris(bool weeekend = false)
       {
           
           int femprocentRabat = 5 * Convert.ToInt32(2.4);
           int result = 125;
           int result2 = 210;

         
           if (_brobizz == true)
           {
               result = result - femprocentRabat;
           }

           if (_øresund)
           {
               result = result2;
           }

           if (_øresund == true && _brobizz == true)
           {
               result = 73;
           }


           return result;
        }
   }
}
