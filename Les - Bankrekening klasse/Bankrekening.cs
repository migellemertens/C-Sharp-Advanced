using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les___Bankrekening_klasse
{
    class Bankrekening
    {
        private double huidigSaldo;
        private string mMunteenheid;

        public Bankrekening()
        {
            this.huidigSaldo = 0;
            this.mMunteenheid = "Eur";
        }

        public Bankrekening(string munt)
        {
            this.huidigSaldo = 0;
            this.mMunteenheid = munt;
        }

        public double HuidigSaldo
        {
            get { return huidigSaldo; }
            set { huidigSaldo = value; }
        }

        public string  Munteenheid
        {
            get { return mMunteenheid; }
            set { mMunteenheid = value; }
        }

        public void BedragWijzigen(double wijziging)
        {
            this.huidigSaldo += wijziging;
        }

    }
}
