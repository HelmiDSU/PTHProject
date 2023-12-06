using System;
using System.Collections.Generic;
using System.Windows.Forms;

/**@author Tucker Carda, Helmi Yatim, Peter Ruehle
 * @class CSC 470
 * @date 12//2023*/

namespace Translator
{
    public partial class Translator : Form
    {
        // Add a list to store past translations
        private List<string> pastTranslations = new List<string>();

        public Translator()
        {
            InitializeComponent();
            
        }

        private void Translate_Click(object sender, EventArgs e)
        {
            var text = Input.Text.ToString();
            if (InputLang.Text == "English" && OutputLang.Text == "English")
            {
                Output.Text = Input.Text;
            }
            if (InputLang.Text == "English" && OutputLang.Text == "Spanish")
            {
                Output.Clear();
                string[] words = Input.Text.Split(new char[]{' '});
                Word single = new Word(InputLang.Text, words[0]);
                single = single.translate(OutputLang.Text);
                Output.Text += single.Content + ' ';
                for (int i = 1; i< words.Length; i++)
                {
                    single = new Word(InputLang.Text, words[i]);
                    single = single.translate(OutputLang.Text);
                    Output.Text += single.Content + ' ';
                }

            }
            if (InputLang.Text == "Spanish" && OutputLang.Text == "English")
            {
                Output.Clear();
                string[] words = Input.Text.Split(new char[] { ' ' });
                Word single = new Word(InputLang.Text, words[0]);
                single = single.translate(OutputLang.Text);
                Output.Text += single.Content + ' ';
                for (int i = 1; i < words.Length; i++)
                {
                    single = new Word(InputLang.Text, words[i]);
                    single = single.translate(OutputLang.Text);
                    Output.Text += single.Content + ' ';
                }

            }
            if (InputLang.Text == "Spanish" && OutputLang.Text == "Spanish")
            {
                Output.Text = Input.Text;
            }

            pastTranslations.Add(Input.Text);
            pastTranslations.Add("=");
            pastTranslations.Add(Output.Text);
            pastTranslations.Add("---------------");

        }

        private void Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void History_Click(object sender, EventArgs e)
        {
            var pastTranslationsForm = new History(pastTranslations);
            pastTranslationsForm.ShowDialog();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            pastTranslations.Clear();
            MessageBox.Show("Past translations cleared.");
        }

        private void Translator_Load(object sender, EventArgs e)
        {

        }

        private void InputLang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
