using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ZusterNikki
{
    class QuizVragen
    {
        private string vraag;
        private string antwoorden;
        int i;

        public string Vraag
        {
            get { return vraag; }
        }

        public string Antwoorden
        {
            get { return antwoorden; }
        }

        public QuizVragen()
        {
            vraag = KiesNieuweVraag();
            antwoorden = SelecteerAntwoorden(i);
        }

        public string KiesNieuweVraag()
        {
            Random rand = new Random();
            i = rand.Next(1, 50);
            string[] LeesVraag = File.ReadAllLines(@"Quiz\QuizVragen.txt");
            string GekozenVraag = LeesVraag[i];
            return GekozenVraag;
        }

        public string SelecteerAntwoorden(int a)
        {
            string[] LeesAntwoord = File.ReadAllLines(@"Quiz\QuizAntwoorden.txt");
            string GekozenAntwoord = LeesAntwoord[i];
            return GekozenAntwoord;
        }

    }
}
