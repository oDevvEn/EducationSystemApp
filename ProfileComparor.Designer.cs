namespace EducationSystemApp
{
    partial class ProfileComparor
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
            yourMathScore = new Label();
            yourMemoryScore = new Label();
            yourWordScore = new Label();
            yourTotalScore = new Label();
            yourTitle = new Label();
            scoreTable = new TableLayoutPanel();
            theirWordScore = new Label();
            theirTotalScore = new Label();
            theirMemoryScore = new Label();
            theirMathScore = new Label();
            theirTitle = new Label();
            mathScoreTitle = new Label();
            memoryScoreTitle = new Label();
            wordScoreTitle = new Label();
            totalScoreTitle = new Label();
            compareInput = new TextBox();
            compareTitle = new Label();
            compareButton = new Button();
            scoreTable.SuspendLayout();
            SuspendLayout();
            // 
            // yourMathScore
            // 
            yourMathScore.AutoSize = true;
            yourMathScore.Dock = DockStyle.Fill;
            yourMathScore.Location = new Point(96, 49);
            yourMathScore.Margin = new Padding(0);
            yourMathScore.Name = "yourMathScore";
            yourMathScore.Size = new Size(96, 38);
            yourMathScore.TabIndex = 0;
            yourMathScore.Text = "mathScore";
            yourMathScore.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // yourMemoryScore
            // 
            yourMemoryScore.AutoSize = true;
            yourMemoryScore.Dock = DockStyle.Fill;
            yourMemoryScore.Location = new Point(96, 87);
            yourMemoryScore.Margin = new Padding(0);
            yourMemoryScore.Name = "yourMemoryScore";
            yourMemoryScore.Size = new Size(96, 38);
            yourMemoryScore.TabIndex = 1;
            yourMemoryScore.Text = "memoryScore";
            yourMemoryScore.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // yourWordScore
            // 
            yourWordScore.AutoSize = true;
            yourWordScore.Dock = DockStyle.Fill;
            yourWordScore.Location = new Point(96, 125);
            yourWordScore.Margin = new Padding(0);
            yourWordScore.Name = "yourWordScore";
            yourWordScore.Size = new Size(96, 38);
            yourWordScore.TabIndex = 2;
            yourWordScore.Text = "wordScore";
            yourWordScore.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // yourTotalScore
            // 
            yourTotalScore.AutoSize = true;
            yourTotalScore.Dock = DockStyle.Fill;
            yourTotalScore.Location = new Point(96, 163);
            yourTotalScore.Margin = new Padding(0);
            yourTotalScore.Name = "yourTotalScore";
            yourTotalScore.Size = new Size(96, 42);
            yourTotalScore.TabIndex = 3;
            yourTotalScore.Text = "totalScore";
            yourTotalScore.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // yourTitle
            // 
            yourTitle.AutoSize = true;
            yourTitle.Dock = DockStyle.Fill;
            yourTitle.Location = new Point(96, 0);
            yourTitle.Margin = new Padding(0);
            yourTitle.Name = "yourTitle";
            yourTitle.Size = new Size(96, 49);
            yourTitle.TabIndex = 4;
            yourTitle.Text = "YOUR";
            yourTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // scoreTable
            // 
            scoreTable.ColumnCount = 3;
            scoreTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            scoreTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            scoreTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            scoreTable.Controls.Add(yourMathScore, 1, 1);
            scoreTable.Controls.Add(yourTitle, 1, 0);
            scoreTable.Controls.Add(yourMemoryScore, 1, 2);
            scoreTable.Controls.Add(yourTotalScore, 1, 4);
            scoreTable.Controls.Add(yourWordScore, 1, 3);
            scoreTable.Controls.Add(theirWordScore, 2, 3);
            scoreTable.Controls.Add(theirTotalScore, 2, 4);
            scoreTable.Controls.Add(theirMemoryScore, 2, 2);
            scoreTable.Controls.Add(theirMathScore, 2, 1);
            scoreTable.Controls.Add(theirTitle, 2, 0);
            scoreTable.Controls.Add(mathScoreTitle, 0, 1);
            scoreTable.Controls.Add(memoryScoreTitle, 0, 2);
            scoreTable.Controls.Add(wordScoreTitle, 0, 3);
            scoreTable.Controls.Add(totalScoreTitle, 0, 4);
            scoreTable.Location = new Point(12, 12);
            scoreTable.Name = "scoreTable";
            scoreTable.RowCount = 5;
            scoreTable.RowStyles.Add(new RowStyle(SizeType.Percent, 24F));
            scoreTable.RowStyles.Add(new RowStyle(SizeType.Percent, 19F));
            scoreTable.RowStyles.Add(new RowStyle(SizeType.Percent, 19F));
            scoreTable.RowStyles.Add(new RowStyle(SizeType.Percent, 19F));
            scoreTable.RowStyles.Add(new RowStyle(SizeType.Percent, 19F));
            scoreTable.Size = new Size(288, 205);
            scoreTable.TabIndex = 5;
            // 
            // theirWordScore
            // 
            theirWordScore.AutoSize = true;
            theirWordScore.Dock = DockStyle.Fill;
            theirWordScore.Location = new Point(192, 125);
            theirWordScore.Margin = new Padding(0);
            theirWordScore.Name = "theirWordScore";
            theirWordScore.Size = new Size(96, 38);
            theirWordScore.TabIndex = 6;
            theirWordScore.Text = "wordScore";
            theirWordScore.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // theirTotalScore
            // 
            theirTotalScore.AutoSize = true;
            theirTotalScore.Dock = DockStyle.Fill;
            theirTotalScore.Location = new Point(192, 163);
            theirTotalScore.Margin = new Padding(0);
            theirTotalScore.Name = "theirTotalScore";
            theirTotalScore.Size = new Size(96, 42);
            theirTotalScore.TabIndex = 7;
            theirTotalScore.Text = "totalScore";
            theirTotalScore.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // theirMemoryScore
            // 
            theirMemoryScore.AutoSize = true;
            theirMemoryScore.Dock = DockStyle.Fill;
            theirMemoryScore.Location = new Point(192, 87);
            theirMemoryScore.Margin = new Padding(0);
            theirMemoryScore.Name = "theirMemoryScore";
            theirMemoryScore.Size = new Size(96, 38);
            theirMemoryScore.TabIndex = 5;
            theirMemoryScore.Text = "memoryScore";
            theirMemoryScore.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // theirMathScore
            // 
            theirMathScore.AutoSize = true;
            theirMathScore.Dock = DockStyle.Fill;
            theirMathScore.Location = new Point(192, 49);
            theirMathScore.Margin = new Padding(0);
            theirMathScore.Name = "theirMathScore";
            theirMathScore.Size = new Size(96, 38);
            theirMathScore.TabIndex = 4;
            theirMathScore.Text = "mathScore";
            theirMathScore.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // theirTitle
            // 
            theirTitle.AutoSize = true;
            theirTitle.Dock = DockStyle.Fill;
            theirTitle.Location = new Point(192, 0);
            theirTitle.Margin = new Padding(0);
            theirTitle.Name = "theirTitle";
            theirTitle.Size = new Size(96, 49);
            theirTitle.TabIndex = 8;
            theirTitle.Text = "THEIR";
            theirTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // mathScoreTitle
            // 
            mathScoreTitle.AutoSize = true;
            mathScoreTitle.Dock = DockStyle.Fill;
            mathScoreTitle.Location = new Point(0, 49);
            mathScoreTitle.Margin = new Padding(0);
            mathScoreTitle.Name = "mathScoreTitle";
            mathScoreTitle.Size = new Size(96, 38);
            mathScoreTitle.TabIndex = 9;
            mathScoreTitle.Text = "MATH SCORE";
            mathScoreTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // memoryScoreTitle
            // 
            memoryScoreTitle.AutoSize = true;
            memoryScoreTitle.Dock = DockStyle.Fill;
            memoryScoreTitle.Location = new Point(0, 87);
            memoryScoreTitle.Margin = new Padding(0);
            memoryScoreTitle.Name = "memoryScoreTitle";
            memoryScoreTitle.Size = new Size(96, 38);
            memoryScoreTitle.TabIndex = 10;
            memoryScoreTitle.Text = "MEMORY SCORE";
            memoryScoreTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // wordScoreTitle
            // 
            wordScoreTitle.AutoSize = true;
            wordScoreTitle.Dock = DockStyle.Fill;
            wordScoreTitle.Location = new Point(0, 125);
            wordScoreTitle.Margin = new Padding(0);
            wordScoreTitle.Name = "wordScoreTitle";
            wordScoreTitle.Size = new Size(96, 38);
            wordScoreTitle.TabIndex = 11;
            wordScoreTitle.Text = "WORD SCORE";
            wordScoreTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // totalScoreTitle
            // 
            totalScoreTitle.AutoSize = true;
            totalScoreTitle.Dock = DockStyle.Fill;
            totalScoreTitle.Location = new Point(0, 163);
            totalScoreTitle.Margin = new Padding(0);
            totalScoreTitle.Name = "totalScoreTitle";
            totalScoreTitle.Size = new Size(96, 42);
            totalScoreTitle.TabIndex = 12;
            totalScoreTitle.Text = "TOTAL SCORE";
            totalScoreTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // compareInput
            // 
            compareInput.Location = new Point(62, 254);
            compareInput.Name = "compareInput";
            compareInput.Size = new Size(191, 23);
            compareInput.TabIndex = 6;
            // 
            // compareTitle
            // 
            compareTitle.AutoSize = true;
            compareTitle.Location = new Point(68, 238);
            compareTitle.Name = "compareTitle";
            compareTitle.Size = new Size(182, 15);
            compareTitle.TabIndex = 7;
            compareTitle.Text = "PROFILE NAME TO COMPARE TO";
            compareTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // compareButton
            // 
            compareButton.Location = new Point(117, 283);
            compareButton.Name = "compareButton";
            compareButton.Size = new Size(75, 23);
            compareButton.TabIndex = 8;
            compareButton.Text = "COMPARE";
            compareButton.UseVisualStyleBackColor = true;
            compareButton.Click += compareButton_Click;
            // 
            // ProfileComparor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(314, 318);
            Controls.Add(compareButton);
            Controls.Add(compareTitle);
            Controls.Add(compareInput);
            Controls.Add(scoreTable);
            Name = "ProfileComparor";
            Text = "Profile Comparison";
            scoreTable.ResumeLayout(false);
            scoreTable.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label yourMathScore;
        private Label yourMemoryScore;
        private Label yourWordScore;
        private Label yourTotalScore;
        private Label yourTitle;
        private TableLayoutPanel scoreTable;
        private Label theirWordScore;
        private Label theirTotalScore;
        private Label theirMemoryScore;
        private Label theirMathScore;
        private Label theirTitle;
        private Label mathScoreTitle;
        private Label memoryScoreTitle;
        private Label wordScoreTitle;
        private Label totalScoreTitle;
        private TextBox compareInput;
        private Label compareTitle;
        private Button compareButton;
    }
}
