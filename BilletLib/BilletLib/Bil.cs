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
        private bool _øresund;


        public string Nummerplade { get { return _nummerplade; }}
        public bool Brobizz { get { return _brobizz;} }
        public DateTime Dato { get { return _dato; } }
        public bool Øresund { get { return _øresund; } }

        public Bil(string nummerplade, DateTime dato, bool brobizz , bool øresund)
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
                return "Øresund Bil";
            }

            return "Bil";
        }

        

        public override int Pris()
        {

            int tyveprocenRabat = 20 * Convert.ToInt32(2.4);
            int femprocentRabat = 5 * Convert.ToInt32(2.4);
            int result = 240;
            int result2 = 410;

            // Rettet det til dayofweek.Satuday or  dayofweek.Friday

            if (_dato.DayOfWeek== DayOfWeek.Saturday || _dato.DayOfWeek == DayOfWeek.Friday)
            {
               result=  result - tyveprocenRabat;

            }

            if (_brobizz == true)
            {
                result = result - femprocentRabat;
            }


            if (_øresund == true)
            {
                result = result2;
            }

            if (_øresund && _brobizz == true)
            {
                result = 161;
            }

            return result;

        }

     

   
    }
}
