using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLib
{
    public class Kunde
    {

        private List<Kørertøj> _list;

        public Kunde(List<Kørertøj> list)
        {
            _list = list;   
        }

        public int TotalPris()
        {
            int totalPris = 0;


            foreach (var kørertøj in _list)
            {
                totalPris = totalPris + kørertøj.Pris();
            }

            return totalPris;
        }


    }
}
