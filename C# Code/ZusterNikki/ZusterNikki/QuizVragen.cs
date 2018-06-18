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
        private int[] getallen;
        private string antwoorden;
        int i;

        public int[] Getallen
        {
            get { return getallen; }
        }

        public QuizVragen()
        {
            getallen = KiesNieuweVraag();
        }

        public int[] KiesNieuweVraag()
        {
            int[] RandomGetal = {9000, 9001, 9002, 9003, 9004, 9005, 9006, 9007, 9008, 9009, 9010, 9011};
            Random rand = new Random();
            string[] hoeveelheid = File.ReadAllLines(@"Quiz\QuizVragen.txt");
            for (int i = 0; i < 11;)
            {
                int generated = rand.Next(0, hoeveelheid.Length);
                if (RandomGetal.Contains(generated))
                {
                    continue;
                }
                else
                {
                    RandomGetal[i] = generated;
                    i++;
                }
            }
            return RandomGetal;
        }

    }
}
