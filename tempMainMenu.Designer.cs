﻿namespace EducationSystemApp {
    partial class tempMainMenu {
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
            speedTestButton = new Button();
            profileComparor = new Button();
            save = new Button();
            SuspendLayout();
            // 
            // speedTestButton
            // 
            speedTestButton.Location = new Point(12, 12);
            speedTestButton.Name = "speedTestButton";
            speedTestButton.Size = new Size(127, 23);
            speedTestButton.TabIndex = 0;
            speedTestButton.Text = "Game 4 - Speed Test";
            speedTestButton.UseVisualStyleBackColor = true;
            speedTestButton.Click += speedTestButton_Click;
            // 
            // profileComparor
            // 
            profileComparor.Location = new Point(12, 41);
            profileComparor.Name = "profileComparor";
            profileComparor.Size = new Size(127, 23);
            profileComparor.TabIndex = 1;
            profileComparor.Text = "Profile Comparer";
            profileComparor.UseVisualStyleBackColor = true;
            profileComparor.Click += profileComparor_Click;
            // 
            // save
            // 
            save.Location = new Point(12, 70);
            save.Name = "save";
            save.Size = new Size(127, 23);
            save.TabIndex = 2;
            save.Text = "save";
            save.UseVisualStyleBackColor = true;
            save.Click += save_Click;
            // 
            // tempMainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(154, 108);
            Controls.Add(save);
            Controls.Add(profileComparor);
            Controls.Add(speedTestButton);
            Name = "tempMainMenu";
            Text = "tempMainMenu";
            ResumeLayout(false);
        }

        #endregion

        private Button speedTestButton;
        private Button profileComparor;
        private Button save;
    }
}