using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bagagesorteringssystems_opgave
{
    public class Reservation
    {
        public Reservation(int PassagerNummer, string PassagerNavn, string FlyAfgang)
        {
            passagerNummer = PassagerNummer;
            passagerNavn = PassagerNavn;
            flyAfgang = FlyAfgang;
        }

        private int passagerNummer;

        public int PassagerNummer
        {
            get { return passagerNummer; }
            set { passagerNummer = value; }
        }

        private string passagerNavn;

        public string PassagerNavn
        {
            get { return passagerNavn; }
            set { passagerNavn = value; }
        }

        private string flyAfgang;

        public string FlyAfgang
        {
            get { return flyAfgang; }
            set { flyAfgang = value; }
        }

    }
}
