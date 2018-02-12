using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace StudentService
{
    [DataContract]
    public class Student
    {
        private string _navn;
        private string _klasseNavn;
        private string _rum;

        public Student(string navn, string klasseNavn, string rum)
        {
            _navn = navn;
            _klasseNavn = klasseNavn;
            _rum = rum;
        }

        public string Navn
        {
            get { return _navn; }
            set { _navn = value; }
        }

        public string KlasseNavn
        {
            get { return _klasseNavn; }
            set { _klasseNavn = value; }
        }

        public string Rum
        {
            get { return _rum; }
            set { _rum = value; }
        }

        public override string ToString()
        {
            return $"{Navn} går i klassen {KlasseNavn} i rum {Rum}";
        }
    }
}