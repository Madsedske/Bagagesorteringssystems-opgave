using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bagagesorteringssystems_opgave
{
    public class Baggage
    {
        public Baggage(int BaggageNummer, int PassagerNummer, DateTime TidsStempelInd, DateTime TidsStempelUd)
        {
            baggageNummer = BaggageNummer;
            passagerNummer = PassagerNummer;
            tidsStempelInd = TidsStempelInd;
            tidsStempelUd = TidsStempelUd;
        }

        private int passagerNummer;

        public int PassagerNummer
        {
            get { return passagerNummer; }
            set { passagerNummer = value; }
        }

        private int baggageNummer;

        public int BaggageNummer
        {
            get { return baggageNummer; }
            set { baggageNummer = value; }
        }

        private DateTime tidsStempelInd;

        public DateTime TidsStempelInd
        {
            get { return tidsStempelInd; }
            set { tidsStempelInd = value; }
        }

        private DateTime tidsStempelUd;

        public DateTime TidsStempelUd
        {
            get { return tidsStempelUd; }
            set { tidsStempelUd = value; }
        }


    }
}
