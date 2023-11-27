using System.Windows.Forms;
using System.Windows;

namespace Translator
{
    partial class Translator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Input = new System.Windows.Forms.TextBox();
            this.Output = new System.Windows.Forms.TextBox();
            this.InputTitle = new System.Windows.Forms.Label();
            this.OutputTitle = new System.Windows.Forms.Label();
            this.InputLang = new System.Windows.Forms.ComboBox();
            this.OutputLang = new System.Windows.Forms.ComboBox();
            this.Translate = new System.Windows.Forms.Button();
            this.Quit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Input
            // 
            this.Input.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Input.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Input.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input.Location = new System.Drawing.Point(140, 223);
            this.Input.Multiline = true;
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(531, 305);
            this.Input.TabIndex = 0;
            // 
            // Output
            // 
            this.Output.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Output.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Output.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Output.Location = new System.Drawing.Point(764, 223);
            this.Output.Multiline = true;
            this.Output.Name = "Output";
            this.Output.ReadOnly = true;
            this.Output.Size = new System.Drawing.Size(554, 305);
            this.Output.TabIndex = 1;
            // 
            // InputTitle
            // 
            this.InputTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InputTitle.AutoSize = true;
            this.InputTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputTitle.Location = new System.Drawing.Point(334, 149);
            this.InputTitle.Name = "InputTitle";
            this.InputTitle.Size = new System.Drawing.Size(112, 46);
            this.InputTitle.TabIndex = 2;
            this.InputTitle.Text = "Input";
            // 
            // OutputTitle
            // 
            this.OutputTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OutputTitle.AutoSize = true;
            this.OutputTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputTitle.Location = new System.Drawing.Point(968, 149);
            this.OutputTitle.Name = "OutputTitle";
            this.OutputTitle.Size = new System.Drawing.Size(145, 46);
            this.OutputTitle.TabIndex = 3;
            this.OutputTitle.Text = "Output";
            // 
            // InputLang
            // 
            this.InputLang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InputLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InputLang.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputLang.FormattingEnabled = true;
            this.InputLang.Items.AddRange(new object[] {
            "English",
            "Spanish"});
            this.InputLang.Location = new System.Drawing.Point(209, 560);
            this.InputLang.Name = "InputLang";
            this.InputLang.Size = new System.Drawing.Size(365, 45);
            this.InputLang.TabIndex = 4;
            // 
            // OutputLang
            // 
            this.OutputLang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OutputLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OutputLang.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputLang.FormattingEnabled = true;
            this.OutputLang.Items.AddRange(new object[] {
            "English",
            "Spanish"});
            this.OutputLang.Location = new System.Drawing.Point(852, 571);
            this.OutputLang.Name = "OutputLang";
            this.OutputLang.Size = new System.Drawing.Size(377, 45);
            this.OutputLang.TabIndex = 5;
            // 
            // Translate
            // 
            this.Translate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Translate.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Translate.Location = new System.Drawing.Point(867, 634);
            this.Translate.Name = "Translate";
            this.Translate.Size = new System.Drawing.Size(362, 184);
            this.Translate.TabIndex = 6;
            this.Translate.Text = "Translate";
            this.Translate.UseVisualStyleBackColor = true;
            this.Translate.Click += new System.EventHandler(this.Translate_Click);
            // 
            // Quit
            // 
            this.Quit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Quit.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quit.Location = new System.Drawing.Point(209, 634);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(362, 184);
            this.Quit.TabIndex = 7;
            this.Quit.Text = "Quit";
            this.Quit.UseVisualStyleBackColor = true;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // Translator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1538, 972);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.Translate);
            this.Controls.Add(this.OutputLang);
            this.Controls.Add(this.InputLang);
            this.Controls.Add(this.OutputTitle);
            this.Controls.Add(this.InputTitle);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Input);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Translator";
            this.Text = "Translator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.TextBox Output;
        private System.Windows.Forms.Label InputTitle;
        private System.Windows.Forms.Label OutputTitle;
        private System.Windows.Forms.ComboBox InputLang;
        private System.Windows.Forms.ComboBox OutputLang;
        private System.Windows.Forms.Button Translate;
        private System.Windows.Forms.Button Quit;
    }
}

