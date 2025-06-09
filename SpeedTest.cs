using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducationSystemApp {
    public partial class SpeedTest : Form {
        Random random;
        int testsDone = 0;
        int totalTime = 0;
        DateTime initalTime;


        public SpeedTest() {
            InitializeComponent();
            random = new Random();
        }


        private async Task GenerateNext() {
            // Wait for button...
            await Task.Delay(random.Next(1000, 5000));

            // Generate Button
            Button button = new Button();
            button.Size = new Size(random.Next(40, 80), random.Next(40, 80));
            button.Location = new Point(random.Next(0, 1200), random.Next(0, 640));
            button.Text = "click?";
            button.Click += testButton_Click; // what is vs2022 trying to warn me about here?????????????
            this.Controls.Add(button);

            // Start speed timer
            initalTime = DateTime.Now;
        }


        private async void testButton_Click(object sender, EventArgs e) {
            totalTime += (int)(DateTime.Now - initalTime).TotalMilliseconds;
            testsDone++;

            // Destroy button
            if (sender is Button button) {
                this.Controls.Remove(button);
            }

            // Keep testing until 10 tests complete AND THEN calculate score & reinit "stuff"
            if (testsDone < 10) {
                await GenerateNext();
            }
            else {
                // Calculate score
                int speedScore = totalTime / testsDone;
                if (speedScore < tempProfile.profile.speedScore) {
                    tempProfile.profile.speedScore = speedScore;
                }
                resultLabel.Text = speedScore.ToString();

                // Reinit "stuff"
                testsDone = 0;
                totalTime = 0;
                startButton.Visible = true;
                resultTitle.Visible = true;
                resultLabel.Visible = true;
            }
        }


        private async void startButton_Click(object sender, EventArgs e) {
            startButton.Visible = false;
            resultTitle.Visible = false;
            resultLabel.Visible = false;
            await GenerateNext();
        }
    }
}
