using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Kaffeemaschine
{
    class Kaffeemaschine
    {
        public double wasser { get; private set; }
        public double bohnen { get; private set; }
        public double gesamtMengeKaffeeProduziert { get; private set; }

        private const double maxWasser = 2.5;

        private const double maxBohnen = 2.5;

        public Kaffeemaschine()
        {
            wasser = 0;
            bohnen = 0;
            gesamtMengeKaffeeProduziert = 0;
        }

        public double wasserAuffuellen(double menge)
        {
            if(menge <= 0)
            {
                return 0;
            }

            if(wasser + menge <= maxWasser)
            {
                wasser += menge;
                return menge;
            }

            double tatsaechlicheMenge = maxWasser - wasser;
            wasser = maxWasser;
            return tatsaechlicheMenge;
        }

        public double bohnenAuffuellen(double menge)
        {
            if (menge <= 0)
            {
                return 0;
            }

            if (bohnen + menge <= maxBohnen)
            {
                bohnen += menge;
                return menge;
            }

            double tatsaechlicheMenge = maxBohnen - bohnen;
            bohnen = maxBohnen;
            return tatsaechlicheMenge;
        }

        public bool macheKaffee(double menge, double verhaeltnisWasserBohnen)
        {
            if(menge <= 0 || verhaeltnisWasserBohnen <= 0)
            {
                return false;
            }

            double bohnenAnteil = menge / (verhaeltnisWasserBohnen + 1);
            double wasserAnteil = menge - bohnenAnteil;

            if(bohnenAnteil > bohnen || wasserAnteil > wasser)
            {
                return false;
            }

            bohnen -= bohnenAnteil;
            wasser -= wasserAnteil;

            gesamtMengeKaffeeProduziert += menge;
            return true;
        }
    }
}
