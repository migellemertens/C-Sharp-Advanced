using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les____personeelsklasse
{
    class Personeel
    {
        private string mNaam;
        private string mVoornaam;
        private string mGeslacht;
        private int mBeoordelingscijfer;
        private int mStartjaar;
        private DateTime mGeboorteDatum;

        public string Naam
        {
            get { return mNaam; }
            return{ mNaam = value; }
        }

        public string Voornaam
        {
            get { return mVoornaam; }
            return{ mNaam = value; }
        }

        public string Geslacht
        {
            get { return mGeslacht; }
            return{ mGeslacht = value; }
        }

        public int Beoordelingscijfer
        {
            get { return mBeoordelingscijfer; }
            set
            {
                if(value > -1 && value < 11)
                {
                    mBeoordelingscijfer = value;
                }
            }
        }

        public int Startjaar
        {
            get { return mStartjaar; }
            set { mStartjaar = value; }
        }

        public DateTime GeboorteDatum
        {
            get { return mGeboorteDatum; }
            set { mGeboorteDatum = value; }
        }

        public Personeel()
        {
            this.Voornaam = "";
            this.Naam = "";
            this.Geslacht = "M";
            this.Beoordelingscijfer = 7;
            this.Startjaar = 2000;
            this.GeboorteDatum = new DateTime(1989,1,1);
        }

        public Personeel(string naam, string voornaam, string geslacht, int beoordelingscijfer, int startjaar, DateTime geboortedatum)
        {
            this.Naam = naam;
            this.Voornaam = voornaam;
            this.Geslacht = geslacht;
            this.Beoordelingscijfer = beoordelingscijfer;
            this.Startjaar = startjaar;
            this.GeboorteDatum = geboortedatum;
        }

        public int AantalDienstjaren
        {
            get { return System.DateTime.Now.Year - this.Startjaar; }
        }

        public string GeslachtTekst
        {
            get { return (this.Geslacht == "M" ? "Mannelijk" : "Vrouwelijk"); }
        }

        public double Premie
        {
            get
            {
                double bedrag = 500 + (this.AantalDienstjaren * 20);

                if(this.Beoordelingscijfer < 5)
                {
                    bedrag *= 0.5;
                }
                else if(this.Beoordelingscijfer > 6 && this.Beoordelingscijfer < 9)
                {
                    bedrag *= 1.5;
                }
                else if(this.Beoordelingscijfer > 8)
                {
                    bedrag *= 2;
                }
                return bedrag;
            }
        }

        public int Leeftijd
        {
            get
            {
                int leeftijd = System.DateTime.Now.Year - this.GeboorteDatum.Year;

                if(this.GeboorteDatum > System.DateTime.Now.AddYears(-leeftijd))
                {
                    leeftijd--;
                }
                return leeftijd;
            }
        }

        public string InformatieVolledig()
        {
            return "Personeelslid " + this.Voornaam + " " + this.Naam + Environment.NewLine +
                "Geslacht: " + this.GeslachtTekst + Environment.NewLine +
                "Aantal dienstjaren: " + this.AantalDienstjaren.ToString() + Environment.NewLine +
                "Beoordelingscijfer: " + this.Beoordelingscijfer.ToString() + Environment.NewLine +
                "Premie: " + $"{this.Premie:€0.00}" + Environment.NewLine +
                "Geboortedatum: " + this.GeboorteDatum.ToString("dd/MM/yyyy") + Environment.NewLine +
                "Leeftijd: " + this.Leeftijd.ToString();
        }

        public void VerhoogBeoordeling()
        {
            this.Beoordelingscijfer++;
        }

        public void VerlaagBeoordeling()
        {
            this.Beoordelingscijfer++;
        }

        public DateTime EerstvolgendeVerjaardag
        {
            get
            {
                int jaartal = DateTime.Now.Year;

                if(DateTime.Now.Month < this.GeboorteDatum.Month || (DateTime.Now.Month == this.GeboorteDatum.Month && DateTime.Now.Day > this.GeboorteDatum.Day))
                {
                    jaartal++;
                }
                return new DateTime(jaartal, this.GeboorteDatum.Month, this.GeboorteDatum.Day);
            }
        }

        public string EerstvolgendeverjaardagTekst
        {
            get { return this.EerstvolgendeVerjaardag.ToString("dddd d MMMM yyyy"); }
        }
    }
}
