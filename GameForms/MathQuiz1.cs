using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducationSystemApp
{
    public partial class MathQuiz1 : Form
    {
        MathQuiz0 call;
        TextBox a;
        Label b;
        Button C;
        Question current;
        Random r = new Random();
        int score = 0;
        public MathQuiz1(MathQuiz0 f)
        {
            call = f;
            int questionamount = call.questionamount;
            InitializeComponent();
            formsetup();
            if (call.hard)
            {
                questionshard(call.questionamount);
            }
            if (call.medium)
            {
                questionsmid(call.questionamount);
            }
            if (call.easy)
            {
                questionseasy(call.questionamount);
            }
        }
        void formsetup()
        {
            a = new TextBox();
            a.Size = new Size(200, 200);
            a.Location = new Point(ClientSize.Width / 2, ClientSize.Height / 2);
            a.Text = "";
            this.Controls.Add(a);

            b = new Label();
            b.Size = new Size(200, 200);
            b.Location = new Point(ClientSize.Width / 2, ClientSize.Height / 2 - 200);
            b.Text = "";
            this.Controls.Add(b);

            C = new Button();
            C.Size = new Size(50, 50);
            C.Location = new Point(ClientSize.Width / 2, ClientSize.Height / 2 +50);
            C.Text = "submit answer";
            this.Controls.Add(C);
            C.Click += submitquestion;
        }
        void questionshard(int questionamount)
        {
            // 
        }
        void questionsmid(int questionamount)
        {
            //timing and dividing
        }
        void questionseasy(int questionamount)
        {
            // only addition and subtraction 
            int A = 0;
            int B = 0;
            bool real = true;
            int signdecider = 0;
            int answer = 0;
            string chosensign = "";
            signdecider = r.Next(1, 3);

            while (real == true)
            {
                A = r.Next(0, 20);
                B = r.Next(0, 20);
                if (signdecider == 1)
                {
                    chosensign = "+";
                    answer = A + B;
                }
                if (signdecider == 2)
                {
                    chosensign = "-";
                    answer = A - B;
                }
                real = false;
                if (answer < 0)
                {
                    real = true;
                }
            }
            
            current = new Question(A,B,signdecider,answer);
            b.Text += A.ToString() + chosensign + B.ToString();

        }
        void submitquestion(object sender, EventArgs e)
        {

            Button question = (Button)sender;
            if (int.Parse(a.Text) == current.answer)
            {
                ProfileSystem.profile.mathScore++;
                ProfileSystem.SaveProfiles();
                call.questionamount--;
                b.Text = "";
                a.Text = "";
                questionseasy(call.questionamount);
            }
            else if (int.Parse(a.Text) != current.answer)
            {
                call.questionamount--;
                b.Text = "";
                a.Text = "";
                questionseasy(call.questionamount);
            }
        }
    }
    
    class Question
    {
        public int A = 0;
        public int B = 0;
        public int signdecider = 0;
        public int answer = 0;

        public Question(int a, int b, int signdecider, int answer)
        {
            A = a;
            B = b;
            this.signdecider = signdecider;
            this.answer = answer;
        }   
    }
}
