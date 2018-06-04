using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZusterNikki
{
    public class Player
    {
        //fields
        string name;
        int age;
        string gender;

        int score;

        int id;


        //properties
        public string Name
        {
            get { return this.name; }
        }

        public int Age
        {
            get { return this.age; }
        }

        public string Gender
        {
            get { return this.gender; }
        }

        public int Score
        {
            get { return this.score; }
        }

        public int Id
        {
            get { return this.id; }
        }

        //constructor
        public Player(int id, string name, int score, int age, string gender)
        {
            this.id = id;
            this.name = name;
            this.score = score;
            this.age = age;
            this.gender = gender;
        }

        //methods
        public void ReceiveScore(int score)
        {
            this.score += score;
        }

        public override string ToString()
        {
            string toString = this.name + " is " + this.age + " jaar oud en heeft een score van " + this.score;
            return toString;
        }
    }
}
