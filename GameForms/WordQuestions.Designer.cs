namespace EducationSystemApp 
{
    partial class WordQuestions
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            StarwarsQuestions = new Button();
            DragonBallQuestions = new Button();
            FortniteQuestions = new Button();
            CsgoQuestions = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            SubmittedAnswer = new Button();
            SuspendLayout();
            // 
            // StarwarsQuestions
            // 
            StarwarsQuestions.Location = new Point(12, 188);
            StarwarsQuestions.Name = "StarwarsQuestions";
            StarwarsQuestions.Size = new Size(156, 84);
            StarwarsQuestions.TabIndex = 0;
            StarwarsQuestions.Text = "Starwars Questions";
            StarwarsQuestions.UseVisualStyleBackColor = true;
            StarwarsQuestions.Click += StarwarsQuestions_Click;
            // 
            // DragonBallQuestions
            // 
            DragonBallQuestions.Location = new Point(12, 278);
            DragonBallQuestions.Name = "DragonBallQuestions";
            DragonBallQuestions.Size = new Size(156, 84);
            DragonBallQuestions.TabIndex = 0;
            DragonBallQuestions.Text = "Dragonball Questions";
            DragonBallQuestions.UseVisualStyleBackColor = true;
            DragonBallQuestions.Click += DragonBallQuestions_Click;
            // 
            // FortniteQuestions
            // 
            FortniteQuestions.Location = new Point(12, 368);
            FortniteQuestions.Name = "FortniteQuestions";
            FortniteQuestions.Size = new Size(156, 84);
            FortniteQuestions.TabIndex = 0;
            FortniteQuestions.Text = "Fortnite Questions";
            FortniteQuestions.UseVisualStyleBackColor = true;
            FortniteQuestions.Click += FortniteQuestions_Click;
            // 
            // CsgoQuestions
            // 
            CsgoQuestions.Location = new Point(12, 458);
            CsgoQuestions.Name = "CsgoQuestions";
            CsgoQuestions.Size = new Size(156, 84);
            CsgoQuestions.TabIndex = 0;
            CsgoQuestions.Text = "Cs:go Questions";
            CsgoQuestions.UseVisualStyleBackColor = true;
            CsgoQuestions.Click += CsgoQuestions_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(1227, 159);
            label1.TabIndex = 1;
            label1.Text = "Press a button";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(312, 188);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Enter answer here!";
            textBox1.Size = new Size(222, 23);
            textBox1.TabIndex = 2;
            // 
            // SubmittedAnswer
            // 
            SubmittedAnswer.Location = new Point(312, 229);
            SubmittedAnswer.Name = "SubmittedAnswer";
            SubmittedAnswer.Size = new Size(222, 120);
            SubmittedAnswer.TabIndex = 3;
            SubmittedAnswer.Text = "SUMBIT ANSWER";
            SubmittedAnswer.UseVisualStyleBackColor = true;
            SubmittedAnswer.Click += SubmittedAnswer_Click;
            // 
            // WordQuestions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(SubmittedAnswer);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(CsgoQuestions);
            Controls.Add(FortniteQuestions);
            Controls.Add(DragonBallQuestions);
            Controls.Add(StarwarsQuestions);
            Name = "WordQuestions";
            Text = "Word Questions";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button StarwarsQuestions;
        private Button DragonBallQuestions;
        private Button FortniteQuestions;
        private Button CsgoQuestions;
        private Label label1;
        private TextBox textBox1;
        private Button SubmittedAnswer;
    }
}
