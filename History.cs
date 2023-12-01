using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Translator
{
    public partial class History : Form
    {
        private List<string> pastTranslations;
        private TextBox pastTranslationsTextBox;

        public History(List<string> pastTranslations)
        {
            InitializeComponent();
            this.pastTranslations = pastTranslations;
            PopulatePastTranslations();
        }

        private void PopulatePastTranslations()
        {
            // Display past translations in a TextBox or any other control of your choice
            foreach (var translation in pastTranslations)
            {
                pastTranslationsTextBox.Text += translation + Environment.NewLine;
            }
        }

        private void InitializeComponent()
        {
            this.pastTranslationsTextBox = new TextBox();
            this.SuspendLayout();
            // 
            // pastTranslationsTextBox
            // 
            this.pastTranslationsTextBox.Location = new System.Drawing.Point(12, 12);
            this.pastTranslationsTextBox.Multiline = true;
            this.pastTranslationsTextBox.ScrollBars = ScrollBars.Both; // Set the ScrollBars property
            this.pastTranslationsTextBox.Name = "pastTranslationsTextBox";
            this.pastTranslationsTextBox.Size = new System.Drawing.Size(300, 200); // Adjust the size as needed
            this.pastTranslationsTextBox.TabIndex = 0;
            // 
            // HistoryForm
            // 
            this.ClientSize = new System.Drawing.Size(400, 300); // Adjust the size as needed
            this.Controls.Add(this.pastTranslationsTextBox);
            this.Name = "HistoryForm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

    }
}
