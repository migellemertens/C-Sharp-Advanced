using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace les___studentenverwerking
{
    class Student
    {

        private string mNaam;
        private string mVoornaam;
        private string mStraat;
        private string mPostcode;
        private string mGeslacht;
        private int mStudiepunten;
        private string mAard;

        public Student()
        {
            this.Naam = "";
            this.Voornaam = "";
            this.Straat = "";
            this.Postcode = "";
            this.Geslacht = "";
            this.Studiepunten = 60;
            this.Aard = "G";
        }

        public Student(string naam, string voornaam, string straat, string postcode, string geslacht, int studiepunten, string aard)
        {
            this.Naam = naam;
            this.Voornaam = voornaam;
            this.Straat = straat;
            this.Postcode = postcode;
            this.Geslacht = geslacht;
            this.Studiepunten = studiepunten;
            this.Aard = aard;
        }

        public string Naam
        {
            get { return mNaam; }
            set { mNaam = value; }
        }

        public string Voornaam
        {
            get { return mVoornaam; }
            set { mVoornaam = value; }
        }

        public string Straat
        {
            get { return mStraat; }
            set { mStraat = value; }
        }

        public string Postcode
        {
            get { return mPostcode; }
            set { mPostcode = value; }
        }

        public string Geslacht
        {
            get { return mPostcode; }
            set { mPostcode = value; }
        }

        public int Studiepunten
        {
            get { return mStudiepunten; }
            set { mStudiepunten = value; }
        }

        public string Aard
        {
            get { return mAard; }
            set
            {
                if(value == "G" || value == "I")
                {
                    mAard = value;
                }
            }
        }

        public int Financierbaarheid
        {
            get
            {
                if(this.Aard == "G")
                {
                    return 100;
                }
                else
                {
                    if(this.Studiepunten > 44)
                    {
                        return 100;
                    }
                    else if(this.Studiepunten > 29)
                    {
                        return 75;
                    }
                    else if(this.Studiepunten > 14)
                    {
                        return 50;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        public string NaamVolledig()
        {
            string aardvolledig = (this.Aard == "G" ? "Standaardstudent " : "IT-Student ");
            return aardvolledig + this.Voornaam + " " + this.Naam;
        }

        public double Inschrijvingsbedrag
        {
            get
            {
                if(this.Aard == "G")
                {
                    return 520;
                }
                else
                {
                    return 50 + 520 * Studiepunten / 60;
                }
            }
        }

        public string AfdrukRegel()
        {
            return $"{this.NaamVolledig()} - {this.Financierbaarheid}% financierbaar";
        }

        public string Recordvorm()
        {
            string studiepuntenMetVoorloopnul;
            studiepuntenMetVoorloopnul = (this.Aard == "G" ? "" : this.Studiepunten.ToString().PadLeft(2, '0'));
            return $"{this.Aard}{this.Naam.PadRight(20)}{this.Voornaam.PadRight(20)}{this.Straat.PadRight(30)}{this.Postcode}{this.Geslacht}{studiepuntenMetVoorloopnul}";
        }

        public void UpdateEigenschappenStudent(string naam, string voornaam, string straat, string postcode, string geslacht, int studiepunten, string aard)
        {
            this.Naam = naam;
            this.Voornaam = voornaam;
            this.Straat = straat;
            this.Postcode = postcode;
            this.Geslacht = geslacht;
            this.Studiepunten = studiepunten;
            this.mAard = aard;
        }

    }
}
