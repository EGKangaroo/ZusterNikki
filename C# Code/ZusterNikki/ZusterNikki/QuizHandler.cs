using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ZusterNikki
{
    class QuizHandler
    {
        // Fields
        private QuizVragen NieuweVraag;
        private string vraag;
        private int[] vragen;
        private string antwoorden;
        private string antwoord1;
        private string antwoord2;
        private string antwoord3;
        private string antwoord4;
        private string echteAntwoord;
        public int bijgetal;

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
            vragen = NieuweVraag.Getallen;
            bijgetal = 0;
            VraagAssignation();
        }

        // Methodes
        public void AntwoordenSeparator(string DeAntwoorden)
        {
            string[] AntwoordenNaarArray = DeAntwoorden.Split(',');
            antwoord1 = AntwoordenNaarArray[1];
            antwoord2 = AntwoordenNaarArray[2];
            antwoord3 = AntwoordenNaarArray[3];
            antwoord4 = AntwoordenNaarArray[4];
            echteAntwoord = AntwoordenNaarArray[5];
        }

        public void VraagAssignation()
        {
            string[] Vragen = File.ReadAllLines(@"Quiz\QuizVragen.txt");
            string[] Antwoorden = File.ReadAllLines(@"Quiz\QuizAntwoorden.txt");

            vraag = Vragen[vragen[bijgetal]];
            string CurrentAntwoorden = Antwoorden[vragen[bijgetal]];
            AntwoordenSeparator(CurrentAntwoorden);
        }
    }
}
