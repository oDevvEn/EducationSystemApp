using System.Diagnostics.Metrics;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace EducationSystemApp
{
    public partial class MathQuiz0 : Form
    {

        Button a;
        TextBox tb;
        public bool select = false;
        public bool easy = false;
        public bool medium = false;
        public bool hard = false;
        public int questionamount = 0;
        public MathQuiz0()
        {
            InitializeComponent();
            startmenu();

        }
        void startmenu()
        {
            int posX = (ClientSize.Width) / 2;
            int posY = (ClientSize.Height) / 2;
            int sizex = (ClientSize.Width) / 8;
            int sizey = (ClientSize.Height) / 8;


            for (int i = 0; i < 3; i++)
            {
                a = new Button();
                a.Size = new Size(sizex, sizey);
                a.Location = new Point(posX, posY);
                posX += ClientSize.Width / 6;
                if (i == 0)
                {
                    a.Text = "easy";
                }
                if (i == 1)
                {
                    a.Text = "medium";
                }
                if (i == 2)
                {
                    a.Text = "hard";
                }
                a.Click += DifficultyClick;
                this.Controls.Add(a);
            }
            tb = new TextBox();
            tb.Size = new Size(300, 300);
            tb.Location = new Point(posX, posY - 200);
            this.Controls.Add(tb);
        }
        void DifficultyClick(object sender, EventArgs e)
        {
            if (tb.Text != "")
            {
               questionamount = int.Parse(tb.Text);
            }
            Button choice = (Button)sender;
            if (choice.Text == "easy")
            {
                easy = true;
            }
            if (choice.Text == "medium")
            {
                medium = true;
            }
            if (choice.Text == "hard")
            {
                hard = true;
            }
            MathQuiz1 x = new MathQuiz1(this);
            this.Hide();
            x.ShowDialog();
            this.Show();
            //this.Enabled = false;
        }
    } 
    
} 
    


