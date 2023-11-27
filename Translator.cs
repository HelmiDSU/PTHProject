using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Translator
{
    public partial class Translator : Form
    {
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

        }

        private void Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
