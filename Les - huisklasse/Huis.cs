using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Les___huisklasse
{
    class Huis
    {
        private string mLocatie;
        private double mLengte;
        private double mBreedte;
        private int mAantalVerdiepingen;
        private string mType;

        public Huis()
        {
            this.Locatie = "";
            this.Lengte = 0;
            this.Breedte = 0;
            this.AantalVerdiepingen = 1;
            this.Type = "";
        }

        public Huis(string locatie, double lengte, double breedte, int aantalVerdiepingen, string type)
        {
            this.Locatie = locatie;
            this.Lengte = lengte;
            this.Breedte = breedte;
            this.AantalVerdiepingen = aantalVerdiepingen;
            this.Type = type;
        }

        public string Locatie
        {
            get { return mLocatie; }
            set { mLocatie = value; }
        }


        public double Lengte
        {
            get { return mLengte; }
            set { mLengte = value; }
        }


        public double Breedte
        {
            get { return mBreedte; }
            set { mBreedte = value; }
        }


        public int AantalVerdiepingen
        {
            get { return mAantalVerdiepingen; }
            set
            {
                if (value > 0)
                {
                    mAantalVerdiepingen = value;
                }
                else
                {
                    MessageBox.Show("Aantal verdiepingen moet minstens 1 zijn", "fout", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        public string Type
        {
            get { return mType; }
            set { mType = value; }
        }

        public void VerhoogAantalVerdiepingen()
        {
            this.AantalVerdiepingen++;
        }

        public void VerhoogAantalVerdiepingen(int extraVerdiepingen)
        {
            this.AantalVerdiepingen += extraVerdiepingen;
        }

        public void VerlaagAantalVerdiepingen(int verminderVerdiepingen = 1)
        {
            this.AantalVerdiepingen -= verminderVerdiepingen;
        }

        public double Oppervlakte()
        {
            return this.Lengte * this.Breedte * this.AantalVerdiepingen;
        }

        public double Inhoud()
        {
            return Oppervlakte() * 2.5;
        }

        public string InformatieVolledig()
        {
            string typeOmschrijving = "";

            switch (this.Type)
            {
                case "O":
                    typeOmschrijving = "Open bebouwing";
                    break;
                case "H":
                    typeOmschrijving = "Half open bebouwing";
                    break;
                default:
                    typeOmschrijving = "Gesloten bebouwing";
                    break;
            }

            return $"Locatie: {this.Locatie}\n" +
                $"Type: {typeOmschrijving}\n" +
                $"Lengte: {this.Lengte}\n" +
                $"Breedte: {this.Breedte}\n" +
                $"Lengte: {this.Lengte}\n" +
                $"Aantal verdiepingen: {this.AantalVerdiepingen}\n" +
                $"Grondoppervlakte: {this.Oppervlakte()}\n" +
                $"Inhoud: {this.Inhoud()}m³";
        }
    }
}
