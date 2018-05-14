using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace ZusterNikki
{
    class AdLibs
    {
        //fields
        private List<String> varWords;
        private string story;
        private string title;
        private string errorReport;

        private static Random rnd = new Random();

        //properties
        public List<String> VarWords
        {
            get { return this.varWords; }
        }

        public string Story
        {
            get { return this.story; }
        }

        public string Title
        {
            get { return this.title; }
        }

        public string ErrorReport
        {
            get { return this.errorReport; }
        }

        //constructor
        public AdLibs()
        {
            varWords = new List<string>();
            GetStory();
        }

        //methods

        //constructor method to read and interpret story files
        private void GetStory()
        {
            //gets all text files from directory adlibs
            var files = Directory.GetFiles("adlibs", "*.txt");

            //chooses a random story from the story files
            FileStream fileStream = new FileStream(files[rnd.Next(files.Length)], FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(fileStream);

            try
            {
                //first line is always the title
                title = reader.ReadLine();

                //patterns for adlib insertions are indicated with [[name]] in the text file
                string pattern = @"\[\[(.*?)\]\]";
                string line = reader.ReadLine();

                while(line != null)
                {
                    story = story + line + "\n";
                    Match m = Regex.Match(line, pattern);
                    
                    while (m.Success)
                    {
                        if(varWords.Contains(m.ToString()) == false)
                        {
                            varWords.Add(m.ToString());
                        }
                        m = m.NextMatch();
                    }
                    line = reader.ReadLine();
                }
            }
            catch(IndexOutOfRangeException)
            {
                errorReport = "De bibliotheek is leeg";
            }
            catch
            {
                errorReport = "Foutje";
            }
            finally
            {
                reader.Close();
            }
        }

        //replaces the AdLib variables with input words and presents the story
        public void MakeStory(List<String> input)
        {
            for(int i = 0; i < varWords.Count; i++)
            {
                story = story.Replace(varWords[i], input[i]);
            }
        }
    }
}
