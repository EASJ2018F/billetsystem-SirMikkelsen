using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLib
{
    public class Bil : Kørertøj
    {
        private string _nummerplade;
        private DateTime _dato;
        private bool _brobizz;


        public string Nummerplade { get { return _nummerplade; }}
        public bool Brobizz { get { return _brobizz;} }
        public DateTime Dato { get { return _dato; } }

        public Bil(string nummerplade, DateTime dato, bool brobizz)
        {
            if (nummerplade.Length > 7)
            {
                throw new ArgumentException("Nummerplade mmå have maks 7 tegn!");
            }

            _nummerplade = nummerplade;
            _dato = dato;
            _brobizz = brobizz;
        }


        public override string Køretøj()
        {
            return "Bil";
        }

        public override int Pris()
        {

            int tyveprocenRabat = 20 * Convert.ToInt32(2.4);
            int femprocentRabat = 5 * Convert.ToInt32(2.4);
            int result = 240;

            if (_brobizz == true)
            {
                return (result - femprocentRabat);
            }

            if (_dato.DayOfWeek == DayOfWeek.Saturday || _dato.DayOfWeek == DayOfWeek.Sunday && _brobizz == true)
            {
               return (result - tyveprocenRabat) - femprocentRabat;

            }

            return result;


        }
    }
}
