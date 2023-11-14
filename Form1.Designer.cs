namespace Translator
{
    partial class Form1
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
            this.InputText = new System.Windows.Forms.TextBox();
            this.OutputText = new System.Windows.Forms.TextBox();
            this.Input = new System.Windows.Forms.Label();
            this.Output = new System.Windows.Forms.Label();
            this.InputLang = new System.Windows.Forms.ComboBox();
            this.OutputLang = new System.Windows.Forms.ComboBox();
            this.Translate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InputText
            // 
            this.InputText.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputText.Location = new System.Drawing.Point(60, 44);
            this.InputText.Multiline = true;
            this.InputText.Name = "InputText";
            this.InputText.Size = new System.Drawing.Size(297, 166);
            this.InputText.TabIndex = 0;
            // 
            // OutputText
            // 
            this.OutputText.Location = new System.Drawing.Point(458, 44);
            this.OutputText.Multiline = true;
            this.OutputText.Name = "OutputText";
            this.OutputText.ReadOnly = true;
            this.OutputText.Size = new System.Drawing.Size(297, 166);
            this.OutputText.TabIndex = 1;
            // 
            // Input
            // 
            this.Input.AutoSize = true;
            this.Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input.Location = new System.Drawing.Point(160, 4);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(93, 37);
            this.Input.TabIndex = 2;
            this.Input.Text = "Input";
            // 
            // Output
            // 
            this.Output.AutoSize = true;
            this.Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Output.Location = new System.Drawing.Point(554, 4);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(120, 37);
            this.Output.TabIndex = 3;
            this.Output.Text = "Output";
            // 
            // InputLang
            // 
            this.InputLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InputLang.FormattingEnabled = true;
            this.InputLang.Items.AddRange(new object[] {
            "English",
            "Spanish"});
            this.InputLang.Location = new System.Drawing.Point(103, 275);
            this.InputLang.Name = "InputLang";
            this.InputLang.Size = new System.Drawing.Size(205, 28);
            this.InputLang.TabIndex = 4;
            // 
            // OutputLang
            // 
            this.OutputLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OutputLang.FormattingEnabled = true;
            this.OutputLang.Items.AddRange(new object[] {
            "English",
            "Spanish"});
            this.OutputLang.Location = new System.Drawing.Point(506, 275);
            this.OutputLang.Name = "OutputLang";
            this.OutputLang.Size = new System.Drawing.Size(205, 28);
            this.OutputLang.TabIndex = 5;
            // 
            // Translate
            // 
            this.Translate.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Translate.Location = new System.Drawing.Point(302, 352);
            this.Translate.Name = "Translate";
            this.Translate.Size = new System.Drawing.Size(190, 64);
            this.Translate.TabIndex = 6;
            this.Translate.Text = "Translate";
            this.Translate.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Translate);
            this.Controls.Add(this.OutputLang);
            this.Controls.Add(this.InputLang);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.OutputText);
            this.Controls.Add(this.InputText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputText;
        private System.Windows.Forms.TextBox OutputText;
        private System.Windows.Forms.Label Input;
        private System.Windows.Forms.Label Output;
        private System.Windows.Forms.ComboBox InputLang;
        private System.Windows.Forms.ComboBox OutputLang;
        private System.Windows.Forms.Button Translate;
    }
}

