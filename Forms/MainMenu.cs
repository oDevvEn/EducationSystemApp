using System.Diagnostics;

namespace EducationSystemApp
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();

            foreach (string name in ProfileSystem.profiles.Keys) {
                ProfileView.Items.Add(new ListViewItem(name, 3));
            }
        }


        private void viewprofilebutton_Click(object sender, EventArgs e)
        {
            if (ProfileView.Visible == false)
            {
                ProfileView.Visible = true;
            }
            if (hideprofilebutton.Visible == false)
            {
                hideprofilebutton.Visible = true;
            }
            if (CreateProfileButton.Visible == false)
            {
                CreateProfileButton.Visible = true;
            }
        }

        private void hideprofilebutton_Click(object sender, EventArgs e)
        {
            if (ProfileView.Visible == true)
            {
                ProfileView.Visible = false;
            }
            if (hideprofilebutton.Visible == true)
            {
                hideprofilebutton.Visible = false;
            }
            if (CreateProfileButton.Visible == true)
            {
                CreateProfileButton.Visible = false;
            }
            /*if (ProfileName.Visible == true)
            {
                ProfileName.Visible = false;
            }
            if (SelectedProfile.Visible == true)
            {
                SelectedProfile.Visible = false;
            }*/
            CreationHide_Click(sender, e);
        }

        private void CreateProfileButton_Click(object sender, EventArgs e)
        {
            if (ProfileView.Visible == false)
            {
                ProfileView.Visible = true;
            }

            if (NameType.Visible == false && NameBox.Visible == false)
            {
                NameType.Visible = true;
                NameBox.Visible = true;
            }
            if (ConfirmCreation.Visible == false)
            {
                ConfirmCreation.Visible = true;
            }
            if (CreationHide.Visible == false)
            {
                CreationHide.Visible = true;
            }
            if (DisplayCreate.Visible == false)
            {
                DisplayCreate.Visible = true;
            }
        }

        private void ConfirmCreation_Click(object sender, EventArgs e)
        {
            string name = NameType.Text;
            NameType.Text = "";

            if (ProfileSystem.profiles.ContainsKey(name)) {
                MessageBox.Show($"Profile with name {name} already exists!", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(name)) {
                MessageBox.Show($"Enter an actual name!!!!!!!", null, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                ProfileSystem.CreateProfile(name);
                ProfileView.Items.Add(new ListViewItem(name, 3));
            }    
        }

        private void CreationHide_Click(object sender, EventArgs e)
        {
            if (NameType.Visible == true && NameBox.Visible == true)
            {
                NameType.Visible = false;
                NameBox.Visible = false;
            }
            if (ConfirmCreation.Visible == true)
            {
                ConfirmCreation.Visible = false;
            }
            if (CreationHide.Visible == true)
            {
                CreationHide.Visible = false;
            }
            if (DisplayCreate.Visible == true)
            {
                DisplayCreate.Visible = false;
            }
        }

        private void ProfileHide_Click(object sender, EventArgs e)
        {
            if (ProfileHide.Visible == true)
            {
                ProfileHide.Visible = false;
            }
            /*if (ProfileName.Visible == true)
            {
                ProfileName.Visible = false;
            }
            if (SelectedProfile.Visible == true)
            {
                SelectedProfile.Visible = false;
            }*/
        }

        private void ProfileView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ProfileView.SelectedItems.Count == 0)
            {
                return;
            }
            //SelectedProfile.Visible = true;
            //ProfileName.Visible = true;
            string name = ProfileView.SelectedItems[0].Text;
            SelectedProfile.Text = name;
            ProfileSystem.SelectProfile(name);
            profilePanel.Visible = true;
            ShowProfileStats();
        }

        private void ShowProfileStats() {
            profileStats.Text = $"""
                {ProfileSystem.profile.mathScore}
                {ProfileSystem.profile.memoryScore}
                {ProfileSystem.profile.wordScore}
                {ProfileSystem.profile.mathScore+ProfileSystem.profile.memoryScore+ProfileSystem.profile.wordScore}
                {ProfileSystem.profile.speedScore}
                """;
        }

        private void ShowForm(Form form, bool nothide) {
            if (!nothide) this.Hide();
            form.ShowDialog();
            ShowProfileStats();
            this.Show();
        }
        private void compareProfilesButton_Click(object sender, EventArgs e) {
            ShowForm(new ProfileComparor(), true);
        }
        private void mathsQuizButton_Click(object sender, EventArgs e) {
            ShowForm(new MathQuiz0(), false);
        }
        private void memoryTestButton_Click(object sender, EventArgs e) {
            throw new NotImplementedException();
        }
        private void wordQuestionsButton_Click(object sender, EventArgs e) {
            ShowForm(new WordQuestions(), false);
        }
        private void speedTestButton_Click(object sender, EventArgs e) {
            ShowForm(new SpeedTest(), false);
        }
    }
}
