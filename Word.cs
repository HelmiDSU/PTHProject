using System;
using System.IO;

//Declare namespace
namespace Translator
{
    //Create Word class
    internal class Word
    {
        //Declare class variables
        private string language { get; };
        private string content { get; }
        private int id { get; };
        private Word[] synonyms;

        //Create constructor given language and content
        public Word(string language, string content)
        {
            //Assign variables
            this.language = language.ToLower();
            this.content = content.ToLower();

            //Get id from database
            using(StreamReader reader = new StreamReader("Database/" + this.language + ".txt"))
            {
                //Search for word content and increment id
                string line;
                while((line = reader.ReadLine()) != null)
                {
                    this.id++;
                    if(line.Contains(content))
                    {
                        //Break if content is found
                        break;
                    }
                }

                //Set id to 0 if content is not found
                if(line == null)
                {
                    this.id = 0;
                }
            }

        }

        //Create constructor given language and id
        public Word(string language, int id)
        {
            //Assign variables
            this.language = language.ToLower();
            this.id = id;

            //Get content from database
            using (StreamReader reader = new StreamReader("Database/" + this.language + ".txt"))
            {
                for(int i=0; i < this.id; i++)
                {
                    this.content = reader.ReadLine();
                }
            }
        }

        //Translate Word into new Word
        public Word translate(string language)
        {
            return new Word(language, this.id);
        }

        //Generate synonym word from synonyms list
        public Word generateSynonym()       //Synonym code has not been implemented yet
        {
            if (synonyms != null)
            {
                Random random = new Random();
                return synonyms[random.Next(0, (synonyms.Length-1))];
            }
            else
            {
                return this;
            }
        }

        //Add synonym to synonyms list
        public void addSynonym(Word synonym)
        {
            //Not implemented
        }
    }
}
