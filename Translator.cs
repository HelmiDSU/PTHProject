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

        }

        private void Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
