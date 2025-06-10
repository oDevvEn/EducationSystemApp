using EducationSystemApp;
using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace EducationSystemApp 
{
    public partial class WordQuestions : Form
    {
        public WordQuestions()
        {
            InitializeComponent();
        }
        int currentIndex = -1;
        string[] lines;
        string currentAnswer = "";
        private void StarwarsQuestions_Click(object sender, EventArgs e)
        {
            string path = "StarwarsQuestions.txt"; 
            if (File.Exists(path))
            {
                

                string[] questions = File.ReadAllLines(path);
                if (questions.Length > 0)
                {
                    
                    Random rand = new Random();
                    int index = rand.Next(questions.Length);
                    label1.Text = questions[index];
                    string[] parts = questions[index].Split('|');
                    if (parts.Length == 2)
                    {
                        label1.Text = parts[0]; // This is the question shown to the user
                        currentAnswer = parts[1]; // This is the correct answer saved for checking
                    }
                }
              

                else
                {
                    label1.Text = "No questions found in the file.";
                }
            }
            else
            {
                label1.Text = "questions.txt not found.";
            }
        }

        private void DragonBallQuestions_Click(object sender, EventArgs e)
        {
            string path = "DragonballQuestions.txt"; // You can give full path if needed
            if (File.Exists(path))
            {


                string[] questions = File.ReadAllLines(path);
                if (questions.Length > 0)
                {
                    Random rand = new Random();
                    int index = rand.Next(questions.Length);
                    label1.Text = questions[index];
                    string[] parts = questions[index].Split('|');
                    if (parts.Length == 2)
                    {
                        label1.Text = parts[0]; // This is the question shown to the user
                        currentAnswer = parts[1]; // This is the correct answer saved for checking
                    }
                }


                else
                {
                    label1.Text = "No questions found in the file.";
                }
            }
            else
            {
                label1.Text = "questions.txt not found.";
            }
        }

        private void FortniteQuestions_Click(object sender, EventArgs e)
        {
            string path = "FortniteQuestions.txt"; // You can give full path if needed
            if (File.Exists(path))
            {


                string[] questions = File.ReadAllLines(path);
                if (questions.Length > 0)
                {
                    Random rand = new Random();
                    int index = rand.Next(questions.Length);
                    label1.Text = questions[index];
                    string[] parts = questions[index].Split('|');
                    if (parts.Length == 2)
                    {
                        label1.Text = parts[0]; // This is the question shown to the user
                        currentAnswer = parts[1]; // This is the correct answer saved for checking
                    }
                }


                else
                {
                    label1.Text = "No questions found in the file.";
                }
            }
            else
            {
                label1.Text = "questions.txt not found.";
            }
        }

        private void CsgoQuestions_Click(object sender, EventArgs e)
        {
            string path = "CsgoQuestions.txt"; // You can give full path if needed
            if (File.Exists(path))
            {


                string[] questions = File.ReadAllLines(path);
                if (questions.Length > 0)
                {
                    Random rand = new Random();
                    int index = rand.Next(questions.Length);
                    label1.Text = questions[index];
                    string[] parts = questions[index].Split('|');
                    if (parts.Length == 2)
                    {
                        label1.Text = parts[0]; // This is the question shown to the user
                        currentAnswer = parts[1]; // This is the correct answer saved for checking
                    }
                }


                else
                {
                    label1.Text = "No questions found in the file.";
                }
            }
            else
            {
                label1.Text = "questions.txt not found.";
            }
        }

        private void SubmittedAnswer_Click(object sender, EventArgs e)
        {
            string userAnswer = textBox1.Text.ToLower().Replace(" ", "");
            string correctAnswer = currentAnswer.ToLower().Replace(" ", "");

            if (userAnswer == correctAnswer)
            {
                label1.Text = "Correct!";
                ProfileSystem.profile.wordScore++;
                ProfileSystem.SaveProfiles();
            }
            else
            {
                label1.Text = "Wrong.";
            }
        }
    }
}
