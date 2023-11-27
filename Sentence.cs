//Declare namespace
namespace Translator
{
    //Create Sentence class
    internal class Sentence
    {
        //Declare class variables
        private string language { get; }
        private Word[] content { get; }

        //Create constructor
        public Sentence(string language, Word[] content)
        {
            //Assign variables
            this.language = language;
            this.content = content;
        }

        //Translate sentence into new sentence
        public Sentence translate(string language)
        {
            //Create new Word array and translate
            Word[] translated = new Word[content.Length];
            for(int i=0; i<content.Length; i++)
            {
                translated[i] = content[i].translate(language);
            }

            return new Sentence(language, translated);
        }
    }
}
