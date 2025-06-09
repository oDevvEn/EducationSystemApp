namespace EducationSystemApp {
    partial class SpeedTest {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            startButton = new Button();
            resultLabel = new Label();
            SuspendLayout();
            // 
            // startButton
            // 
            startButton.Location = new Point(575, 272);
            startButton.Name = "startButton";
            startButton.Size = new Size(75, 23);
            startButton.TabIndex = 0;
            startButton.Text = "START";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // resultLabel
            // 
            resultLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(592, 298);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(35, 15);
            resultLabel.TabIndex = 1;
            resultLabel.Text = "score";
            resultLabel.TextAlign = ContentAlignment.MiddleCenter;
            resultLabel.Visible = false;
            // 
            // SpeedTest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(resultLabel);
            Controls.Add(startButton);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "SpeedTest";
            Text = "SpeedTest";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button startButton;
        private Label resultLabel;
    }
}