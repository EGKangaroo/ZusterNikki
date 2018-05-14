using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZusterNikki
{
    class QuizHandler
    {
        // Fields
        private QuizVragen NieuweVraag;
        private string vraag;
        private string antwoorden;
        private string antwoord1;
        private string antwoord2;
        private string antwoord3;
        private string antwoord4;
        private string echteAntwoord;

        // Properties
        public string Vraag
        {
            get { return vraag; }
        }

        public string Antwoord1
        {
            get { return antwoord1; }
        }

        public string Antwoord2
        {
            get { return antwoord2; }
        }

        public string Antwoord3
        {
            get { return antwoord3; }
        }

        public string Antwoord4
        {
            get { return antwoord4; }
        }

        public string EchteAntwoord
        {
            get { return echteAntwoord; }
        }


        // Constructor 
        public QuizHandler()
        {
            NieuweVraag = new QuizVragen();
            vraag = NieuweVraag.Vraag;
            antwoorden = NieuweVraag.Antwoorden;
            AntwoordenSeparator();
        }

        // Methodes
        public void AntwoordenSeparator()
        {
            string[] AntwoordenNaarArray = antwoorden.Split(',');
            antwoord1 = AntwoordenNaarArray[1];
            antwoord2 = AntwoordenNaarArray[2];
            antwoord3 = AntwoordenNaarArray[3];
            antwoord4 = AntwoordenNaarArray[4];
            echteAntwoord = AntwoordenNaarArray[5];
        }
    }
}
